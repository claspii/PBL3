namespace PBL3.GUI
{
    partial class Map
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbPX = new System.Windows.Forms.ComboBox();
            this.cbbQH = new System.Windows.Forms.ComboBox();
            this.cbbTP = new System.Windows.Forms.ComboBox();
            this.bOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(853, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Phường, xã";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(449, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Quận, huyện";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tỉnh, thành phố";
            // 
            // cbbPX
            // 
            this.cbbPX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbPX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbPX.FormattingEnabled = true;
            this.cbbPX.Location = new System.Drawing.Point(965, 12);
            this.cbbPX.Name = "cbbPX";
            this.cbbPX.Size = new System.Drawing.Size(262, 33);
            this.cbbPX.TabIndex = 9;
            // 
            // cbbQH
            // 
            this.cbbQH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbQH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbQH.FormattingEnabled = true;
            this.cbbQH.Location = new System.Drawing.Point(574, 12);
            this.cbbQH.Name = "cbbQH";
            this.cbbQH.Size = new System.Drawing.Size(273, 33);
            this.cbbQH.TabIndex = 8;
            this.cbbQH.SelectedIndexChanged += new System.EventHandler(this.cbbQH_SelectedIndexChanged);
            // 
            // cbbTP
            // 
            this.cbbTP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTP.FormattingEnabled = true;
            this.cbbTP.Location = new System.Drawing.Point(160, 12);
            this.cbbTP.Name = "cbbTP";
            this.cbbTP.Size = new System.Drawing.Size(283, 33);
            this.cbbTP.TabIndex = 7;
            this.cbbTP.SelectedIndexChanged += new System.EventHandler(this.cbbTP_SelectedIndexChanged);
            // 
            // bOK
            // 
            this.bOK.AutoSize = true;
            this.bOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bOK.Location = new System.Drawing.Point(555, 68);
            this.bOK.Name = "bOK";
            this.bOK.Size = new System.Drawing.Size(82, 35);
            this.bOK.TabIndex = 114;
            this.bOK.Text = "OK";
            this.bOK.UseVisualStyleBackColor = true;
            this.bOK.Click += new System.EventHandler(this.bOK_Click);
            // 
            // Map
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 106);
            this.Controls.Add(this.bOK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbPX);
            this.Controls.Add(this.cbbQH);
            this.Controls.Add(this.cbbTP);
            this.Name = "Map";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Map";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbPX;
        private System.Windows.Forms.ComboBox cbbQH;
        private System.Windows.Forms.ComboBox cbbTP;
        private System.Windows.Forms.Button bOK;
    }
}