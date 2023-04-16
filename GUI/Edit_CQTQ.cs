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
    public partial class Edit_CQTQ : Form
    {
        public delegate void Mydel();
        public Mydel d { get;set;}  
        private CQTQ current;
        public Edit_CQTQ(string ID)
        {           
            current = BLL_QLCD.Instance.GetCQTQbyID(ID);
            InitializeComponent();
            this.ControlBox = false;
            GUI();
        }
        public void Set_Map(string txt)
        {
            txtTT.Text = txt;
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
            cbbName.Items.AddRange(BLL_QLCD.Instance.GetAllName_CQTQ().ToArray());
            if (current != null)
            {
                txtID.Text = current.ID_CQTQ;
                SetCBBItem(cbbName, current.Name_CQTQ);
                txtTT.Text = current.TT;
                txtDiaChi.Text = current.DiaChi;
                txtEmail.Text = current.Email;
                txtSDT.Text = current.SDT;
            }
            else
            {
                txtID.ReadOnly = false;
                current = new CQTQ();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Map f = new Map();
            f.d += this.Set_Map;
            f.Show();
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            if (cbbName.SelectedItem != null)
            {
                current.ID_CQTQ = txtID.Text;
                current.Name_CQTQ = cbbName.SelectedItem.ToString();
                current.TT = txtTT.Text;
                current.DiaChi = txtDiaChi.Text;
                current.Email = txtEmail.Text;
                current.SDT = txtSDT.Text;
                if (BLL_QLCD.Instance.Check_Edit_CQTQ(current) && txtID.ReadOnly == false)
                {
                    MessageBox.Show("ID bị trùng, vui lòng nhập ID khác");
                    return;
                }    
                else if (!BLL_QLCD.Instance.Check_Edit_CQTQ(current) && BLL_QLCD.Instance.Check_Exists_CQTQ(current))
                {
                    MessageBox.Show("Cơ quan đã tồn tại, vui lòng chọn cơ quan khác");
                    return;
                }
                string msg = "Chắc chắn lưu cơ quan này ?";
                string Title = "Xác nhận";
                DialogResult d = MessageBox.Show(msg, Title, MessageBoxButtons.OKCancel);
                if (d == DialogResult.OK)
                {
                    BLL_QLCD.Instance.Add_Edit_CQTQ(current);
                    MessageBox.Show("Lưu thông tin thành công");
                }    
            }
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            d();
            this.Dispose();
        }
    }
}
