﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_QliSieuThi.data_provider
{
    internal class qlsanpham
    {
        private static qlsanpham instance;

        private string connectionStr = "Data Source=LAPTOP-LKVH2QD8\\SQLEXPRESS;Initial Catalog=QliSieuThi_db;Integrated Security=True;";

        public static qlsanpham Instance
        {
            get
            {
                if (instance == null)
                    instance = new qlsanpham();

                return instance;
            }
            private set => instance = value;
        }
        public DataTable layttTuMasp(int masp)
        {
            string query = "select * from sanpham where masp = @masp";

            List<object> parameters = new List<object>();

            parameters.Add(masp);

            DataTable table = dataprovider.Instance.ketnoi(query, parameters);
                        
            return table;
        }

        public DataTable layds()
        {           

            string query = "select * from sanpham";

            DataTable table = dataprovider.Instance.ketnoi(query, null);
            
            return table;

        }        
        public DataTable laydsbangtensp(string tensp)
        {  
           
            List<object> parameters = new List<object>();
            string query = "select * from sanpham where tensp = @tensp ";           
            parameters.Add(tensp);
            DataTable table = dataprovider.Instance.ketnoi(query, parameters);
            
            return table;
        }

        public DataTable laydsbanglsp(int malsp)
        {
            List<object> parameters = new List<object>();
            string query = "select * from sanpham  where malsp = @malsp ";            
            parameters.Add(malsp);
            DataTable table = dataprovider.Instance.ketnoi(query, parameters);
            
            return table;
        }

        
        public int xoa(int masp)
        {            
            List<object> parameters = new List<object>();
            string query = "delete from sanpham where masp = @masp";
            
            parameters.Add(masp);

            return data_provider.dataprovider.Instance.capnhat(query, parameters);
        }

        public int sua( string tensp, int malsp, int soluong, int dongiaban, int dongianhap, int masp)
        {            
            string query = "UPDATE sanpham SET tensp = @tensp ,malsp = @malsp ,soluong = @soluong ,dongiaban = @dongiaban ,dongianhap = @dongianhap WHERE masp = @masp";
            List<object> parameters = new List<object>();
            
            parameters.Add(tensp);
            parameters.Add(malsp);
            parameters.Add(soluong);
            parameters.Add(dongiaban);
            parameters.Add(dongianhap);
            parameters.Add(masp);
                       
            return data_provider.dataprovider.Instance.capnhat(query, parameters);
        }

        public int them(string tensp, int malsp, int soluong, int dongiaban, int dongianhap)
        {            
            List<object> parameters = new List<object>();
            string query = "insert into sanpham (tensp, malsp, soluong, dongiaban, dongianhap) values ( @tensp , @malsp , @soluong , @dongiaban , @dongianhap )";
            parameters.Add(tensp);
            parameters.Add(malsp);
            parameters.Add(soluong);
            parameters.Add(dongiaban);
            parameters.Add(dongianhap);

            return data_provider.dataprovider.Instance.capnhat(query, parameters);
        }

        public int suasl(int soluong, int masp)
        {            
            List<object> parameters = new List<object>();
            string query = "update sanpham set  soluong = @soluong where masp = @masp";

            parameters.Add(soluong);
            parameters.Add(masp);

            return data_provider.dataprovider.Instance.capnhat(query, parameters);
                       
        }


    }
}
