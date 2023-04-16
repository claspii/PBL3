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
    public partial class Request_CDVN : Form
    {
        public delegate void Mydel();
        public Mydel d1 { get;set;}
        private CDVN current;
        public Request_CDVN(string ID_CD)
        {
            InitializeComponent();
            current = BLL_QLCD.Instance.GetCDVNbyID(ID_CD);
            GUI(ID_CD);
        }
        public void GUI(string ID)
        {
            cbbTT.Items.AddRange(BLL_QLCD.Instance.GetCBBDiaChibyID(ID).Distinct().ToArray());
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbTitle.SelectedItem != null)
            {
                cbbCQTQ.Items.Clear();
                cbbCQTQ.Items.AddRange(BLL_QLCD.Instance.GetCQTQbyNV(cbbTitle.SelectedItem.ToString()).ToArray());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string msg = "Bạn có chắc chắn gửi yêu cầu này?";
            string title = "Xác nhận gửi yêu cầu";
            MessageBoxButtons b = MessageBoxButtons.OKCancel;
            DialogResult d = MessageBox.Show(msg, title, b);
            if (d == DialogResult.OK)
            {
                if (BLL_QLCD.Instance.GetIDCQTQbyNameTT(cbbCQTQ.Text, cbbTT.Text) != null && cbbCQTQ.SelectedItem != null && cbbTT.SelectedItem != null)
                {
                    if (BLL_QLCD.Instance.Check_ExistsYeuCau(current.ID_CD, cbbTitle.SelectedItem.ToString()))
                    {
                        MessageBox.Show("Bạn đã gửi yêu cầu này, vui lòng chờ đợi để được xử lý");
                        return;
                    }
                    Yeucau y = new Yeucau
                    {
                        Title = cbbTitle.SelectedItem.ToString(),
                        ND = textBox1.Text,
                        Date_sent = DateTime.Now,
                        ID_1 = current.ID_CD,
                        ID_2 = BLL_QLCD.Instance.GetIDCQTQbyNameTT(cbbCQTQ.Text, cbbTT.Text)
                    };
                    BLL_QLCD.Instance.Add_request(y);
                    MessageBox.Show("Gửi yêu cầu thành công");
                    d1();
                }
                else
                {
                    MessageBox.Show("Gửi yêu cầu thất bại");
                    return;
                }
            }
            else
            {
                return;
            }
        }
    }
}
