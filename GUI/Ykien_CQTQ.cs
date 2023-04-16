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
    public partial class Ykien_CQTQ : Form
    {
        private CQTQ current;
        public Ykien_CQTQ(LDVN l)
        {
            InitializeComponent();
            current = BLL_QLCD.Instance.GetCQTQbyID(l.ID_CQTQ);
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
            dataGridView1.DataSource = BLL_QLCD.Instance.ToView_Ykien(BLL_QLCD.Instance.GetListYkienbyIDCQTQ(current.ID_CQTQ));
            cbbTP.Items.AddRange(BLL_QLCD.Instance.GetCBBItems("TP", "").ToArray());
            if (current.TT.Contains("Phường") || current.TT.Contains("Xã"))
            {
                cbbTP.Enabled = false;
                cbbQH.Enabled = false;
                cbbPX.Enabled = false;
                string QH = BLL_QLCD.Instance.GetUpperCBBDiaChi(current.TT);
                string TP = BLL_QLCD.Instance.GetUpperCBBDiaChi(QH);
                Console.WriteLine(QH + " " + TP);
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

        private void bsent_Click(object sender, EventArgs e)
        {
            if (cbbTP.SelectedItem != null)
            {
                List<Thongbao> li = new List<Thongbao>();
                foreach (string s in BLL_QLCD.Instance.GetListIDCDVN(cbbTP.Text, cbbQH.Text, cbbPX.Text))
                {
                    if (s != "All")
                    {
                        Thongbao temp = new Thongbao
                        {
                            Title = "Khảo sát ý kiến nhân dân",
                            ID_CD = s,
                            Date_sent = DateTime.Now,
                            ND = txtND.Text,
                            ID_CQTQ = current.ID_CQTQ
                        };
                        li.Add(temp);
                    }
                }
                string msg = "Xác nhận gửi thông báo ?";
                string title = "Xác nhận";
                MessageBoxButtons b = MessageBoxButtons.OKCancel;
                DialogResult d = MessageBox.Show(msg, title, b);
                if (d == DialogResult.OK)
                {
                    BLL_QLCD.Instance.Add_noti(li);
                    MessageBox.Show("Gửi thông báo thành công");
                }
                else
                    return;
            }
        }

        private void cbbPX_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
