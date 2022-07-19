using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bloquinhos.Forms
{
    public partial class Form1 : Form
    {
        int angle;
        Rectangle retangle = new Rectangle(0, 0, 100, 100);
        Graphics g;

        Timer tempo;

        public Form1()
        {
            angle = 0;
            retangle  = new Rectangle(0, 0, 100, 100);
            g = CreateGraphics();
            tempo = new Timer();
            g.TranslateTransform(124, 150);
            //  g.RotateTransform(angle);
          
            Paint += new PaintEventHandler(PaintRectangle);
         

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // Paint += new PaintEventHandler(PaintRectangle);
           
         
            tempo.Tick += new EventHandler(DrawRectangle);
            tempo.Interval = 1;
            tempo.Start();
           // t.Stop();
        }
        private void DrawRectangle(object sender, EventArgs e)
        {
            angle=1;
            Console.WriteLine(angle);
            if (angle>=90)
            {
                tempo.Tick -= new EventHandler(DrawRectangle);

                tempo.Stop();
                angle = 0;
            }
            //angle++;
            Invalidate();
        }

        private void PaintRectangle(object sender, PaintEventArgs e)
        {
            // Rectangle r = new Rectangle(0, 0, 100, 100);
            //Graphics g = CreateGraphics();
         

            //   g.TranslateTransform(124, 150);
            g.RotateTransform(angle);
           g.DrawRectangle(Pens.Red, retangle);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
