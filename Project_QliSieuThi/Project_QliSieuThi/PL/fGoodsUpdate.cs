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
using System.IO;

namespace Project_QliSieuThi.PL
{
    public partial class fGoodsUpdate : Form
    {
        //<kietbeve>
        string thuMucAnh = Path.Combine(Application.StartupPath, "Images");//lay duong dan toi file Images
        string linkAnh = "";//luu link danh dang mo
        string tenFileAnh = "";// luu ten file anh dang mo
        static ManagementLogic logic = new ManagementLogic();
        QuanLi quanLi = logic.getInfoQuanLi();//lay thong tin quan li
        //</kietbeve>
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
            ptb_AnhSP.Image = Image.FromFile(thuMucAnh + "\\" + sanPham.Anh);
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
            //<kietbeve>
            if (!File.Exists(thuMucAnh + "\\" + tenFileAnh))
            {
                File.Copy(linkAnh, thuMucAnh + "\\" + tenFileAnh, true);//tenlinl_anh_dc_copy,ten file dc luu 
            }
            //</kietbeve>
            ManagementSanPham managementsanpham = new ManagementSanPham();
            int check = managementsanpham.UpdateGoods(tensp, malsp, sl, dongiaban, dongianhap, masp,tenFileAnh);
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

        private void btn_TaiAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            //string thuMucAnh = Path.Combine(Application.StartupPath, "kietbeve_Images");//lay duong dan toi file kietbeve_Images
            ofd.ShowDialog();
            linkAnh = ofd.FileName;
            tenFileAnh = Path.GetFileName(ofd.FileName);//lay ten file anh
            //tenFileAnh =quanLi.Anh;
            //txt_test.Text = tenFileAnh;
            ptb_AnhSP.Image = Image.FromFile(ofd.FileName);
            // Tao thu muc kietbeve_Images neu chua ton tai
            if (!Directory.Exists(thuMucAnh))//ktra ton tai cua file kietbeve_Images
            {
                Directory.CreateDirectory(thuMucAnh);
            }
        }

        private void fGoodsUpdate_Load(object sender, EventArgs e)
        {

        }
    }
}
