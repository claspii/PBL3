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
    public partial class Thongke_CQTQ : Form
    {
        public delegate void Mydel();
        public Mydel d { get; set; }
        private List<CDVN> li;
        private CQTQ current;
        public Thongke_CQTQ(List<CDVN> list, string ID)
        {
            current = BLL_QLCD.Instance.GetCQTQbyID(ID);
            li = list;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                if (comboBox1.SelectedItem.ToString() == "Độ tuổi, tình trạng hôn nhân" && textBox2.Text != "" && textBox3.Text != "")
                {
                    int min = Convert.ToInt32(textBox2.Text);
                    int max = Convert.ToInt32(textBox3.Text);
                    if (min < max && comboBox2.SelectedIndex == 0)
                        dataGridView1.DataSource = BLL_QLCD.Instance.ToView_CDVN(BLL_QLCD.Instance.GetListCDVNbyAgeTTHN(li, min, max, ""));
                    else if (min < max && comboBox2.SelectedIndex != 0)
                        dataGridView1.DataSource = BLL_QLCD.Instance.ToView_CDVN(BLL_QLCD.Instance.GetListCDVNbyAgeTTHN(li, min, max, comboBox2.SelectedItem.ToString()));
                }
                else if (comboBox1.SelectedItem.ToString() == "Số liệu đi nghĩa vụ quân sự")
                    dataGridView1.DataSource = BLL_QLCD.Instance.ToView_CDVN(BLL_QLCD.Instance.GetListCDVNbyAgeTTHN(li, 18, 25, ""));
                else if (comboBox1.SelectedItem.ToString() == "Số người trong độ tuổi lao động")
                    dataGridView1.DataSource = BLL_QLCD.Instance.ToView_CDVN(BLL_QLCD.Instance.GetListCDVNbyDTLD(li));
                else if (comboBox1.SelectedItem.ToString() == "Tình hình tội phạm")
                    dataGridView1.DataSource = BLL_QLCD.Instance.ToView_CDVN(BLL_QLCD.Instance.GetListCDVNbyTHTP(li)); 
                else if (comboBox1.SelectedItem.ToString() == "Ý kiến đóng góp")
                    dataGridView1.DataSource = BLL_QLCD.Instance.ToView_Ykien(BLL_QLCD.Instance.GetListYkien(li, current.ID_CQTQ));
            }
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            d();
            this.Dispose();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                if (comboBox1.SelectedItem.ToString() == "Độ tuổi, tình trạng hôn nhân")
                {
                    panel1.Visible = true;
                    comboBox2.SelectedIndex = 0;
                }
                else
                {
                    panel1.Visible = false;
                }
                    
            }
        }
    }
}
