namespace admin_controls
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.label4 = new System.Windows.Forms.Label();
            this.rbtnIsStudent = new System.Windows.Forms.RadioButton();
            this.ad_exit = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbtnIsTeacher = new System.Windows.Forms.RadioButton();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lg_show = new Bunifu.Framework.UI.BunifuCheckbox();
            this.adminlog = new System.Windows.Forms.Button();
            this.signup = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.userline = new System.Windows.Forms.PictureBox();
            this.user = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ad_exit)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userline)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkGreen;
            this.label4.Location = new System.Drawing.Point(22, 276);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "I am";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rbtnIsStudent
            // 
            this.rbtnIsStudent.AutoSize = true;
            this.rbtnIsStudent.BackColor = System.Drawing.Color.Transparent;
            this.rbtnIsStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnIsStudent.ForeColor = System.Drawing.Color.DarkGreen;
            this.rbtnIsStudent.Location = new System.Drawing.Point(26, 314);
            this.rbtnIsStudent.Name = "rbtnIsStudent";
            this.rbtnIsStudent.Size = new System.Drawing.Size(71, 20);
            this.rbtnIsStudent.TabIndex = 19;
            this.rbtnIsStudent.TabStop = true;
            this.rbtnIsStudent.Text = "Student";
            this.rbtnIsStudent.UseVisualStyleBackColor = false;
            // 
            // ad_exit
            // 
            this.ad_exit.BackColor = System.Drawing.Color.Transparent;
            this.ad_exit.Image = ((System.Drawing.Image)(resources.GetObject("ad_exit.Image")));
            this.ad_exit.ImageActive = null;
            this.ad_exit.Location = new System.Drawing.Point(301, 7);
            this.ad_exit.Margin = new System.Windows.Forms.Padding(2);
            this.ad_exit.Name = "ad_exit";
            this.ad_exit.Size = new System.Drawing.Size(24, 27);
            this.ad_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ad_exit.TabIndex = 24;
            this.ad_exit.TabStop = false;
            this.ad_exit.Zoom = 10;
            this.ad_exit.Click += new System.EventHandler(this.ad_exit_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Honeydew;
            this.panel2.Controls.Add(this.ad_exit);
            this.panel2.Location = new System.Drawing.Point(361, -1);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(334, 37);
            this.panel2.TabIndex = 23;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // rbtnIsTeacher
            // 
            this.rbtnIsTeacher.AutoSize = true;
            this.rbtnIsTeacher.BackColor = System.Drawing.Color.Transparent;
            this.rbtnIsTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnIsTeacher.ForeColor = System.Drawing.Color.DarkGreen;
            this.rbtnIsTeacher.Location = new System.Drawing.Point(26, 340);
            this.rbtnIsTeacher.Name = "rbtnIsTeacher";
            this.rbtnIsTeacher.Size = new System.Drawing.Size(77, 20);
            this.rbtnIsTeacher.TabIndex = 20;
            this.rbtnIsTeacher.TabStop = true;
            this.rbtnIsTeacher.Text = "Teacher";
            this.rbtnIsTeacher.UseVisualStyleBackColor = false;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.DarkGreen;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(51, 232);
            this.bunifuCustomLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(107, 17);
            this.bunifuCustomLabel1.TabIndex = 18;
            this.bunifuCustomLabel1.Text = "Show Password";
            // 
            // lg_show
            // 
            this.lg_show.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.lg_show.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.lg_show.Checked = false;
            this.lg_show.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.lg_show.ForeColor = System.Drawing.Color.White;
            this.lg_show.Location = new System.Drawing.Point(26, 232);
            this.lg_show.Name = "lg_show";
            this.lg_show.Size = new System.Drawing.Size(20, 20);
            this.lg_show.TabIndex = 17;
            this.lg_show.OnChange += new System.EventHandler(this.lg_show_OnChange);
            // 
            // adminlog
            // 
            this.adminlog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminlog.ForeColor = System.Drawing.Color.Green;
            this.adminlog.Location = new System.Drawing.Point(233, 488);
            this.adminlog.Margin = new System.Windows.Forms.Padding(2);
            this.adminlog.Name = "adminlog";
            this.adminlog.Size = new System.Drawing.Size(89, 25);
            this.adminlog.TabIndex = 15;
            this.adminlog.Text = "Admin Login";
            this.adminlog.UseVisualStyleBackColor = true;
            this.adminlog.Click += new System.EventHandler(this.adminlog_Click);
            // 
            // signup
            // 
            this.signup.ActiveLinkColor = System.Drawing.Color.YellowGreen;
            this.signup.AutoSize = true;
            this.signup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup.LinkColor = System.Drawing.Color.DarkGreen;
            this.signup.Location = new System.Drawing.Point(99, 437);
            this.signup.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.signup.Name = "signup";
            this.signup.Size = new System.Drawing.Size(152, 13);
            this.signup.TabIndex = 14;
            this.signup.TabStop = true;
            this.signup.Text = "I dont have an account signup";
            this.signup.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.signup_LinkClicked_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.ForestGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(72, 383);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 38);
            this.button1.TabIndex = 13;
            this.button1.Text = "LOGIN";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(14, 206);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(292, 8);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // userline
            // 
            this.userline.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.userline.Image = ((System.Drawing.Image)(resources.GetObject("userline.Image")));
            this.userline.Location = new System.Drawing.Point(14, 125);
            this.userline.Margin = new System.Windows.Forms.Padding(2);
            this.userline.Name = "userline";
            this.userline.Size = new System.Drawing.Size(292, 8);
            this.userline.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userline.TabIndex = 7;
            this.userline.TabStop = false;
            // 
            // user
            // 
            this.user.BackColor = System.Drawing.Color.Honeydew;
            this.user.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.user.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user.ForeColor = System.Drawing.SystemColors.WindowText;
            this.user.Location = new System.Drawing.Point(26, 89);
            this.user.Margin = new System.Windows.Forms.Padding(2);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(231, 31);
            this.user.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGreen;
            this.label3.Location = new System.Drawing.Point(22, 149);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(22, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "User Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(134, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sign-In";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(362, 565);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(362, 565);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // pass
            // 
            this.pass.BackColor = System.Drawing.Color.Honeydew;
            this.pass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pass.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass.ForeColor = System.Drawing.SystemColors.WindowText;
            this.pass.Location = new System.Drawing.Point(26, 171);
            this.pass.Margin = new System.Windows.Forms.Padding(2);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(231, 31);
            this.pass.TabIndex = 9;
            this.pass.UseSystemPasswordChar = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Honeydew;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.rbtnIsTeacher);
            this.panel1.Controls.Add(this.rbtnIsStudent);
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Controls.Add(this.lg_show);
            this.panel1.Controls.Add(this.adminlog);
            this.panel1.Controls.Add(this.signup);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pass);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.userline);
            this.panel1.Controls.Add(this.user);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(361, 36);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(334, 522);
            this.panel1.TabIndex = 22;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(695, 561);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(695, 561);
            this.MinimizeBox = false;
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign-In";
            ((System.ComponentModel.ISupportInitialize)(this.ad_exit)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userline)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbtnIsStudent;
        private Bunifu.Framework.UI.BunifuImageButton ad_exit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbtnIsTeacher;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCheckbox lg_show;
        private System.Windows.Forms.Button adminlog;
        private System.Windows.Forms.LinkLabel signup;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox userline;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.Panel panel1;
    }
}

