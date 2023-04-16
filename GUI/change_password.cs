using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3.DTO;
using PBL3.BLL;

namespace PBL3.GUI
{
    public partial class change_password : Form
    {
        public delegate void Mydel();
        public Mydel d { get;set;}
        private Account acc;

        public change_password(Account a)
        {
            acc = a;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != acc.password)
            {
                MessageBox.Show("Mật khẩu cũ sai, vui lòng nhập lại");
                textBox1.Text = textBox2.Text = textBox3.Text = "";
            }    
            else
            {
                if (textBox2.Text.Length < 6)
                {
                    MessageBox.Show("Mật khẩu mới không hợp lệ");
                    textBox1.Text =textBox2.Text = textBox3.Text = "";
                }    
                else if (textBox2.Text != textBox3.Text)
                {
                    MessageBox.Show("Mật khẩu mới không trùng khớp");
                    textBox1.Text = textBox2.Text = textBox3.Text = "";
                }    
                else
                {
                    BLL_QLCD.Instance.change_password(acc, textBox2.Text);
                    MessageBox.Show("Thay đổi mật khẩu thành công");
                    d();
                    this.Dispose();
                } 
                    
            }    
        }
    }
}
