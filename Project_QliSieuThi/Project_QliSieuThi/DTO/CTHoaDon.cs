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
    public class CTHoaDon
    {
        private int maHD;
        private int maSP;
        private int soLuong;
        private int donGia;
        private int thanhTien;

        public int MaHD { get => maHD; set => maHD = value; }
        public int MaSP { get => maSP; set => maSP = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public int DonGia { get => donGia; set => donGia = value; }
        public int ThanhTien { get => thanhTien; set => thanhTien = value; }

        /// <summary>
        /// Hàm khởi tạo không tham số
        /// </summary>
        public CTHoaDon()
        {
            this.maHD = 0;
            this.maSP = 0;
            this.soLuong = 0;
            this.donGia = 0;
            this.thanhTien = 0;
        }

        /// <summary>
        /// Hàm khởi tạo với tham số là các thuộc tính của lớp
        /// </summary>
        /// <param name="maHD"></param>
        /// <param name="maSP"></param>
        /// <param name="soLuong"></param>
        /// <param name="donGia"></param>
        /// <param name="thanhTien"></param>
        public CTHoaDon(int maHD, int maSP, int soLuong, int donGia, int thanhTien)
        {
            this.maHD = maHD;
            this.maSP = maSP;
            this.soLuong = soLuong;
            this.donGia = donGia;
            this.thanhTien = thanhTien;
        }


        /// <summary>
        /// Hàm khởi tạo với tham số là một dòng dữ liệu
        /// </summary>
        /// <param name="row"></param>
        public CTHoaDon (DataRow row)
        {
            this.maHD = (int)row[0];
            this.maSP = (int)row[1];
            this.soLuong = (int)row[2];
            this.donGia = (int)row[3];
            this.thanhTien = (int)row[4];
        }
    }
}
