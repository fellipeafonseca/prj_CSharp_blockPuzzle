using Bloquinhos.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Shapes;

namespace Bloquinhos
{

    public partial class Jogo2 : Form
    {
        //   SoundPlayer somfundoJogo = new SoundPlayer(@"C:\Users\S\Desktop\FundoJogo.wav");
        //SoundPlayer somErro = new SoundPlayer(@"C:\Users\S\Desktop\Erro.wav");
        // SoundPlayer somQuebrar = new SoundPlayer(@"C:\Users\S\Desktop\Quebrar.wav");

        private int largura;
        private int altura;
        private int numero_cores;
        private Pintor p;
        private List<Color> nomesCores;
        private List<Color> coresFundo;
        private Button[,] matrizButton;
        private int[,] matrizInteiros;
        private int quantidadesBloquinhos;
        private Button b;
        private TableLayoutPanel tableBloquinhos;
        private List<Node> solucao;
        private int[,] matriz_Inicial;
        private bool set_botao_giro;

        private Color cor_botao_desabilitado ;
        private Color cor_botao_habilitado;
        private bool passo;

        public Jogo2()
        {
            numero_cores = 4;
            largura = 4;
            altura = 4;

           
            cor_botao_habilitado = Color.Red;

            #region Nomes das Cores
            nomesCores = new List<Color>();
            

            //0 cor Vermelha
            nomesCores.Add(Color.Red);

            //1 cor Amarela

            nomesCores.Add(Color.Yellow);

            //2 cor Azul
            nomesCores.Add(Color.Blue);

            //3 cor Verde
            nomesCores.Add(Color.Green);

            //4 cor Laranja
            nomesCores.Add(Color.Orange);

            //5 cor Rosa
            nomesCores.Add(Color.Pink);

            //6 cor Roxo
            nomesCores.Add(Color.Purple);

            //7 cor Marrom
            nomesCores.Add(Color.Brown);


            //8 cor Cinza
            nomesCores.Add(Color.Gray);

            //9 cor Lime Green
            nomesCores.Add(Color.LimeGreen);

            #endregion

            #region Cores de Fundo
            coresFundo = new List<Color>();

            coresFundo.Add(Color.LightSkyBlue);
            coresFundo.Add(Color.Beige);
            coresFundo.Add(Color.Moccasin);
            coresFundo.Add(Color.RosyBrown);
            coresFundo.Add(Color.LightBlue);

            #endregion

            
           

            InitializeComponent();
           

          

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = new Size( 50 * 4 + 50, 50 * 4 +50+50) ;

            Iniciar_Jogo(true);


        }

        private void Iniciar_Jogo(bool inicio)
        {

            passo = set_botao_giro = false;

            solucao = new List<Node>();


            if (inicio)
            {

                tableBloquinhos = new TableLayoutPanel();
                tableBloquinhos.Location = new Point(5, 25);
                tableBloquinhos.AutoSize = true;
            }

            else
            {
                tableBloquinhos.Controls.Clear();
            }
           

            matrizButton = new Button[largura, altura];
            matrizInteiros = new int[largura, altura];
            matriz_Inicial = new int[largura, altura];
            tableBloquinhos.RowCount = largura;
            tableBloquinhos.ColumnCount = altura;
          

            if (!this.Controls.Contains(tableBloquinhos))
            {
                this.Controls.Add(tableBloquinhos);
            }
           
         

            for (int x = 0; x < largura; x++)
            {
                for (int y = 0; y < altura; y++)
                {
                    if (matrizButton[x, y] == null)
                    {


                        b = new Button();
                        b.Text = x + "," + y;
                        b.Width = 50;
                        b.Height = 50;
                        b.Font = new Font(b.Font.Name, b.Font.Size, FontStyle.Bold);
                        b.Click += new EventHandler(OnClick);
                        matrizButton[x, y] = b;
                        tableBloquinhos.Controls.Add(b, x, y);

                       
                    }
                  
                }
            }



            ColorirRandomico();

           
            
        }

        public void Limpa_Cores()
        {
            
        }


