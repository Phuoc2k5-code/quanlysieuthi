using Project_QliSieuThi.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Project_QliSieuThi.PL
{
    public partial class fViewInfoGoods : Form
    {

        public fViewInfoGoods(SanPham sanPham)
        {
            InitializeComponent();
            loadInfoSanPham(sanPham);
        }

        public fViewInfoGoods()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Hàm load thông tin sản phẩm
        /// </summary>
        /// <param name="sanPham"></param>
        private void loadInfoSanPham(SanPham sanPham)
        {
            lbl_tt_MaSP.Text = sanPham.MaSP.ToString();
            lbl_tt_TenSP.Text = sanPham.TenSP;
            lbl_tt_MaLSP.Text = sanPham.MaLoaiSP.ToString();
            lbl_tt_SoLuong.Text = sanPham.SoLuong.ToString();
            lbl_tt_DonGiaNhap.Text = sanPham.DonGiaNhap.ToString();
            lbl_tt_DonGiaBan.Text = sanPham.DonGiaBan.ToString();


        }

    }
}
