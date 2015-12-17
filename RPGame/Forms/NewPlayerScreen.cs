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

namespace RPGame.Forms
{
    public partial class NewPlayerScreen : Form
    {
        public NewPlayerScreen()
        {
            InitializeComponent();
        }

        private void Btn_SavePlayer_Click(object sender, EventArgs e)
        {
            Amateur player1 = new Amateur();


            String output = "";

            // Name
            output += "Name: " + tbx_ChName.Text;

            // Gender

            output += "\nGender: " +
                      (string) (this.rb_Male.Checked ? "Male" : (this.rb_Female.Checked ? "Female" : "Other"));
            // Level
            output += "\nLevel: " + (this.cbx_Level.Text);

            MessageBox.Show(output);
        }

        private void NewPlayer_Load(object sender, EventArgs e)
        {

        }
    }
}
