using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_QliSieuThi.BLL;

namespace Project_QliSieuThi
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void btnViewPass_Click(object sender, EventArgs e)
        {
            txt_lg_MatKhau.UseSystemPasswordChar = !txt_lg_MatKhau.UseSystemPasswordChar;
            if (txt_lg_MatKhau.UseSystemPasswordChar)
            {
                btn_lg_ViewPass.Text = "Hiện mật khẩu";
            }
            else
            {
                btn_lg_ViewPass.Text = "Ẩn mật khẩu";
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn thật sự muốn thoát chương trình? ","Thông báo",MessageBoxButtons.OKCancel,MessageBoxIcon.Question)!=System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            fManager fManager = new fManager();
            ManagementLogic logic = new ManagementLogic();
            string taiKhoan = txt_lg_TaiKhoan.Text;
            string matKhau = txt_lg_MatKhau.Text;

            if (logic.)
            {
                //this.Hide();
                fManager.ShowDialog();
                //this.Show();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
