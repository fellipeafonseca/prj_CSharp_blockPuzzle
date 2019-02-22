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
    public partial class Recordes : Form
    {
        public Recordes()
        {
            InitializeComponent();
        }

        private void Recordes_Load(object sender, EventArgs e)
        {
            try
            {
                string arquivo;
                using (var file = System.IO.File.OpenText(@"C:\Users\S\Desktop\Pontuacao.txt"))
                {
                    arquivo = file.ReadToEnd();

                }


                var sep = arquivo.Split(';');




                //Os 5 primeiros
                for (int i = 0; i < sep.Length; i++)
                {


                    var sep2 = sep[i].Split(',');

                    //Pontuação do cara maior que o do arquivo
                    if (i == 0 && sep2.Length == 2)
                    {
                        lblJog1.Text = sep2[0];

                        lblPont1.Text = sep2[1];
                    }

                    if (i == 1 && sep2.Length == 2)
                    {
                        lblJog2.Text = sep2[0];

                        lblPont2.Text = sep2[1];
                    }



                    if (i == 2 && sep2.Length == 2)
                    {
                        lblJog3.Text = sep2[0];

                        lblPont3.Text = sep2[1];
                    }

                    if (i == 3 && sep2.Length == 2)
                    {
                        lblJog4.Text = sep2[0];

                        lblPont4.Text = sep2[1];
                    }


                    if (i == 4 && sep2.Length == 2)
                    {
                        lblJog5.Text = sep2[0];

                        lblPont5.Text = sep2[1];
                    }


                }

            }
            catch
            {


            }






        }

        private void btnRecordes_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();


            m.Show();
            Hide();
        }

        private void lblPont2_Click(object sender, EventArgs e)
        {

        }
    }
}
