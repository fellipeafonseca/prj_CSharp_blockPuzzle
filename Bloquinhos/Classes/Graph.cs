using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Bloquinhos
{
    /// <summary>
    /// Classe que representa um grafo.
    /// </summary>
    [Serializable]
    public class Graph
    {
        /// <summary>
        /// Lista de nós que compõe o grafo.
        /// </summary>
        public Dictionary<string, Node> nodes;

       

        public Graph()
        {
            this.nodes = new Dictionary<string, Node>();
        }


        protected Node FindNode(string name)
        {
            if (nodes.ContainsKey(name))
                return nodes[name];
            else
                return null;
        }

        public List<Node> ShortestPath(string begin, string end)
        {
            // TODO: apagar!!!
            ClearVisited();
            List<Node> visitationOrder = new List<Node>();
            Graph g = new Graph();
            Node n = FindNode(begin);
            int cont = 0;
            g.AddNode(begin, 0);
            n.Visited = true;
            visitationOrder.Add(n);
            while (n.Name != end)
            {
                double minCost = -1;
                Edge bestEdge = null;
                Node fromNode = null;
                foreach (Node node in g.nodes.Values)
                {
                    Node originalNode = FindNode(node.Name);
                    foreach (Edge e in originalNode.Edges)
                    {
                        if (!e.To.Visited && e.To.Info.ToString() != "B")
                        {
                            if (bestEdge == null || e.Cost + Convert.ToDouble(node.Info) < minCost)
                            {
                                fromNode = node;
                                bestEdge = e;
                                minCost = e.Cost + Convert.ToDouble(node.Info);
                            }
                        }
                    }
                }
                n = new Node(bestEdge.To.Name, minCost);
                g.nodes.Add(n.Name , n);
                bestEdge.To.Visited = true;
                bestEdge.To.Parent = bestEdge.From;
                visitationOrder.Add(bestEdge.To);
            }

            // Retornando so o caminho
            List<Node> res = new List<Node>();
            Node x = visitationOrder[visitationOrder.Count-1];
                while (x.Parent != null)
                {
                res.Add(x);
                    x = x.Parent;
                }

            res.Reverse();
            return res;
        }

        public List<Node> BreadthFirstSearch(string begin)
        {
            ClearVisited();
            List<Node> visitationOrder = new List<Node>();
            Queue<Node> q = new Queue<Node>();
            Node n = FindNode(begin);
            q.Enqueue(n);
            while (q.Count != 0)
            {
                n = q.Dequeue();
                if (!n.Visited)
                {
                    n.Visited = true;
                    visitationOrder.Add(n);
                    foreach (Edge e in n.Edges)
                    {
                        if (!e.To.Visited)
                        {
                            q.Enqueue(e.To);
                            e.To.Parent = n;
                        }
                    }
                }
            }
            return visitationOrder;
        }

        public List<Node> DepthFirstSearch(string begin)
        {
            ClearVisited();
            List<Node> visitationOrder = new List<Node>();
            Stack<Node> s = new Stack<Node>();
            Node n = FindNode(begin);
            s.Push(n);
            while (s.Count != 0)
            {
                n = s.Pop();
                if (!n.Visited)
                {
                    n.Visited = true;
                    visitationOrder.Add(n);
                    foreach (Edge e in n.Edges)
                    {
                        if (!e.To.Visited)
                        {
                            s.Push(e.To);
                            e.To.Parent = n;
                        }
                    }
                }
            }
            return visitationOrder;
        }

        public void AddNode(string name, object info)
        {
            AddNode(name, info, null);
        }

        public bool AddNode(string name, object info, object info_2)
        {
            Node n = FindNode(name);
            if (n == null)
            {
                nodes.Add(name, new Node(name, info, info_2, 0));
                return true;
            }
            else
            {
                return false;

            }
            //Alteração para só adcionar possibilidades que ainda não existam
                //throw new Exception("Esse nó já existe.");
        }


        public bool RemoveNode(string name)
        {
            Node n = FindNode(name);
            if (n != null)
            {
                nodes.Remove(name);
                return true;
            }
            else
            {
                return false;

            }
            //Alteração para só adcionar possibilidades que ainda não existam
            //throw new Exception("Esse nó já existe.");
        }

        public void AddEdge(string nameFrom, string nameTo, int cost)
        {
            Node nodeFrom = FindNode(nameFrom);
            Node nodeTo = FindNode(nameTo);
            if (nodeFrom != null && nodeTo != null)
                nodeFrom.AddEdge(nodeTo, cost);
            else
                throw new Exception("Não foi possível adicionar a aresta. Nós inválidos.");
        }

        private void ClearVisited()
        {

                foreach (Node item2 in nodes.Values)
                {
                    item2.Visited = false;
                    item2.Parent = null;
                }
            
            
        }

     

        public void Save(string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            try
            {
                formatter.Serialize(fs, this);
            }
            catch (SerializationException se)
            {
                Console.WriteLine("Failed to serialize. Reason: " + se.Message);
                throw;
            }
            finally
            {
                fs.Close();
            }

        }

        public void Load(string fileName)
        {
            // Open the file containing the data that you want to deserialize.
            FileStream fs = new FileStream(fileName, FileMode.Open);
            try
            {
                BinaryFormatter formatter = new BinaryFormatter();

                Graph g = (Graph)formatter.Deserialize(fs);
                this.nodes = g.nodes;
            }
            catch (SerializationException se)
            {
                Console.WriteLine("Failed to deserialize. Reason: " + se.Message);
                throw;
            }
            finally
            {
                fs.Close();
            }


        }


      

        public void MergeGraphs(List<Graph> graphs)
        {
        }

        public int DirtyCount(string begin, int maxDistance)
        {
            return 0;
        }


        public static Graph CreateMSTGraph(int n)
        {
            return null;
        }

        public int MSTLength(string start)
        {
            return 0;
        }


    }
}
