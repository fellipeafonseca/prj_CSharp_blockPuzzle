using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Bloquinhos
{
    public partial class FimJogo : Form
    {

        int posicaoSalvar;
        public FimJogo()
        {
            InitializeComponent();
        }


        private void FimJogo_Load(object sender, EventArgs e)
        {
           
        }

        private void lblPontuacao2_Click(object sender, EventArgs e)
        {

        }



        public void LabelPontuacao(string pontuacao,int posicao)
        {

            lblPontuacao2.Text = pontuacao;
            posicaoSalvar = posicao;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {






            string arquivo;


            //  var arquivo = System.IO.File.OpenText(@"C:\Users\S\Desktop\Pontuacao.txt");
            //  arquivo.(lblNome.Text+","+lblPontuacao2.Text+";");
            // arquivo.Close();




            if (posicaoSalvar == -1)
            {
                var file3 = System.IO.File.CreateText(@"C:\Users\S\Desktop\Pontuacao.txt");


                file3.Write(txtNome.Text + "," + lblPontuacao2.Text + ";");

                file3.Flush();
                file3.Close();
            
            }
            else
            {


                using (var file = System.IO.File.OpenText(@"C:\Users\S\Desktop\Pontuacao.txt"))
                {
                    arquivo = file.ReadToEnd();



                }


                System.IO.File.Delete(@"C:\Users\S\Desktop\Pontuacao.txt");




                var sep = arquivo.Split(';');




                int j = 0;


                var file3 = System.IO.File.CreateText(@"C:\Users\S\Desktop\Pontuacao.txt");





                //Os 5 primeiros
                for (int i = 0; i < sep.Length; i++)
                {




                    //posição a salvar
                    if (posicaoSalvar == i)
                    {


                        file3.Write(txtNome.Text + "," + lblPontuacao2.Text + ";");

                    }
                    else
                    {

                        if (i<5)
                        {
                            file3.Write(sep[j] + ";");

                            j++;
                        }
                       

                    }


                }




                file3.Flush();

                file3.Close();




            }



            Menu m = new Menu();



            m.Show();
            Hide();


        }
    }
}
