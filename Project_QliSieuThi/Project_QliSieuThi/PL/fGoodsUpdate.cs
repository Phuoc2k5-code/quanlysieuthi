using Project_QliSieuThi.DTO;
using Project_QliSieuThi.BLL;
using Project_QliSieuThi.DAL;
using Project_QliSieuThi.PL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Project_QliSieuThi.PL
{
    public partial class fGoodsUpdate : Form
    {
        public fGoodsUpdate()
        {
            InitializeComponent();
        }
        public fGoodsUpdate(SanPham sanPham)
        {
            InitializeComponent();
            loadInfoSanPham(sanPham);
        }
        private void loadInfoSanPham(SanPham sanPham)
        {
            txt_MaSP.Text = sanPham.MaSP.ToString();
            txt_TenSP.Text = sanPham.TenSP;
            txt_MaLoai.Text = sanPham.MaLoaiSP.ToString();
            txt_SoLuong.Text = sanPham.SoLuong.ToString();
            txt_DonGiaNhap.Text = sanPham.DonGiaNhap.ToString();
            txt_DonGiaBan.Text = sanPham.DonGiaBan.ToString();
        }
        private void btn_Ok_Click(object sender, EventArgs e)
        {
            fManager fManager = new fManager();
            int masp = Convert.ToInt32(txt_MaSP.Text);
            string tensp = txt_TenSP.Text;
            int malsp = Convert.ToInt32(txt_MaLoai.Text);
            int sl = Convert.ToInt32(txt_SoLuong.Text);
            int dongiaban = Convert.ToInt32(txt_DonGiaBan.Text);
            int dongianhap = Convert.ToInt32(txt_DonGiaNhap.Text);
            ManagementSanPham managementsanpham = new ManagementSanPham();
            int check = managementsanpham.UpdateGoods(tensp, malsp, sl, dongiaban, dongianhap, masp);
            if (check == 1)
            {
                MessageBox.Show("thành công");               
                this.Hide();
                fManager.loadListSanPham();
                fManager.ShowDialog();
            }
            else
            {
                MessageBox.Show(" ko thành công");
            }
            Close();
        }
    }
}
