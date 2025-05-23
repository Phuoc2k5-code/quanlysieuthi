﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_QliSieuThi.DTO;
using Project_QliSieuThi.DAL;
using System.Data;


namespace Project_QliSieuThi.DTO
{
    public class SanPham
    {
        private int maSP;
        private string tenSP;
        private int maLoaiSP;
        private int soLuong;
        private float donGiaNhap;
        private float donGiaBan;
        private string anh;//kietbeve

        public int MaSP { get => maSP; set => maSP = value; }
        public string TenSP { get => tenSP; set => tenSP = value; }
        public int MaLoaiSP { get => maLoaiSP; set => maLoaiSP = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public float DonGiaNhap { get => donGiaNhap; set => donGiaNhap = value; }
        public float DonGiaBan { get => donGiaBan; set => donGiaBan = value; }
        public string Anh { get => anh; set => anh = value; }//kietbeve

        //public string HinhAnh { get => hinhAnh; set => hinhAnh = value; }
        //public string GhiChu { get => ghiChu; set => ghiChu = value; }

        /// <summary>
        /// Hàm khởi tạo không tham số
        /// </summary>
        public SanPham()
        {
            this.maSP = 0;
            this.tenSP = "";
            this.maLoaiSP = 0;
            this.soLuong = 0;
            this.donGiaNhap = 0;
            this.donGiaBan = 0;
            this.anh = "";//kietbeve
        }
        /// <summary>
        /// Ham khởi tạo với tham số là các thuộc tính của lớp
        /// </summary>
        /// <param name="maSP"></param>
        /// <param name="tenSP"></param>
        /// <param name="maLoaiSP"></param>
        /// <param name="soLuong"></param>
        /// <param name="donGiaNhap"></param>
        /// <param name="donGiaBan"></param>
        public SanPham(int maSP, string tenSP, int maLoaiSP, int soLuong, int donGiaNhap, int donGiaBan)
        {
            this.maSP = maSP;
            this.tenSP = tenSP;
            this.maLoaiSP = maLoaiSP;
            this.soLuong = soLuong;
            this.donGiaNhap = donGiaNhap;
            this.donGiaBan = donGiaBan;
            this.anh = "";//kietbeve
        }

        /// <summary>
        /// Hàm khởi tạo với tham số là một hàng dữ liệu
        /// </summary>
        /// <param name="row"></param>
        public SanPham(DataRow row)
        {
            //this.maSP = (int)row[1];
            //this.tenSP = row[2].ToString();
            //this.maLoaiSP = (int)row[3];
            //this.soLuong = (int)row[4];
            //this.donGiaNhap = (float)Convert.ToDouble(row[5].ToString());
            //this.donGiaBan = (float)Convert.ToDouble(row[6].ToString());

            //<kietbeve>
            this.maSP = (int)row["masp"];
            this.tenSP = row["tensp"].ToString();
            this.maLoaiSP = (int)row["malsp"];
            this.soLuong = (int)row["soluong"];
            this.donGiaNhap = (float)Convert.ToDouble(row["dongianhap"].ToString());
            this.donGiaBan = (float)Convert.ToDouble(row["dongiaban"].ToString());
            this.anh = row["anh"].ToString();//kietbeve
            //</kietbeve>
        }
    }
}
