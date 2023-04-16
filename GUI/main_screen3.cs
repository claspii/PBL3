using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3.DTO;
using PBL3.BLL;
using System.Drawing.Imaging;

namespace PBL3.GUI
{
    public partial class main_screen3 : Form
    {
        public delegate void Mydel();
        public Mydel d { get; set; }
        public Account acc { get; set; }
        public LDVN current { get; set; }
        
        public main_screen3(Account a)
        {
            acc = a;
            current = BLL_QLCD.Instance.GetLDVNbyID(a.username);
            InitializeComponent();
            GUI();
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
        public void GUI()
        {
            txtCMND.Text = current.ID_LD;
            txtHoTen.Text = current.HoTenLD;
            SetCBBItem(cbbGender, current.GioiTinh);
            dtNgaySinh.Value = current.NgaySinhLD.Value;
            txtDiaChi.Text = current.DiaChi_LD;
            txtEmail.Text = current.Email_LD;
            txtSDT.Text = current.SDT_LD;
            txtChucvu.Text = current.Chucvu;
            string txt = BLL_QLCD.Instance.GetCQTQbyID(current.ID_CQTQ).TT;
            txt = txt.Insert(0, txt[0].ToString().ToLower()).Remove(1, 1);
            txtCQTQ.Text = BLL_QLCD.Instance.GetCQTQbyID(current.ID_CQTQ).Name_CQTQ + " " + txt;
            Load_img();

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
        private void bEdit_Click(object sender, EventArgs e)
        {
            bEdit.Enabled = false;
            bImage.Enabled = true;
            txtHoTen.ReadOnly = false;
            cbbGender.Enabled = true;
            dtNgaySinh.Enabled = true;
            txtDiaChi.ReadOnly = false;
            txtEmail.ReadOnly = false;
            txtSDT.ReadOnly = false;
            bSave.Enabled = true;
        }
        private void SetNotEdit()
        {
            bEdit.Enabled = true;
            bImage.Enabled = false;
            txtHoTen.ReadOnly = true;
            cbbGender.Enabled = false;
            dtNgaySinh.Enabled = false;
            txtDiaChi.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtSDT.ReadOnly = true;
            bSave.Enabled = false;
        }
        private void bSave_Click(object sender, EventArgs e)
        {           
            string msg = "Bạn có chắc chắn lưu thông tin này ?";
            string Title = "Xác nhận";
            MessageBoxButtons b = MessageBoxButtons.OKCancel;
            DialogResult d = MessageBox.Show(msg, Title, b);
            if (d == DialogResult.OK)
            {
                current.HoTenLD = txtHoTen.Text;
                current.GioiTinh = cbbGender.SelectedItem.ToString();
                current.NgaySinhLD = dtNgaySinh.Value;
                current.DiaChi_LD = txtDiaChi.Text;
                current.Email_LD = txtEmail.Text;
                current.SDT_LD = txtSDT.Text;
                if (pictureBox1.Image != null)
                {
                    MemoryStream m = new MemoryStream();
                    pictureBox1.Image.Save(m, ImageFormat.Jpeg);
                    current.Anh = m.ToArray();
                }
                BLL_QLCD.Instance.Add_Edit_LDVN(current);
                MessageBox.Show("Lưu thông tin thành công");
                SetNotEdit();
            }
            else
            {
                return;
            }
        }
    }
}
