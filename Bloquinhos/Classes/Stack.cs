using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
//using System.Threading.Tasks;


namespace Bloquinhos
{
    public class Stack
    {
        private int topo, maximo;
        private object[] elementos;


        public Stack(int maximo)
        {
            this.maximo = maximo;
            elementos = new object[maximo];
            topo = 0;
        }



        public void Push(object x)
        {
            if (FullStack())
                throw new Exception("Pilha Cheia");
            
                elementos[topo++] = x;

        }


        public object Pop()
        {


            if (EmptyStack())
                throw new Exception("Pilha Vazia");

            else
            {

                return elementos[--topo];

            }
          

        }


        public object Peek()
        {
            if (EmptyStack())
                throw new Exception("Pilha Vazia");

            return elementos[topo - 1];

        }


        public bool FullStack(){

            if (maximo == topo)
                return true;

            return false;

        }


        public bool EmptyStack()
        {
            if (topo == 0)
                return true;
            return false;

        }

    }
}
