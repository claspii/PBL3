namespace PBL3.GUI
{
    partial class noti_CQTQ
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbTP = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbQH = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbPX = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtND = new System.Windows.Forms.TextBox();
            this.cbbtitle = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbbreceiver = new System.Windows.Forms.ComboBox();
            this.bsent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Thông báo đến người dân:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tỉnh, thành phố:";
            // 
            // cbbTP
            // 
            this.cbbTP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTP.FormattingEnabled = true;
            this.cbbTP.Location = new System.Drawing.Point(172, 137);
            this.cbbTP.Name = "cbbTP";
            this.cbbTP.Size = new System.Drawing.Size(275, 33);
            this.cbbTP.TabIndex = 3;
            this.cbbTP.SelectedIndexChanged += new System.EventHandler(this.cbbTP_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(453, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Quận, huyện";
            // 
            // cbbQH
            // 
            this.cbbQH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbQH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbQH.FormattingEnabled = true;
            this.cbbQH.Location = new System.Drawing.Point(573, 137);
            this.cbbQH.Name = "cbbQH";
            this.cbbQH.Size = new System.Drawing.Size(294, 33);
            this.cbbQH.TabIndex = 5;
            this.cbbQH.SelectedIndexChanged += new System.EventHandler(this.cbbQH_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(873, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Phường, xã";
            // 
            // cbbPX
            // 
            this.cbbPX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbPX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbPX.FormattingEnabled = true;
            this.cbbPX.Location = new System.Drawing.Point(991, 137);
            this.cbbPX.Name = "cbbPX";
            this.cbbPX.Size = new System.Drawing.Size(257, 33);
            this.cbbPX.TabIndex = 7;
            this.cbbPX.SelectedIndexChanged += new System.EventHandler(this.cbbPX_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "Tiêu đề:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 382);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 25);
            this.label7.TabIndex = 10;
            this.label7.Text = "Nội dung:";
            // 
            // txtND
            // 
            this.txtND.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtND.Location = new System.Drawing.Point(115, 379);
            this.txtND.Name = "txtND";
            this.txtND.Size = new System.Drawing.Size(775, 30);
            this.txtND.TabIndex = 11;
            // 
            // cbbtitle
            // 
            this.cbbtitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbtitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbtitle.FormattingEnabled = true;
            this.cbbtitle.Items.AddRange(new object[] {
            "Lấy ý kiến nhân dân",
            "Yêu cầu công chứng, xác nhận giấy tờ",
            "Đơn khiếu nại",
            "Yêu cầu thay đổi, chỉnh sửa thông tin"});
            this.cbbtitle.Location = new System.Drawing.Point(103, 302);
            this.cbbtitle.Name = "cbbtitle";
            this.cbbtitle.Size = new System.Drawing.Size(380, 33);
            this.cbbtitle.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 221);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 25);
            this.label8.TabIndex = 13;
            this.label8.Text = "Người nhận:";
            // 
            // cbbreceiver
            // 
            this.cbbreceiver.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbreceiver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbreceiver.FormattingEnabled = true;
            this.cbbreceiver.Items.AddRange(new object[] {
            "All"});
            this.cbbreceiver.Location = new System.Drawing.Point(137, 218);
            this.cbbreceiver.Name = "cbbreceiver";
            this.cbbreceiver.Size = new System.Drawing.Size(405, 33);
            this.cbbreceiver.TabIndex = 14;
            // 
            // bsent
            // 
            this.bsent.AutoSize = true;
            this.bsent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bsent.Location = new System.Drawing.Point(563, 495);
            this.bsent.Name = "bsent";
            this.bsent.Size = new System.Drawing.Size(144, 35);
            this.bsent.TabIndex = 15;
            this.bsent.Text = "Gửi thông báo";
            this.bsent.UseVisualStyleBackColor = true;
            this.bsent.Click += new System.EventHandler(this.bsent_Click);
            // 
            // noti_CQTQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 605);
            this.Controls.Add(this.bsent);
            this.Controls.Add(this.cbbreceiver);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbbtitle);
            this.Controls.Add(this.txtND);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbbPX);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbbQH);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbbTP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "noti_CQTQ";
            this.Text = "Gửi thông báo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbTP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbQH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbPX;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtND;
        private System.Windows.Forms.ComboBox cbbtitle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbbreceiver;
        private System.Windows.Forms.Button bsent;
    }
}