        /// <summary>
        /// Verifica a Pontuacao do usuario e direciona para qual formulario deve ser Redirecionado.
        /// </summary>
        /// <param name="pontuacao">Pontuação Final do usuario</param>
        private void FimJogo(int pontuacao, int quantidadeBloquinhos)
        {


            //somfundoJogo.Stop();



            int entrou = 0;
            FimJogo f = new FimJogo();
            int posicaoSalvar = -1;

            ////Criando um arquivo de Pontuação



            // var o = System.IO.File.OpenText(@"~\Usuarios.txt");

            if (System.IO.File.Exists(@"C:\Users\S\Desktop\Pontuacao.txt"))
            {

                string arquivo;


                using (var file = System.IO.File.OpenText(@"C:\Users\S\Desktop\Pontuacao.txt"))
                {
                    arquivo = file.ReadToEnd();

                }






                var sep = arquivo.Split(';');



                if (sep.Length - 1 != 5)
                {
                    posicaoSalvar = sep.Length - 1;
                }



                //Os 5 primeiros
                for (int i = 0; i < sep.Length - 1; i++)
                {
                    try
                    {

                        var sep2 = sep[i].Split(',');

                        //Pontuação do cara maior que o do arquivo
                        if (pontuacao >= Convert.ToInt32(sep2[1]) && entrou == 0)
                        {
                            posicaoSalvar = i;
                            entrou = 1;
                        }



                    }
                    catch
                    {



                    }

                }







                //se a pontuação não for maior que os 5 primeiros, sera redirecionado para a tela de Game Over
                if (posicaoSalvar == -1)
                {

                    GameOver gameOver = new GameOver();

                    gameOver.LabelPontuacao(pontuacao.ToString());


                    gameOver.Show();
                    Hide();

                }
                else
                {

                   

                    f.Show();
                    Hide();




                }



            }


            else
            {



             

                f.Show();
                Hide();


            }









        }

        /// <summary>
        /// Função dos Botões em cena
        /// </summary>
        private void OnClick(object sender, EventArgs e)
        {
            p = new Pintor();
            //Botão Clicado
            var v = ((Button)sender).Text.Split(',');
            Point pontoClicado = new Point(int.Parse(v[0]), int.Parse(v[1]));

            int cor = matrizInteiros[int.Parse(v[0]), int.Parse(v[1])];

            int count = p.Colorir(matrizInteiros, pontoClicado, matrizInteiros.GetLength(0), matrizInteiros.GetLength(1), true);

            if (count != 0)
            {
              

             //   AtualizaQuantidadeBloquinho(count, cor);
               // AtualizaPontuacao(count);
                //Colori os Botões
                ColoriBloquinhos(matrizInteiros, true);
               
            }

            else
            {
               // DiminuiPontuacao();
            }

        }

        /// <summary>
        /// Colorir os bloquinhos Randomicamente
        /// </summary>
        private void btnRandomico_Click(object sender, EventArgs e)
        {
            
                ColorirRandomico();
            
        }

        /// <summary>
        /// Gira Anti horario os bloquinhos
        /// </summary>
        private void btnGirarAntiHorario_Click(object sender, EventArgs e)
        {
            p = new Pintor();

            p.GirarAntiHorario(matrizInteiros, matrizInteiros.GetLength(0),
                matrizInteiros.GetLength(1));
         
            ColoriBloquinhos(matrizInteiros,true);

        }

        /// <summary>
        /// Gira horario os bloquinhos
        /// </summary>
        private void btnGirarHorario_Click(object sender, EventArgs e)
        {
            p = new Pintor();

            p.GirarHorario(matrizInteiros, matrizInteiros.GetLength(0),
                matrizInteiros.GetLength(1));
            
            ColoriBloquinhos(matrizInteiros, true);

        }

        /// <summary>
        /// Colori Randomicamente os Botões Existentes
        /// </summary>
        public void ColorirRandomico()
        {


            Random r = new Random();
            int id;

            int QuantidadeVermelho = default(int);
            int QuantidadeAmarelo = default(int);
            int QuantidadeAzul = default(int);
            int QuantidadeVerde = default(int);
            int QuantidadeLaranja = default(int);
            int QuantidadeRosa = default(int);



            for (int l = 0; l < matrizInteiros.GetLength(0); l++)
            {
                for (int c = 0; c < matrizInteiros.GetLength(1); c++)
                {

                    //matrizButton[l, c].BackColor = nomesCores[0];
                    //matrizButton[l, c].ForeColor = nomesCores[0];


                    if (matrizInteiros[l, c] != -1)
                    {
                        id = r.Next(0, numero_cores);
                        matrizButton[l, c].BackColor = nomesCores[id];
                        matrizButton[l, c].ForeColor = nomesCores[id];

                        matrizInteiros[l, c] = id;
                        if (id == 0)
                        {
                            QuantidadeVermelho++;
                        }
                        if (id == 1)
                        { QuantidadeAmarelo++; }

                        if (id == 2)
                        {
                            QuantidadeAzul++;
                        }

                        if (id == 3)
                        { QuantidadeVerde++; }

                        if (id == 4)
                        {
                            QuantidadeLaranja++;
                        }

                        if (id == 5)
                        { QuantidadeRosa++; }

                    }


                }
            }


                  



        }


