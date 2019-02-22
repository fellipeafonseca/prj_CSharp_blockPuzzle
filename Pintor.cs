//Fellipe Augusto Fonseca RA:122608


using System;
using System.Collections;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace Bloquinhos
{
    public class Pintor
    {

        /// <summary>
        /// Função Colorir os Bloquinhos (Verifica as cores dos Bloquinhos nas posições X e Y para quebrar)
        /// </summary>
        /// <param name="matrizBotao"></param>
        /// <param name="botaoClicado"></param>
        /// <param name="Height"></param>
        /// <param name="Width"></param>
        /// <returns></returns>
        public int Colorir(Button[,] matrizBotao, Button botaoClicado, int Height, int Width)//Recebe Matriz de Button e o botão Clicado
        {

           // System.Media.SoundPlayer meuPlayer =
           //     new System.Media.SoundPlayer("~/Teste.mp3");
           //meuPlayer.Play();
    


            #region Variaveis
            //Fila do Tamanho da Matriz de Botão
            int count = 1;
            Fila fila = new Fila(matrizBotao.Length);


            //Pegando a Cor do Botão Clicado
            Color corPontoInicial = new Color();
            corPontoInicial = botaoClicado.BackColor;


            //Cor Auxiliar Control
            Color corGray = Color.Gray;



            //Pegando o Ponto do Botão 
            var ponto = botaoClicado.Text.Split(',');
            int x = int.Parse(ponto[0]);
            int y = int.Parse(ponto[1]);


            Point p = new Point(x, y);
            Point pontoAuxiliar;


            //Inserindo Ponto Inicial Clicado na Fila
            fila.Insert(p);

            #endregion


            if (corPontoInicial.R == corGray.R &&
                corPontoInicial.G == corGray.G &&
                corPontoInicial.B == corGray.B)
                return 0;


            while (!fila.FilaVazia())
            {
                p = new Point();
                p = (Point)fila.Remove();


                #region Posição Y+1
                //Primeiro no If (é o ponto que sai da fila)
                if (p.Y + 1 < Height)
                {
                    //Vendo condição Y+1
                    if (corPontoInicial.R == ((Button)(matrizBotao[p.X, p.Y + 1])).BackColor.R &&
                       corPontoInicial.G == ((Button)(matrizBotao[p.X, p.Y + 1])).BackColor.G
                        && corPontoInicial.B == ((Button)(matrizBotao[p.X, p.Y + 1])).BackColor.B && ((Button)(matrizBotao[p.X, p.Y + 1])).Visible)
                    {
                        //b.SetPixel(p.X, p.Y + 1, C1);

                        //Se for da Mesma Cor Muda a Visibilidade Do Botão()
                        ((Button)(matrizBotao[p.X, p.Y + 1])).Visible = false;
                        pontoAuxiliar = new Point(p.X, p.Y + 1);
                        fila.Insert(pontoAuxiliar);

                        count++;
                        Thread.Sleep(1000);
                    }
                }
                #endregion

                #region Posição Y-1 e Movimentação dos Bloquinhos
                if (p.Y - 1 >= 0)
                {
                    //Vendo condição Y-1
                    if (corPontoInicial.R == ((Button)(matrizBotao[p.X, p.Y - 1])).BackColor.R &&
                       corPontoInicial.G == ((Button)(matrizBotao[p.X, p.Y - 1])).BackColor.G
                        && corPontoInicial.B == ((Button)(matrizBotao[p.X, p.Y - 1])).BackColor.B && ((Button)(matrizBotao[p.X, p.Y - 1])).Visible)
                    {
                        //Se for da Mesma Cor Muda a Visibilidade Do Botão()       
                        ((Button)(matrizBotao[p.X, p.Y - 1])).Visible = false;
                        pontoAuxiliar = new Point(p.X, p.Y - 1);
                        fila.Insert(pontoAuxiliar);

                        count++;
                        Thread.Sleep(1000);

                    }


                    #region Movimentando os Bloquinhos que estão acima do botão Clicado para baixo
                    else
                    {

                        if (((Button)(matrizBotao[p.X, p.Y])).BackColor.R == corPontoInicial.R &&
                            ((Button)(matrizBotao[p.X, p.Y])).BackColor.G == corPontoInicial.G &&
                            ((Button)(matrizBotao[p.X, p.Y])).BackColor.B == corPontoInicial.B && count != 1 &&
                            ((Button)(matrizBotao[p.X, p.Y - 1])).BackColor != corPontoInicial)
                        {




                            for (int i = p.Y - 1; i < Height; i++)
                            {

                                if (!((Button)(matrizBotao[p.X, i])).Visible || ((Button)(matrizBotao[p.X, i])).BackColor == corPontoInicial)
                                {
                                    ((Button)(matrizBotao[p.X, i])).BackColor = ((Color)((Button)(matrizBotao[p.X, i - 1])).BackColor);
                                    ((Button)(matrizBotao[p.X, i])).ForeColor = ((Color)((Button)(matrizBotao[p.X, i - 1])).BackColor);
                                    ((Button)(matrizBotao[p.X, i])).Visible = true;
                                    ((Button)(matrizBotao[p.X, i - 1])).Visible = false;




                                }
                            }





                            for (int i = p.Y - 1; i > 0; i--)
                            {

                                //Talvez acrescentar || == Cor do Ponto Inicial
                                if (((Button)(matrizBotao[p.X, i])).Visible == false && ((Button)(matrizBotao[p.X, i - 1])).Visible)
                                {
                                    ((Button)(matrizBotao[p.X, i])).BackColor = ((Color)((Button)(matrizBotao[p.X, i - 1])).BackColor);
                                    ((Button)(matrizBotao[p.X, i])).ForeColor = ((Color)((Button)(matrizBotao[p.X, i - 1])).BackColor);




                                    ((Button)(matrizBotao[p.X, i])).Visible = true;



                                    ((Button)(matrizBotao[p.X, i - 1])).Visible = false;




                                }
                            }


                        }


                    }

                    #endregion


                }

                #endregion

                #region Posição X+1

                if (p.X + 1 < Width)
                {
                    //Vendo a Condição de X+1
                    if (corPontoInicial.R == ((Button)(matrizBotao[p.X + 1, p.Y])).BackColor.R &&
                  corPontoInicial.G == ((Button)(matrizBotao[p.X + 1, p.Y])).BackColor.G
                   && corPontoInicial.B == ((Button)(matrizBotao[p.X + 1, p.Y])).BackColor.B && ((Button)(matrizBotao[p.X + 1, p.Y])).Visible)
                    {
                        // b.SetPixel(p.X + 1, p.Y, C1);
                        ((Button)(matrizBotao[p.X + 1, p.Y])).Visible = false;
                        pontoAuxiliar = new Point(p.X + 1, p.Y);
                        fila.Insert(pontoAuxiliar);
                        count++;

                        Thread.Sleep(1000);
                    }


                }
                #endregion

                #region Posição X-1
                if (p.X - 1 >= 0)
                {
                    //Vendo a Condição de X-1
                    if (corPontoInicial.R == ((Button)(matrizBotao[p.X - 1, p.Y])).BackColor.R &&
                  corPontoInicial.G == ((Button)(matrizBotao[p.X - 1, p.Y])).BackColor.G
                   && corPontoInicial.B == ((Button)(matrizBotao[p.X - 1, p.Y])).BackColor.B && ((Button)(matrizBotao[p.X - 1, p.Y])).Visible)
                    {

                        ((Button)(matrizBotao[p.X - 1, p.Y])).Visible = false;
                        pontoAuxiliar = new Point(p.X - 1, p.Y);
                        fila.Insert(pontoAuxiliar);

                        Thread.Sleep(1000);

                        count++;
                    }

                }
                #endregion


            }



            bool colunaVazia = false;

            do
            {

                for (int i = 0; i < Width; i++)
                {
                    colunaVazia = false;
                    if (ColunaEsquerdaVazia(i, matrizBotao, Height))
                    {
                        MoveColunaParaEsquerda(i, matrizBotao, Height);
                        colunaVazia = true;
                    }
                }

            } while (colunaVazia);



            //Soma +1
            return count;

        }

        /// <summary>
        /// Verifica se a coluna da esquerda está vazia
        /// </summary>
        /// <param name="indice">Índice da coluna atual</param>
        /// <param name="matrizBotao">Matriz de botões</param>
        /// <returns>Retorna se a coluna se esquerda está toda branca</returns>
        private bool ColunaEsquerdaVazia(int indice, Button[,] matrizBotao, int Height)
        {
            //Se não há mais coluna na esquerda
            if (indice == 0)
                return false;

            bool temBotao=false;

            for (int i = 0; i < Height; i++)
            {
                if (matrizBotao[indice - 1, i].Visible)
                    return false;
                if (matrizBotao[indice, i].Visible)
                    temBotao = true;
            }
            return temBotao;
        }

        private void MoveColunaParaEsquerda(int indice, Button[,] matrizBotao, int Height)
        {
            if (indice > 0)
            {
                for (int i = 0; i < Height; i++)
                {
                    Button aux = new Button();

                    aux.Visible = matrizBotao[indice - 1, i].Visible;
                    aux.BackColor = matrizBotao[indice - 1, i].BackColor;
                    aux.ForeColor = matrizBotao[indice - 1, i].ForeColor;

                    matrizBotao[indice - 1, i].Visible = matrizBotao[indice, i].Visible;
                    matrizBotao[indice - 1, i].BackColor = matrizBotao[indice, i].BackColor;
                    matrizBotao[indice - 1, i].ForeColor = matrizBotao[indice, i].ForeColor;


                    matrizBotao[indice, i].Visible = aux.Visible;
                    matrizBotao[indice, i].BackColor = aux.BackColor;
                    matrizBotao[indice, i].ForeColor = aux.ForeColor;
                }
            }
        }



        /// <summary>
        /// Verifica se Existe possibilidades de Duplas de cores, antes de quebrar os bloquinhos infividuais
        /// </summary>
        /// <param name="matrizBotao"></param>
        /// <param name="Height"></param>
        /// <param name="Width"></param>
        /// <returns></returns>
        public bool VerificaColorir(Button[,] matrizBotao, int Height, int Width)
        {

            //Fila do Tamanho da Matriz de Botão
            int count = 1;
            Fila fila = new Fila(matrizBotao.Length);


            //Pegando a Cor do Botão Clicado
            Color corPontoInicial;



            //Cor Auxiliar Control
            Color corGray = Color.Gray;



            //Pegando o Ponto do Botão 
            // var ponto = botaoClicado.Text.Split(',');



            Point p;




            //Color c = b.GetPixel(x, y);


            for (int x = 0; x < Width; x++)
            {
                for (int y = 0; y < Height; y++)
                {
                    p = new Point(x, y);

                    fila.Insert(p);
                    corPontoInicial = matrizBotao[x, y].BackColor;




                    if (corPontoInicial.R == corGray.R &&
            corPontoInicial.G == corGray.G &&
            corPontoInicial.B == corGray.B)
                    {
                        count = 0;
                    }


                    while (!fila.FilaVazia())
                    {
                        p = new Point();

                        p = (Point)fila.Remove();



                        //Primeiro no If (é o ponto que sai da fila)
                        if (p.Y + 1 < Height)
                        {
                            //Vendo condição Y+1
                            if (corPontoInicial.R == ((Button)(matrizBotao[p.X, p.Y + 1])).BackColor.R &&
                               corPontoInicial.G == ((Button)(matrizBotao[p.X, p.Y + 1])).BackColor.G
                                && corPontoInicial.B == ((Button)(matrizBotao[p.X, p.Y + 1])).BackColor.B && ((Button)(matrizBotao[p.X, p.Y + 1])).Visible && ((Button)(matrizBotao[p.X, p.Y])).Visible)
                            {
                                //b.SetPixel(p.X, p.Y + 1, C1);

                                //Se for da Mesma Cor Muda a Visibilidade Do Botão()
                                //((Button)(matrizBotao[p.X, p.Y + 1])).BackColor = corGray;
                                //((Button)(matrizBotao[p.X, p.Y + 1])).Visible = false;
                                //pontoAuxiliar = new Point(p.X, p.Y + 1);
                                //fila.Insert(pontoAuxiliar);
                                return true;
                                count++;
                                // Thread.Sleep(1000);
                            }
                        }




                        if (p.Y - 1 >= 0)
                        {
                            //Vendo condição Y-1
                            if (corPontoInicial.R == ((Button)(matrizBotao[p.X, p.Y - 1])).BackColor.R &&
                               corPontoInicial.G == ((Button)(matrizBotao[p.X, p.Y - 1])).BackColor.G
                                && corPontoInicial.B == ((Button)(matrizBotao[p.X, p.Y - 1])).BackColor.B && ((Button)(matrizBotao[p.X, p.Y - 1])).Visible && ((Button)(matrizBotao[p.X, p.Y])).Visible)
                            {
                                // b.SetPixel(p.X, p.Y - 1, C1);

                                //Se for da Mesma Cor Muda a Visibilidade Do Botão()
                                // ((Button)(matrizBotao[p.X, p.Y - 1])).BackColor = corGray;
                                //((Button)(matrizBotao[p.X, p.Y - 1])).Visible = false;
                                //pontoAuxiliar = new Point(p.X, p.Y - 1);
                                //fila.Insert(pontoAuxiliar);

                                count++;
                                return true;
                                //Thread.Sleep(1000);

                            }

                            //else//Pode Dar Pau Rever
                            //{

                            //    if (((Button)(matrizBotao[p.X, p.Y])).BackColor.R == corPontoInicial.R &&
                            //        ((Button)(matrizBotao[p.X, p.Y])).BackColor.G == corPontoInicial.G &&
                            //        ((Button)(matrizBotao[p.X, p.Y])).BackColor.B == corPontoInicial.B && ((Button)(matrizBotao[p.X, p.Y - 1])).BackColor != corPontoInicial)
                            //    {
                            //        ((Button)(matrizBotao[p.X, p.Y])).BackColor = ((Color)((Button)(matrizBotao[p.X, p.Y - 1])).BackColor);
                            //        ((Button)(matrizBotao[p.X, p.Y])).ForeColor = ((Color)((Button)(matrizBotao[p.X, p.Y - 1])).BackColor);


                            //        ((Button)(matrizBotao[p.X, p.Y])).Visible = true;
                            //        // ((Button)(matrizBotao[p.X, p.Y - 1])).BackColor = ;
                            //        ((Button)(matrizBotao[p.X, p.Y - 1])).Visible = false;


                            //    }






                            //    // ((Button)(matrizBotao[p.X, p.Y - 1]))..Visible = false;
                            //    //  ((Button)(matrizBotao[p.X, p.Y - 1])).Location = new Point(((Button)(matrizBotao[p.X, p.Y - 1])).Location.X, ((Button)(matrizBotao[p.X, p.Y - 1])).Location.Y+50);

                            //    //((Button)(matrizBotao[p.X, p.Y - 1])).Visible = true;
                            //    // Thread.Sleep(1000);

                            //}


                        }


                        if (p.X + 1 < Width)
                        {
                            //Vendo a Condição de X+1
                            if (corPontoInicial.R == ((Button)(matrizBotao[p.X + 1, p.Y])).BackColor.R &&
                          corPontoInicial.G == ((Button)(matrizBotao[p.X + 1, p.Y])).BackColor.G
                           && corPontoInicial.B == ((Button)(matrizBotao[p.X + 1, p.Y])).BackColor.B && ((Button)(matrizBotao[p.X + 1, p.Y])).Visible && ((Button)(matrizBotao[p.X, p.Y])).Visible)
                            {
                                // b.SetPixel(p.X + 1, p.Y, C1);

                                // ((Button)(matrizBotao[p.X + 1, p.Y])).BackColor = corGray;
                                //((Button)(matrizBotao[p.X + 1, p.Y])).Visible = false;
                                //pontoAuxiliar = new Point(p.X + 1, p.Y);
                                //fila.Insert(pontoAuxiliar);
                                count++;
                                return true;
                                //Thread.Sleep(1000);
                            }


                        }



                        if (p.X - 1 >= 0)
                        {
                            //Vendo a Condição de X-1
                            if (corPontoInicial.R == ((Button)(matrizBotao[p.X - 1, p.Y])).BackColor.R &&
                          corPontoInicial.G == ((Button)(matrizBotao[p.X - 1, p.Y])).BackColor.G
                           && corPontoInicial.B == ((Button)(matrizBotao[p.X - 1, p.Y])).BackColor.B && ((Button)(matrizBotao[p.X - 1, p.Y])).Visible && ((Button)(matrizBotao[p.X, p.Y])).Visible)
                            {
                                // b.SetPixel(p.X - 1, p.Y, C1);
                                //// ((Button)(matrizBotao[p.X - 1, p.Y])).BackColor = corGray;
                                //((Button)(matrizBotao[p.X - 1, p.Y])).Visible = false;
                                //pontoAuxiliar = new Point(p.X - 1, p.Y);
                                //fila.Insert(pontoAuxiliar);

                                //Thread.Sleep(1000);

                                count++;
                                return true;
                            }

                        }


                        //Pinta o Ponto
                        //  b.SetPixel(p.X, p.Y, C1);
                        //    count++;

                        // ((Button)(matrizBotao[p.X + 1, p.Y])).BackColor = corGray;
                        // ((Button)(matrizBotao[p.X + 1, p.Y])).Visible = false;
                    }








                }//for y
            }//for do X




            //Ainda Existe possibilidades para pintar 
            if (count != 0 && count != 1)
            {
                return true;
            }
            else
            {
                //Não Existe mais possibilidades
                return false;
            }
        }




        //Verifica coluna


    }

}
