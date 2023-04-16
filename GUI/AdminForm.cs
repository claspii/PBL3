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
    public partial class AdminForm : Form
    {
        private int state;
        public AdminForm()
        {
            InitializeComponent();
            this.ControlBox = false;
        }
        public void Reload()
        {
            this.Show();
            if (state == 2)
                dataGridView1.DataSource = BLL_QLCD.Instance.ToView_LDVN(BLL_QLCD.Instance.GetAllLDVN());
            else if (state == 3)
                dataGridView1.DataSource = BLL_QLCD.Instance.ToView_CQTQ(BLL_QLCD.Instance.GetAllCQTQ());
        }
        private void button1_Click(object sender, EventArgs e)
        {
            bAdd.Visible = false;
            bEdit.Visible = false;
            bDel.Visible = false;
            dataGridView1.DataSource = BLL_QLCD.Instance.ToView_Account(BLL_QLCD.Instance.GetListAcc());
            state = 1;
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (state == 1 && dataGridView1.SelectedRows.Count == 1)
            {
                if (BLL_QLCD.Instance.GetCDVNbyID(dataGridView1.SelectedRows[0].Cells["CMND"].Value.ToString()) != null)
                {
                    Edit_tt f = new Edit_tt(dataGridView1.SelectedRows[0].Cells["CMND"].Value.ToString(), 1);
                    f.d += this.Reload;
                    this.Hide();
                    f.Show();
                }
                else if (BLL_QLCD.Instance.GetLDVNbyID(dataGridView1.SelectedRows[0].Cells["CMND"].Value.ToString()) != null)
                {
                    TT_LDVN f = new TT_LDVN(dataGridView1.SelectedRows[0].Cells["CMND"].Value.ToString(), 0);
                    f.d += this.Reload;
                    this.Hide();
                    f.Show();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bAdd.Visible = true;
            bEdit.Visible = true;
            bDel.Visible = true;
            dataGridView1.DataSource = BLL_QLCD.Instance.ToView_LDVN(BLL_QLCD.Instance.GetAllLDVN());
            state = 2;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bAdd.Visible = false;
            bEdit.Visible = false;
            bDel.Visible = false;
            dataGridView1.DataSource = BLL_QLCD.Instance.ToView_Ykien(BLL_QLCD.Instance.GetListYkienbyIDCQTQ("0"));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            state = 3;
            bAdd.Visible = true;
            bEdit.Visible = true;
            bDel.Visible = true;
            dataGridView1.DataSource = BLL_QLCD.Instance.ToView_CQTQ(BLL_QLCD.Instance.GetAllCQTQ());
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            if (state == 2)
            {
                TT_LDVN f = new TT_LDVN("0", 1);
                f.d += this.Reload;
                this.Hide();
                f.Show();
            }    
            else if (state == 3)
            {
                Edit_CQTQ f = new Edit_CQTQ("0");
                f.d += this.Reload;
                this.Hide();
                f.Show();
            }    
            
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1 && state == 2)
            {
                TT_LDVN f = new TT_LDVN(dataGridView1.SelectedRows[0].Cells["CMND"].Value.ToString(), 1);
                f.d += this.Reload;
                this.Hide();
                f.Show();
            }
            else if (dataGridView1.SelectedRows.Count == 1 && state == 3)
            {
                Edit_CQTQ f = new Edit_CQTQ(dataGridView1.SelectedRows[0].Cells["ID"].Value.ToString());
                f.d += this.Reload;
                this.Hide();
                f.Show();
            }
        }

        private void bDel_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1 && state == 2)
            {
                string msg = "Chắc chắn xóa tài khoản này ?";
                string Title = "Xác nhận";
                DialogResult d = MessageBox.Show(msg, Title, MessageBoxButtons.OKCancel);
                if (d == DialogResult.OK)
                {
                    BLL_QLCD.Instance.Del_LD(dataGridView1.SelectedRows[0].Cells["CMND"].Value.ToString());
                    MessageBox.Show("Xóa tài khoản thành công");
                    Reload();
                }    

            }
            else if (dataGridView1.SelectedRows.Count == 1 && state == 3)
            {
                string msg = "Chắc chắn xóa cơ quan này ?";
                string Title = "Xác nhận";
                DialogResult d = MessageBox.Show(msg, Title, MessageBoxButtons.OKCancel);
                if (d == DialogResult.OK)
                {
                    BLL_QLCD.Instance.Del_CQTQ(dataGridView1.SelectedRows[0].Cells["ID"].Value.ToString());
                    MessageBox.Show("Xóa cơ quan thành công");
                    Reload();
                }
            }
        }
    }
}
