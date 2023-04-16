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
    public partial class Ykien_CDVN : Form
    {
        private string ID_CQTQ;
        private CDVN current;
        public Ykien_CDVN(string ID)
        {
            InitializeComponent();
            current = BLL_QLCD.Instance.GetCDVNbyID(ID);
            GUI();
        }
        public void GUI()
        {
            dataGridView1.DataSource = BLL_QLCD.Instance.ToView_Thongbao(BLL_QLCD.Instance.GetListNotiYkienbyIDCD(current.ID_CD));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                txtCQTQ.Text = dataGridView1.SelectedRows[0].Cells["Người_gửi"].Value.ToString();
                panel1.Visible = true;
                ID_CQTQ = dataGridView1.SelectedRows[0].Cells["ID_CQTQ"].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtCQTQ.Text != "Admin hệ thống")
            {
                if (txtND.Text != null && dataGridView1.SelectedRows.Count == 1)
                {
                    Ykien y = new Ykien
                    {
                        ID_CD = current.ID_CD,
                        ID = ID_CQTQ,
                        ND = txtND.Text,
                        Title = dataGridView1.SelectedRows[0].Cells["Nội_dung"].Value.ToString(),
                        Date_sent = DateTime.Now.Date
                    };
                    string msg = "Bạn có chắc gửi ý kiến này ?";
                    string Title = "Xác nhận";
                    DialogResult d = MessageBox.Show(msg, Title, MessageBoxButtons.OKCancel);
                    if (d == DialogResult.OK)
                    {
                        BLL_QLCD.Instance.Add_Ykien(y, Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value));
                        MessageBox.Show("Gửi ý kiến thành công");
                        txtND.Text = null;
                        txtCQTQ.Text = null;
                        panel1.Visible = false;
                    }
                }
            }
            else
            {
                Ykien y = new Ykien
                {
                    ID_CD = current.ID_CD,
                    ID = ID_CQTQ,
                    ND = txtND.Text,
                    Title = "Đóng góp ý kiến hệ thống",
                    Date_sent = DateTime.Now.Date
                };
                string msg = "Bạn có chắc gửi ý kiến này ?";
                string Title = "Xác nhận";
                DialogResult d = MessageBox.Show(msg, Title, MessageBoxButtons.OKCancel);
                if (d == DialogResult.OK)
                {
                    BLL_QLCD.Instance.Add_Ykien(y, 0);
                    MessageBox.Show("Gửi ý kiến thành công");
                    txtND.Text = null;
                    txtCQTQ.Text = null;
                    panel1.Visible = false;
                }
            }    
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                Thongbao t = BLL_QLCD.Instance.GetNotibyID(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value));
                string txt = t.CQTQ.Name_CQTQ + " " + t.CQTQ.TT.Insert(0, t.CQTQ.TT[0].ToString().ToLower()).Remove(1, 1);
                string msg = "Từ: " + txt + "\n" + "Gửi đến: " + t.ID_CD + ", " + t.CDVN.HoTenCD + "\n"
                    + "Ngày gửi: " + t.Date_sent.Value.ToString(@"dd/MM/yyyy") + "\n" + "Nội dung: " + t.ND;
                string Title = t.Title;
                MessageBox.Show(msg, Title, MessageBoxButtons.OK);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            txtCQTQ.Text = "Admin hệ thống";
            ID_CQTQ = "0";
        }
    }
}
