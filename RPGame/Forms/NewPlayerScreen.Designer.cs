namespace RPGame.Forms
{
    partial class NewPlayerScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewPlayerScreen));
            this.tbx_ChName = new System.Windows.Forms.TextBox();
            this.lbl_ChName = new System.Windows.Forms.Label();
            this.gbx_Gender = new System.Windows.Forms.GroupBox();
            this.rb_Other = new System.Windows.Forms.RadioButton();
            this.rb_Female = new System.Windows.Forms.RadioButton();
            this.rb_Male = new System.Windows.Forms.RadioButton();
            this.cbx_Level = new System.Windows.Forms.ComboBox();
            this.lbl_Level = new System.Windows.Forms.Label();
            this.btn_SavePlayer = new System.Windows.Forms.Button();
            this.gbx_Gender.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbx_ChName
            // 
            this.tbx_ChName.Location = new System.Drawing.Point(70, 12);
            this.tbx_ChName.Name = "tbx_ChName";
            this.tbx_ChName.Size = new System.Drawing.Size(162, 20);
            this.tbx_ChName.TabIndex = 0;
            // 
            // lbl_ChName
            // 
            this.lbl_ChName.AutoSize = true;
            this.lbl_ChName.Location = new System.Drawing.Point(29, 15);
            this.lbl_ChName.Name = "lbl_ChName";
            this.lbl_ChName.Size = new System.Drawing.Size(35, 13);
            this.lbl_ChName.TabIndex = 1;
            this.lbl_ChName.Text = "Name";
            // 
            // gbx_Gender
            // 
            this.gbx_Gender.Controls.Add(this.rb_Other);
            this.gbx_Gender.Controls.Add(this.rb_Female);
            this.gbx_Gender.Controls.Add(this.rb_Male);
            this.gbx_Gender.Location = new System.Drawing.Point(23, 38);
            this.gbx_Gender.Name = "gbx_Gender";
            this.gbx_Gender.Size = new System.Drawing.Size(209, 42);
            this.gbx_Gender.TabIndex = 2;
            this.gbx_Gender.TabStop = false;
            this.gbx_Gender.Text = "Gender";
            // 
            // rb_Other
            // 
            this.rb_Other.AutoSize = true;
            this.rb_Other.Location = new System.Drawing.Point(155, 20);
            this.rb_Other.Name = "rb_Other";
            this.rb_Other.Size = new System.Drawing.Size(51, 17);
            this.rb_Other.TabIndex = 2;
            this.rb_Other.TabStop = true;
            this.rb_Other.Text = "Other";
            this.rb_Other.UseVisualStyleBackColor = true;
            // 
            // rb_Female
            // 
            this.rb_Female.AutoSize = true;
            this.rb_Female.Location = new System.Drawing.Point(78, 20);
            this.rb_Female.Name = "rb_Female";
            this.rb_Female.Size = new System.Drawing.Size(59, 17);
            this.rb_Female.TabIndex = 1;
            this.rb_Female.TabStop = true;
            this.rb_Female.Text = "Female";
            this.rb_Female.UseVisualStyleBackColor = true;
            // 
            // rb_Male
            // 
            this.rb_Male.AutoSize = true;
            this.rb_Male.Location = new System.Drawing.Point(9, 20);
            this.rb_Male.Name = "rb_Male";
            this.rb_Male.Size = new System.Drawing.Size(48, 17);
            this.rb_Male.TabIndex = 0;
            this.rb_Male.TabStop = true;
            this.rb_Male.Text = "Male";
            this.rb_Male.UseVisualStyleBackColor = true;
            // 
            // cbx_Level
            // 
            this.cbx_Level.FormattingEnabled = true;
            this.cbx_Level.Items.AddRange(new object[] {
            "Beginner",
            "Amateur",
            "Pro",
            "Legend"});
            this.cbx_Level.Location = new System.Drawing.Point(23, 109);
            this.cbx_Level.Name = "cbx_Level";
            this.cbx_Level.Size = new System.Drawing.Size(209, 21);
            this.cbx_Level.TabIndex = 3;
            // 
            // lbl_Level
            // 
            this.lbl_Level.AutoSize = true;
            this.lbl_Level.Location = new System.Drawing.Point(29, 93);
            this.lbl_Level.Name = "lbl_Level";
            this.lbl_Level.Size = new System.Drawing.Size(58, 13);
            this.lbl_Level.TabIndex = 4;
            this.lbl_Level.Text = "You\'re a ...";
            // 
            // btn_SavePlayer
            // 
            this.btn_SavePlayer.Location = new System.Drawing.Point(23, 412);
            this.btn_SavePlayer.Name = "btn_SavePlayer";
            this.btn_SavePlayer.Size = new System.Drawing.Size(209, 27);
            this.btn_SavePlayer.TabIndex = 5;
            this.btn_SavePlayer.Text = "Save";
            this.btn_SavePlayer.UseVisualStyleBackColor = true;
            this.btn_SavePlayer.Click += new System.EventHandler(this.Btn_SavePlayer_Click);
            // 
            // NewPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(540, 478);
            this.Controls.Add(this.btn_SavePlayer);
            this.Controls.Add(this.lbl_Level);
            this.Controls.Add(this.cbx_Level);
            this.Controls.Add(this.gbx_Gender);
            this.Controls.Add(this.lbl_ChName);
            this.Controls.Add(this.tbx_ChName);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewPlayer";
            this.Text = "NewPlayer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.NewPlayer_Load);
            this.gbx_Gender.ResumeLayout(false);
            this.gbx_Gender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbx_ChName;
        private System.Windows.Forms.Label lbl_ChName;
        private System.Windows.Forms.GroupBox gbx_Gender;
        private System.Windows.Forms.RadioButton rb_Other;
        private System.Windows.Forms.RadioButton rb_Female;
        private System.Windows.Forms.RadioButton rb_Male;
        private System.Windows.Forms.ComboBox cbx_Level;
        private System.Windows.Forms.Label lbl_Level;
        private System.Windows.Forms.Button btn_SavePlayer;
    }
}