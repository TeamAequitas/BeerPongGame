﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPGame.Forms
{
    public partial class MainMap : Form
    {
        public MainMap()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            GameScreen gameScreen = new GameScreen();
            gameScreen.Show();
        }
    }
}
