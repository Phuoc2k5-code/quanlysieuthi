using Project_QliSieuThi.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Project_QliSieuThi.PL
{
    public partial class fAddTypeGoods : Form
    {
        public fAddTypeGoods()
        {
            InitializeComponent();
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            string tenlsp = txt_LoaiMoi.Text;
            ManagementLoaiSanPham managementLoaiSanPham = new ManagementLoaiSanPham();
            int check = managementLoaiSanPham.InsertTypeGoods(tenlsp);
            if (check == 1)
            {
                fTypeGoods fTypeGoods = new fTypeGoods();
                MessageBox.Show("Them thành công");
                fTypeGoods.loadListLoaiSanPham();               
            }
            else
                MessageBox.Show("Them thất bại");

            Close();
        }

        private void fAddTypeGoods_Load(object sender, EventArgs e)
        {

        }
    }
}
