using Bloquinhos.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bloquinhos
{
    public partial class Menu : Form
    {

        SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\S\Desktop\Inicial.wav");
        public Menu()
        {
            InitializeComponent();
        }

      
        private void Menu_Load(object sender, EventArgs e)
        {
            
          //  simpleSound.PlayLooping();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnComecar_Click(object sender, EventArgs e)
        {
            simpleSound.Stop();
            Jogo _f1;
            _f1 = new Jogo();
            _f1.Show();
            Hide();

            //System.Media.SoundPlayer MeuPlayer = new System.Media.SoundPlayer(@"C:\Users\Danilo\Desktop\Bloquinhos\Bloquinhos\Properties\blink.wav");
            //MeuPlayer.Play();

        }

        private void btnRecordes_Click(object sender, EventArgs e)
        {


            Recordes r = new Recordes();


            r.Show();

            Hide();




        }
    }
}
