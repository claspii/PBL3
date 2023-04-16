namespace PBL3.GUI
{
    partial class UI
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.bYkien = new FontAwesome.Sharp.IconButton();
            this.bRequest = new FontAwesome.Sharp.IconButton();
            this.bExit = new FontAwesome.Sharp.IconButton();
            this.bNoti = new FontAwesome.Sharp.IconButton();
            this.bHen = new FontAwesome.Sharp.IconButton();
            this.bSearch = new FontAwesome.Sharp.IconButton();
            this.bInfo = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bHome = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.iconButton3);
            this.panelMenu.Controls.Add(this.bYkien);
            this.panelMenu.Controls.Add(this.bRequest);
            this.panelMenu.Controls.Add(this.bExit);
            this.panelMenu.Controls.Add(this.bNoti);
            this.panelMenu.Controls.Add(this.bHen);
            this.panelMenu.Controls.Add(this.bSearch);
            this.panelMenu.Controls.Add(this.bInfo);
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(245, 803);
            this.panelMenu.TabIndex = 0;
            // 
            // iconButton3
            // 
            this.iconButton3.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.ForeColor = System.Drawing.Color.White;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.iconButton3.IconColor = System.Drawing.Color.White;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.Location = new System.Drawing.Point(0, 585);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(245, 69);
            this.iconButton3.TabIndex = 8;
            this.iconButton3.Tag = "Đổi mật khẩu";
            this.iconButton3.Text = "Đổi mật khẩu";
            this.iconButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton3.UseVisualStyleBackColor = true;
            this.iconButton3.Click += new System.EventHandler(this.bChangePassword_Click);
            // 
            // bYkien
            // 
            this.bYkien.Dock = System.Windows.Forms.DockStyle.Top;
            this.bYkien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bYkien.ForeColor = System.Drawing.Color.White;
            this.bYkien.IconChar = FontAwesome.Sharp.IconChar.Whatsapp;
            this.bYkien.IconColor = System.Drawing.Color.White;
            this.bYkien.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bYkien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bYkien.Location = new System.Drawing.Point(0, 516);
            this.bYkien.Name = "bYkien";
            this.bYkien.Size = new System.Drawing.Size(245, 69);
            this.bYkien.TabIndex = 7;
            this.bYkien.Tag = "Ý kiến";
            this.bYkien.Text = "Ý kiến";
            this.bYkien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bYkien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bYkien.UseVisualStyleBackColor = true;
            this.bYkien.Click += new System.EventHandler(this.bYkien_Click);
            // 
            // bRequest
            // 
            this.bRequest.Dock = System.Windows.Forms.DockStyle.Top;
            this.bRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bRequest.ForeColor = System.Drawing.Color.White;
            this.bRequest.IconChar = FontAwesome.Sharp.IconChar.Pray;
            this.bRequest.IconColor = System.Drawing.Color.White;
            this.bRequest.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bRequest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bRequest.Location = new System.Drawing.Point(0, 447);
            this.bRequest.Name = "bRequest";
            this.bRequest.Size = new System.Drawing.Size(245, 69);
            this.bRequest.TabIndex = 6;
            this.bRequest.Tag = "Yêu cầu";
            this.bRequest.Text = "Yêu cầu";
            this.bRequest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bRequest.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bRequest.UseVisualStyleBackColor = true;
            this.bRequest.Click += new System.EventHandler(this.bRequest_Click);
            // 
            // bExit
            // 
            this.bExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bExit.ForeColor = System.Drawing.Color.White;
            this.bExit.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.bExit.IconColor = System.Drawing.Color.White;
            this.bExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bExit.Location = new System.Drawing.Point(0, 750);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(245, 53);
            this.bExit.TabIndex = 9;
            this.bExit.Tag = "Đăng xuất";
            this.bExit.Text = "Đăng xuất";
            this.bExit.UseVisualStyleBackColor = true;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // bNoti
            // 
            this.bNoti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.bNoti.Dock = System.Windows.Forms.DockStyle.Top;
            this.bNoti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bNoti.ForeColor = System.Drawing.Color.White;
            this.bNoti.IconChar = FontAwesome.Sharp.IconChar.Bell;
            this.bNoti.IconColor = System.Drawing.Color.White;
            this.bNoti.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bNoti.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bNoti.Location = new System.Drawing.Point(0, 378);
            this.bNoti.Name = "bNoti";
            this.bNoti.Size = new System.Drawing.Size(245, 69);
            this.bNoti.TabIndex = 3;
            this.bNoti.Tag = "Thông báo";
            this.bNoti.Text = "Thông báo";
            this.bNoti.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bNoti.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bNoti.UseVisualStyleBackColor = false;
            this.bNoti.Click += new System.EventHandler(this.bNoti_Click);
            // 
            // bHen
            // 
            this.bHen.Dock = System.Windows.Forms.DockStyle.Top;
            this.bHen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bHen.ForeColor = System.Drawing.Color.White;
            this.bHen.IconChar = FontAwesome.Sharp.IconChar.CalendarAlt;
            this.bHen.IconColor = System.Drawing.Color.White;
            this.bHen.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bHen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bHen.Location = new System.Drawing.Point(0, 309);
            this.bHen.Name = "bHen";
            this.bHen.Size = new System.Drawing.Size(245, 69);
            this.bHen.TabIndex = 2;
            this.bHen.Tag = "Lịch hẹn";
            this.bHen.Text = "Lịch hẹn";
            this.bHen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bHen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bHen.UseVisualStyleBackColor = true;
            this.bHen.Click += new System.EventHandler(this.bHen_Click);
            // 
            // bSearch
            // 
            this.bSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.bSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSearch.ForeColor = System.Drawing.Color.White;
            this.bSearch.IconChar = FontAwesome.Sharp.IconChar.Info;
            this.bSearch.IconColor = System.Drawing.Color.White;
            this.bSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bSearch.Location = new System.Drawing.Point(0, 240);
            this.bSearch.Name = "bSearch";
            this.bSearch.Size = new System.Drawing.Size(245, 69);
            this.bSearch.TabIndex = 1;
            this.bSearch.Tag = "Tra cứu thông tin";
            this.bSearch.Text = "Tra cứu thông tin";
            this.bSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bSearch.UseVisualStyleBackColor = true;
            this.bSearch.Click += new System.EventHandler(this.bSearch_Click);
            // 
            // bInfo
            // 
            this.bInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.bInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bInfo.ForeColor = System.Drawing.Color.White;
            this.bInfo.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.bInfo.IconColor = System.Drawing.Color.White;
            this.bInfo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bInfo.Location = new System.Drawing.Point(0, 171);
            this.bInfo.Name = "bInfo";
            this.bInfo.Size = new System.Drawing.Size(245, 69);
            this.bInfo.TabIndex = 0;
            this.bInfo.Tag = "Thông tin cá nhân";
            this.bInfo.Text = "Thông tin cá nhân";
            this.bInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bInfo.UseVisualStyleBackColor = true;
            this.bInfo.Click += new System.EventHandler(this.bInfo_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.bHome);
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 171);
            this.panel1.TabIndex = 0;
            // 
            // bHome
            // 
            this.bHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.bHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bHome.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.bHome.IconColor = System.Drawing.Color.White;
            this.bHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bHome.IconSize = 150;
            this.bHome.Location = new System.Drawing.Point(0, 0);
            this.bHome.Name = "bHome";
            this.bHome.Size = new System.Drawing.Size(187, 167);
            this.bHome.TabIndex = 0;
            this.bHome.UseVisualStyleBackColor = false;
            this.bHome.Click += new System.EventHandler(this.bHome_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.Red;
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Right;
            this.iconButton1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Bars;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(187, 0);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(54, 167);
            this.iconButton1.TabIndex = 0;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelTitleBar.Controls.Add(this.iconPictureBox3);
            this.panelTitleBar.Controls.Add(this.lblTitleChildForm);
            this.panelTitleBar.Controls.Add(this.iconPictureBox2);
            this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTitleBar.Controls.Add(this.iconPictureBox1);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(245, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1261, 88);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // iconPictureBox3
            // 
            this.iconPictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconPictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.iconPictureBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.iconPictureBox3.IconColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox3.IconSize = 23;
            this.iconPictureBox3.Location = new System.Drawing.Point(1234, 3);
            this.iconPictureBox3.Name = "iconPictureBox3";
            this.iconPictureBox3.Size = new System.Drawing.Size(24, 23);
            this.iconPictureBox3.TabIndex = 4;
            this.iconPictureBox3.TabStop = false;
            this.iconPictureBox3.Click += new System.EventHandler(this.iconPictureBox3_Click);
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitleChildForm.Location = new System.Drawing.Point(93, 27);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(57, 22);
            this.lblTitleChildForm.TabIndex = 1;
            this.lblTitleChildForm.Text = "Home";
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconPictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.iconPictureBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.iconPictureBox2.IconColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 23;
            this.iconPictureBox2.Location = new System.Drawing.Point(1195, 3);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(24, 23);
            this.iconPictureBox2.TabIndex = 3;
            this.iconPictureBox2.TabStop = false;
            this.iconPictureBox2.Click += new System.EventHandler(this.iconPictureBox2_Click);
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.IconSize = 59;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(37, 12);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(59, 65);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 24;
            this.iconPictureBox1.Location = new System.Drawing.Point(1154, 0);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(24, 26);
            this.iconPictureBox1.TabIndex = 2;
            this.iconPictureBox1.TabStop = false;
            this.iconPictureBox1.Click += new System.EventHandler(this.iconPictureBox1_Click);
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.White;
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(245, 88);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1261, 715);
            this.panelDesktop.TabIndex = 2;
            // 
            // UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1506, 803);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.MinimumSize = new System.Drawing.Size(1379, 780);
            this.Name = "UI";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.panelMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Panel panelDesktop;
        private FontAwesome.Sharp.IconButton bInfo;
        private FontAwesome.Sharp.IconButton bRequest;
        private FontAwesome.Sharp.IconButton bExit;
        private FontAwesome.Sharp.IconButton bNoti;
        private FontAwesome.Sharp.IconButton bHen;
        private FontAwesome.Sharp.IconButton bSearch;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Label lblTitleChildForm;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton bHome;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton bYkien;
    }
}