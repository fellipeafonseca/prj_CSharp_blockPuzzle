using System;

namespace Bloquinhos
{

    public class Fila
    {
        private object[] elementos;
        private int front, rear, size, count;

        public int Rear
        {
            get { return rear; }
            set { rear = value; }
        }

        public int Count
        {
            get { return count; }
            set { count = value; }
        }

        public int Size
        {
            get { return size; }
            set { size = value; }
        }

        public int Front
        {
            get { return front; }
            set { front = value; }
        }




        public Fila(int size)
        {
            elementos = new object[size];
            Size = size;
            Front = 0;
            Rear = 0;
            Count = 0;
        }


        public bool FilaCheia()
        {

            if (Count == Size)
                return true;
            else return false;


        }

        public bool FilaVazia()
        {

            if (Count == 0)
                return true;
            else
                return false;
        }

        public object Remove()
        {

            if (FilaVazia())
                throw new Exception("Fila Vazia");
            if (Front == Size - 1)
                Front = 0;
            else
                Front++;
            Count--;
            return elementos[Front];

        }

        public void Insert(object x)
        {
            if (FilaCheia())
                throw new Exception("Fila Cheia");
            if (Rear == Size - 1)
                Rear = 0;
            else
                Rear++;
            elementos[Rear] = x;
            Count++;

        }

    }
}

