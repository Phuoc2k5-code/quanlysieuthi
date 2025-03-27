using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_QliSieuThi.data_provider
{
    internal class loaisp
    {
        private static loaisp instance;
        public static loaisp Instance
        {
            get
            {
                if (instance == null)
                    instance = new loaisp();

                return instance;
            }
            private set => instance = value;
        }
        public DataTable layttTuMalsp(int malsp)
        {
            data_object.loaisanpham lsp;
            string query = "select * from loaisanpham where malsp = @malsp";

            List<object> parameters = new List<object>();

            parameters.Add(malsp);

            DataTable table = dataprovider.Instance.ketnoi(query, parameters);            

            return table;
        }

        public DataTable layds()
        {
            string query = "select * from loaisanpham";

            DataTable table = dataprovider.Instance.ketnoi(query, null);
            
            return table;
        }

        public int them(string tenlsp)
        {
            
            List<object> parameters = new List<object>();
            string query = "insert into loaisanpham values ( @tenlsp )";
            parameters.Add((tenlsp));
            return data_provider.dataprovider.Instance.capnhat(query, parameters);

        }

        public int xoa(int malsp)
        {
            
            List<object> parameters = new List<object>();
            string query = "delete from loaisanpham where malsp = @malsp";
            parameters.Add(malsp);
            return data_provider.dataprovider.Instance.capnhat(query, parameters);
        }

        public int sua(string tenlsp, int malsp)
        {
            
            List<object> parameters = new List<object>();
            string query = "update loaisanpham set tenlsp = @tenlsp where malsp = @malsp";
            parameters.Add(tenlsp);
            parameters.Add(malsp);
            return data_provider.dataprovider.Instance.capnhat(query, parameters);
        }

    }
}
