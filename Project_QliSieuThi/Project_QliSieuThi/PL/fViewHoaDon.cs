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
    public partial class fViewHoaDon : Form
    {
        public fViewHoaDon(HoaDon hoaDon)
        {
            InitializeComponent();
            loadHoaDon(hoaDon);
        }
        public fViewHoaDon()
        {
            InitializeComponent();
        }
        public void loadHoaDon(HoaDon hoaDon)
        {
            lbl_ViewHD_MaHD.Text = hoaDon.MaHD.ToString();
            lbl_ViewHD_MaNV.Text = hoaDon.MaNV.ToString();
            lbl_ViewHD_NgayLap.Text = hoaDon.NgayLap.ToString();
            lbl_ViewHD_TongTien.Text = hoaDon.TongTien.ToString();
        }
        private void fViewHoaDon_Load(object sender, EventArgs e)
        {

        }

        private void lbl_vinv_NgaySinh_Click(object sender, EventArgs e)
        {

        }
    }
}
