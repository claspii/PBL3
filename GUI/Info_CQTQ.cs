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
    public partial class Info_CQTQ : Form
    {
        public delegate void MyDel(Form childForm);
        public MyDel d { get; set; }
        private CQTQ current;
        public void Reload()
        {
            this.Show();
            dataGridView1.DataSource = BLL_QLCD.Instance.ToView_CDVN(BLL_QLCD.Instance.Search_CDVN(cbbTP.Text, cbbQH.Text, cbbPX.Text, "" ));
        }
        public Info_CQTQ(LDVN l)
        {
            InitializeComponent();
            GUI(l);
            
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
        public void GUI(LDVN l)
        {
            current = BLL_QLCD.Instance.GetCQTQbyID(l.ID_CQTQ);
            cbbTP.Items.AddRange(BLL_QLCD.Instance.GetCBBItems("TP", "").ToArray());
            if (current.TT.Contains("Phường") || current.TT.Contains("Xã"))
            {
                cbbTP.Enabled = false;
                cbbQH.Enabled = false;
                cbbPX.Enabled = false;
                string QH = BLL_QLCD.Instance.GetUpperCBBDiaChi(current.TT);
                string TP = BLL_QLCD.Instance.GetUpperCBBDiaChi(QH);
                SetCBBItem(cbbTP, TP);
                SetCBBItem(cbbQH, QH);
                SetCBBItem(cbbPX, current.TT);          
            }    
            else if (current.TT.Contains("Quận") || current.TT.Contains("Huyện"))
            {
                cbbTP.Enabled = false;
                cbbQH.Enabled = false;
                string TP = BLL_QLCD.Instance.GetUpperCBBDiaChi(current.TT);
                SetCBBItem(cbbTP, TP);
                SetCBBItem(cbbQH, current.TT);
            }
            else if (current.TT.Contains("Tỉnh") || current.TT.Contains("Thành phố"))
            {
                cbbTP.Enabled = false;
                SetCBBItem(cbbTP, current.TT);
            }    
            else
            {
                cbbTP.Items.Clear();
                cbbTP.Items.Add("All");
                cbbTP.Items.AddRange(BLL_QLCD.Instance.GetCBBItems("TP", "").ToArray());
            }
        }    
        private void button1_Click(object sender, EventArgs e)
        {
            Edit_tt tt = new Edit_tt("", 0);
            tt.d += this.Reload;
            d(tt);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                string ID_CD = dataGridView1.SelectedRows[0].Cells["CMND"].Value.ToString();
                Edit_tt tt = new Edit_tt(ID_CD, 0);
                tt.d += this.Reload;
                d(tt);
            }
            
        }

        private void bSearch_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLL_QLCD.Instance.ToView_CDVN(BLL_QLCD.Instance.Search_CDVN(cbbTP.Text, cbbQH.Text, 
                cbbPX.Text, txtSearch.Text));
        }

        private void cbbTP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbTP.SelectedItem.ToString() == "All")
            {
                cbbQH.Items.Clear();
                cbbPX.Items.Clear();
            }
            else
            {
                cbbQH.Items.Clear();
                cbbPX.Items.Clear();
                cbbQH.Items.Add("All");
                cbbQH.Items.AddRange(BLL_QLCD.Instance.GetCBBItems("QH", cbbTP.SelectedItem.ToString()).ToArray());
            }
            
        }

        private void cbbQH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbQH.SelectedItem.ToString() == "All")
            {
                cbbPX.Items.Clear();
            }
            else
            {
                cbbPX.Items.Clear();
                cbbPX.Items.Add("All");
                cbbPX.Items.AddRange(BLL_QLCD.Instance.GetCBBItems("PX", cbbQH.SelectedItem.ToString()).ToArray());
            }
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                string msg = "Xác nhận xóa tài khoản này ?";
                string Title = "Xác nhận";
                MessageBoxButtons b = MessageBoxButtons.OKCancel;
                DialogResult d = MessageBox.Show(msg, Title, b);
                if (d == DialogResult.OK)
                {
                    BLL_QLCD.Instance.Del_CD(dataGridView1.SelectedRows[0].Cells["CMND"].Value.ToString());
                    MessageBox.Show("Xóa tài khoản thành công");
                    Reload();
                }
                else
                    return;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Thongke_CQTQ f = new Thongke_CQTQ(BLL_QLCD.Instance.Search_CDVN(cbbTP.Text, cbbQH.Text,
                cbbPX.Text, ""), current.ID_CQTQ);
            f.d += this.Reload;
            d(f);
        }
    }
}
