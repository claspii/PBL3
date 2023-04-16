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
    public partial class Map : Form
    {
        public delegate void Mydel(string txt);
        public Mydel d { get; set; }
        public Map()
        {
            InitializeComponent();
            cbbTP.Items.AddRange(BLL_QLCD.Instance.GetCBBItems("TP", "").ToArray());
        }

        private void cbbTP_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbQH.Items.Clear();
            cbbPX.Items.Clear();
            cbbQH.Items.AddRange(BLL_QLCD.Instance.GetCBBItems("QH", cbbTP.SelectedItem.ToString()).ToArray());
        }

        private void cbbQH_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbPX.Items.Clear();
            cbbPX.Items.AddRange(BLL_QLCD.Instance.GetCBBItems("PX", cbbQH.SelectedItem.ToString()).ToArray());
        }

        private void bOK_Click(object sender, EventArgs e)
        {
            if (cbbTP.SelectedItem != null)
            {
                if (cbbQH.SelectedItem != null)
                {
                    if (cbbPX.SelectedItem != null)
                        d(cbbPX.SelectedItem.ToString());
                    else
                        d(cbbQH.SelectedItem.ToString());
                }
                else
                    d(cbbTP.SelectedItem.ToString());
                this.Dispose();
            }
        }
    }
}
