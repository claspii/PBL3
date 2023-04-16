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
    public partial class noti_CDVN : Form
    {
        private string ID_CD;
        public noti_CDVN(string ID_CD)
        {
            InitializeComponent();
            this.ID_CD = ID_CD;  
            GUI();
        }
        public void GUI()
        {
            dataGridView1.DataSource = BLL_QLCD.Instance.ToView_Thongbao(BLL_QLCD.Instance.GetListThongbaobyIDCD(ID_CD));
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            List<ThongbaoView> temp = new List<ThongbaoView>();
            foreach(ThongbaoView t in BLL_QLCD.Instance.ToView_Thongbao(BLL_QLCD.Instance.GetListThongbaobyIDCD(ID_CD)))
            {
                if (t.Ngày_gửi.Date == dateTimePicker1.Value.Date)
                    temp.Add(t);
            }
            dataGridView1.DataSource = temp;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GUI();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
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

        private void bDel_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                string msg = "Bạn có chắc chắn xóa thông báo này ?";
                string Title = "Xác nhận";
                DialogResult d = MessageBox.Show(msg, Title, MessageBoxButtons.OKCancel);
                if (d == DialogResult.OK)
                {
                    BLL_QLCD.Instance.Del_Noti(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value));
                    MessageBox.Show("Xóa thông báo thành công");
                    GUI();
                }
            }
        }
    }
}
