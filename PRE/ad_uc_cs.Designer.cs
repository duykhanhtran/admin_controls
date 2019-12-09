namespace admin_controls.PRE
{
    partial class ad_uc_cs
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ad_uc_cs));
            this.ad_pcs = new System.Windows.Forms.Panel();
            this.ad_dgv_c = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.COURSE_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COURSENAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlControl = new System.Windows.Forms.Panel();
            this.txtCoursename = new System.Windows.Forms.TextBox();
            this.btnCreate = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.btnUp = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtCourseID = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ad_pcs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ad_dgv_c)).BeginInit();
            this.pnlControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ad_pcs
            // 
            this.ad_pcs.Controls.Add(this.ad_dgv_c);
            this.ad_pcs.Controls.Add(this.pnlControl);
            this.ad_pcs.Controls.Add(this.label11);
            this.ad_pcs.Controls.Add(this.pictureBox14);
            this.ad_pcs.Controls.Add(this.pictureBox15);
            this.ad_pcs.Location = new System.Drawing.Point(0, 0);
            this.ad_pcs.Margin = new System.Windows.Forms.Padding(2);
            this.ad_pcs.Name = "ad_pcs";
            this.ad_pcs.Size = new System.Drawing.Size(1050, 570);
            this.ad_pcs.TabIndex = 20;
            // 
            // ad_dgv_c
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ad_dgv_c.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ad_dgv_c.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.ad_dgv_c.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ad_dgv_c.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ad_dgv_c.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ad_dgv_c.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ad_dgv_c.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.COURSE_ID,
            this.COURSENAME});
            this.ad_dgv_c.DoubleBuffered = true;
            this.ad_dgv_c.EnableHeadersVisualStyles = false;
            this.ad_dgv_c.HeaderBgColor = System.Drawing.Color.SteelBlue;
            this.ad_dgv_c.HeaderForeColor = System.Drawing.Color.Black;
            this.ad_dgv_c.Location = new System.Drawing.Point(0, 37);
            this.ad_dgv_c.Name = "ad_dgv_c";
            this.ad_dgv_c.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ad_dgv_c.RowHeadersWidth = 51;
            this.ad_dgv_c.Size = new System.Drawing.Size(556, 530);
            this.ad_dgv_c.TabIndex = 51;
            this.ad_dgv_c.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ad_dgv_c_CellClick);
            // 
            // COURSE_ID
            // 
            this.COURSE_ID.DataPropertyName = "COURSE_ID";
            this.COURSE_ID.HeaderText = "Course ID";
            this.COURSE_ID.MinimumWidth = 6;
            this.COURSE_ID.Name = "COURSE_ID";
            this.COURSE_ID.ReadOnly = true;
            this.COURSE_ID.Width = 200;
            // 
            // COURSENAME
            // 
            this.COURSENAME.DataPropertyName = "COURSENAME";
            this.COURSENAME.HeaderText = "Coursename";
            this.COURSENAME.MinimumWidth = 6;
            this.COURSENAME.Name = "COURSENAME";
            this.COURSENAME.ReadOnly = true;
            this.COURSENAME.Width = 305;
            // 
            // pnlControl
            // 
            this.pnlControl.Controls.Add(this.txtSearch);
            this.pnlControl.Controls.Add(this.pictureBox2);
            this.pnlControl.Controls.Add(this.pictureBox1);
            this.pnlControl.Controls.Add(this.txtCoursename);
            this.pnlControl.Controls.Add(this.btnCreate);
            this.pnlControl.Controls.Add(this.btnDel);
            this.pnlControl.Controls.Add(this.label28);
            this.pnlControl.Controls.Add(this.label27);
            this.pnlControl.Controls.Add(this.btnUp);
            this.pnlControl.Controls.Add(this.txtCourseID);
            this.pnlControl.Location = new System.Drawing.Point(562, 37);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(307, 520);
            this.pnlControl.TabIndex = 52;
            // 
            // txtCoursename
            // 
            this.txtCoursename.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCoursename.Location = new System.Drawing.Point(80, 215);
            this.txtCoursename.Name = "txtCoursename";
            this.txtCoursename.Size = new System.Drawing.Size(200, 22);
            this.txtCoursename.TabIndex = 57;
            // 
            // btnCreate
            // 
            this.btnCreate.Activecolor = System.Drawing.Color.LightSeaGreen;
            this.btnCreate.BackColor = System.Drawing.Color.DarkCyan;
            this.btnCreate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCreate.BorderRadius = 0;
            this.btnCreate.ButtonText = "Create";
            this.btnCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreate.DisabledColor = System.Drawing.Color.Gray;
            this.btnCreate.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCreate.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnCreate.Iconimage")));
            this.btnCreate.Iconimage_right = null;
            this.btnCreate.Iconimage_right_Selected = null;
            this.btnCreate.Iconimage_Selected = null;
            this.btnCreate.IconMarginLeft = 0;
            this.btnCreate.IconMarginRight = 0;
            this.btnCreate.IconRightVisible = true;
            this.btnCreate.IconRightZoom = 0D;
            this.btnCreate.IconVisible = true;
            this.btnCreate.IconZoom = 50D;
            this.btnCreate.IsTab = false;
            this.btnCreate.Location = new System.Drawing.Point(80, 375);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Normalcolor = System.Drawing.Color.DarkCyan;
            this.btnCreate.OnHovercolor = System.Drawing.Color.Teal;
            this.btnCreate.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCreate.selected = false;
            this.btnCreate.Size = new System.Drawing.Size(200, 30);
            this.btnCreate.TabIndex = 56;
            this.btnCreate.Text = "Create";
            this.btnCreate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCreate.Textcolor = System.Drawing.Color.White;
            this.btnCreate.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Click += new System.EventHandler(this.ad_cc_Click);
            // 
            // btnDel
            // 
            this.btnDel.Activecolor = System.Drawing.Color.LightSeaGreen;
            this.btnDel.BackColor = System.Drawing.Color.DarkCyan;
            this.btnDel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDel.BorderRadius = 0;
            this.btnDel.ButtonText = "Delete";
            this.btnDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDel.DisabledColor = System.Drawing.Color.Gray;
            this.btnDel.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDel.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDel.Iconimage")));
            this.btnDel.Iconimage_right = null;
            this.btnDel.Iconimage_right_Selected = null;
            this.btnDel.Iconimage_Selected = null;
            this.btnDel.IconMarginLeft = 0;
            this.btnDel.IconMarginRight = 0;
            this.btnDel.IconRightVisible = true;
            this.btnDel.IconRightZoom = 0D;
            this.btnDel.IconVisible = true;
            this.btnDel.IconZoom = 40D;
            this.btnDel.IsTab = false;
            this.btnDel.Location = new System.Drawing.Point(80, 276);
            this.btnDel.Margin = new System.Windows.Forms.Padding(4);
            this.btnDel.Name = "btnDel";
            this.btnDel.Normalcolor = System.Drawing.Color.DarkCyan;
            this.btnDel.OnHovercolor = System.Drawing.Color.Teal;
            this.btnDel.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDel.selected = false;
            this.btnDel.Size = new System.Drawing.Size(200, 30);
            this.btnDel.TabIndex = 46;
            this.btnDel.Text = "Delete";
            this.btnDel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDel.Textcolor = System.Drawing.Color.White;
            this.btnDel.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.Click += new System.EventHandler(this.ad_bcdl_Click);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(-3, 218);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(85, 16);
            this.label28.TabIndex = 40;
            this.label28.Text = "Coursename";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(1, 179);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(67, 16);
            this.label27.TabIndex = 39;
            this.label27.Text = "Course ID";
            // 
            // btnUp
            // 
            this.btnUp.Activecolor = System.Drawing.Color.LightSeaGreen;
            this.btnUp.BackColor = System.Drawing.Color.DarkCyan;
            this.btnUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUp.BorderRadius = 0;
            this.btnUp.ButtonText = "Update";
            this.btnUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUp.DisabledColor = System.Drawing.Color.Gray;
            this.btnUp.Iconcolor = System.Drawing.Color.Transparent;
            this.btnUp.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnUp.Iconimage")));
            this.btnUp.Iconimage_right = null;
            this.btnUp.Iconimage_right_Selected = null;
            this.btnUp.Iconimage_Selected = null;
            this.btnUp.IconMarginLeft = 0;
            this.btnUp.IconMarginRight = 0;
            this.btnUp.IconRightVisible = true;
            this.btnUp.IconRightZoom = 0D;
            this.btnUp.IconVisible = true;
            this.btnUp.IconZoom = 40D;
            this.btnUp.IsTab = false;
            this.btnUp.Location = new System.Drawing.Point(80, 326);
            this.btnUp.Margin = new System.Windows.Forms.Padding(4);
            this.btnUp.Name = "btnUp";
            this.btnUp.Normalcolor = System.Drawing.Color.DarkCyan;
            this.btnUp.OnHovercolor = System.Drawing.Color.Teal;
            this.btnUp.OnHoverTextColor = System.Drawing.Color.White;
            this.btnUp.selected = false;
            this.btnUp.Size = new System.Drawing.Size(200, 30);
            this.btnUp.TabIndex = 38;
            this.btnUp.Text = "Update";
            this.btnUp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUp.Textcolor = System.Drawing.Color.White;
            this.btnUp.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUp.Click += new System.EventHandler(this.ad_bcup_Click);
            // 
            // txtCourseID
            // 
            this.txtCourseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCourseID.Location = new System.Drawing.Point(80, 173);
            this.txtCourseID.Name = "txtCourseID";
            this.txtCourseID.Size = new System.Drawing.Size(200, 22);
            this.txtCourseID.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label11.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(100, 9);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 21);
            this.label11.TabIndex = 14;
            this.label11.Text = "All Courses";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox14
            // 
            this.pictureBox14.BackColor = System.Drawing.Color.LightSeaGreen;
            this.pictureBox14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox14.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox14.Image")));
            this.pictureBox14.Location = new System.Drawing.Point(31, 0);
            this.pictureBox14.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(34, 37);
            this.pictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox14.TabIndex = 13;
            this.pictureBox14.TabStop = false;
            // 
            // pictureBox15
            // 
            this.pictureBox15.BackColor = System.Drawing.Color.LightSeaGreen;
            this.pictureBox15.Location = new System.Drawing.Point(0, 0);
            this.pictureBox15.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(1065, 37);
            this.pictureBox15.TabIndex = 12;
            this.pictureBox15.TabStop = false;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.SystemColors.Control;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(56, 56);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(224, 22);
            this.txtSearch.TabIndex = 75;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_OnTextChange);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(7, 48);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 74;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Teal;
            this.pictureBox1.Location = new System.Drawing.Point(43, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(248, 5);
            this.pictureBox1.TabIndex = 73;
            this.pictureBox1.TabStop = false;
            // 
            // ad_uc_cs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ad_pcs);
            this.Name = "ad_uc_cs";
            this.Size = new System.Drawing.Size(1050, 570);
            this.ad_pcs.ResumeLayout(false);
            this.ad_pcs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ad_dgv_c)).EndInit();
            this.pnlControl.ResumeLayout(false);
            this.pnlControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel ad_pcs;
        public System.Windows.Forms.PictureBox pictureBox14;
        public System.Windows.Forms.PictureBox pictureBox15;
        public System.Windows.Forms.Label label11;
        public Bunifu.Framework.UI.BunifuCustomDataGrid ad_dgv_c;
        private System.Windows.Forms.DataGridViewTextBoxColumn COURSE_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn COURSENAME;
        public System.Windows.Forms.Panel pnlControl;
        public Bunifu.Framework.UI.BunifuFlatButton btnCreate;
        public Bunifu.Framework.UI.BunifuFlatButton btnDel;
        public System.Windows.Forms.Label label28;
        public System.Windows.Forms.Label label27;
        public Bunifu.Framework.UI.BunifuFlatButton btnUp;
        public System.Windows.Forms.TextBox txtCourseID;
        public System.Windows.Forms.TextBox txtCoursename;
        public System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
