using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RPGame.Forms;

namespace RPGame
{
    public partial class BeerPongStartScreen : Form
    {
        public BeerPongStartScreen()
        {
            InitializeComponent();
        }

        private void BeerPong_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_NewPlayer_Click(object sender, EventArgs e)
        {
            NewPlayerScreen playerCreator = new NewPlayerScreen();
            playerCreator.Show();
        }

    }
}
