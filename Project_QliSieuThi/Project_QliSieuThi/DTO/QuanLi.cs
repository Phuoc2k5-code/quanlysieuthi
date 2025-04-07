using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_QliSieuThi.DTO;
using Project_QliSieuThi.DAL;

namespace Project_QliSieuThi.DTO
{
    public class QuanLi
    {
        private int maQL;
        private string tenQL;
        private string tenTK;
        private string matKhau;
        private string ngaySinh;
        private string sdt;
        private string anh;//kietbeve

        public int MaQL { get => maQL; set => maQL = value; }
        public string TenQL { get => tenQL; set => tenQL = value; }
        public string TenTK { get => tenTK; set => tenTK = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public string NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Anh { get => anh; set => anh = value; }//kietbeve

        /// <summary>
        /// Hàm khởi tạo không tham số
        /// </summary>
        public QuanLi()
        
        {
            this.maQL = -1;
            this.tenQL = "";
            this.tenTK = "";
            this.matKhau = "";
            this.ngaySinh = "";
            this.sdt = "";
            this.anh = "";//kietbeve
        }

        /// <summary>
        /// Ham khởi tạo với tham số là các thuộc tính của lớp
        /// </summary>
        /// <param name="maQL"></param>
        /// <param name="tenQL"></param>
        /// <param name="tenTK"></param>
        /// <param name="matKhau"></param>
        /// <param name="ngaySinh"></param>
        /// <param name="sdt"></param>
        public QuanLi(int maQL, string tenQL, string tenTK, string matKhau, string ngaySinh, string sdt)
        
        {
            this.maQL = maQL;
            this.tenQL = tenQL;
            this.tenTK = tenTK;
            this.matKhau = matKhau;
            this.ngaySinh = ngaySinh;
            this.sdt = sdt;
            this.anh = "";//kietbeve
        }
        /// <summary>
        /// Hàm khởi tạo với tham số là một hàng trong bảng dữ liệu
        /// </summary>
        /// <param name="row"></param>
        public QuanLi(DataRow row)
        
        {
            //this.maQL = Int32.Parse(row[0].ToString());
            //this.tenQL = row[1].ToString();
            //this.tenTK = row[2].ToString();
            //this.matKhau = row[3].ToString();
            //this.ngaySinh = row[4].ToString();
            //this.sdt = row[5].ToString();

            //<kietbeve>
            this.maQL = Int32.Parse(row["maql"].ToString());
            this.tenQL = row["tenql"].ToString();
            this.tenTK = row["tentk"].ToString();
            this.matKhau = row["mk"].ToString();
            this.ngaySinh = row["ngaysinh"].ToString();
            this.sdt = row["sdt"].ToString();
            this.Anh = row["anh"].ToString();
            //</kietbeve>
        }

    }
}
