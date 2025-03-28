//using Project_QliSieuThi.bll;
//using Project_QliSieuThi.data_object;
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

namespace Project_QliSieuThi
{
    public partial class fManager : Form
    {
        public fManager()
        {
            InitializeComponent();
            //fTypeGoods fTypeGoods = new fTypeGoods();
            //bll.qlsp qlsp = new bll.qlsp();
            //qlsp.hienthisp(lv_qlsp);
            //DataTable listLSP = data_provider.loaisp.Instance.layds();
            //string malsp;
            //foreach (DataRow lsp in listLSP.Rows)
            //{
            //    ListViewItem item = new ListViewItem(lsp[0].ToString());
            //    malsp = item.Text;
            //    cbb_qlsp_LoaiNhanVien.Items.Add(malsp);

            //}
        }

        //public void clean()
        //{
        //    lv_qlsp.Items.Clear();
        //}

        //public void hienthi()
        //{
        //    bll.qlsp qlsp = new bll.qlsp();
        //    qlsp.hienthisp(lv_qlsp);
        //}

        //private void btn_qlnv_XemChiTiet_Click(object sender, EventArgs e)
        //{

        //    fViewInfoNhanVien fViewInfoNhanVien = new fViewInfoNhanVien();           
        //    fViewInfoNhanVien.ShowDialog();
        //}

        //private void btn_qlsp_XemChiTiet_Click(object sender, EventArgs e)
        //{
        //    string masp, tensp, malsp, soluong, dongiaban, dongianhap;
        //    fViewInfoGoods fViewInfoSanPham = new fViewInfoGoods();
        //    if (lv_qlsp.SelectedItems.Count>0)
        //    {
        //        ListViewItem item = lv_qlsp.SelectedItems[0];
        //        int tim = Convert.ToInt32(item.SubItems[0].Text);

        //        DataTable listSP = data_provider.qlsanpham.Instance.layttTuMasp(tim);

        //        foreach (DataRow row in listSP.Rows)
        //        {
        //            ListViewItem item1 = new ListViewItem(row["masp"].ToString());
        //            masp = item.Text;
        //            tensp = item1.SubItems.Add(row["tensp"].ToString()).Text;
        //            malsp = item1.SubItems.Add(row["malsp"].ToString()).Text;
        //            soluong = item1.SubItems.Add(row["soluong"].ToString()).Text;
        //            dongiaban = item1.SubItems.Add(row["dongiaban"].ToString()).Text;
        //            dongianhap = item1.SubItems.Add(row["dongianhap"].ToString()).Text;
        //            fViewInfoSanPham.tt(masp, tensp, malsp, soluong, dongiaban, dongianhap);
        //        }               

        //        fViewInfoSanPham.ShowDialog();
        //    }
        //    else
        //        MessageBox.Show("Chưa chọn hàng cần xem");
            
        //}

        //private void btn_qlsp_NhapHang_Click(object sender, EventArgs e)
        //{
        //    fImportGoods fImportGoods = new fImportGoods();
        //    this.Hide();
        //    fImportGoods.ShowDialog();

        //    this.Show();
        //}

        //private void btn_qlsp_SuaSanPham_Click(object sender, EventArgs e)
        //{
        //    string masp, tensp, malsp, soluong, dongiaban, dongianhap;
           
        //    fGoodsUpdate fGoodsUpdate = new fGoodsUpdate();
        //    if (lv_qlsp.SelectedItems.Count > 0)
        //    {
               
        //        ListViewItem item = lv_qlsp.SelectedItems[0];
        //        int tim = Convert.ToInt32(item.SubItems[0].Text);

        //        DataTable listSP = data_provider.qlsanpham.Instance.layttTuMasp(tim);

        //        foreach (DataRow row in listSP.Rows)
        //        {
        //            ListViewItem item1 = new ListViewItem(row["masp"].ToString());
        //            masp = item.Text;
        //            tensp = item1.SubItems.Add(row["tensp"].ToString()).Text;
        //            malsp = item1.SubItems.Add(row["malsp"].ToString()).Text;
        //            soluong = item1.SubItems.Add(row["soluong"].ToString()).Text;
        //            dongiaban = item1.SubItems.Add(row["dongiaban"].ToString()).Text;
        //            dongianhap = item1.SubItems.Add(row["dongianhap"].ToString()).Text;
        //            fGoodsUpdate.tt(masp, tensp, malsp, soluong, dongiaban, dongianhap);
        //        }
        //        fGoodsUpdate.ShowDialog();

        //        Close();
        //    }
        //    else
        //        MessageBox.Show("Chưa chọn sản phẩm cần sửa");

        //}

