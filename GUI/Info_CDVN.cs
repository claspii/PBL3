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
    public partial class Info_CDVN : Form
    {
        public delegate void Mydel(Form childForm);
        public Mydel d { get; set; }
        private List<CQTQView> back_up;
        private string ID;
        public Info_CDVN(string ID)
        {
            this.ID = ID;
            InitializeComponent();
            cbbTP.Items.Add("All");
            cbbTP.Items.AddRange(BLL_QLCD.Instance.GetCBBItems("TP", " ").ToArray());
        }
        public void Reload()
        {
            this.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            List<CQTQ> li = new List<CQTQ>();
            if (cbbTP.SelectedItem != null)
            {
                if (cbbQH.SelectedItem != null)
                {
                    if (cbbPX.SelectedItem != null)
                    {
                        if (cbbPX.SelectedItem.ToString() == "All")
                            li = BLL_QLCD.Instance.Search_CQTQ(cbbQH.SelectedItem.ToString(), "Phường", "Xã");
                        else
                            li = BLL_QLCD.Instance.Search_CQTQ(cbbPX.SelectedItem.ToString(), "Phường", "Xã");
                    }
                    else if (cbbQH.SelectedItem.ToString() == "All")
                        li = BLL_QLCD.Instance.Search_CQTQ(cbbTP.SelectedItem.ToString(), "Quận", "Huyện");
                    else
                        li = BLL_QLCD.Instance.Search_CQTQ(cbbQH.SelectedItem.ToString(), "Quận", "Huyện");
                }
                else if (cbbTP.SelectedItem.ToString() == "All")
                    li = BLL_QLCD.Instance.GetAllTP();
                else
                    li = BLL_QLCD.Instance.Search_CQTQ(cbbTP.SelectedItem.ToString(), "Tỉnh", "Thành phố");
                dataGridView1.DataSource = BLL_QLCD.Instance.ToView_CQTQ(li);
            }
            else
                MessageBox.Show("Bạn chưa chọn phạm vi cơ quan");
        }

        private void cbbTP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbTP.SelectedItem.ToString() == "All")
            {
                cbbQH.Items.Clear();
                cbbPX.Items.Clear();
                return;
            }
            cbbQH.Items.Clear();
            cbbQH.Items.Add("All");
            cbbQH.Items.AddRange(BLL_QLCD.Instance.GetCBBItems("QH", cbbTP.SelectedItem.ToString()).ToArray());
        }

        private void cbbQH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbQH.SelectedItem.ToString() == "All")
            {
                cbbPX.Items.Clear();
                return;
            }
            cbbPX.Items.Clear();
            cbbPX.Items.Add("All");
            cbbPX.Items.AddRange(BLL_QLCD.Instance.GetCBBItems("PX", cbbQH.SelectedItem.ToString()).ToArray());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = BLL_QLCD.Instance.ToView_CQTQ(BLL_QLCD.Instance.Search_CQTQ("Trung ương", "", ""));
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                string txt = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                switch (BLL_QLCD.Instance.Check_dt(txt))
                {
                    case 1:
                        {
                            Edit_tt f = new Edit_tt(txt, 1);
                            d(f);
                            f.d += this.Reload;
                            return;
                        }
                    case 2:
                        {
                            TT_LDVN f = new TT_LDVN(txt, 0);
                            d(f);
                            f.d += this.Reload;
                            return;
                        }
                    case 3:
                        {
                            back_up = dataGridView1.DataSource as List<CQTQView>;
                            dataGridView1.DataSource = BLL_QLCD.Instance.ToView_LDVN(BLL_QLCD.Instance.GetLDVNbyCQTQ(txt));
                            this.button4.Visible = true;
                            return;
                        }
                    default:
                        return;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == "Thông tin hộ khẩu")
            {
                dataGridView1.DataSource = BLL_QLCD.Instance.ToView_CDVN(BLL_QLCD.Instance.GetCDVNbyIDchuho(ID));
                cbbQH.Enabled = false;
                cbbPX.Enabled = false;
                cbbTP.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Text = "Tra cứu thông tin CQTQ";
            }
            else
            {
                dataGridView1.DataSource = new List<CQTQView>();
                button3.Text = "Thông tin hộ khẩu";
                cbbQH.Enabled = true;
                cbbPX.Enabled = true;
                cbbTP.Enabled = true;
                button1.Enabled = true;
                button2.Enabled = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.button4.Visible = false;
            dataGridView1.DataSource = back_up;
        }
    }
}
