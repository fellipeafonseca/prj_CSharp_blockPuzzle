using EP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bloquinhos
{
    public class Solucao : Graph
    {
        private int nivel_Menor;
        public int[,] Matriz_Inicial { get; set; }
        private int Menor_Numero_Blocos { get; set; }
        private int Cont_Nos_Giros { get; set; }
        private Node Node_Final { get; set; }
        public bool Verifica_coluna { get; set; }
        public bool Solution_hard { get; set; }

        // private List<Node> Lista_Nos_Finais { get; set; }

        public Solucao()
        {

        }

        public Solucao(int[,] Matriz_Inicial)
        {
            this.Matriz_Inicial = new int[Matriz_Inicial.GetLength(0), Matriz_Inicial.GetLength(1)];
            this.Matriz_Inicial = Matriz_Inicial.Clone() as int[,];
            Menor_Numero_Blocos = int.MaxValue;
            Node_Final = new Node();
        }

        public List<Node> Solution()
        {
            PriorityQueue<int, Node> fila = new PriorityQueue<int, Node>();
            Dictionary<string, int> pontos_aux = new Dictionary<string, int>();
            Dictionary<string, int> pontos_clicados = new Dictionary<string,int>();
            bool possiveis_jogadas = false;
            int contagem_blocos = Conta_Blocos_Aval_Function(Matriz_Inicial);
           
            Node n0 = new Node();
            n0.Info = Matriz_Inicial;
            string name = Getname(n0);
            n0.Name = name;
            n0.Nivel = 0;
            n0.Giro_Ant = n0.Giro_Hora = false;
            n0.Cont_Blocos = contagem_blocos;

            AddNode(name, Matriz_Inicial);
            fila.Enqueue(contagem_blocos, n0.Nivel, n0);
            bool while_2 = true;

            int c = 0;

            while (fila.Count != 0)
            {
                c++;

                Node aux = fila.Dequeue();
                
                Node aux2 = new Node(aux.Name, Copia_Matriz(aux));
               
                pontos_aux.Clear();

                //Se ja atingio a menor quantidade possivel de nós pode desconsiderar 
                // Nós com Niveis maiores do que o atual nó Final (aux.Nivel+ 1)


                if (c == 1000000)
                {
                    break;
                }

                if (!(Menor_Numero_Blocos == 0 && aux.Nivel >= Node_Final.Nivel))
                {
                    while (Verifica_Possiveis_Jogadas(aux2, pontos_aux, pontos_clicados))
                    {


                        //Se ja atingio a menor quantidade possivel de nós pode desconsiderar 
                        // Nós com Niveis maiores do que o atual nó Final (aux.Nivel+ 1)
                        if (Menor_Numero_Blocos == 0 && aux.Nivel + 1 >= Node_Final.Nivel)
                        {
                            while_2 = false;
                        }

                        Node novo_no = new Node() ;

                        if (while_2)
                        {
                                //Node novo_no = new Node();
                            
                                novo_no = Gera_Nova_Matriz(aux, pontos_clicados);
                                novo_no.Cont_Blocos = aux.Cont_Blocos - pontos_clicados.Count;
                                novo_no.Nivel = aux.Nivel + 1;
                        }
                    

                       

                        if (while_2 && (novo_no.Cont_Blocos == Menor_Numero_Blocos && novo_no.Nivel < Node_Final.Nivel))
                        {
                            // Remove para não perder nós com Niveis menores        
                            RemoveNode(Node_Final.Name);

                        }

                        if (while_2 && AddNode(novo_no.Name, novo_no.Info, novo_no.Info_2))
                        {
                            novo_no.Parent = aux;

                            AddEdge(aux.Name, novo_no.Name, aux.Cont_Blocos - pontos_clicados.Count);
                            novo_no.Giro_Ant = novo_no.Giro_Hora = false;

                            // novo_no.Cont_Blocos = aux.Cont_Blocos - pontos_clicados.Count;

                            //Aval Function (contagem_blocos - pontos_clicados.Count)
                            fila.Enqueue(aux.Cont_Blocos - pontos_clicados.Count, novo_no.Nivel, novo_no);
                            possiveis_jogadas = true;
                        }

                      

                        pontos_clicados.Clear();

                        while_2 = true;
                    }
                }

                pontos_aux.Clear();


                //Só Verifica se é final se Não tiver mais numero de 
                //jogadas funcao(Verifica_Possiveis_Jogadas)
                if (!possiveis_jogadas)
                {
                    Verifica_No_Final(aux);
                }



                if (Solution_hard && aux.Cont_Blocos > 1 &&
                     !(Menor_Numero_Blocos == 0 && aux.Nivel + 1 >= Node_Final.Nivel) &&
                     !Matriz_Equal(aux.Info as int[,]))
                    {
                    Node novo_no;
                  

                    //Giro Anti-Horario
                        novo_no = Gera_Matriz_Hard(aux, 1);


                        // Se nó não Existir conseguiu adcionar
                        if (AddNode(novo_no.Name, novo_no.Info, novo_no.Info_2))
                        {
                            novo_no.Parent = aux;

                            AddEdge(aux.Name, novo_no.Name, 0);
                            novo_no.Nivel = aux.Nivel + 1;
                            novo_no.Cont_Giros = aux.Cont_Giros + 1;
                            novo_no.Cont_Blocos = aux.Cont_Blocos;
                            novo_no.Giro_Ant = true;
                            fila.Enqueue(aux.Cont_Blocos, novo_no.Nivel, novo_no);

                        }

                      
                    
                        // Giro Horario
                        novo_no = Gera_Matriz_Hard(aux, 2);

                    if (AddNode(novo_no.Name, novo_no.Info, novo_no.Info_2))
                    {


                        novo_no.Parent = aux;

                        AddEdge(aux.Name, novo_no.Name, 0);
                        novo_no.Nivel = aux.Nivel + 1;
                        novo_no.Cont_Giros = aux.Cont_Giros + 1;
                        novo_no.Cont_Blocos = aux.Cont_Blocos;
                        novo_no.Giro_Hora = true;
                        fila.Enqueue(aux.Cont_Blocos, novo_no.Nivel, novo_no);

                    }

                    }
                
                possiveis_jogadas = false;


              
            }

            return Monta_Solucao();
        }

        private List<Node> Monta_Solucao()
        {
            List<Node> caminho = new List<Node>();
            Node nofinal_aux = Node_Final;
            caminho.Add(nofinal_aux);

            while (nofinal_aux.Parent!=null)
            {
                caminho.Add(nofinal_aux.Parent);
                nofinal_aux = nofinal_aux.Parent;
            }
            caminho.RemoveAt(caminho.Count() - 1);
            caminho.Reverse();
            return caminho;

        }

        private bool Matriz_Equal(int[,] matriz)
        {
            int cor = -1;

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (matriz[i, j] != -1 && cor==-1)
                    {
                        cor = matriz[i, j];
                    }

                    if (cor != matriz[i ,j])
                    {
                        return false;
                    }

                }
            }

            return true;


        }

        private object Copia_Matriz(Node aux)
        {
            return (aux.Info as int[,]).Clone();
        }

        private Node Gera_Nova_Matriz(Node aux, Dictionary<string, int> pontos_visitados)
        {
            Node retur= new Node();

            int[,] matriz = new int[(aux.Info as int[,]).GetLength(0), 
                        (aux.Info as int[,]).GetLength(1)];


            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (!pontos_visitados.ContainsKey(i.ToString() + (j.ToString())))
                    {
                        matriz[i, j] = (aux.Info as int[,])[i, j];
                    }
                    else
                    {
                        matriz[i, j] = -1;
                    }
                 
                }
            }

            retur.Info_2 = matriz.Clone();

            Pintor p1 = new Pintor();
            p1.MovimentacaoY(matriz, matriz.GetLength(0), matriz.GetLength(1));

            if (Verifica_coluna)
            {
                p1.VerificaColuna(matriz, matriz.GetLength(0), matriz.GetLength(1));

            }
        

            retur.Info = matriz;
            retur.Name = Getname(retur);

            return retur;
        }

        private bool Verifica_Possiveis_Jogadas(Node par,
         Dictionary<string, int> lista_Pontos_Visitados, Dictionary<string, int> lista_Pontos_Visitados_Jogada)
        {

            Pintor p1 = new Pintor();

            int[,] m = ((par.Info as int[,]).Clone()) as int[,];
          


            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    if (m[i, j] != -1
                        && !lista_Pontos_Visitados.ContainsKey(i.ToString() + j.ToString())
                     //   && !lista_Pontos_Visitados.Exists(x => x.Equals(i.ToString() + (j.ToString())))
                     )
                    {
                        if (p1.Colorir2((par.Info as int[,]), new System.Drawing.Point(i, j),
                            m.GetLength(0), 
                            m.GetLength(1), 
                            lista_Pontos_Visitados,
                            lista_Pontos_Visitados_Jogada) != 0)
                        {
                            return true;
                        }
                    }
                }
            }

       

            return false;


        }


        private Node Gera_Matriz_Hard(Node aux, int op)
        {

            Node retur = new Node();
     
            retur.Info_2 = ((aux.Info) as int[,]).Clone();
            retur.Info = ((aux.Info) as int[,]).Clone();
           

            Pintor p1 = new Pintor();


            if (op ==1)
            {
                p1.GirarAntiHorario((retur.Info as int[,]), (retur.Info as int[,]).GetLength(0),
               (retur.Info as int[,]).GetLength(1));
            }


            if (op == 2)
            {
                p1.GirarHorario((retur.Info as int[,]), (retur.Info as int[,]).GetLength(0),
               (retur.Info as int[,]).GetLength(1));
            }

            retur.Name = Getname(retur);

            return retur;
        }

        private void Verifica_No_Final(Node aux)
        {
            // int count = Conta_Blocos_Aval_Function(aux.Info as int[,]);
            int count = aux.Cont_Blocos;

            if (Menor_Numero_Blocos == int.MaxValue  
                || count < Menor_Numero_Blocos 
                || (count == Menor_Numero_Blocos && aux.Nivel < nivel_Menor))
            {
                Node_Final = aux;
              //  Lista_Nos_Finais.Add(aux);
                Menor_Numero_Blocos = count;
                nivel_Menor = aux.Nivel;
                return;
            }

            //if (count <= Menor_Numero_Blocos && aux.Nivel <= nivel_Menor)
            //{
            //    // Lista_Nos_Finais.Clear();
            //    //  Lista_Nos_Finais.Add(aux);
            //    Node_Final = aux;
            //    Menor_Numero_Blocos = count;
            //    nivel_Menor = aux.Nivel;
            //    return;
            //}


        }

        public int Conta_Blocos_Aval_Function(int[,] matriz)
        {
            int retorno = default(int);

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (matriz[i, j] != -1)
                    {
                        retorno++;
                    }
                }
            }

            return retorno;
        }

        private string Getname(Node n)
        {
            string name = string.Empty;
            int[,] matriz = n.Info as int[,];

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                   name+= matriz[i, j].ToString();
                }
        
            }

            return name;
        }

       
    }
}
