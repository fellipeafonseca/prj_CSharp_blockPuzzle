
using System;
using System.Collections;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using System.Collections.Generic;

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
        public int Colorir(int[,] matrizInteiros, Point pontoClicado, int Width,int Height, bool moviColuna)//Recebe Matriz de Button e o botão Clicado
        {

            #region Variaveis
            //Fila do Tamanho da Matriz de Botão
            int count = default(int);
            Fila fila = new Fila(matrizInteiros.Length);


            //Pegando a Cor do Botão Clicado
            int corPontoInicial;
            corPontoInicial = matrizInteiros[pontoClicado.X, pontoClicado.Y];


            //Cor Auxiliar Control
            Point p;
            Point pontoAuxiliar;


            //Inserindo Ponto Inicial Clicado na Fila
            fila.Insert(pontoClicado);

            #endregion




            while (!fila.FilaVazia())
            {
                p = new Point();
                p = (Point)fila.Remove();


                #region Posição Y+1
                //Primeiro no If (é o ponto que sai da fila)
                if (p.Y + 1 < Height)
                {
                    //Vendo condição Y+1
                    if (corPontoInicial == matrizInteiros[p.X, p.Y + 1] && matrizInteiros[p.X, p.Y+1] != -1)
                    {
                        

                        //Se for da Mesma Cor Muda a Visibilidade Do Botão()
                        matrizInteiros[p.X, p.Y + 1] = -1;
                        pontoAuxiliar = new Point(p.X, p.Y + 1);
                        fila.Insert(pontoAuxiliar);

                        count++;
                     
                    }
                }
                #endregion

                #region Posição Y-1 
                if (p.Y - 1 >= 0)
                {
                    //Vendo condição Y-1
                    if (corPontoInicial== matrizInteiros[p.X, p.Y - 1] &&  matrizInteiros[p.X, p.Y-1]!=-1)
                    {
                        //Se for da Mesma Cor Muda a Visibilidade Do Botão()       
                        matrizInteiros[p.X, p.Y - 1] = -1;
                        pontoAuxiliar = new Point(p.X, p.Y - 1);
                        fila.Insert(pontoAuxiliar);

                        count++;
                      

                    }


                }

                #endregion

                #region Posição X+1

                if (p.X + 1 < Width)
                {
                    //Vendo a Condição de X+1
                    if (corPontoInicial == matrizInteiros[p.X + 1, p.Y] &&
                  matrizInteiros[p.X + 1, p.Y]!=-1)
                    {
                        // b.SetPixel(p.X + 1, p.Y, C1);
                        matrizInteiros[p.X + 1, p.Y] = -1;
                        pontoAuxiliar = new Point(p.X + 1, p.Y);
                        fila.Insert(pontoAuxiliar);
                        count++;

                     
                    }


                }
                #endregion

                #region Posição X-1
                if (p.X - 1 >= 0)
                {
                    //Vendo a Condição de X-1
                    if (corPontoInicial == matrizInteiros[p.X - 1, p.Y] && matrizInteiros[p.X - 1, p.Y]!=-1)
                    {
                       matrizInteiros[p.X - 1, p.Y]=-1;
                        pontoAuxiliar = new Point(p.X - 1, p.Y);
                        fila.Insert(pontoAuxiliar);


                        count++;
                    }

                }
                #endregion


            }


            if (count != 0)
            {
               MovimentacaoY(matrizInteiros, Width, Height);

                if (moviColuna)
                {
                    VerificaColuna(matrizInteiros, Width, Height);
                }
               
            }



            return count;

        }


        public int Colorir2(int[,] matrizInteiros, Point pontoClicado, int Width, int Height,
            Dictionary<string, int> pontosVisitados, Dictionary<string, int> pontos_visitados_jogada)//Recebe Matriz de Button e o botão Clicado
        {

            #region Variaveis
            //Fila do Tamanho da Matriz de Botão
            int count = default(int);
            Fila fila = new Fila(matrizInteiros.Length);


            //Pegando a Cor do Botão Clicado
            int corPontoInicial;
            corPontoInicial = matrizInteiros[pontoClicado.X, pontoClicado.Y];


            //Cor Auxiliar Control
            Point p;
            Point pontoAuxiliar;
            int x, y;

            //Inserindo Ponto Inicial Clicado na Fila
            fila.Insert(pontoClicado);

            #endregion




            while (!fila.FilaVazia())
            {
                p = new Point();
                p = (Point)fila.Remove();


                #region Posição Y+1
                //Primeiro no If (é o ponto que sai da fila)
                if (p.Y + 1 < Height)
                {
                    //Vendo condição Y+1
                    if (corPontoInicial == matrizInteiros[p.X, p.Y + 1] && matrizInteiros[p.X, p.Y + 1] != -1)
                    {
                        //Se for da Mesma Cor Muda a Visibilidade Do Botão()
                        matrizInteiros[p.X, p.Y + 1] = -1;
                        pontoAuxiliar = new Point(p.X, p.Y + 1);
                        fila.Insert(pontoAuxiliar);
                        x = p.X;
                        y = p.Y + 1;

                        pontosVisitados.Add(x.ToString() + y.ToString(),0);
                        pontos_visitados_jogada.Add(x.ToString() + y.ToString(),0);
                        count++;

                    }
                }
                #endregion

                #region Posição Y-1 
                if (p.Y - 1 >= 0)
                {
                    //Vendo condição Y-1
                    if (corPontoInicial == matrizInteiros[p.X, p.Y - 1] && matrizInteiros[p.X, p.Y - 1] != -1)
                    {
                        //Se for da Mesma Cor Muda a Visibilidade Do Botão()       
                        matrizInteiros[p.X, p.Y - 1] = -1;
                        pontoAuxiliar = new Point(p.X, p.Y - 1);
                        fila.Insert(pontoAuxiliar);
                        x = p.X;
                        y = p.Y - 1;
                        pontosVisitados.Add(x.ToString() + y.ToString(),0);
                        pontos_visitados_jogada.Add(x.ToString() + y.ToString(),0);
                        count++;


                    }


                }

                #endregion

                #region Posição X+1

                if (p.X + 1 < Width)
                {
                    //Vendo a Condição de X+1
                    if (corPontoInicial == matrizInteiros[p.X + 1, p.Y] &&
                  matrizInteiros[p.X + 1, p.Y] != -1)
                    {
                        // b.SetPixel(p.X + 1, p.Y, C1);
                        matrizInteiros[p.X + 1, p.Y] = -1;
                        pontoAuxiliar = new Point(p.X + 1, p.Y);
                        fila.Insert(pontoAuxiliar);
                        x = p.X + 1;
                        y = p.Y;
                        pontosVisitados.Add(x.ToString() + y.ToString(),0);
                        pontos_visitados_jogada.Add(x.ToString() + y.ToString(),0);
                        count++;


                    }


                }
                #endregion

                #region Posição X-1
                if (p.X - 1 >= 0)
                {
                    //Vendo a Condição de X-1
                    if (corPontoInicial == matrizInteiros[p.X - 1, p.Y] && matrizInteiros[p.X - 1, p.Y] != -1)
                    {
                        matrizInteiros[p.X - 1, p.Y] = -1;
                        pontoAuxiliar = new Point(p.X - 1, p.Y);
                        fila.Insert(pontoAuxiliar);

                        x = p.X - 1;
                        y = p.Y;
                        count++;
                        pontosVisitados.Add(x.ToString() + y.ToString(),0);

                        pontos_visitados_jogada.Add(x.ToString() + y.ToString(),0);
                    }

                }
                #endregion


            }



            return count;

        }


        /// <summary>
        /// Verifica se o Bloquinho esta vazio -1 e Movimenta os Bloquinhos Acima para que eles possam cair
        /// </summary>
        /// <param name="indice">matriz de Inteiros</param>
        /// <param name="matrizBotao">Largura (Width)</param>
        /// <param name="matrizBotao">Altura (Height)</param>
        /// <returns></returns>
        public void MovimentacaoY(int[,] matrizInteiros, int Width, int Height)
        {

          
            List<int> numeros = new List<int>();
            bool vazia = false;
            Stack<int> pilha = new Stack<int>();

                for (int x = 0; x < Width; x++)
                {
                for (int y = 0; y < Height; y++)
                {
                    if (matrizInteiros[x, y] == -1)
                    {
                        //Achou vazia
                        vazia = true;
                    }

                    else
                    {
                        pilha.Push(matrizInteiros[x, y]);
                    }
                }

                if (vazia)
                {
                    int aux = Height;

                    for (int i = Height-1; i >= 0; i--)
                    {
                        if (pilha.Count > 0)
                        {
                            matrizInteiros[x, i] = pilha.Pop();
                        }
                        else
                        {
                            matrizInteiros[x, i] = -1;
                        }
                    }

                }
                pilha.Clear();
                vazia = false;


                    }
                


            





        }
   

        /// <summary>
        /// Verifica se existemm colunas vazias
        /// </summary>
        /// <param name="matrizInteiros"></param>
        /// <param name="Width"></param>
        /// <param name="Height"></param>
        public void VerificaColuna(int[,] matrizInteiros, int Width, int Height){


            int contagem = default(int);

            for (int x = Width-1; x >=0; x--)
            {
                for (int y = 0; y <Height; y++)
                {

                    if (matrizInteiros[x,y]==-1)
                    {
                        contagem++;
                    }

                }

                //Se todos da coluna estiverem vazios move os Blocos a direita)
                if (contagem==Height)
                {

                    //Movimentar para Esquerda
                    MovimentacaoColuna(matrizInteiros, x + 1, Width, Height);



                }

                contagem = default(int);
            }





    }


        /// <summary>
        /// Movimentação de todos os bloquinhos a direita da coluna que estiverem vazios
        /// </summary>
        /// <param name="matrizInteiros"></param>
        /// <param name="indice"></param>
        /// <param name="Width"></param>
        /// <param name="Height"></param>
        public void MovimentacaoColuna(int[,] matrizInteiros, int indice, int Width, int Height)
        {
          

            for (int x = indice; x < Width; x++)
            {
                for (int y= 0; y <Height; y++)
                {
                    //aux = matrizInteiros[x + 1, y];
                    matrizInteiros[x -1, y] = matrizInteiros[x, y];
                    matrizInteiros[x, y] = -1;
                }
            }


        }


        /// <summary>
        /// Gira em sentido Anti-Horário a imagem 
        /// </summary>
        /// <param name="matrizInteiros"></param>
        public void GirarAntiHorario(int[,] matrizInteiros, int Width, int Height)
        {


            Stack pilha = new Stack(matrizInteiros.GetLength(1) * matrizInteiros.GetLength(0));

            for (int y = 0; y < matrizInteiros.GetLength(1); y++)
            {
                for (int x = 0; x <matrizInteiros.GetLength(0); x++)
                {

                    pilha.Push(matrizInteiros[x, y]);


                }
            }


            for (int x = matrizInteiros.GetLength(0)-1; x >= 0; x--)
            {

                for (int y = 0; y < matrizInteiros.GetLength(1); y++)
                {


                    matrizInteiros[x, y] = int.Parse(pilha.Pop().ToString());

                }
            }

      
      

            MovimentacaoY(matrizInteiros, Width, Height);
            VerificaColuna(matrizInteiros, Width, Height);


        }


        /// <summary>
        /// Gira em sentido Horário a imagem 
        /// </summary>
        /// <param name="matrizInteiros"></param>
        public void GirarHorario(int[,] matrizInteiros, int Width, int Height)
        {


            Stack pilha = new Stack(matrizInteiros.GetLength(1) * matrizInteiros.GetLength(0));



            for (int y = 0; y < matrizInteiros.GetLength(1); y++)
            {
                for (int x = 0; x < matrizInteiros.GetLength(0); x++)
                {



                    pilha.Push(matrizInteiros[x, y]);




                }
            }


            for (int x = 0; x < matrizInteiros.GetLength(0); x++)
            {

                for (int y = matrizInteiros.GetLength(1)-1; y >= 0; y--)
                {


                    matrizInteiros[x, y] = int.Parse(pilha.Pop().ToString());

                }
            }



            MovimentacaoY(matrizInteiros, Width, Height);
            VerificaColuna(matrizInteiros, Width, Height);

        }




    }

}
