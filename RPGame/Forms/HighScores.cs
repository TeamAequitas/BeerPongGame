using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RPGame.Players;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace RPGame.Forms
{
    public partial class HighScores : Form
    {
        public HighScores()
        {
            InitializeComponent();
        }

        
        
        private void btn_OK_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
