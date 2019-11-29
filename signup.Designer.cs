namespace admin_controls
{
    partial class signup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(signup));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sign = new System.Windows.Forms.Button();
            this.fullname = new System.Windows.Forms.TextBox();
            this.user = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.panel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.confirm = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.birthday = new Bunifu.Framework.UI.BunifuDatepicker();
            this.id = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ad_exit = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ad_exit)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(348, 549);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(139, 2);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sign-Up";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sign
            // 
            this.sign.BackColor = System.Drawing.Color.ForestGreen;
            this.sign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sign.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sign.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.sign.Location = new System.Drawing.Point(74, 440);
            this.sign.Margin = new System.Windows.Forms.Padding(2);
            this.sign.Name = "sign";
            this.sign.Size = new System.Drawing.Size(206, 38);
            this.sign.TabIndex = 14;
            this.sign.Text = "SIGN UP";
            this.sign.UseVisualStyleBackColor = false;
            this.sign.Click += new System.EventHandler(this.button1_Click);
            // 
            // fullname
            // 
            this.fullname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.fullname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullname.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.fullname.Location = new System.Drawing.Point(57, 110);
            this.fullname.Margin = new System.Windows.Forms.Padding(2);
            this.fullname.Name = "fullname";
            this.fullname.Size = new System.Drawing.Size(236, 30);
            this.fullname.TabIndex = 15;
            this.fullname.Text = "Full Name";
            this.fullname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.fullname.Click += new System.EventHandler(this.fullname_Click);
            // 
            // user
            // 
            this.user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.user.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.user.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.user.Location = new System.Drawing.Point(57, 170);
            this.user.Margin = new System.Windows.Forms.Padding(2);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(236, 30);
            this.user.TabIndex = 17;
            this.user.Text = "User Name";
            this.user.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.user.Click += new System.EventHandler(this.user_Click);
            // 
            // pass
            // 
            this.pass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.pass.Location = new System.Drawing.Point(57, 230);
            this.pass.Margin = new System.Windows.Forms.Padding(2);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(236, 30);
            this.pass.TabIndex = 18;
            this.pass.Text = "Password";
            this.pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pass.Click += new System.EventHandler(this.pass_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.confirm);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.birthday);
            this.panel1.Controls.Add(this.id);
            this.panel1.Controls.Add(this.pass);
            this.panel1.Controls.Add(this.user);
            this.panel1.Controls.Add(this.fullname);
            this.panel1.Controls.Add(this.sign);
            this.panel1.Controls.Add(this.label1);
            this.panel1.GradientBottomLeft = System.Drawing.Color.White;
            this.panel1.GradientBottomRight = System.Drawing.Color.White;
            this.panel1.GradientTopLeft = System.Drawing.Color.White;
            this.panel1.GradientTopRight = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(348, 41);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Quality = 10;
            this.panel1.Size = new System.Drawing.Size(346, 507);
            this.panel1.TabIndex = 22;
            // 
            // confirm
            // 
            this.confirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.confirm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirm.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.confirm.Location = new System.Drawing.Point(57, 290);
            this.confirm.Margin = new System.Windows.Forms.Padding(2);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(236, 30);
            this.confirm.TabIndex = 26;
            this.confirm.Text = "Confirm Password";
            this.confirm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label2.Location = new System.Drawing.Point(97, 340);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "What is your birthday?";
            // 
            // birthday
            // 
            this.birthday.BackColor = System.Drawing.Color.LightSteelBlue;
            this.birthday.BorderRadius = 10;
            this.birthday.ForeColor = System.Drawing.Color.DarkGreen;
            this.birthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.birthday.FormatCustom = null;
            this.birthday.Location = new System.Drawing.Point(86, 370);
            this.birthday.Name = "birthday";
            this.birthday.Size = new System.Drawing.Size(185, 37);
            this.birthday.TabIndex = 24;
            this.birthday.Value = new System.DateTime(2019, 11, 26, 12, 21, 39, 539);
            // 
            // id
            // 
            this.id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.id.Location = new System.Drawing.Point(57, 50);
            this.id.Margin = new System.Windows.Forms.Padding(2);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(236, 30);
            this.id.TabIndex = 22;
            this.id.Text = "Student ID";
            this.id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.id.Click += new System.EventHandler(this.id_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.ad_exit);
            this.panel2.Location = new System.Drawing.Point(348, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(346, 41);
            this.panel2.TabIndex = 25;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // ad_exit
            // 
            this.ad_exit.BackColor = System.Drawing.Color.Transparent;
            this.ad_exit.Image = ((System.Drawing.Image)(resources.GetObject("ad_exit.Image")));
            this.ad_exit.ImageActive = null;
            this.ad_exit.Location = new System.Drawing.Point(311, 10);
            this.ad_exit.Margin = new System.Windows.Forms.Padding(2);
            this.ad_exit.Name = "ad_exit";
            this.ad_exit.Size = new System.Drawing.Size(24, 27);
            this.ad_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ad_exit.TabIndex = 24;
            this.ad_exit.TabStop = false;
            this.ad_exit.Zoom = 10;
            this.ad_exit.Click += new System.EventHandler(this.ad_exit_Click);
            // 
            // signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(692, 548);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "signup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ad_exit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button sign;
        private System.Windows.Forms.TextBox fullname;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.TextBox pass;
        private Bunifu.Framework.UI.BunifuGradientPanel panel1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuImageButton ad_exit;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuDatepicker birthday;
        private System.Windows.Forms.TextBox confirm;
    }
}