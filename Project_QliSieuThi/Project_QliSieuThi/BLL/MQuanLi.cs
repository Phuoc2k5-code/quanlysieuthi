using Project_QliSieuThi.DAL;
using Project_QliSieuThi.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_QliSieuThi.BLL
{
    public class MQuanLi
    {
        private static MQuanLi instance;


        public static MQuanLi Instance
        {
            get
            {
                if (instance == null)
                    instance = new MQuanLi();

                return instance;
            }
            private set => instance = value;
        }
        public int UpdateQL(int maql, QuanLi quanLi)
        {
            DataProvider dataProvider = new DataProvider();
            string query = "UPDATE quanli SET tenql = @tenql ,tentk = @tentk ,mk = @mk ,ngaysinh = @ngaysinh ,sdt = @sdt ,anh = @anh WHERE maql = @maql";
            List<object> parameters = new List<object>();
            parameters.Add(quanLi.TenQL);
            parameters.Add(quanLi.TenTK);
            parameters.Add(quanLi.MatKhau);
            parameters.Add(quanLi.NgaySinh);
            parameters.Add(quanLi.Sdt);
            parameters.Add(quanLi.Anh);
            parameters.Add(maql);

            return dataProvider.excuteNonQueryCommand(query, parameters);
        }
    }
}
