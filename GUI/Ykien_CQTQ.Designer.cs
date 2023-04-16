namespace PBL3.GUI
{
    partial class Ykien_CQTQ
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
            this.bsent = new System.Windows.Forms.Button();
            this.txtND = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbbPX = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbQH = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbTP = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bsent
            // 
            this.bsent.AutoSize = true;
            this.bsent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bsent.Location = new System.Drawing.Point(1102, 144);
            this.bsent.Name = "bsent";
            this.bsent.Size = new System.Drawing.Size(144, 35);
            this.bsent.TabIndex = 30;
            this.bsent.Text = "Gửi thông báo";
            this.bsent.UseVisualStyleBackColor = true;
            this.bsent.Click += new System.EventHandler(this.bsent_Click);
            // 
            // txtND
            // 
            this.txtND.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtND.Location = new System.Drawing.Point(113, 146);
            this.txtND.Name = "txtND";
            this.txtND.Size = new System.Drawing.Size(983, 30);
            this.txtND.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 25);
            this.label7.TabIndex = 25;
            this.label7.Text = "Nội dung:";
            // 
            // cbbPX
            // 
            this.cbbPX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbPX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbPX.FormattingEnabled = true;
            this.cbbPX.Location = new System.Drawing.Point(989, 85);
            this.cbbPX.Name = "cbbPX";
            this.cbbPX.Size = new System.Drawing.Size(257, 33);
            this.cbbPX.TabIndex = 23;
            this.cbbPX.SelectedIndexChanged += new System.EventHandler(this.cbbPX_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(871, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Phường, xã";
            // 
            // cbbQH
            // 
            this.cbbQH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbQH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbQH.FormattingEnabled = true;
            this.cbbQH.Location = new System.Drawing.Point(571, 85);
            this.cbbQH.Name = "cbbQH";
            this.cbbQH.Size = new System.Drawing.Size(294, 33);
            this.cbbQH.TabIndex = 21;
            this.cbbQH.SelectedIndexChanged += new System.EventHandler(this.cbbQH_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(453, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Quận, huyện";
            // 
            // cbbTP
            // 
            this.cbbTP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTP.FormattingEnabled = true;
            this.cbbTP.Location = new System.Drawing.Point(172, 85);
            this.cbbTP.Name = "cbbTP";
            this.cbbTP.Size = new System.Drawing.Size(275, 33);
            this.cbbTP.TabIndex = 19;
            this.cbbTP.SelectedIndexChanged += new System.EventHandler(this.cbbTP_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Tỉnh, thành phố:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Lấy ý kiến người dân:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 255);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1230, 309);
            this.dataGridView1.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(530, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(192, 25);
            this.label6.TabIndex = 32;
            this.label6.Text = "Danh sách phản hồi:";
            // 
            // Ykien_CQTQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 605);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bsent);
            this.Controls.Add(this.txtND);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbbPX);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbbQH);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbbTP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Ykien_CQTQ";
            this.Text = "Ý kiến";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bsent;
        private System.Windows.Forms.TextBox txtND;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbbPX;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbQH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbTP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
    }
}