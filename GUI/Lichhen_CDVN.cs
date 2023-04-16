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
    public partial class Lichhen_CDVN : Form
    {
        private CDVN current;
        public delegate void Mydel(Form childForm);
        public Mydel d { get; set; }
        public void Reload()
        {
            this.Visible = true;
            dataGridView1.DataSource = BLL_QLCD.Instance.ToView_Lichhen(BLL_QLCD.Instance.GetAllLichhen(current.ID_CD));
        }    
        public Lichhen_CDVN(string ID)
        {
            current = BLL_QLCD.Instance.GetCDVNbyID(ID);
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Edit_lichhen ed = new Edit_lichhen(current.ID_CD);
            ed.d += this.Reload;
            d(ed);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                Edit_lichhen ed = new Edit_lichhen(dataGridView1.SelectedRows[0].Cells["ID"].Value.ToString());
                ed.d += this.Reload;
                d(ed);
            }        
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Reload();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                string msg = "Bạn có muốn hủy lịch hẹn này ?";
                string Title = "Xác nhận";
                DialogResult d = MessageBox.Show(msg, Title, MessageBoxButtons.OKCancel);
                if (d == DialogResult.OK)
                {
                    BLL_QLCD.Instance.Del_Lichhen(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value));
                    MessageBox.Show("Thành công");
                    Reload();
                }
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLL_QLCD.Instance.ToView_Lichhen(BLL_QLCD.Instance.GetLichhenbyTime(dateTimePicker1.Value));
        }
    }
}
