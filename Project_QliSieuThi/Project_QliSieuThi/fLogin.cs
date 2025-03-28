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
using Project_QliSieuThi.DAL;

namespace Project_QliSieuThi
{
    public partial class fLogin : Form
    {
        public UserManager userManager = new UserManager();
        public fLogin()
        {
            InitializeComponent();
        }

        private void btnViewPass_Click(object sender, EventArgs e)
        {
            //Ham xem mat khau
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
            //Ham nut thoat ung dung
            Application.Exit();
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Ham thong bao khi thoat
            if (MessageBox.Show("Bạn thật sự muốn thoát chương trình? ","Thông báo",MessageBoxButtons.OKCancel,MessageBoxIcon.Question)!=System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Ham xu li danh nhap
            if (txt_lg_TaiKhoan.Text==""||txt_lg_MatKhau.Text=="")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (userManager.checkLogin(txt_lg_TaiKhoan.Text, txt_lg_MatKhau.Text))
                {
                    userManager.userInfo(txt_lg_TaiKhoan.Text, txt_lg_MatKhau.Text);

                    fManager fManager = new fManager();
                    this.Hide();
                    fManager.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
           
        }

        private void txt_lg_MatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            //An nut Enter tai dong nhap mat khau se thay cho nut Dang nhap
            if (e.KeyCode == Keys.Enter)
            {
                
                btn_lg_Login.PerformClick();
            }
        }

    }
}
