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
    public partial class Request_CQTQ : Form
    {
        private CQTQ current;
        public Request_CQTQ(LDVN l)
        {
            current = BLL_QLCD.Instance.GetCQTQbyID(l.ID_CQTQ);
            InitializeComponent();
            GUI(l);
        }
        public void GUI(LDVN l)
        {
            dataGridView1.DataSource = BLL_QLCD.Instance.ToView_Yeucau(BLL_QLCD.Instance.GetYeucaubyIDCQTQ(current.ID_CQTQ));
            comboBox1.Items.AddRange(BLL_QLCD.Instance.GetUpperCBBItem(current).ToArray());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count == 1)
            {
                string ID = dataGridView1.SelectedRows[0].Cells["CMND_người_gửi"].Value.ToString();
                string txt = dataGridView1.SelectedRows[0].Cells["Chủ_đề"].Value.ToString();
                BLL_QLCD.Instance.Solve_Yeucau(ID, txt);
                dataGridView1.DataSource = BLL_QLCD.Instance.ToView_Yeucau(BLL_QLCD.Instance.GetYeucaubyIDCQTQ(current.ID_CQTQ));
                string msg = "Đã xử lý yêu cầu, tự động gửi thông báo ?";
                string title = "Xác nhận gửi thông báo";
                MessageBoxButtons b = MessageBoxButtons.OKCancel;
                DialogResult d = MessageBox.Show(msg, title, b);
                if(d == DialogResult.OK)
                {
                    List<Thongbao> li = new List<Thongbao>();
                    Thongbao t = new Thongbao
                    {
                        Title = txt,
                        ND = "Đã xử lý yêu cầu",
                        ID_CQTQ = current.ID_CQTQ,
                        ID_CD = ID,
                        Date_sent = DateTime.Now
                    };
                    li.Add(t);
                    BLL_QLCD.Instance.Add_noti(li);
                    MessageBox.Show("Đã gửi thông báo");             
                }
                else
                {
                    return;
                }    
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                string ID = dataGridView1.SelectedRows[0].Cells["CMND_người_gửi"].Value.ToString();
                string txt = dataGridView1.SelectedRows[0].Cells["Chủ_đề"].Value.ToString();
                BLL_QLCD.Instance.Del_Yeucau(ID, txt);
                string msg = "Đã xóa yêu cầu, tự động gửi thông báo ?";
                string title = "Xác nhận gửi thông báo";
                MessageBoxButtons b = MessageBoxButtons.OKCancel;
                DialogResult d = MessageBox.Show(msg, title, b);
                if (d == DialogResult.OK)
                {
                    List<Thongbao> li = new List<Thongbao>();
                    Thongbao t = new Thongbao
                    {
                        Title = dataGridView1.SelectedRows[0].Cells["Chủ_đề"].Value.ToString(),
                        ND = "Không thể xử lý yêu cầu",
                        ID_CQTQ = current.ID_CQTQ,
                        ID_CD = ID,
                        Date_sent = DateTime.Now
                    };
                    li.Add(t);
                    BLL_QLCD.Instance.Add_noti(li);
                    MessageBox.Show("Đã gửi thông báo");
                    dataGridView1.DataSource = BLL_QLCD.Instance.GetYeucaubyIDCQTQ(current.ID_CQTQ);
                }
                else
                {
                    return;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                if (comboBox1.SelectedItem != null)
                {
                    string ID_CQTQ = ((CBBItem)comboBox1.SelectedItem).Value;
                    string ID = dataGridView1.SelectedRows[0].Cells["CMND_người_gửi"].Value.ToString();
                    string txt = dataGridView1.SelectedRows[0].Cells["Chủ_đề"].Value.ToString();
                    string msg = "Xác nhận chuyển tiếp yêu cầu này ?";
                    string Title = "Chuyển tiếp yêu cầu";
                    MessageBoxButtons b = MessageBoxButtons.OKCancel;
                    DialogResult d = MessageBox.Show(msg, Title, b);
                    if (d == DialogResult.OK)
                    {
                        BLL_QLCD.Instance.Forward_Yeucau(ID, txt, ID_CQTQ);
                        MessageBox.Show("Chuyển tiếp yêu cầu thành công");
                        dataGridView1.DataSource = BLL_QLCD.Instance.ToView_Yeucau(BLL_QLCD.Instance.GetYeucaubyIDCQTQ(current.ID_CQTQ));
                    }
                    else
                        return;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text == "Xem yêu cầu đã xử lý")
            {
                dataGridView1.DataSource = BLL_QLCD.Instance.ToView_Yeucau(BLL_QLCD.Instance.GetSolvedYeucaubyIDCQTQ(current.ID_CQTQ));
                button4.Text = "Xem yêu cầu chưa xử lý";
            }    
            else
            {
                dataGridView1.DataSource = BLL_QLCD.Instance.ToView_Yeucau(BLL_QLCD.Instance.GetYeucaubyIDCQTQ(current.ID_CQTQ));
                button4.Text = "Xem yêu cầu đã xử lý";
            }    
            
        }
    }
}
