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
    public partial class GameOver : Form
    {
        public GameOver()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();

            Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void GameOver_Load(object sender, EventArgs e)
        {

        }


        public void LabelPontuacao(string texto)
        {
            lblPontuacao.Text = texto;


        }

        private void btnJogarNovamente_Click(object sender, EventArgs e)
        {


            Jogo jogo = new Jogo();
            jogo.Show();
            Hide();

        }


    }
}
