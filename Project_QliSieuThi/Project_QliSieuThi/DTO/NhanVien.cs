using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_QliSieuThi.DAL;
using Project_QliSieuThi.DTO;

namespace Project_QliSieuThi.DTO
{
 
    public class NhanVien
    {
        private int maNV;
        private string tenNV;
        private int maCV;
        private string ngaySinh;
        private string gioiTinh;
        private string diaChi;
        private string sdt;
        
        public int MaNV { get => maNV; set => maNV = value; }
        public string TenNV { get => tenNV; set => tenNV = value; }
        public int MaCV { get => maCV; set => maCV = value; }
        public string NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string Sdt { get => sdt; set => sdt = value; }

        /// <summary>
        /// Hàm Khởi tạo không tham số
        /// </summary>
        public NhanVien()
        {
            this.maNV = -1;
            this.tenNV = "";
            this.maCV = -1;
            this.ngaySinh = "";
            this.gioiTinh = "";
            this.diaChi = "";
            this.sdt = "";
        }


        /// <summary>
        /// Hàm khởi tạo với tham số là các thuộc tính của lớp
        /// </summary>
        /// <param name="maNV"></param>
        /// <param name="tenNV"></param>
        /// <param name="maCV"></param>
        /// <param name="ngaySinh"></param>
        /// <param name="gioiTinh"></param>
        /// <param name="diaChi"></param>
        /// <param name="sdt"></param>
        public NhanVien(int maNV, string tenNV, int maCV, string ngaySinh, string gioiTinh, string diaChi, string sdt)
        {
            this.maNV = maNV;
            this.tenNV = tenNV;
            this.maCV = maCV;
            this.ngaySinh = ngaySinh;
            this.gioiTinh = gioiTinh;
            this.diaChi = diaChi;
            this.sdt = sdt;
        }

        /// <summary>
        /// Hàm khởi tạo với tham số là một dòng dữ liệu
        /// </summary>
        /// <param name="row"></param>
        public NhanVien(DataRow row)
        {
            this.maNV = (int)row[0];
            this.tenNV = row[1].ToString();
            this.maCV = (int)row[2];
            this.ngaySinh = row[3].ToString();
            this.gioiTinh = row[4].ToString();
            this.diaChi = row[5].ToString();
            this.sdt = row[6].ToString();
        }
    }
}