        public void Colorir_Funcao(string pintar)
        {

            int id = 0;

            var novo = pintar.Split(',');

            for (int l = 0; l < matrizInteiros.GetLength(0); l++)
            {
                for (int c = 0; c < matrizInteiros.GetLength(1); c++)
                {

                    //matrizButton[l, c].BackColor = nomesCores[0];
                    //matrizButton[l, c].ForeColor = nomesCores[0];

                    int j = Convert.ToInt32(novo[id]);


                    matrizButton[ c, l].BackColor = nomesCores[j];
                    matrizButton [c, l].ForeColor = nomesCores[j];

                    matrizInteiros[c, l] = j;

                    id++;

                }

            }
        }
        /// <summary>
        /// Colori os botões de acordo com o numero dentro da matriz Inteiros
        /// </summary>
        private void ColoriBloquinhos(int[,] matrizInteiros, bool op)
        {

            for (int x = 0; x < matrizInteiros.GetLength(0); x++)
            {
                for (int y = 0; y < matrizInteiros.GetLength(1); y++)
                {

                    //Button Invisivel
                    if (matrizInteiros[x, y] == -1  && op)
                    {
                       
                           // matrizButton[x, y].Visible = false;
                            matrizButton[x, y].BackColor = Color.White;
                            matrizButton[x, y].ForeColor = Color.White;
                        
                    }

                    if (matrizInteiros[x, y] == -1 && !op && matrizButton[x, y].BackColor != Color.White)
                    {

                        // matrizButton[x, y].Visible = false;
                        matrizButton[x, y].ForeColor = Color.Black;
                        matrizButton[x, y].Text = "X";

                    }


                    if (matrizInteiros[x, y] != -1  && op)
                    {
                       // matrizButton[x, y].Visible = true;
                        matrizButton[x, y].BackColor = nomesCores[matrizInteiros[x, y]];
                        matrizButton[x, y].ForeColor = nomesCores[matrizInteiros[x, y]];
                        matrizButton[x, y].Text = x + "," + y;
                      
                    }
                       
                    
                }
            }
        }

        /// <summary>
        /// Atualiza a quantidade de Bloquinhos de cada cor a medida que o Usuário vai quebrando.
        /// </summary>
        /// <param name="count">Valor Existente no botão</param>
        /// <param name="cor">Cor que deve ser atualizada</param>
        private void AtualizaQuantidadeBloquinho(int count, int cor)
        {

            quantidadesBloquinhos -= count;



            //if (quantidadesBloquinhos == 0 || quantidadesBloquinhos == 1)
            //{
            //    FimJogo(int.Parse(lblPontuacao.Text), quantidadesBloquinhos);
            //}




           

        }

        /// <summary>
        /// Atualiza a pontuação do Usuario
        /// </summary>
        /// <param name="count">Recebe a pontuação que deve-se adcionar</param>
        private void AtualizaPontuacao(int count)
        {

          //  lblPontuacao.Text = (int.Parse(lblPontuacao.Text) + count).ToString();

        }

        /// <summary>
        /// Caso usuario Click em um Botão que não tenha combinações de cores a sua pontuação será diminuida em 5 pontos. Caso Seja 0 será mantida
        /// </summary>
        //private void DiminuiPontuacao()
        //{


        //    if (int.Parse(lblPontuacao.Text) != 0)
        //    {

        //        //somErro.Play();
        //        Thread.Sleep(900);

        //        //somfundoJogo.PlayLooping();
        //        lblPontuacao.Text = (int.Parse(lblPontuacao.Text) - 5).ToString();

        //    }


        //    if (int.Parse(lblPontuacao.Text) < 0)
        //    {
        //        lblPontuacao.Text = "0";
        //    }

        //}

        private void btn_Solucionar_Click(object sender, EventArgs e)
        {
          


        //    foreach (Node s in solucao)
          //  {
               
                //  InitializeComponent();
                //Thread.Sleep(2000);
        //    }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            Iniciar_Jogo(false);
        }

