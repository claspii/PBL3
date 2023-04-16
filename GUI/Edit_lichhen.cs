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
    public partial class Edit_lichhen : Form
    {
        public delegate void Mydel();
        public Mydel d { get; set; }
        private int ID_Noti;
        private string ID_CD;
        private string ID_CQTQ;
        public void SetCBBItem(ComboBox c, string txt)
        {
            foreach (object s in c.Items)
            {
                if (s.ToString() == txt)
                {
                    c.SelectedItem = s;
                    return;
                }
            }
        }
        public Edit_lichhen(string ID)
        {
            InitializeComponent();
            GUI(ID);
        }
        public void GUI(string ID)
        {
            if (BLL_QLCD.Instance.GetCDVNbyID(ID) != null)
            {
                ID_CD = ID;
                button2.Enabled = false;
                cbbTT.Items.AddRange(BLL_QLCD.Instance.GetCBBDiaChibyID(ID_CD).Distinct().ToArray());
                cbbCQTQ.Items.AddRange(BLL_QLCD.Instance.GetAllNameCQTQ().ToArray());
            }
            else
            {
                ID_Noti = Convert.ToInt32(ID);
                button3.Enabled = false;
                Lichhen l = BLL_QLCD.Instance.GetLichhenbyID(ID);
                ID_CD = l.ID_CD;
                ID_CQTQ = l.ID_CQTQ;
                cbbTG.Items.AddRange(BLL_QLCD.Instance.GetCBBTG(ID_CQTQ).ToArray());
                cbbTT.Items.AddRange(BLL_QLCD.Instance.GetCBBDiaChibyID(ID_CD).Distinct().ToArray());
                cbbCQTQ.Items.AddRange(BLL_QLCD.Instance.GetAllNameCQTQ().ToArray());
                txtND.Text = l.Title;
                SetCBBItem(cbbCQTQ, l.CQTQ.Name_CQTQ);
                SetCBBItem(cbbTT, l.CQTQ.TT);
                dateTimePicker1.Value = l.Date_hen.Value;
                SetCBBItem(cbbTG, l.Time);
            }
            
        }
        public bool Check_valid_date()
        {
            if ((dateTimePicker1.Value.Date - DateTime.Now.Date).Days <= 7 && (dateTimePicker1.Value.Date - DateTime.Now.Date).Days >= 1 && dateTimePicker1.Value.DayOfWeek != DayOfWeek.Sunday)
                return true;
            else return false;
        }
        private void cbbCQTQ_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cbbTG.Items.Clear();
            if (cbbCQTQ.SelectedItem != null && cbbTT.SelectedItem != null)
            {
                string ID = BLL_QLCD.Instance.GetIDCQTQbyNameTT(cbbCQTQ.SelectedItem.ToString(), cbbTT.SelectedItem.ToString());
                if (ID != null)
                {
                    cbbTG.Items.AddRange(BLL_QLCD.Instance.GetCBBTG(ID).ToArray());
                    ID_CQTQ = ID;
                }
            }                                
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!(Check_valid_date()))
            {
                MessageBox.Show("Ngày hẹn không hợp lệ, vui lòng chọn lại");
                return;
            }                 
            if (cbbTG.SelectedItem != null)
            {
                string msg = "Bạn có muốn thêm lịch hẹn này ?";
                string Title = "Xác nhận";
                DialogResult d = MessageBox.Show(msg, Title, MessageBoxButtons.OKCancel);
                if (d == DialogResult.OK)
                {
                    if (BLL_QLCD.Instance.Check_Empty_Time(dateTimePicker1.Value.Date, cbbTG.SelectedItem.ToString(), ID_CQTQ,
                        Convert.ToInt32(((CBBItem)cbbTG.SelectedItem).Value)))
                    {
                        Lichhen l = new Lichhen
                        {
                            ID_CQTQ = ID_CQTQ,
                            ID_CD = ID_CD,
                            TG = DateTime.Now,
                            Time = cbbTG.SelectedItem.ToString(),
                            Date_hen = dateTimePicker1.Value.Date,
                            Title = txtND.Text
                        };
                        BLL_QLCD.Instance.Add_Edit_Lichhen(l, 0);
                        MessageBox.Show("Thêm lịch hẹn thành công");
                        bExit.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("Lịch hẹn thời gian này đã đầy");
                        return;
                    }    
                }    
            }
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            d();
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!(Check_valid_date()))
            {
                MessageBox.Show("Ngày hẹn không hợp lệ, vui lòng chọn lại");
                return;
            }
            if (cbbTG.SelectedItem != null)
            {
                string msg = "Bạn có muốn lưu lịch hẹn này ?";
                string Title = "Xác nhận";
                DialogResult d = MessageBox.Show(msg, Title, MessageBoxButtons.OKCancel);
                if (d == DialogResult.OK)
                {
                    if (BLL_QLCD.Instance.Check_Empty_Time(dateTimePicker1.Value.Date, cbbTG.SelectedItem.ToString(), ID_CQTQ,
                        Convert.ToInt32(((CBBItem)cbbTG.SelectedItem).Value)))
                    {
                        Lichhen l = new Lichhen
                        {
                            ID_CQTQ = ID_CQTQ,
                            ID_CD = ID_CD,
                            TG = DateTime.Now,
                            Time = cbbTG.SelectedItem.ToString(),
                            Date_hen = dateTimePicker1.Value.Date,
                            Title = txtND.Text
                        };
                        BLL_QLCD.Instance.Add_Edit_Lichhen(l, ID_Noti);
                        MessageBox.Show("Thay đổi lịch hẹn thành công");
                        bExit.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("Lịch hẹn thời gian này đã đầy");
                        return;
                    }
                }
            }
        }
    }
}