        //private void btn_qlnv_SuaNhanVien_Click(object sender, EventArgs e)
        //{
        //    fStaffUpdate fStaffUpdate = new fStaffUpdate();
        //    fStaffUpdate.ShowDialog();
        //}

        //private void btn_qlsp_LoaiSanPham_Click(object sender, EventArgs e)
        //{

        //    fTypeGoods fTypeGoods = new fTypeGoods();
        //    this.Hide();
        //    fTypeGoods.ShowDialog();
        //    this.Show();
        //}

        //private void btn_qlnv_LoaiNhanVien_Click(object sender, EventArgs e)
        //{

        //    fJobStaff fJobStaff = new fJobStaff();
        //    this.Hide();
        //    fJobStaff.ShowDialog();
        //    this.Show();
        //}

        //private void btn_qlnv_ThemNhanVien_Click(object sender, EventArgs e)
        //{
        //    fAddStaff fAddStaff = new fAddStaff();
        //    fAddStaff.ShowDialog();
        //}

        //private void btn_qlsp_XoaHang_Click(object sender, EventArgs e)
        //{
        //    if (lv_qlsp.SelectedItems.Count > 0)
        //    {
        //        ListViewItem item = lv_qlsp.SelectedItems[0];

        //        bll.qlsp qlsp = new bll.qlsp();
        //        int masp = Convert.ToInt32(item.SubItems[0].Text);
        //        int kt = qlsp.dlt(masp);
        //        if (kt == 1)
        //        {
        //            MessageBox.Show("thành công");
        //            clean();
        //        }
        //        else
        //        {
        //            MessageBox.Show(" ko thành công");
        //        }
        //        qlsp.hienthisp(lv_qlsp);
        //    }
        //    else
        //        MessageBox.Show("Chưa chọn mặt hàng!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        //}

        //private void btn_qlnv_XoaNhanVien_Click(object sender, EventArgs e)
        //{
        //    MessageBox.Show("Chưa chọn nhân viên!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //}

        //private void dataView_qlsp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{

        //}

        
        //private void btn_qlsp_TimKiem_Click(object sender, EventArgs e)
        //{
        //    bll.qlsp qlsp = new bll.qlsp();
        //    if (rdb_qlsp_TenSanPham.Checked)
        //    {
        //        string tensp = txt_qlsp_TenSanPham.Text;
        //        if (tensp != "")
        //        {
                    
        //            int kt = qlsp.layttbangten(tensp);
        //            if (kt == 1)
        //            {
        //                lv_qlsp.Items.Clear();
        //                DataTable listSP = data_provider.qlsanpham.Instance.laydsbangtensp(tensp);
        //                foreach (DataRow row in listSP.Rows)
        //                {
        //                    ListViewItem item = new ListViewItem(row["masp"].ToString());
        //                    item.SubItems.Add(row["tensp"].ToString());
        //                    item.SubItems.Add(row["soluong"].ToString());
        //                    item.SubItems.Add(row["dongiaban"].ToString());
        //                    lv_qlsp.Items.Add(item);
        //                }
        //            }
        //            else
        //                MessageBox.Show("Lỗi ");
        //        }
        //        else
        //            MessageBox.Show("Chưa nhập tên sản phẩm");
        //    }
        //    else if (rdb_qlsp_TatCa.Checked)
        //    {
        //        lv_qlsp.Items.Clear();
        //        qlsp.hienthisp(lv_qlsp);
        //    }
        //    else if (rdb_qlsp_LoaiSanPham.Checked)
        //    {

        //        if (cbb_qlsp_LoaiNhanVien.Text != "")
        //        {

        //            int malsp = Convert.ToInt32(cbb_qlsp_LoaiNhanVien.Text);
        //            int kt = qlsp.layttbangloai(malsp);
        //            if (kt == 1)
        //            {
        //                lv_qlsp.Items.Clear();
        //                DataTable listSP = data_provider.qlsanpham.Instance.laydsbanglsp(malsp);
        //                foreach (DataRow row in listSP.Rows)
        //                {
        //                    ListViewItem item = new ListViewItem(row["masp"].ToString());
        //                    item.SubItems.Add(row["tensp"].ToString());
        //                    item.SubItems.Add(row["soluong"].ToString());
        //                    item.SubItems.Add(row["dongiaban"].ToString());
        //                    lv_qlsp.Items.Add(item);
        //                }
        //            }
        //            else
        //                MessageBox.Show("....");
        //        }
        //        else
        //            MessageBox.Show("Chưa nhập mã loại sản phẩm");
        //    }
        //}

        //private void cbb_qlsp_LoaiNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        //{                
                    
                
        //}

        //private void txt_bctk_TongChi_TextChanged(object sender, EventArgs e)
        //{

        //}

        //private void fManager_Load(object sender, EventArgs e)
        //{

        //}
    }
}
