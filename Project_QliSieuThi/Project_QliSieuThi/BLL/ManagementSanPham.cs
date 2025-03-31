using Project_QliSieuThi.DAL;
using Project_QliSieuThi.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_QliSieuThi.BLL
{
    internal class ManagementSanPham
    {
        private static ManagementSanPham instance;


        public static ManagementSanPham Instance
        {
            get
            {
                if (instance == null)
                    instance = new ManagementSanPham();

                return instance;
            }
            private set => instance = value;
        }

        public DataTable layThongTinTuMasp(int masp)
        {
            string query = $"select * from sanpham where masp = '{masp}' ";
            DataProvider dataProvider = new DataProvider();

            DataTable table = dataProvider.executeSelect(query);

            return table;
        }


        public DataTable layDanhSachBangTensp(string tensp)
        {
            string query = $"select * from sanpham where tensp like '%{tensp}%' ";
            DataProvider dataProvider = new DataProvider();
            DataTable table = dataProvider.executeSelect(query);

            return table;
        }

        public DataTable layDanhSachBangLSP(int malsp)
        {
            string query = $"select * from sanpham  where malsp = '{@malsp}' ";
            DataProvider dataProvider = new DataProvider();
            DataTable table = dataProvider.executeSelect(query);

            return table;
        }


        public int DeleteGoods(int masp)
        {
            DataProvider dataProvider = new DataProvider();
            List<object> parameters = new List<object>();
            string query = "delete from sanpham where masp = @masp";
            parameters.Add(masp);

            return dataProvider.excuteNonQueryCommand(query, parameters);
        }

        public int UpdateGoods(string tensp, int malsp, int soluong, int dongiaban, int dongianhap, int masp)
        {
            DataProvider dataProvider = new DataProvider();
            string query = "UPDATE sanpham SET tensp = @tensp ,malsp = @malsp ,soluong = @soluong ,dongiaban = @dongiaban ,dongianhap = @dongianhap WHERE masp = @masp";
            List<object> parameters = new List<object>();

            parameters.Add(tensp);
            parameters.Add(malsp);
            parameters.Add(soluong);
            parameters.Add(dongiaban);
            parameters.Add(dongianhap);
            parameters.Add(masp);

            return dataProvider.excuteNonQueryCommand(query, parameters);
        }

        public int AddGoods(string tensp, int malsp, int soluong, int dongiaban, int dongianhap)
        {
            DataProvider dataProvider = new DataProvider();
            List<object> parameters = new List<object>();
            string query = "insert into sanpham (tensp, malsp, soluong, dongiaban, dongianhap) values ( @tensp , @malsp , @soluong , @dongiaban , @dongianhap )";
            parameters.Add(tensp);
            parameters.Add(malsp);
            parameters.Add(soluong);
            parameters.Add(dongiaban);
            parameters.Add(dongianhap);

            return dataProvider.excuteNonQueryCommand(query, parameters);
        }

        public int UpdateGoodsSoLuongSP(int soluong, int masp)
        {
            DataProvider dataProvider = new DataProvider();
            List<object> parameters = new List<object>();
            string query = "update sanpham set  soluong = @soluong where masp = @masp";

            parameters.Add(soluong);
            parameters.Add(masp);

            return dataProvider.excuteNonQueryCommand(query, parameters);

        }

        
    } 
}
