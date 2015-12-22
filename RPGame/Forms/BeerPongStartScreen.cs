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

        private void Btn_NewPlayer_Click(object sender, EventArgs e)
        {
            NewPlayerScreen playerCreator = new NewPlayerScreen();
            playerCreator.Show();
        }

        private void btn_LoadPlayer_Click(object sender, EventArgs e)
        {

        }

        private void btn_About_Click(object sender, EventArgs e)
        {
            About aboutForm = new About();
            aboutForm.Show();
        }

        private void btn_NewGame_Click(object sender, EventArgs e)
        {
            MainMap mapCreator = new MainMap();
            mapCreator.Show();
        }

        private void btn_Options_Click(object sender, EventArgs e)
        {
            GameScreen gameCreator = new GameScreen();
            gameCreator.Show();
        }

        private void btn_HighScores_Click(object sender, EventArgs e)
        {
            HighScores highScoresForm = new HighScores();
            highScoresForm.Show();
        }
    }
}
