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
    internal class LoaiSanPham
    {
        private int maLoai;
        private string tenLoai;

        public int MaLoai { get => maLoai; set => maLoai = value; }
        public string TenLoai { get => tenLoai; set => tenLoai = value; }

        /// <summary>
        /// Hàm khởi tạo không tham số
        /// </summary>
        public LoaiSanPham() {
            this.maLoai = -1;
            this.tenLoai = "";
        }

        /// <summary>
        /// Hàm khởi tạo với tham số là các thuộc tính của lớp
        /// </summary>
        /// <param name="maLoai"></param>
        /// <param name="tenLoai"></param>
        public LoaiSanPham(int maLoai, string tenLoai)
        {
            this.maLoai = maLoai;
            this.tenLoai = tenLoai;
        }

        /// <summary>
        /// Ham khởi tạo với tham số là một dòng dữ liệu
        /// </summary>
        /// <param name="row"></param>
        public LoaiSanPham(DataRow row)
        {
            this.maLoai = (int)row[0];
            this.tenLoai = row[1].ToString();
        }
    }
}
