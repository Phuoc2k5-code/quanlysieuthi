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

namespace Project_QliSieuThi.Views
{
    public partial class fTypeGoods : Form
    {
        public fTypeGoods()
        {
            InitializeComponent();
            hienthilsp();
        }

        public void hienthilsp()
        {
            DataTable listLSP = data_provider.loaisp.Instance.layds();
            foreach (DataRow row in listLSP.Rows)
            {
                ListViewItem item = new ListViewItem(row[0].ToString());
                item.SubItems.Add(row[1].ToString());
                
                lv_lsp.Items.Add(item);
            }
        }

        public void clean()
        {
            lv_lsp.Items.Clear();
        }

        private void btn_SuaLoai_Click(object sender, EventArgs e)
        {
            string malsp, tenlsp;
            fUpdateTypeGoods fUpdateTypeGoods = new fUpdateTypeGoods();
            if (lv_lsp.SelectedItems.Count > 0)
            {
                
                ListViewItem item = lv_lsp.SelectedItems[0];

                DataTable listlsp = data_provider.loaisp.Instance.layttTuMalsp(Convert.ToInt32(item.SubItems[0].Text));

                foreach (DataRow row in listlsp.Rows)
                {
                    ListViewItem item1 = new ListViewItem(row[0].ToString());
                    malsp = item1.Text;
                    tenlsp = item1.SubItems.Add(row[1].ToString()).Text;
                    fUpdateTypeGoods.tt(malsp, tenlsp);
                    lv_lsp.Items.Clear();
                }
                
                
                fUpdateTypeGoods.ShowDialog();

                Close();
            }
            else
                MessageBox.Show("Chưa chọn hàng cần sửa");
        }

        private void fTypeGoods_Load(object sender, EventArgs e)
        {

        }

        private void btn_qlsp_XemChiTiet_Click(object sender, EventArgs e)
        {

        }

        private void btn_ThemLoai_Click(object sender, EventArgs e)
        {
            
            fAddTypeGoods fAddTypeGoods = new fAddTypeGoods();       
            
            fAddTypeGoods.ShowDialog();

            Close();
        }

        private void btn_XoaLoai_Click(object sender, EventArgs e)
        {
            if (lv_lsp.SelectedItems.Count == 0)
            {
                MessageBox.Show("Chưa nhập hàng cần xóa");
            }
            else
            {
                ListViewItem item = lv_lsp.SelectedItems[0];
                int malsp = Convert.ToInt32(item.SubItems[0].Text);
                bll.loaisp loaisp = new bll.loaisp();
                int kt = loaisp.xoa(malsp);
                if (kt == 1)
                {
                    MessageBox.Show("Xóa thành công");
                    clean();
                    hienthilsp();
                }
                else
                {
                    MessageBox.Show("Thất bại");
                }
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
