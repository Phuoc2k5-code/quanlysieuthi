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
    internal class CongViec
    {
        private int maCV;
        private string tenCV;

        public int MaCV { get => maCV; set => maCV = value; }
        public string TenCV { get => tenCV; set => tenCV = value; }


        /// <summary>
        /// Hàm khởi tạo không tham số
        /// </summary>
        public CongViec() 
        {
            this.maCV = 0;
            this.tenCV = "";
        }

        /// <summary>
        /// Hàm khởi tạo với tham số là các thuộc tính của lớp
        /// </summary>
        /// <param name="maCV"></param>
        /// <param name="tenCV"></param>
        public CongViec(int maCV, string tenCV)
        {
            this.maCV = maCV;
            this.tenCV = tenCV;
        }

        /// <summary>
        /// Hàm khởi tạo với tham số là một dòng dữ liệu
        /// </summary>
        /// <param name="row"></param>
        public CongViec(DataRow row)
        {
            this.maCV = (int)row[0];
            this.tenCV = row[1].ToString();
        }
    }
}
