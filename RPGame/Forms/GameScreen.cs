using System;
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
    public partial class GameScreen : Form
    {
        public GameScreen()
        {
            InitializeComponent();
        }

        private void GameScreen_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tbx_Angle_TextChanged(object sender, EventArgs e)
        {
            int angle;
            bool success=false;
             success= int.TryParse(this.tbx_Angle.Text, out angle);
            if (angle < 0)
            {
                angle = angle*-1;
            }
            if (angle > 360)
            {
                angle = angle/360;} 
        }

        private void lbl_Angle_Click(object sender, EventArgs e)
        {
           
        }

        private void tbx_Strength_TextChanged(object sender, EventArgs e)
        {
            int strength;
            strength = int.Parse(this.tbx_Strength.Text);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btn_CiveUp_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }
    }
}
