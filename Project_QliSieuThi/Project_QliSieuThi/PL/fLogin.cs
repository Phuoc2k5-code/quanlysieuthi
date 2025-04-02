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

        private void BtnViewPass_Click(object sender, EventArgs e)
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

        /// <summary>
        /// Hàm xử lý sự kiện khi đóng chương trình 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn thật sự muốn thoát chương trình? ","Thông báo",MessageBoxButtons.OKCancel,MessageBoxIcon.Question)!=System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        /// <summary>
        /// Hàm xử lý sự kiện khi nhấn nút Đăng nhập
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_lg_Login_Click(object sender, EventArgs e)
        {
            string taiKhoan = txt_lg_TaiKhoan.Text;
            string matKhau = txt_lg_MatKhau.Text;
                       
            ManagementLogic logic = new ManagementLogic();

            if (taiKhoan == "" || matKhau == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (/*true*/logic.checkLogin(taiKhoan, matKhau))
                {
                    fManager f = new fManager();
                    this.Hide();
                    f.ShowDialog();

                    //reset lại thông tin tài khoản và mật khẩu
                    txt_lg_TaiKhoan.Text= "";
                    txt_lg_MatKhau.Text = "";

                    this.Show();
                }
                else
                {
                    MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            

        }


        /// <summary>
        /// Hàm xử lý sự kiện khi nhấn Enter trong ô mật khẩu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_lg_MatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_lg_Login.PerformClick();
            }
        }
    }
}
