﻿//using Project_QliSieuThi.bll;
//using Project_QliSieuThi.data_object;
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

namespace Project_QliSieuThi
{
    public partial class fManager : Form
    {
        //<kietbeve>
        string thuMucAnh = Path.Combine(Application.StartupPath, "Images");//lay duong dan toi file kietbeve_Images
        string linkAnh = "";
        string tenFileAnh = "";
        //</kietbeve>
        public fManager()
        {
            InitializeComponent();
            ManagementLoaiSanPham managementLoaiSanPham = new ManagementLoaiSanPham();
            //managementLoaiSanPham.layMaSanPham(cbb_qlsp_LoaiNhanVien);
            rdb_bctk_TatCa.Checked = true;//kietbeve
        }

        private void fManager_Load(object sender, EventArgs e)
        {
            ManagementLoaiSanPham loaiSanPham = new ManagementLoaiSanPham();
            loaiSanPham.layTenLSP(cbb_qlsp_LoaiNhanVien);
            loadListSanPham();
            loadListNhanVien();
            loadListHoaDon();
            loadTTQuanLy();
            loadTien();
        }

        public void loadListSanPham()
        {
            DataProvider data = new DataProvider();

            //lấy danh sách nhân viên từ database
            ManagementLogic logic = new ManagementLogic();
            ListView list = new ListView();
            List<object> cot = new List<object> { "masp", "tensp", "tenlsp", "soluong" };
            list = logic.fillListView("sanpham, loaisanpham", cot, "WHERE sanpham.malsp = loaisanpham.malsp ");
            Console.WriteLine(list.Items.Count);

            //lam sach listview
            lsv_listSanPham.Columns.Clear();
            lsv_listSanPham.Items.Clear();
            lsv_listSanPham.View = View.Details;

            //add column
            foreach (ColumnHeader column in list.Columns)
            {
                lsv_listSanPham.Columns.Add(column.Text);
            }

            //add item
            foreach (ListViewItem item in list.Items)
            {
                DataRow row = data.executeSelect($"SELECT * FROM sanpham WHERE masp = {item.SubItems[0].Text}").Rows[0];
                SanPham sp = new SanPham(row);

                ListViewItem item1 = new ListViewItem();
                item1 = item;
                item1.Tag = sp;
                lsv_listSanPham.Items.Add((ListViewItem)item1.Clone());
            }

            //auto size column
            lsv_listSanPham.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lsv_listSanPham.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        /// <summary>
        /// Hàm load danh sách nhân viên
        /// </summary>
        private void loadListNhanVien()
        {
            DataProvider data = new DataProvider();

            //lấy danh sách nhân viên từ database
            ManagementLogic logic = new ManagementLogic();
            ListView list = new ListView();
            List<object> cot = new List<object> { "manv", "tennv", "tencv" };
            list = logic.fillListView("nhanvien, congviec", cot, "WHERE nhanvien.macv = congviec.macv ");
            Console.WriteLine(list.Items.Count);

            //lam sach listview
            lsv_listNhanVien.Columns.Clear();
            lsv_listNhanVien.Items.Clear();
            lsv_listNhanVien.View = View.Details;

            //add column
            foreach (ColumnHeader column in list.Columns)
            {
                lsv_listNhanVien.Columns.Add(column.Text);
            }

            //add item
            foreach (ListViewItem item in list.Items)
            {
                lsv_listNhanVien.Items.Add((ListViewItem)item.Clone());
            }

            //auto size column
            lsv_listNhanVien.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lsv_listNhanVien.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void loadListHoaDon()
        {
            DataProvider data = new DataProvider();

            ManagementLogic logic = new ManagementLogic();
            ListView list = new ListView();
            //List<object> cot = new List<object> { "mahd","manv","ngaylap","tongtien" };
            //<kietbeve> Dinh dang ngay lap theo dd/mm/yyyy
            List<object> cot = new List<object> { "mahd", "manv", "format(ngaylap,'dd-MM-yyyy') as 'ngaylap'", "tongtien" };
            //</kietbeve>

            list = logic.fillListView("hoadon", cot);
            Console.WriteLine(list.Items.Count);

            //lam sach listview
            lsv_listHoaDon.Columns.Clear();
            lsv_listHoaDon.Items.Clear();
            lsv_listHoaDon.View = View.Details;

            //add column
            foreach (ColumnHeader column in list.Columns)
            {
                lsv_listHoaDon.Columns.Add(column.Text);
            }

            //add item
            foreach (ListViewItem item in list.Items)
            {
                lsv_listHoaDon.Items.Add((ListViewItem)item.Clone());
            }

            //auto size column
            lsv_listHoaDon.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lsv_listHoaDon.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        /// <summary>
        /// Hàm load thông tin quản lý
        /// </summary>
        private void loadTTQuanLy()
        {
            ManagementLogic logic = new ManagementLogic();
            QuanLi quanLi = logic.getInfoQuanLi();
            lbl_tttk_MaNqLi.Text = quanLi.MaQL.ToString();
            lbl_tttk_TenNqLi.Text = quanLi.TenQL;
            lbl_tttk_TenTK.Text = quanLi.TenTK;
            lbl_tttk_Mk.Text = quanLi.MatKhau;
            //lbl_tttk_NgaySinh.Text = quanLi.NgaySinh;

            //<kietbeve>
            DateTime ngaysinh = DateTime.Parse(quanLi.NgaySinh);
            lbl_tttk_NgaySinh.Text = ngaysinh.Day.ToString() + "/" + ngaysinh.Month.ToString() + "/" + ngaysinh.Year.ToString();
            //ptb_tk_AnhQLi.Image = Image.FromFile(thuMucAnh + "\\" + quanLi.Anh);
            //<kietbeve>

            lbl_tttk_Sdt.Text = quanLi.Sdt;

        }

        /// <summary>
        /// Hàm xử lý sự kiện khi click vào nút xem chi tiết nhân viên
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_qlsp_XemChiTiet_Click(object sender, EventArgs e)
        {
            if (lsv_listSanPham.SelectedItems.Count > 0)
            {
                ListViewItem item = lsv_listSanPham.SelectedItems[0];
                SanPham sp = (SanPham)item.Tag;
                fViewInfoGoods fViewInfoSanPham = new fViewInfoGoods(sp);
                fViewInfoSanPham.ShowDialog();
            }
            else
            {
                MessageBox.Show("Chưa chọn hàng cần xem", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }            
        }

        private void btn_qlsp_XoaHang_Click(object sender, EventArgs e)
        {
            ManagementSanPham managementsanpham = new ManagementSanPham();
            if (lsv_listSanPham.SelectedItems.Count > 0)
            {
                ListViewItem item = lsv_listSanPham.SelectedItems[0];
                int check = managementsanpham.DeleteGoods(Convert.ToInt32(item.SubItems[0].Text));
                if (check == 1)
                {
                    MessageBox.Show("thành công");
                    //clean();
                }
                else
                {
                    MessageBox.Show(" ko thành công");
                }
                loadListSanPham();
            }
            else
                MessageBox.Show("Chưa chọn mặt hàng!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);           
            
        }

        private void btn_qlsp_SuaSanPham_Click(object sender, EventArgs e)
        {
            if (lsv_listSanPham.SelectedItems.Count > 0)
            {
                ListViewItem item = lsv_listSanPham.SelectedItems[0];
                SanPham sp = (SanPham)item.Tag;
                fGoodsUpdate fGoodsUpdate = new fGoodsUpdate(sp);
                fGoodsUpdate.ShowDialog();
            }
            else
            {
                MessageBox.Show("Chưa chọn hàng cần xem", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void btn_qlsp_LoaiSanPham_Click(object sender, EventArgs e)
        {
            fTypeGoods fTypeGoods = new fTypeGoods();
            this.Hide();
            fTypeGoods.ShowDialog();
            this.Show();
        }

        private void btn_qlsp_NhapHang_Click(object sender, EventArgs e)
        {
            fImportGoods fImportGoods = new fImportGoods();
            this.Hide();
            fImportGoods.ShowDialog();
            this.Show();
        }

        private void btn_qlsp_TimKiem_Click(object sender, EventArgs e)
        {
            ManagementSanPham managementSanPham = new ManagementSanPham();
            if (rdb_qlsp_TenSanPham.Checked)
            {
                string tensp = txt_qlsp_TenSanPham.Text;
                if (tensp != "")
                {
                    lsv_listSanPham.Items.Clear();
                    DataTable listSP = managementSanPham.layDanhSachBangTensp(tensp);
                    foreach (DataRow row in listSP.Rows)
                    {
                        ListViewItem item = new ListViewItem(row["masp"].ToString());
                        item.SubItems.Add(row["tensp"].ToString());
                        item.SubItems.Add(row["soluong"].ToString());
                        item.SubItems.Add(row["dongiaban"].ToString());
                        lsv_listSanPham.Items.Add(item);

                    }

                    lsv_listSanPham.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                    lsv_listSanPham.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                }
                else
                    MessageBox.Show("Chưa nhập tên sản phẩm");
            }
            else if (rdb_qlsp_TatCa.Checked)
            {
                loadListSanPham();
            }
            else if (rdb_qlsp_LoaiSanPham.Checked)
            {

                if (cbb_qlsp_LoaiNhanVien.Text != "")
                {
                    string tenlsp = cbb_qlsp_LoaiNhanVien.Text;
                        lsv_listSanPham.Items.Clear();
                        DataTable listSP = managementSanPham.layDanhSachBangLSP(tenlsp);
                        foreach (DataRow row in listSP.Rows)
                        {
                            ListViewItem item = new ListViewItem(row["masp"].ToString());
                            item.SubItems.Add(row["tensp"].ToString());
                            item.SubItems.Add(row["soluong"].ToString());
                            item.SubItems.Add(row["dongiaban"].ToString());
                            lsv_listSanPham.Items.Add(item);
                        }
                   
                }
                else
                    MessageBox.Show("Chưa nhập mã loại sản phẩm");
            }
        }

        private void lsv_listHoaDon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_tk_SuaTTin_Click(object sender, EventArgs e)
        {
            fSuaTTQuanLi fQL=new fSuaTTQuanLi();
            fQL.ShowDialog();
        }

        private void btn_bctk_TimKiem_Click(object sender, EventArgs e)
        {
            //ham nay ko tim theo ten san pham
            DataProvider data = new DataProvider();

            ManagementLogic logic = new ManagementLogic();
            ListView list = new ListView();
            List<object> cot = new List<object> { "mahd", "manv", "format(ngaylap,'dd-MM-yyyy') as 'ngaylap'", "tongtien" };
            string dieuKien = "";
            if (rdb_bctk_MaHD.Checked)
            {
                dieuKien = $"where mahd='{txt_bctk_MaHD.Text}'";
            }
            else if (rdb_bctk_TenNguoiLap.Checked)
            {
                dieuKien = $"where manv='{txt_bctk_TenNguoiLap.Text}'";//Tam thoi tim theo manv
            }
            else if (rdb_bctk_NgayLap.Checked)
            {
                string ngayLap = dtp_bctk_NgayLap.Value.ToString("MM/dd/yyyy");
                dieuKien = $"where ngaylap='{ngayLap}'";
            }
            else if (rdb_bctk_TatCa.Checked)
            {
                dieuKien = "";
            }


            list = logic.fillListView("hoadon", cot, dieuKien);
            Console.WriteLine(list.Items.Count);

            //lam sach listview
            lsv_listHoaDon.Columns.Clear();
            lsv_listHoaDon.Items.Clear();
            lsv_listHoaDon.View = View.Details;

            //add column
            foreach (ColumnHeader column in list.Columns)
            {
                lsv_listHoaDon.Columns.Add(column.Text);
            }

            //add item
            foreach (ListViewItem item in list.Items)
            {
                lsv_listHoaDon.Items.Add((ListViewItem)item.Clone());
            }

            //auto size column
            lsv_listHoaDon.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lsv_listHoaDon.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void btn_bctk_XemHoaDOn_Click(object sender, EventArgs e)
        {
            if (lsv_listHoaDon.SelectedItems.Count > 0)
            {
                ListViewItem item = lsv_listHoaDon.SelectedItems[0];
                HoaDon hd=new HoaDon();
                hd.MaHD=Int32.Parse(item.SubItems[0].Text);
                hd.MaNV= Int32.Parse(item.SubItems[1].Text);
                hd.NgayLap = item.SubItems[2].Text;
                hd.TongTien = float.Parse(item.SubItems[3].Text);
                fViewHoaDon fViewHD = new fViewHoaDon(hd);
                //MessageBox.Show(hd.MaHD.ToString());
                fViewHD.ShowDialog();
            }
            else
            {
                MessageBox.Show("Chưa chọn hàng cần xem", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void loadTien()
        {
            double tongThu = MHoaDon.Instance.tinhTongThu();
            double tongChi= MHoaDon.Instance.tinhTongChi();
            txt_bctk_TongThu.Text=tongThu.ToString();
            txt_bctk_TongChi.Text=tongChi.ToString();
            txt_bctk_DoanhThu.Text=(tongThu-tongChi).ToString();
        }
    }
}
