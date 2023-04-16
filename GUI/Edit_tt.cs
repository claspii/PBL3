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
using System.Data.SqlClient;
using System.IO;
using System.Drawing.Imaging;

namespace PBL3.GUI
{
    public partial class Edit_tt : Form
    {
        public delegate void MyDel();
        public MyDel d { get; set; }
        private CDVN current = new CDVN();
        public Edit_tt(string ID_CD, int n)
        {
            this.ControlBox = false;
            InitializeComponent();
            GUI(ID_CD, n);
        }
        public void SetCBBItem(ComboBox c, string txt)
        {
            foreach (string s in c.Items)
            {
                if (s == txt)
                {
                    c.SelectedItem = s;
                    return;
                }
            }
        }
        public void GUI(string ID_CD, int n)
        {
            if (ID_CD != "")
            {
                if (n == 1)
                {
                    bSave.Visible = false;
                    button6.Visible = false;
                    bAdd.Visible = false;
                    txtCMND.ReadOnly = true;
                    txtName.ReadOnly = true;
                    cbbGender.Enabled = false;
                    dtNgaysinh.Enabled = false;
                    cbbTT_hn.Enabled = false;
                    txtDiachi.ReadOnly = true;
                    txtSDT.ReadOnly = true;
                    txtEmail.ReadOnly = true;
                    txtChuho.ReadOnly = true;
                    cbbTATS.Enabled = false;
                }                 
                bAdd.Enabled = false;
                txtCMND.Enabled = false;
                current = BLL_QLCD.Instance.GetCDVNbyID(ID_CD);
                txtCMND.Text = current.ID_CD;
                txtName.Text = current.HoTenCD;
                SetCBBItem(cbbGender, current.GioiTinh);
                dtNgaysinh.Value = current.NgaySinhCD.Value;
                SetCBBItem(cbbTT_hn, current.TT_hn);
                txtDiachi.Text = current.DiaChi_CD;
                txtEmail.Text = current.Email_CD;
                txtSDT.Text = current.SDT_CD;
                txtChuho.Text = current.ID_Chuho;
                SetCBBItem(cbbTATS, current.TATS);
                Load_img();
            }    
            else
            {
                bSave.Enabled = false;
            }               
        }
        private void Load_img()
        {
            if (current.Anh == null)
                return;
            else
            {
                MemoryStream m = new MemoryStream(current.Anh.ToArray());
                Image img = Image.FromStream(m);
                pictureBox1.Image = img;
            }
        }
        private void bAdd_Click(object sender, EventArgs e)
        {
            CDVN c = new CDVN
            {
                ID_CD = txtCMND.Text,
                HoTenCD = txtName.Text,
                GioiTinh = cbbGender.Text,
                NgaySinhCD = dtNgaysinh.Value.Date,
                TT_hn = cbbTT_hn.Text,
                DiaChi_CD = txtDiachi.Text,
                Email_CD = txtEmail.Text,
                SDT_CD = txtSDT.Text,
                ID_Chuho = txtChuho.Text,
                TATS = cbbTATS.Text
            };
            string msg = "Xác nhận thêm tài khoản này?";
            string title = "Xác nhận";
            MessageBoxButtons b = MessageBoxButtons.OKCancel;
            DialogResult dia = MessageBox.Show(msg, title, b);
            if (dia == DialogResult.OK)
            {
                if (pictureBox1.Image != null)
                {
                    MemoryStream m = new MemoryStream();
                    pictureBox1.Image.Save(m, ImageFormat.Jpeg);
                    c.Anh = m.ToArray();
                }
                BLL_QLCD.Instance.Add_Edit_CDVN(c);
                d();
                MessageBox.Show("Thêm tài khoản thành công");
                this.Dispose();
            }
            else
                return;
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            CDVN c = new CDVN
            {
                ID_CD = txtCMND.Text,
                HoTenCD = txtName.Text,
                GioiTinh = cbbGender.Text,
                NgaySinhCD = dtNgaysinh.Value,
                TT_hn = cbbTT_hn.Text,
                DiaChi_CD = txtDiachi.Text,
                Email_CD = txtEmail.Text,
                SDT_CD = txtSDT.Text,
                ID_Chuho = txtChuho.Text,
                TATS = cbbTATS.Text
            };
            string msg = "Xác nhận lưu tài khoản này?";
            string title = "Xác nhận";
            MessageBoxButtons b = MessageBoxButtons.OKCancel;
            DialogResult dia = MessageBox.Show(msg, title, b);
            if (dia == DialogResult.OK)
            {
                if (pictureBox1.Image != null)
                {
                    MemoryStream m = new MemoryStream();
                    pictureBox1.Image.Save(m, ImageFormat.Jpeg);
                    c.Anh = m.ToArray();
                }
                BLL_QLCD.Instance.Add_Edit_CDVN(c);
                d();
                MessageBox.Show("Lưu thông tin thành công");
                this.Dispose();
            }
            else
                return;
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            d();
            this.Dispose();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string path = openFileDialog1.FileName;
            if (string.IsNullOrEmpty(path))
                return;
            try
            { pictureBox1.Image = Image.FromFile(path); }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
