namespace PBL3.GUI
{
    partial class login_screen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        /// <summary>
        /// 
        /// </summary>
        /// <param name="disposing"></param>
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
            this.userControl11 = new WindowsFormsControlLibrary1.UserControl1();
            this.button1 = new System.Windows.Forms.Button();
            this.bExit = new FontAwesome.Sharp.IconButton();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(8, 142);
            this.userControl11.Name = "userControl11";
            this.userControl11.Password = "";
            this.userControl11.Size = new System.Drawing.Size(418, 138);
            this.userControl11.TabIndex = 0;
            this.userControl11.UserName = "";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(128, 286);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 31);
            this.button1.TabIndex = 1;
            this.button1.Text = "Đăng nhập";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bExit
            // 
            this.bExit.BackColor = System.Drawing.SystemColors.Control;
            this.bExit.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.bExit.IconColor = System.Drawing.Color.Red;
            this.bExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bExit.IconSize = 30;
            this.bExit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bExit.Location = new System.Drawing.Point(384, 3);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(33, 35);
            this.bExit.TabIndex = 3;
            this.bExit.UseVisualStyleBackColor = false;
            this.bExit.Click += new System.EventHandler(this.button2_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.Aquamarine;
            this.panelTitleBar.Controls.Add(this.iconButton1);
            this.panelTitleBar.Controls.Add(this.bExit);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(431, 41);
            this.panelTitleBar.TabIndex = 4;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.SystemColors.Control;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 30;
            this.iconButton1.Location = new System.Drawing.Point(345, 3);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(33, 35);
            this.iconButton1.TabIndex = 4;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // login_screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 340);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.userControl11);
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(449, 387);
            this.MinimumSize = new System.Drawing.Size(449, 387);
            this.Name = "login_screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.login_screen_KeyDown);
            this.panelTitleBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private WindowsFormsControlLibrary1.UserControl1 userControl11;
        private System.Windows.Forms.Button button1;
        private FontAwesome.Sharp.IconButton bExit;
        private System.Windows.Forms.Panel panelTitleBar;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}

