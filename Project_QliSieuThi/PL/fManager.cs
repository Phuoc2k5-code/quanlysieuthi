using Project_QliSieuThi.BLL;
using Project_QliSieuThi.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_QliSieuThi
{
    public partial class fManager : Form
    {

        public fManager()
        {
            InitializeComponent();
        }
        private void fManager_Load(object sender, EventArgs e)
        {
            loadInforUser();
        }
        public void loadInforUser()
        {
            //ham laod thong tin quan li
            lbl_tttk_MaNqLi.Text = UserInfo.maQl;
            lbl_tttk_TenNqLi.Text= UserInfo.tenQl;
            lbl_tttk_TenTK.Text = UserInfo.tenTk;
            lbl_tttk_Mk.Text = UserInfo.matKhau;
            lbl_tttk_NgaySinh.Text = UserInfo.ngaySinh;
            lbl_tttk_Sdt.Text = UserInfo.sdt;
        }

        
        private void btn_qlnv_XemChiTiet_Click(object sender, EventArgs e)
        {
            fViewInfoNhanVien fViewInfoNhanVien = new fViewInfoNhanVien();
            fViewInfoNhanVien.ShowDialog();
        }

        private void btn_qlsp_XemChiTiet_Click(object sender, EventArgs e)
        {
            fViewInfoGoods fViewInfoGoods = new fViewInfoGoods();
            fViewInfoGoods.ShowDialog();
        }

        private void btn_qlsp_NhapHang_Click(object sender, EventArgs e)
        {
            fImportGoods fImportGoods = new fImportGoods();
            this.Hide();
            fImportGoods.ShowDialog();
            this.Show();
        }

        private void btn_qlsp_SuaSanPham_Click(object sender, EventArgs e)
        {
            fGoodsUpdate fGoodsUpdate = new fGoodsUpdate();
            fGoodsUpdate.ShowDialog();
        }

        private void btn_qlnv_SuaNhanVien_Click(object sender, EventArgs e)
        {
            fStaffUpdate fStaffUpdate = new fStaffUpdate();
            fStaffUpdate.ShowDialog();
        }

        private void btn_qlsp_LoaiSanPham_Click(object sender, EventArgs e)
        {
            fTypeGoods fTypeGoods = new fTypeGoods();
            this.Hide();
            fTypeGoods.ShowDialog();
            this.Show();
        }

        private void btn_qlnv_LoaiNhanVien_Click(object sender, EventArgs e)
        {
            fJobStaff fJobStaff = new fJobStaff();
            this.Hide();
            fJobStaff.ShowDialog();
            this.Show();
        }

        private void btn_qlnv_ThemNhanVien_Click(object sender, EventArgs e)
        {
            fAddStaff fAddStaff = new fAddStaff();
            fAddStaff.ShowDialog();
        }

        private void btn_qlsp_XoaHang_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chưa chọn mặt hàng!", "Cảnh báo!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }

        private void btn_qlnv_XoaNhanVien_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chưa chọn nhân viên!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
