using Project_QliSieuThi.BLL;
using Project_QliSieuThi.DAL;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project_QliSieuThi.PL
{
    public partial class fTypeGoods : Form
    {
        public fTypeGoods()
        {
            InitializeComponent();
            loadListLoaiSanPham();
        }

        public void loadListLoaiSanPham()
        {
            DataProvider data = new DataProvider();

            //lấy danh sách nhân viên từ database
            ManagementLogic logic = new ManagementLogic();
            System.Windows.Forms.ListView list = new System.Windows.Forms.ListView();
            List<object> cot = new List<object> { "malsp", "tenlsp" };
            list = logic.fillListView("loaisanpham", cot);
            Console.WriteLine(list.Items.Count);

            //lam sach listview
            lv_lsp.Columns.Clear();
            lv_lsp.Items.Clear();
            lv_lsp.View = View.Details;

            //add column
            foreach (ColumnHeader column in list.Columns)
            {
                lv_lsp.Columns.Add(column.Text);
            }

            //add item
            foreach (ListViewItem item in list.Items)
            {
                DataRow row = data.executeSelect($"SELECT * FROM loaisanpham WHERE malsp = {item.SubItems[0].Text}").Rows[0];
                LoaiSanPham sp = new LoaiSanPham(row);

                ListViewItem item1 = new ListViewItem();
                item1 = item;
                item1.Tag = sp;
                lv_lsp.Items.Add((ListViewItem)item1.Clone());
            }

            //auto size column
            lv_lsp.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lv_lsp.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void btn_ThemLoai_Click(object sender, EventArgs e)
        {
            fAddTypeGoods fAddTypeGoods = new fAddTypeGoods();
            this.Hide();
            fAddTypeGoods.ShowDialog();
            this.Show();
        }

        private void btn_SuaLoai_Click(object sender, EventArgs e)
        {
            if (lv_lsp.SelectedItems.Count > 0)
            {
                ListViewItem item = lv_lsp.SelectedItems[0];
                LoaiSanPham lsp = (LoaiSanPham)item.Tag;
                fUpdateTypeGoods fUpdateTypeGoods = new fUpdateTypeGoods(lsp);
                this.Hide();
                fUpdateTypeGoods.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Chưa chọn hàng cần xem", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btn_XoaLoai_Click(object sender, EventArgs e)
        {
            ManagementLoaiSanPham managementLoaiSanPham = new ManagementLoaiSanPham();
            if (lv_lsp.SelectedItems.Count > 0)
            {
                try
                {
                    ListViewItem item = lv_lsp.SelectedItems[0];
                    int check = managementLoaiSanPham.deleteTypeGoods(Convert.ToInt32(item.SubItems[0].Text));
                    if (check == 1)
                    {
                        MessageBox.Show("thành công");
                        //clean();
                    }
                    else
                    {
                        MessageBox.Show(" ko thành công");
                    }
                    loadListLoaiSanPham();
                }
                catch
                {
                    MessageBox.Show("Vẫn còn sản phẩm loại này!");
                }
            }
            else
                MessageBox.Show("Chưa chọn mặt hàng!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void fTypeGoods_Load(object sender, EventArgs e)
        {

        }
    }
}
