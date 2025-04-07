using Project_QliSieuThi.BLL;
using Project_QliSieuThi.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_QliSieuThi.PL
{
    public partial class fSuaTTQuanLi : Form
    {
        //<kietbeve>
        string thuMucAnh = Path.Combine(Application.StartupPath, "Images");//lay duong dan toi file Images
        string linkAnh = "";//luu link danh dang mo
        string tenFileAnh = "";// luu ten file anh dang mo
        static ManagementLogic logic = new ManagementLogic();
        QuanLi quanLi = logic.getInfoQuanLi();//lay thong tin quan li
        //</kietbeve>
        public fSuaTTQuanLi()
        {
            InitializeComponent();
            loadTTQuanLy();
        }
        private void loadTTQuanLy()//kietbeve
        {
            lbl_SuaTTQuanLi_MaNqLi.Text = quanLi.MaQL.ToString();
            txt_SuaTTQuanLi_TenQL.Text = quanLi.TenQL;
            txt_SuaTTQuanLi_TenTK.Text = quanLi.TenTK;
            txt_SuaTTQuanLi_MK.Text = quanLi.MatKhau;
            date_SuaTTQuanLi_NgaySinh.Value = DateTime.Parse(quanLi.NgaySinh);
            txt_SuaTTQuanLi_SDT.Text = quanLi.Sdt;
            ptb_SuaTTQuanLi_AnhQLi.Image = Image.FromFile(thuMucAnh + "\\" + quanLi.Anh);
        }

        private void btn_SuaTTQuanLi_TaiAnh_Click(object sender, EventArgs e)//kietbeve
        {
            OpenFileDialog ofd = new OpenFileDialog();
            //string thuMucAnh = Path.Combine(Application.StartupPath, "kietbeve_Images");//lay duong dan toi file kietbeve_Images
            ofd.ShowDialog();
            linkAnh = ofd.FileName;
            tenFileAnh = Path.GetFileName(ofd.FileName);//lay ten file anh
            //tenFileAnh =quanLi.Anh;
            //txt_test.Text = tenFileAnh;
            ptb_SuaTTQuanLi_AnhQLi.Image = Image.FromFile(ofd.FileName);
            // Tao thu muc kietbeve_Images neu chua ton tai
            if (!Directory.Exists(thuMucAnh))//ktra ton tai cua file kietbeve_Images
            {
                Directory.CreateDirectory(thuMucAnh);
            }
        }

        private void btn_tk_SuaTTin_Click(object sender, EventArgs e)//kietbeve
        {
            //Luu thong tin thay doi vao quanLi
            if (tenFileAnh == "")
            {

            }
            else
            {
                quanLi.Anh = tenFileAnh;
            }
            quanLi.TenQL = txt_SuaTTQuanLi_TenQL.Text;
            quanLi.TenTK = txt_SuaTTQuanLi_TenTK.Text;
            quanLi.MatKhau = txt_SuaTTQuanLi_MK.Text;
            quanLi.NgaySinh = date_SuaTTQuanLi_NgaySinh.Value.ToString("MM/dd/yyyy");
            quanLi.Sdt = txt_SuaTTQuanLi_SDT.Text;
            
            //Copy anh vao file Images
            if (tenFileAnh == "")
            {

            }
            else
            {
                if (!File.Exists(thuMucAnh + "\\" + tenFileAnh))
                {
                    File.Copy(linkAnh, thuMucAnh + "\\" + tenFileAnh, true);//tenlinl_anh_dc_copy,ten file dc luu 
                }
            }

            if (MQuanLi.Instance.UpdateQL(quanLi.MaQL, quanLi) >= 1)
            {
                MessageBox.Show("Sua Thanh Cong!");
            }
        }

        private void fSuaTTQuanLi_Load(object sender, EventArgs e)
        {

        }
    }
}
