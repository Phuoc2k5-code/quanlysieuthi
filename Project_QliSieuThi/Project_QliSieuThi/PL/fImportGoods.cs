//using Project_QliSieuThi.data_object;
//using Project_QliSieuThi.data_provider;
using Project_QliSieuThi.BLL;
using Project_QliSieuThi.DAL;
using Project_QliSieuThi.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Project_QliSieuThi.PL
{
    public partial class fImportGoods : Form
    {
        public fImportGoods()
        {
            InitializeComponent();
            loadListSanPham();
            ManagementLoaiSanPham managementLoaiSanPham = new ManagementLoaiSanPham();
            managementLoaiSanPham.layMaSanPham(cbb_mal);
        }
        private int sl_bandau = 0;
        private int sum = 0;
        private int temp = 0;

        
        public void loadListSanPham()
        {
            DataProvider data = new DataProvider();

            //lấy danh sách nhân viên từ database
            ManagementLogic logic = new ManagementLogic();
            System.Windows.Forms.ListView list = new System.Windows.Forms.ListView();
            List<object> cot = new List<object> { "masp", "tensp", "soluong", "dongianhap" };
            list = logic.fillListView("sanpham", cot);
            Console.WriteLine(list.Items.Count);

            //lam sach listview
            lv_nhaphang_qlsp.Columns.Clear();
            lv_nhaphang_qlsp.Items.Clear();
            lv_nhaphang_qlsp.View = View.Details;

            //add column
            foreach (ColumnHeader column in list.Columns)
            {
                lv_nhaphang_qlsp.Columns.Add(column.Text);
            }

            //add item
            foreach (ListViewItem item in list.Items)
            {
                DataRow row = data.executeSelect($"SELECT * FROM sanpham WHERE masp = {item.SubItems[0].Text}").Rows[0];
                SanPham sp = new SanPham(row);

                ListViewItem item1 = new ListViewItem();
                item1 = item;
                item1.Tag = sp;
                lv_nhaphang_qlsp.Items.Add((ListViewItem)item1.Clone());
            }

            //auto size column
            lv_nhaphang_qlsp.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lv_nhaphang_qlsp.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void btn_nhaphang_them_Click(object sender, EventArgs e)
        {
            if (lv_nhaphang_qlsp.SelectedItems.Count > 0)
            {
                ListViewItem item = lv_nhaphang_qlsp.SelectedItems[0];

                ListViewItem newItem = new ListViewItem(item.Text); // Sao chép cột đầu tiên

                // Lặp qua các subitems và sao chép vào newItem
                for (int i = 1; i < item.SubItems.Count; i++)
                {
                    if (i == 2)
                    {
                        newItem.SubItems.Add("0");
                        i++;
                    }
                    newItem.SubItems.Add(item.SubItems[i].Text); // Sao chép các subitem
                }

                // Thêm item mới vào ListView2
                lv_nhaphang_dssp.Items.Add(newItem);

            }
            else
                MessageBox.Show("Vui lòng chọn hàng");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (txt_nhaphang_tenspthem.Text != "" && cbb_mal.Text != "" && num_soluong.Text != "" && txt_dongiaban.Text != "" && txt_dongianhap.Text != "")
            {
                string tensp = txt_nhaphang_tenspthem.Text;
                int malsp = Convert.ToInt32(cbb_mal.Text);
                int soluong = Convert.ToInt32(num_soluong.Text);
                int dongiaban = Convert.ToInt32(txt_dongiaban.Text);
                int dongianhap = Convert.ToInt32(txt_dongianhap.Text);
                ManagementSanPham managementSanPham = new ManagementSanPham();
                int check = managementSanPham.AddGoods(tensp, malsp, soluong, dongiaban, dongianhap);
                if (check == 1)
                {
                    MessageBox.Show("Thêm thành công");
                    lv_nhaphang_qlsp.Items.Clear();
                    loadListSanPham();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }
            }
            else
            {
                MessageBox.Show("Chưa nhập đủ thông tin");
            }
        }

        private void lv_nhaphang_dssp_SelectedIndexChanged(object sender, EventArgs e)
        {
            lv_nhaphang_dssp.FullRowSelect = true; // lệnh chọn fullrow trong listview
            lv_nhaphang_dssp.View = View.Details;
            if (lv_nhaphang_dssp.SelectedItems.Count > 0)
            {
                ListViewItem item = lv_nhaphang_dssp.SelectedItems[0];
                txt_nhaphang_tendssp.Text = item.SubItems[1].Text;
                txt_ds_sl.Text = "0";
                foreach (ListViewItem item1 in lv_nhaphang_qlsp.Items)
                {
                    if (item.SubItems[0].Text == item1.SubItems[0].Text)
                    {
                        sl_bandau = Convert.ToInt32(item1.SubItems[2].Text);
                        return;
                    }
                }
                temp = 0;
            }
        }

        private void btn_nhaphang_suasl_Click(object sender, EventArgs e)
        {
            if (temp == 0)
            {
                temp = sl_bandau;
            }
            if (lv_nhaphang_qlsp.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lv_nhaphang_dssp.SelectedItems[0];
                selectedItem.SubItems[1].Text = txt_nhaphang_tendssp.Text;
                selectedItem.SubItems[2].Text = txt_ds_sl.Text;


                

                sum += Convert.ToInt32(selectedItem.SubItems[2].Text) * Convert.ToInt32(selectedItem.SubItems[3].Text);
                temp = Convert.ToInt32(selectedItem.SubItems[2].Text);
                txt_tonghd.Text = sum.ToString();
            }
            else
            {
                MessageBox.Show("Chọn hàng cần nhập hàng");
            }
        }

        private void btn_nhaphang_xoa_Click(object sender, EventArgs e)
        {
            if (lv_nhaphang_qlsp.SelectedItems.Count == 0)
            {
                MessageBox.Show("Chọn hàng cần xóa");
            }
            else
            {
                ListViewItem item = lv_nhaphang_dssp.SelectedItems[0];
                lv_nhaphang_dssp.Items.Remove(item);
            }
        }

        private void btn_nhaphang_dathang_Click(object sender, EventArgs e)
        {
            int masp = 0, sl = 0;
            ManagementSanPham managementSanPham = new ManagementSanPham();
            foreach (ListViewItem item in lv_nhaphang_dssp.Items)
            {
                foreach(ListViewItem item1 in lv_nhaphang_qlsp.Items)
                {
                   if (item.SubItems[0].Text== item1.SubItems[0].Text)
                   {
                       sl_bandau = Convert.ToInt32(item1.SubItems[2].Text);
                       
                   }
                }

                for (int i = 0; i < item.SubItems.Count; i++)
                {
                    masp = Convert.ToInt32(item.SubItems[0].Text);
                    sl = sl_bandau+Convert.ToInt32(item.SubItems[2].Text);
                    managementSanPham.UpdateGoodsSoLuongSP(sl, masp);
                }

            }

            loadListSanPham();
        }

        private void btn_nhaphang_timkiem_Click(object sender, EventArgs e)
        {
            ManagementSanPham managementSanPham = new ManagementSanPham();
            string tensp = txt_nhaphang_tensp.Text;
            if (tensp != "")
            {
                lv_nhaphang_qlsp.Items.Clear();
                DataTable listSP = managementSanPham.layDanhSachBangTensp(tensp);
                foreach (DataRow row in listSP.Rows)
                {
                    ListViewItem item = new ListViewItem(row["masp"].ToString());
                    item.SubItems.Add(row["tensp"].ToString());
                    item.SubItems.Add(row["soluong"].ToString());
                    item.SubItems.Add(row["dongianhap"].ToString());
                    lv_nhaphang_qlsp.Items.Add(item);
                    txt_nhaphang_dongia.Text = row["dongianhap"].ToString();
                }

            }
            else
                MessageBox.Show("Chưa nhập tên sản phẩm");

        }

        private void fImportGoods_Load(object sender, EventArgs e)
        {

        }
    }
}
