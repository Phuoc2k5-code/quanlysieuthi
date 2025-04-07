using Project_QliSieuThi.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_QliSieuThi.BLL
{
    public class MHoaDon
    {
        private static MHoaDon instance;


        public static MHoaDon Instance
        {
            get
            {
                if (instance == null)
                    instance = new MHoaDon();

                return instance;
            }
            private set => instance = value;
        }
        public double tinhTongThu()
        {
            DataTable tb = new DataTable();
            double ketQua = 0;
            string queri = "select sum(thanhtien) as'tongthu'\r\nfrom cthd";
            tb = DataProvider.Instance.executeSelect(queri, null);
            DataRow row= tb.Rows[0];
            ketQua = Double.Parse(row["tongthu"].ToString());
            return ketQua;
        }
        public double tinhTongChi()
        {
            DataTable tb = new DataTable();
            double ketQua = 0;
            string queri = "select sum(soluong*dongianhap) as 'tongchi' from sanpham";
            tb = DataProvider.Instance.executeSelect(queri, null);
            DataRow row = tb.Rows[0];
            ketQua = Double.Parse(row["tongchi"].ToString());
            return ketQua;
        }
    }
}
