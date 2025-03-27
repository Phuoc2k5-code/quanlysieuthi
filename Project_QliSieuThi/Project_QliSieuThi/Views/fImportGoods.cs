using Project_QliSieuThi.data_object;
using Project_QliSieuThi.data_provider;
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
    public partial class fImportGoods : Form
    {
        public fImportGoods()
        {
           
            InitializeComponent();
            bll.qlsp qlsp = new bll.qlsp();
            qlsp.hienThiDSSP(lv_nhaphang_qlsp);
            
            DataTable listLSP = data_provider.loaisp.Instance.layds();
            string malsp;
            foreach (DataRow lsp in listLSP.Rows)
            {
                ListViewItem item = new ListViewItem(lsp[0].ToString());
                malsp = item.Text;
                cbb_mal.Items.Add(malsp);                   
                                
            }
            
           
        }

       
        private int sl_bandau = 0;
        private int sum = 0;
        private int temp = 0;
       

        private void button5_Click(object sender, EventArgs e)
        {
            
            if (txt_nhaphang_tenspthem.Text != "" && cbb_mal.Text != "" && num_soluong.Text != "" && txt_dongiaban.Text != "" && txt_dongianhap.Text != "")
            {
                string tensp = txt_nhaphang_tenspthem.Text;
                int malsp = Convert.ToInt32(cbb_mal.Text);
                int soluong = Convert.ToInt32(num_soluong.Text);
                int dongiaban = Convert.ToInt32(txt_dongiaban.Text);
                int dongianhap = Convert.ToInt32(txt_dongianhap.Text);
                bll.qlsp qlsp = new bll.qlsp();
                int kt = qlsp.them(tensp, malsp, soluong, dongiaban, dongianhap);
                if (kt == 1)
                {
                    MessageBox.Show("Thêm thành công");
                    lv_nhaphang_qlsp.Items.Clear();
                    qlsp.hienthisp(lv_nhaphang_qlsp);
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

        private void button3_Click(object sender, EventArgs e)
        {
            string tensp = txt_nhaphang_tensp.Text;
            
            if (tensp != "")
            {
                bll.qlsp qlsp = new bll.qlsp();
                int kt = qlsp.layttbangten(tensp);
                if (kt == 1)
                {
                    lv_nhaphang_qlsp.Items.Clear();
                    DataTable sp = data_provider.qlsanpham.Instance.laydsbangtensp(tensp);
                    foreach (DataRow row in sp.Rows)
                    {
                        ListViewItem item = new ListViewItem(row["masp"].ToString());
                        item.SubItems.Add(row["tensp"].ToString());
                        item.SubItems.Add(row["soluong"].ToString());
                        item.SubItems.Add(row["dongianhap"].ToString());
                        lv_nhaphang_qlsp.Items.Add(item);
                        textBox2.Text = row["dongianhap"].ToString();
                    }
                }
                else
                    MessageBox.Show("Lỗi");
            }
            else
            {
                MessageBox.Show("Chưa nhập tên sp cần tìm");
            }
            
        }

        private void fImportGoods_Load(object sender, EventArgs e)
        {

        }

        private void btn_nhaphang_them_Click(object sender, EventArgs e)
        {
            //dgv_nhaphang_dshoadon.Rows.Clear();
            if (lv_nhaphang_qlsp.SelectedItems.Count > 0)
            {
                ListViewItem item = lv_nhaphang_qlsp.SelectedItems[0];

                ListViewItem newItem = new ListViewItem(item.Text); // Sao chép cột đầu tiên

                // Lặp qua các subitems và sao chép vào newItem
                for (int i = 1; i < item.SubItems.Count; i++)
                {
                    newItem.SubItems.Add(item.SubItems[i].Text); // Sao chép các subitem
                }

                // Thêm item mới vào ListView2
                lv_nhaphang_dssp.Items.Add(newItem);

            }
            else
                MessageBox.Show("Vui lòng chọn hàng");


        }



        private void lv_nhaphang_dssp_SelectedIndexChanged(object sender, EventArgs e)
        {
            lv_nhaphang_dssp.FullRowSelect = true; // lệnh chọn fullrow trong listview
            lv_nhaphang_dssp.View = View.Details;

            if (lv_nhaphang_dssp.SelectedItems.Count > 0)
            {
                ListViewItem item = lv_nhaphang_dssp.SelectedItems[0];
                txt_nhaphang_tendssp.Text = item.SubItems[1].Text;
                txt_ds_sl.Text = item.SubItems[2].Text;
                sl_bandau = Convert.ToInt32(item.SubItems[2].Text);
                temp = 0;               

            }
            
        }




        private void btn_nhaphang_suasl_Click(object sender, EventArgs e)
        {
            
            if (temp  == 0)
            {
                temp = sl_bandau;
            }
            if (lv_nhaphang_qlsp.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lv_nhaphang_dssp.SelectedItems[0];
                selectedItem.SubItems[1].Text = txt_nhaphang_tendssp.Text;
                selectedItem.SubItems[2].Text = txt_ds_sl.Text;
                
                
                int sl_nhapvao = Convert.ToInt32(txt_ds_sl.Text) - temp;
                
                sum += Convert.ToInt32(sl_nhapvao) * Convert.ToInt32(selectedItem.SubItems[3].Text);
                temp = Convert.ToInt32(selectedItem.SubItems[2].Text);
                txt_tonghd.Text = sum.ToString();
            }
            else
            {
                MessageBox.Show("Chọn hàng cần nhập hàng");
            }

           

        }

        private void btn_nhaphang_dathang_Click(object sender, EventArgs e)
        {
            int masp = 0, sl = 0;
            bll.qlsp qlsp = new bll.qlsp();
            foreach (ListViewItem item in lv_nhaphang_dssp.Items)
            {           
                for (int i = 0; i < item.SubItems.Count; i++)
                {
                    masp = Convert.ToInt32(item.SubItems[0].Text);
                    sl = Convert.ToInt32(item.SubItems[2].Text);
                    data_provider.qlsanpham.Instance.suasl(sl, masp);
                }
                
            }

            qlsp.hienThiDSSP(lv_nhaphang_qlsp);


        }

        private void btn_nhaphang_xoa_Click(object sender, EventArgs e)
        {
            if(lv_nhaphang_qlsp.SelectedItems.Count == 0)
            {
                MessageBox.Show("Chọn hàng cần xóa");
            }
            else
            {
                ListViewItem item = lv_nhaphang_dssp.SelectedItems[0];
                lv_nhaphang_dssp.Items.Remove(item);
            }
        }

        private void cbb_mal_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
    }
}
