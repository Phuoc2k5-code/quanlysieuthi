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
    internal class HoaDon
    {
        private int maHD;
        private int maNV;
        private string ngayLap;
        private float tongTien;

        public int MaHD { get => maHD; set => maHD = value; }
        public int MaNV { get => maNV; set => maNV = value; }
        public string NgayLap { get => ngayLap; set => ngayLap = value; }
        public float TongTien { get => tongTien; set => tongTien = value; }
        /// <summary>
        /// Hàm khởi tạo không tham số
        /// </summary>
        public HoaDon() 
        {
            this.maHD = -1;
            this.maNV = -1;
            this.ngayLap = "";
            this.tongTien = 0;  
        }

        /// <summary>
        /// Hàm khởi tạo với tham số là các thuộc tính của lớp
        /// </summary>
        /// <param name="maHD"></param>
        /// <param name="maNV"></param>
        /// <param name="ngayLap"></param>
        /// <param name="tongTien"></param>
        public HoaDon(int maHD, int maNV, string ngayLap, float tongTien)
        {
            this.maHD = maHD;
            this.maNV = maNV;
            this.ngayLap = ngayLap;
            this.tongTien = tongTien;
        }

        /// <summary>
        /// Hàm khởi tạo với tham số là một dòng dữ liệu
        /// </summary>
        /// <param name="row"></param>
        public HoaDon(DataRow row)
        {
            this.maHD = (int)row[0];
            this.maNV = (int)row[1];
            this.ngayLap = row[2].ToString();
            this.tongTien = (float)Convert.ToDouble(row[3].ToString());
        }


    }
}
