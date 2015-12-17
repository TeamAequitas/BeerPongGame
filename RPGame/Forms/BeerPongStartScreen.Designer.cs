namespace RPGame
{
    partial class BeerPongStartScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BeerPongStartScreen));
            this.lbl_GameSlogan = new System.Windows.Forms.Label();
            this.btn_NewGame = new System.Windows.Forms.Button();
            this.btn_Options = new System.Windows.Forms.Button();
            this.btn_NewPlayer = new System.Windows.Forms.Button();
            this.btn_About = new System.Windows.Forms.Button();
            this.btn_HighScores = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_GameSlogan
            // 
            this.lbl_GameSlogan.AutoSize = true;
            this.lbl_GameSlogan.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GameSlogan.ForeColor = System.Drawing.Color.Firebrick;
            this.lbl_GameSlogan.Location = new System.Drawing.Point(335, 9);
            this.lbl_GameSlogan.Name = "lbl_GameSlogan";
            this.lbl_GameSlogan.Size = new System.Drawing.Size(695, 49);
            this.lbl_GameSlogan.TabIndex = 0;
            this.lbl_GameSlogan.Text = "Grab Your Balls! We\'re Playing";
            this.lbl_GameSlogan.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btn_NewGame
            // 
            this.btn_NewGame.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.btn_NewGame.AutoSize = true;
            this.btn_NewGame.BackColor = System.Drawing.Color.White;
            this.btn_NewGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_NewGame.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_NewGame.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_NewGame.FlatAppearance.BorderSize = 0;
            this.btn_NewGame.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCoral;
            this.btn_NewGame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato;
            this.btn_NewGame.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NewGame.ForeColor = System.Drawing.Color.Firebrick;
            this.btn_NewGame.Location = new System.Drawing.Point(137, 651);
            this.btn_NewGame.Margin = new System.Windows.Forms.Padding(0);
            this.btn_NewGame.Name = "btn_NewGame";
            this.btn_NewGame.Size = new System.Drawing.Size(160, 48);
            this.btn_NewGame.TabIndex = 1;
            this.btn_NewGame.Text = "New Game";
            this.btn_NewGame.UseVisualStyleBackColor = false;
            // 
            // btn_Options
            // 
            this.btn_Options.AutoSize = true;
            this.btn_Options.BackColor = System.Drawing.Color.White;
            this.btn_Options.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Options.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_Options.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Options.FlatAppearance.BorderSize = 0;
            this.btn_Options.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCoral;
            this.btn_Options.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato;
            this.btn_Options.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Options.ForeColor = System.Drawing.Color.Firebrick;
            this.btn_Options.Location = new System.Drawing.Point(597, 651);
            this.btn_Options.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Options.Name = "btn_Options";
            this.btn_Options.Size = new System.Drawing.Size(160, 48);
            this.btn_Options.TabIndex = 1;
            this.btn_Options.Text = "Options";
            this.btn_Options.UseVisualStyleBackColor = false;
            // 
            // btn_NewPlayer
            // 
            this.btn_NewPlayer.AllowDrop = true;
            this.btn_NewPlayer.AutoSize = true;
            this.btn_NewPlayer.BackColor = System.Drawing.Color.White;
            this.btn_NewPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_NewPlayer.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_NewPlayer.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_NewPlayer.FlatAppearance.BorderSize = 0;
            this.btn_NewPlayer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCoral;
            this.btn_NewPlayer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato;
            this.btn_NewPlayer.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NewPlayer.ForeColor = System.Drawing.Color.Firebrick;
            this.btn_NewPlayer.Location = new System.Drawing.Point(366, 651);
            this.btn_NewPlayer.Margin = new System.Windows.Forms.Padding(0);
            this.btn_NewPlayer.Name = "btn_NewPlayer";
            this.btn_NewPlayer.Size = new System.Drawing.Size(168, 48);
            this.btn_NewPlayer.TabIndex = 0;
            this.btn_NewPlayer.Text = "New Player";
            this.btn_NewPlayer.UseCompatibleTextRendering = true;
            this.btn_NewPlayer.UseVisualStyleBackColor = false;
            this.btn_NewPlayer.Click += new System.EventHandler(this.Btn_NewPlayer_Click);
            // 
            // btn_About
            // 
            this.btn_About.AutoSize = true;
            this.btn_About.BackColor = System.Drawing.Color.White;
            this.btn_About.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_About.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_About.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_About.FlatAppearance.BorderSize = 0;
            this.btn_About.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCoral;
            this.btn_About.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato;
            this.btn_About.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_About.ForeColor = System.Drawing.Color.Firebrick;
            this.btn_About.Location = new System.Drawing.Point(1078, 651);
            this.btn_About.Margin = new System.Windows.Forms.Padding(0);
            this.btn_About.Name = "btn_About";
            this.btn_About.Size = new System.Drawing.Size(160, 48);
            this.btn_About.TabIndex = 3;
            this.btn_About.Text = "About";
            this.btn_About.UseVisualStyleBackColor = false;
            // 
            // btn_HighScores
            // 
            this.btn_HighScores.AutoSize = true;
            this.btn_HighScores.BackColor = System.Drawing.Color.White;
            this.btn_HighScores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_HighScores.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_HighScores.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_HighScores.FlatAppearance.BorderSize = 0;
            this.btn_HighScores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCoral;
            this.btn_HighScores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato;
            this.btn_HighScores.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_HighScores.ForeColor = System.Drawing.Color.Firebrick;
            this.btn_HighScores.Location = new System.Drawing.Point(834, 651);
            this.btn_HighScores.Margin = new System.Windows.Forms.Padding(0);
            this.btn_HighScores.Name = "btn_HighScores";
            this.btn_HighScores.Size = new System.Drawing.Size(177, 48);
            this.btn_HighScores.TabIndex = 4;
            this.btn_HighScores.Text = "High Scores";
            this.btn_HighScores.UseVisualStyleBackColor = false;
            this.btn_HighScores.Click += new System.EventHandler(this.button1_Click);
            // 
            // BeerPongStartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1334, 712);
            this.Controls.Add(this.btn_HighScores);
            this.Controls.Add(this.btn_About);
            this.Controls.Add(this.btn_NewPlayer);
            this.Controls.Add(this.btn_Options);
            this.Controls.Add(this.btn_NewGame);
            this.Controls.Add(this.lbl_GameSlogan);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BeerPongStartScreen";
            this.Text = "BeerPong Main Menu";
            this.TransparencyKey = System.Drawing.Color.Lime;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.BeerPong_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_GameSlogan;
        private System.Windows.Forms.Button btn_NewGame;
        private System.Windows.Forms.Button btn_Options;
        private System.Windows.Forms.Button btn_NewPlayer;
        private System.Windows.Forms.Button btn_About;
        private System.Windows.Forms.Button btn_HighScores;
    }
}

