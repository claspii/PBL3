using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3.BLL;
using PBL3.DTO;

namespace PBL3.GUI
{
    public partial class Lichhen_CQTQ : Form
    {
        private int a;
        private CQTQ c;
        public Lichhen_CQTQ(LDVN l)
        {
            c = BLL_QLCD.Instance.GetCQTQbyID(l.ID_CQTQ);
            InitializeComponent();
            GUI(l.ID_CQTQ);
        }
        public void GUI(string ID)
        {
            cbbTG.Items.Clear();
            cbbTG.Items.AddRange(BLL_QLCD.Instance.GetCBBTG(ID).ToArray());
            dataGridView2.DataSource = BLL_QLCD.Instance.ToView_FreeTime(BLL_QLCD.Instance.GetAllFreeTime(ID));
            dateTimePicker1.Value = DateTime.Now;
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            string msg = "Bạn có chắc chắn thêm thời gian này?";
            string Title = "Xác nhận";
            DialogResult d = MessageBox.Show(msg, Title, MessageBoxButtons.OKCancel);
            if (d == DialogResult.OK && begin.Value.TimeOfDay < end.Value.TimeOfDay)
            {
                FreeTime f = new FreeTime
                {
                    ID_CQTQ = c.ID_CQTQ,
                    Start_time = begin.Value.TimeOfDay,
                    End_time = end.Value.TimeOfDay,  
                    Max_per = Convert.ToInt32(txtMax.Text)
                };
                BLL_QLCD.Instance.Add_FreeTime(f);
                MessageBox.Show("Thêm thành công");
                panel1.Visible = false;
                GUI(c.ID_CQTQ);
            }    
        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count == 1)
            {
                a = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells["ID"].Value);
                panel1.Visible = true;
                bAdd.Visible = false;
                bSave.Visible = true;
                txtMax.Text = dataGridView2.SelectedRows[0].Cells["Max"].Value.ToString();
            }
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count == 1)
            {
                string msg = "Bạn có chắc chắn muốn xóa, những lịch hẹn đã đặt sẽ bị hủy ?";
                string Title = "Xác nhận";
                DialogResult d = MessageBox.Show(msg, Title, MessageBoxButtons.OKCancel);
                if (d == DialogResult.OK)
                {
                    BLL_QLCD.Instance.Del_FreeTime(Convert.ToInt32(dataGridView2.SelectedRows[0].Cells["ID"].Value));
                    MessageBox.Show("Xóa thành công");
                    GUI(c.ID_CQTQ);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            string msg = "Bạn có chắc chắn lưu thời gian này, những lịch hẹn đã đặt sẽ bị hủy ?";
            string Title = "Xác nhận";
            DialogResult d = MessageBox.Show(msg, Title, MessageBoxButtons.OKCancel);
            if (d == DialogResult.OK && begin.Value.TimeOfDay < end.Value.TimeOfDay && txtMax.Text != null) 
            {
                FreeTime f = new FreeTime
                {
                    ID_CQTQ = c.ID_CQTQ,
                    Start_time = begin.Value.TimeOfDay,
                    End_time = end.Value.TimeOfDay,
                    Max_per = Convert.ToInt32(txtMax.Text)
                };
                BLL_QLCD.Instance.Edit_FreeTime(a, f);
                MessageBox.Show("Lưu thành công");
                panel1.Visible = false;
                bAdd.Visible = true;
                bSave.Visible = false;
                GUI(c.ID_CQTQ);
            }
        }

        private void cbbTG_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbTG.SelectedItem != null)
            {
                dataGridView1.DataSource = BLL_QLCD.Instance.ToView_Lichhen(BLL_QLCD.Instance.GetLichhenbyIDCQTQKG(dateTimePicker1.Value.Date, 
                    cbbTG.SelectedItem.ToString(), c.ID_CQTQ));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Width < 1235)
            {
                dataGridView1.Width = 1235;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                panel2.Visible = false;
            }    
            else
            {
                panel2.Visible = true;
                dataGridView1.Width = 930;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            }    
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            cbbTG.SelectedItem = null;
            dataGridView1.DataSource = null;
        }
    }
}
