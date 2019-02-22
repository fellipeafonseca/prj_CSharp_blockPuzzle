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
    public partial class Form1 : Form
    {
        Pintor p;

       // public enum Cores { Red, Blue };
        List<Color> nomesCores;


        Button[,] matriz = new Button[4,3];

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
       
            nomesCores=new List<Color>();


          
            nomesCores.Add(Color.Red);

            nomesCores.Add(Color.Yellow);

            nomesCores.Add(Color.Blue);
            nomesCores.Add(Color.Green);

            nomesCores.Add(Color.Violet);

            

            
           
            
            
      


            











           
            matriz[0, 0] = button1;
            matriz[0, 1] = button2;
            matriz[0, 2] = button3;
          
            
            matriz[1, 0] = button4;
            matriz[1, 1] = button5;
            matriz[1, 2] = button6;
            

            matriz[2, 0] = button7;
            matriz[2, 1] = button8;
            matriz[2, 2] = button9;


            matriz[3, 0] = button10;
            matriz[3, 1] = button11;
            matriz[3, 2] = button12;


            Random r=new Random();
            int id;

            for (int l = 0; l < 4; l++)
            {
                for (int c = 0; c < 3; c++)
                {
                    id = r.Next(0,5);
                    matriz[l, c].BackColor = nomesCores[id];
                    matriz[l, c].ForeColor = nomesCores[id];
                }
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            p= new Pintor();

            int count=p.Colorir(matriz, button1, 3, 4);

            if (count == 1 || count == 0)
            {
                //Se não Existir mais possibilidades ==false
                //Botão fica false
                if (!p.VerificaColorir(matriz, 3, 4))
                {
                  button1.Visible = false;
                }


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            p = new Pintor();

            int count = p.Colorir(matriz, button2, 3, 4);

            if (count == 1 || count == 0)
            {
                //Se não Existir mais possibilidades ==false
                //Botão fica false
                if (!p.VerificaColorir(matriz, 3, 4))
                {
                    button2.Visible = false;
                }


            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            p = new Pintor();

            int count = p.Colorir(matriz, button3, 3, 4);

            if (count == 1 || count == 0)
            {
                //Se não Existir mais possibilidades ==false
                //Botão fica false
                if (!p.VerificaColorir(matriz, 3, 4))
                {
                    button3.Visible = false;
                }


            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            p = new Pintor();

            int count = p.Colorir(matriz, button4, 3, 4);

            if (count == 1 || count == 0)
            {
                //Se não Existir mais possibilidades ==false
                //Botão fica false
                if (!p.VerificaColorir(matriz, 3, 4))
                {
                    button4.Visible = false;
                }


            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            p = new Pintor();

            int count = p.Colorir(matriz, button5, 3, 4);

            if (count == 1 || count == 0)
            {
                //Se não Existir mais possibilidades ==false
                //Botão fica false
                if (!p.VerificaColorir(matriz, 3, 4))
                {
                    button5.Visible = false;
                }


            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            p = new Pintor();

            int count = p.Colorir(matriz, button6, 3, 4);

            if (count == 1 || count == 0)
            {
                //Se não Existir mais possibilidades ==false
                //Botão fica false
                if (!p.VerificaColorir(matriz, 3, 4))
                {
                    button6.Visible = false;
                }


            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            p = new Pintor();

            int count = p.Colorir(matriz, button7, 3, 4);

            if (count == 1 || count == 0)
            {
                //Se não Existir mais possibilidades ==false
                //Botão fica false
                if (!p.VerificaColorir(matriz, 3, 4))
                {
                    button7.Visible = false;
                }


            }


        }

        private void button8_Click(object sender, EventArgs e)
        {
            p = new Pintor();

            int count = p.Colorir(matriz, button8, 3, 4);

            if (count == 1 || count == 0)
            {
                //Se não Existir mais possibilidades ==false
                //Botão fica false
                if (!p.VerificaColorir(matriz, 3, 4))
                {
                    button8.Visible = false;
                }


            }


        }

        private void button9_Click(object sender, EventArgs e)
        {
            p = new Pintor();

            int count = p.Colorir(matriz, button9, 3, 4);

            if (count == 1 || count == 0)
            {
                //Se não Existir mais possibilidades ==false
                //Botão fica false
                if (!p.VerificaColorir(matriz, 3, 4))
                {
                    button9.Visible = false;
                }


            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            p = new Pintor();

            int count = p.Colorir(matriz, button10, 3, 4);

            if (count == 1 || count == 0)
            {
                //Se não Existir mais possibilidades ==false
                //Botão fica false
                if (!p.VerificaColorir(matriz, 3, 4))
                {
                    button10.Visible = false;
                }


            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            p = new Pintor();

            int count = p.Colorir(matriz, button11, 3, 4);

            if (count == 1 || count == 0)
            {
                //Se não Existir mais possibilidades ==false
                //Botão fica false
                if (!p.VerificaColorir(matriz, 3, 4))
                {
                    button11.Visible = false;
                }


            }
        }

        private void button12_Click(object sender, EventArgs e)
        {

            //Esta dando Pau Rever
            p = new Pintor();

            int count = p.Colorir(matriz, button12, 3, 4);

            if (count == 1 || count == 0)
            {
                //Se não Existir mais possibilidades ==false
                //Botão fica false
                if (!p.VerificaColorir(matriz, 3, 4))
                {
                    button12.Visible = false;
                }


            }
        }

     

    

    }
}
