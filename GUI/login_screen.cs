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
using System.IO;
using PBL3.BLL;
using System.Runtime.InteropServices;

namespace PBL3.GUI
{

    public partial class login_screen : Form
    {
        public delegate void Mydel(Account a);
        public Mydel d { get; set; }
        public Account acc;

        public login_screen()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        public void rerun()
        {
            this.Show();
            userControl11.UserName = "";
            userControl11.Password = "";
        }

        public void login_succeeded()
        {
            d(acc);
            this.Dispose();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (BLL_QLCD.Instance.check_valid_username(userControl11.UserName) && BLL_QLCD.Instance.check_valid_password(userControl11.Password))
            {
                if (BLL_QLCD.Instance.Login(userControl11.UserName, userControl11.Password) != null)
                {
                    acc = BLL_QLCD.Instance.Login(userControl11.UserName, userControl11.Password);
                    MessageBox.Show("Đăng nhập thành công");
                    login_succeeded();
                    return;
                }
                MessageBox.Show("Đăng nhập thất bại, tài khoản hoặc mật khẩu bạn nhập sai");
            }
            else if (!BLL_QLCD.Instance.check_valid_username(userControl11.UserName))
            {
                MessageBox.Show("Tài khoản bạn nhập không hợp lệ");
            }
            else if (!BLL_QLCD.Instance.check_valid_password(userControl11.Password))
            {
                MessageBox.Show("Mật khẩu bạn nhập không hợp lệ");
            }  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void iconButton1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void login_screen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }
    }
}
