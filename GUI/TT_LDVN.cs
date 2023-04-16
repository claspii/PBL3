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
using PBL3.BLL;
using PBL3.DTO;

namespace PBL3.GUI
{
    public partial class TT_LDVN : Form
    {
        public delegate void MyDel();
        public MyDel d { get; set; }
        private LDVN current;
        public TT_LDVN(string ID, int m)
        {
            current = BLL_QLCD.Instance.GetLDVNbyID(ID);
            InitializeComponent();
            this.ControlBox = false;
            cbbChucvu.Items.AddRange(BLL_QLCD.Instance.GetAllChucvu().ToArray());
            GUI(m);
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
        public void GUI(int m)
        {
            if (m == 0)
                cbbChucvu.Enabled = false;
            else
            {
                txtCQTQ.ReadOnly = false;
                cbbChucvu.Enabled = true;
                bSave.Visible = true;
            }
            if (current != null)
            {
                txtCMND.Text = current.ID_LD;
                txtHoTen.Text = current.HoTenLD;
                SetCBBItem(cbbGender, current.GioiTinh);
                dtNgaySinh.Value = current.NgaySinhLD.Value;
                txtDiaChi.Text = current.DiaChi_LD;
                txtEmail.Text = current.Email_LD;
                txtSDT.Text = current.SDT_LD;
                SetCBBItem(cbbChucvu, current.Chucvu);
                string txt = BLL_QLCD.Instance.GetCQTQbyID(current.ID_CQTQ).TT;
                txt = txt.Insert(0, txt[0].ToString().ToLower()).Remove(1, 1);
                txtCQTQ.Text = BLL_QLCD.Instance.GetCQTQbyID(current.ID_CQTQ).Name_CQTQ + " " + txt;
                Load_img();
            }
            else
            {
                txtCMND.ReadOnly = false;
                txtHoTen.ReadOnly = false;
                cbbGender.Enabled = true;
                dtNgaySinh.Enabled = true;
                txtDiaChi.ReadOnly = false;
                txtEmail.ReadOnly = false;
                txtSDT.ReadOnly = false;
            }    
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            d();
            this.Dispose();
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            string msg = "Chắc chắn lưu thông tin này ?";
            string Title = "Xác nhận";
            DialogResult d = MessageBox.Show(msg, Title, MessageBoxButtons.OKCancel);
            if (d == DialogResult.OK)
            {
                if (txtCMND.Enabled == false)
                {
                    current.Chucvu = cbbChucvu.SelectedItem.ToString();
                    if (BLL_QLCD.Instance.GetCQTQbyID(txtCQTQ.Text) != null)
                        current.ID_CQTQ = txtCQTQ.Text;
                    BLL_QLCD.Instance.Add_Edit_LDVN(current);
                    MessageBox.Show("Lưu thông tin thành công");
                }
                else
                {
                    LDVN l = new LDVN
                    {
                        ID_LD = txtCMND.Text,
                        HoTenLD = txtHoTen.Text,
                        GioiTinh = cbbGender.SelectedItem.ToString(),
                        NgaySinhLD = dtNgaySinh.Value.Date,
                        DiaChi_LD = txtDiaChi.Text,
                        Email_LD = txtEmail.Text,
                        SDT_LD = txtSDT.Text,
                        Chucvu = cbbChucvu.SelectedItem.ToString(),
                        ID_CQTQ = txtCQTQ.Text
                    };
                    BLL_QLCD.Instance.Add_Edit_LDVN(l);
                }
                MessageBox.Show("Lưu thông tin thành công");
                
            }                  
        }
    }
}
