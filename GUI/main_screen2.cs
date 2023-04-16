using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3.DTO;
using PBL3.BLL; 

namespace PBL3.GUI
{
    public partial class main_screen2 : Form
    {
        public delegate void Mydel();
        public Mydel d { get; set; }
        public CDVN current;
        public Account acc;
        private bool img_exists { get; set; }
        public main_screen2(Account a)
        {
            acc = a;
            current = BLL_QLCD.Instance.GetCDVNbyID(a.username);
            InitializeComponent();
            GUI();
        }
        public void SetCBBItem(ComboBox c, string txt)
        {
            foreach(string s in c.Items)
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
            txtCMND.Text = current.ID_CD;
            txtHoten.Text = current.HoTenCD;
            SetCBBItem(cbbGender, current.GioiTinh);
            dtNgaysinh.Value = current.NgaySinhCD.Value;
            SetCBBItem(cbbTT_hn, current.TT_hn);
            txtDiachi.Text = current.DiaChi_CD;
            txtEmail.Text = current.Email_CD;
            txtSDT.Text = current.SDT_CD;
            if (current.ID_Chuho == current.ID_CD)
                txtHotenchuho.Text = "Chủ hộ";
            else if (BLL_QLCD.Instance.GetCDVNbyID(current.ID_Chuho) != null)
                txtHotenchuho.Text = BLL_QLCD.Instance.GetCDVNbyID(current.ID_Chuho).HoTenCD;
            SetCBBItem(cbbTienan, current.TATS);
            if (BLL_QLCD.Instance.CheckEditCDVN(current.ID_CD))
                bEdit.Enabled = true;
            Load_img();
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
        private void SetNotEdit()
        {
            bImage.Enabled = false;
            txtHoten.ReadOnly = true;
            cbbGender.Enabled = false;
            dtNgaysinh.Enabled = false;
            cbbTT_hn.Enabled = false;
            txtDiachi.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtSDT.ReadOnly = true;
            cbbTienan.Enabled = false;
            bSave.Enabled = false;
            bEdit.Enabled = false;
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

        private void bEdit_Click(object sender, EventArgs e)
        {
            bImage.Enabled = true;
            txtHoten.ReadOnly = false;
            cbbGender.Enabled = true;
            dtNgaysinh.Enabled = true;
            cbbTT_hn.Enabled = true;
            txtDiachi.ReadOnly = false;
            txtEmail.ReadOnly = false;
            txtSDT.ReadOnly = false;
            bSave.Enabled = true;
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            string msg = "Bạn có chắc chắn lưu thông tin này, thông tin sẽ không thể chỉnh sửa cho đến khi được cấp quyền lần tiếp theo";
            string Title = "Xác nhận";
            MessageBoxButtons b = MessageBoxButtons.OKCancel;
            DialogResult d = MessageBox.Show(msg, Title, b);
            if(d == DialogResult.OK)
            {
                current.HoTenCD = txtHoten.Text;
                current.GioiTinh = cbbGender.SelectedItem.ToString();
                current.NgaySinhCD = dtNgaysinh.Value;
                current.TT_hn = cbbTT_hn.SelectedItem.ToString();  
                current.DiaChi_CD = txtDiachi.Text;
                current.Email_CD = txtEmail.Text;
                current.SDT_CD = txtSDT.Text;
                current.TATS = cbbTienan.SelectedItem.ToString();
                if (pictureBox1.Image != null)
                {
                    MemoryStream m = new MemoryStream();
                    pictureBox1.Image.Save(m, ImageFormat.Jpeg);
                    current.Anh = m.ToArray();
                }
                BLL_QLCD.Instance.Add_Edit_CDVN(current);
                BLL_QLCD.Instance.SetEdited(current.ID_CD);
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
