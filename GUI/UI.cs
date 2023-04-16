using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using PBL3.BLL;
using PBL3.DTO;

namespace PBL3.GUI
{
    public partial class UI : Form
    {
            
        private Account acc;
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        //Constructor
        public UI()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;         
            login_screen f = new login_screen();
            f.Show();
            f.d += this.Reload;
            Reset();
        }
        private void Reload(Account a)
        {
            if (a.account_type == 3)
                bSearch.Text = "Quản lý công dân";
            acc = a;
            this.ShowInTaskbar = true;
            this.WindowState = FormWindowState.Normal;
            if (a.account_type == 2 && BLL_QLCD.Instance.Check_newNoti(a.username))
            {
                bNoti.ForeColor = Color.Red;
                bNoti.IconColor = Color.Red;
            }
            if (a.account_type == 1)
            {
                this.Visible = false;
                this.ShowInTaskbar = false;
                AdminForm f = new AdminForm();
                f.Show();
            }    
        }
        //Structs
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }
        //Methods
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Current Child Form Icon
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.White;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Dispose();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleChildForm.Text = childForm.Text;
        }
        private void OpenChildForm1(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Hide();
            }
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleChildForm.Text = childForm.Text;
        }
        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.MediumPurple;
            lblTitleChildForm.Text = "Home";
            OpenChildForm(new Home());
        }
        private void bHome_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            Reset();
        }
       
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void iconPictureBox2_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void iconPictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormMainMenu_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                FormBorderStyle = FormBorderStyle.None;
            else
                FormBorderStyle = FormBorderStyle.Sizable;
        }

        private void bInfo_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            if (acc.account_type == 2)
                OpenChildForm(new main_screen2(acc));
            else if (acc.account_type == 3)
                OpenChildForm(new main_screen3(acc));
        }

        private void bSearch_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            if (acc.account_type == 2)
            {
                Info_CDVN f = new Info_CDVN(BLL_QLCD.Instance.GetCDVNbyID(acc.username).ID_Chuho);
                f.d += this.OpenChildForm1;
                OpenChildForm(f);
            }
            else
            {
                Info_CQTQ f = new Info_CQTQ(BLL_QLCD.Instance.GetLDVNbyID(acc.username));
                OpenChildForm(f);
                f.d += this.OpenChildForm1;
            }
        }

        private void bHen_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            if (acc.account_type == 2)
            {
                Lichhen_CDVN f = new Lichhen_CDVN(acc.username);
                f.d += this.OpenChildForm1;
                OpenChildForm(f);
            }
            else
            {
                Lichhen_CQTQ f = new Lichhen_CQTQ(BLL_QLCD.Instance.GetLDVNbyID(acc.username));
                OpenChildForm(f);
            }
        }

        private void bNoti_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            if (acc.account_type == 2)
            {
                if (BLL_QLCD.Instance.Check_newNoti(acc.username))
                {
                    bNoti.IconColor = Color.White;
                    bNoti.ForeColor = Color.White;
                    BLL_QLCD.Instance.Seen_Noti(acc.username);
                }            
                OpenChildForm(new noti_CDVN(acc.username));
            }
            else
            {
                noti_CQTQ f = new noti_CQTQ(BLL_QLCD.Instance.GetLDVNbyID(acc.username));
                f.dlg += this.Reset;
                OpenChildForm(f);
                
            }
        }

        private void bRequest_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            if (acc.account_type == 2)
            {
                Request_CDVN f = new Request_CDVN(acc.username);
                f.d1 += this.Reset;
                OpenChildForm(f);
            }
            else
            {
                OpenChildForm(new Request_CQTQ(BLL_QLCD.Instance.GetLDVNbyID(acc.username)));
            }
        }

        private void bYkien_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            if (acc.account_type == 2)
            {
                Ykien_CDVN f = new Ykien_CDVN(acc.username);
                OpenChildForm(f);
            }
            else
            {
                Ykien_CQTQ f = new Ykien_CQTQ(BLL_QLCD.Instance.GetLDVNbyID(acc.username));
                OpenChildForm(f);
            }
        }
        private void bChangePassword_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            change_password f = new change_password(acc);
            f.d += this.Reset;
            OpenChildForm(f);

        }

        private void bExit_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            CollapseMenu();
        }
        private void CollapseMenu()
        {
            if (this.panelMenu.Width > 200) //Collapse menu
            {
                panelMenu.Width = 100;
                this.Width -= 145;
                bHome.Visible = false;
                iconButton1.Dock = DockStyle.Top;
                foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "";
                    menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                    menuButton.Padding = new Padding(0);
                }
            }
            else
            { //Expand menu
                panelMenu.Width = 245;
                this.Width += 145;
                bHome.Visible = true;
                iconButton1.Dock = DockStyle.Right;
                foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "   " + menuButton.Tag.ToString();
                    menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                    menuButton.Padding = new Padding(10, 0, 0, 0);
                }
            }
        }
    }
}