         //Botão Passo
        private void button2_Click(object sender, EventArgs e)
        {
 
            if (solucao!= null && solucao.Count>0)
            {
               
                if (solucao[0].Giro_Ant || solucao[0].Giro_Hora)
                {
                    if (!set_botao_giro)
                    {
                        ColoriBloquinhos(solucao[0].Info_2 as int[,], false);
                      
                        set_botao_giro = true;
                    }
                   else
                    {
                      
                        
                        ColoriBloquinhos(solucao[0].Info as int[,], true);
                        solucao.RemoveAt(0);
                        set_botao_giro = false;
                    }
                  
                }
                else
                {
                    if (!passo)
                    {
                        ColoriBloquinhos(solucao[0].Info_2 as int[,], false);
                        passo = true;
                    }
                   else
                    {
                       
                        ColoriBloquinhos(solucao[0].Info as int[,], true);
                        solucao.RemoveAt(0);
                        passo = false;

                    }

                 
                }
               
            }
          
        }

        //Botão Animar
        private void button3_Click(object sender, EventArgs e)
        {

            while (solucao != null && solucao.Count > 0)
            {
                ColoriBloquinhos(solucao[0].Info_2 as int[,], false);

                if (solucao[0].Giro_Ant || solucao[0].Giro_Hora)
                {
                    //Verificar Isso Tempo
                 
                    ColoriBloquinhos(solucao[0].Info as int[,], true);
                    solucao.RemoveAt(0);
                    Update();
                    Thread.Sleep(2000);

                }
                else
                {
                    Update();
                    Thread.Sleep(2000);
                    ColoriBloquinhos(solucao[0].Info as int[,], true);
                    solucao.RemoveAt(0);
                }
               
            }

        }


      

        private void numericUpDown_Cores_ValueChanged(object sender, EventArgs e)
        {
           // numero_cores = Convert.ToInt32(//numericUpDown_Cores.Value);

            if (numero_cores >10)
            {
             //   numericUpDown_Cores.Value = 10;
                numero_cores = 10;
            }
            Iniciar_Jogo(false);

        }

        private void numericUpDown_Matriz_ValueChanged(object sender, EventArgs e)
        {

            //largura  = Convert.ToInt32(numericUpDown_Matriz.Value);
           // altura = Convert.ToInt32(numericUpDown_Matriz.Value);

            if (altura > 10)
            {
              //  numericUpDown_Matriz.Value = 10;

                largura = altura = 10;
            }

            Iniciar_Jogo(false);

        }

        private void checkBox_Solucao_Hard_CheckedChanged(object sender, EventArgs e)
        {
          //  if (checkBox_Solucao_Hard.Checked)
            //{
              //  checkBox_Movimenta_C.Checked = true;
            //}
            
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button4_Retornar_Click(object sender, EventArgs e)
        {
            if (matriz_Inicial != null)
            {
                Solucao s = new Solucao();
                matrizInteiros = matriz_Inicial.Clone() as int[,];
                ColoriBloquinhos(matrizInteiros, true);
            }
          

        }

       

        private void reiniciarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Iniciar_Jogo(false);
        }

        private void colorirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorirRandomico();
        }

        private void animarSoluçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            while (solucao != null && solucao.Count > 0)
            {
                ColoriBloquinhos(solucao[0].Info_2 as int[,], false);

                if (solucao[0].Giro_Ant || solucao[0].Giro_Hora)
                {
                    //Verificar Isso Tempo

                    ColoriBloquinhos(solucao[0].Info as int[,], true);
                    solucao.RemoveAt(0);
                    Update();
                    Thread.Sleep(2000);

                }
                else
                {
                    Update();
                    Thread.Sleep(2000);
                    ColoriBloquinhos(solucao[0].Info as int[,], true);
                    solucao.RemoveAt(0);
                }

            }

        }

        private void solucionarIAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (solucao != null)
            {
                solucao.Clear();
                ColoriBloquinhos(matrizInteiros, true);


            }



            matriz_Inicial = matrizInteiros.Clone() as int[,];

            Solucao s = new Solucao(matrizInteiros);

            s.Verifica_coluna = true;
            s.Solution_hard = true;

            solucao = s.Solution();


            if (solucao.Count != 0)
            {

                MessageBox.Show("Solução Encontrada.");


            }
            else
            {
                MessageBox.Show("Solução não Encontrada!!!");
            }
        }
    }
}


















