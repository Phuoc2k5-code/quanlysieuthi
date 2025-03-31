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
    public partial class fUpdateTypeGoods : Form
    {
        public fUpdateTypeGoods(LoaiSanPham loaiSanPham)
        {
            InitializeComponent();
            loadInfoLoaiSanPham(loaiSanPham);
        }         
        public fUpdateTypeGoods()
        {
            InitializeComponent();
        }       
        
        private void loadInfoLoaiSanPham(LoaiSanPham loaiSanPham)
        {
            txt_malsp.Text = loaiSanPham.MaLoai.ToString();
            txt_tenlsp.Text = loaiSanPham.TenLoai.ToString();
        }

        private void btn_Ok_Click_1(object sender, EventArgs e)
        {
            int malsp = Convert.ToInt32(txt_malsp.Text);
            string tenlsp = txt_tenlsp.Text;
            ManagementLoaiSanPham managementLoaiSanPham = new ManagementLoaiSanPham();
            int check = managementLoaiSanPham.UpdateTypeGoods(tenlsp, malsp);
            if (check == 1)
            {
                fTypeGoods fTypeGoods = new fTypeGoods();
                MessageBox.Show("Sửa thành công");
                fTypeGoods.loadListLoaiSanPham();
                //fTypeGoods.ShowDialog();
                Close();
            }
            else
                MessageBox.Show("Sửa thất bại");

            Close();
        }

        private void fUpdateTypeGoods_Load(object sender, EventArgs e)
        {

        }
    }
}
