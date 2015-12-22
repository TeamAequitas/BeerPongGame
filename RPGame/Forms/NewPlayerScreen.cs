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
    public partial class NewPlayerScreen : Form
    {
        public NewPlayerScreen()
        {
            InitializeComponent();
        }

        private void Btn_SavePlayer_Click(object sender, EventArgs e)
        {
           // Player player1 = new Player();


            string name;
            string output="";
            Player player1 = null;
            EntityGender gender=EntityGender.Other;
            playerLevel level;

            
            // Name Verification
            if (String.IsNullOrEmpty(tbx_ChName.Text) || tbx_ChName.Text[0] == ' ')
                output = "You must enter name, not begining with space!";

            name = this.tbx_ChName.Text;

            // Gender Verification
            if (this.rb_Male.Checked)
            {
                gender = EntityGender.Male;
            }
            else if(this.rb_Female.Checked)
                gender=EntityGender.Female;
            
            else if (this.rb_Other.Checked)
                gender = EntityGender.Other;
            else
                output += "\nYou Must Specify Gender!";
            
            
            // Level Verification

            if (String.IsNullOrEmpty(cbx_Level.Text))

            {
                output += "\nYou Must choose Level!";
                
            }
            if (!string.IsNullOrEmpty(output))
            {
                //throw new Exception("");
                MessageBox.Show(output);
            }
            else
            {
                MessageBox.Show("Grab your balls " + name + ", and may The Force be with you!");

                


                switch (cbx_Level.Text)
                {
                    case "Amateur":
                    
                        level = playerLevel.Amateur;
                        player1 = new Amateur(name, gender);
                        break;
                    
                    case "Beginner":
                        level = playerLevel.Beginner;
                        player1 = new Beginner (name, gender);
                        break;
                    case "Pro":
                        level = playerLevel.Pro;
                   //     Player player1 = new Pro (name, gender);
                        break;
                    case "Expert":
                        level = playerLevel.Expert;
                        //     Player player1 = new Expert (name, gender);
                        break;
                    case "Legend":
                        level = playerLevel.Legend;
                        break;
                }

             //   Player player1 = new Amateur (name, gender, level, 0);

                this.Close();
            }
        }

        private void NewPlayer_Load(object sender, EventArgs e)
        {

        }

        private void gbx_Gender_Enter(object sender, EventArgs e)
        {

        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }
    }
}
