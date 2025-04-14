using Project_QliSieuThi.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_QliSieuThi.BLL
{
   public class ManagementLoaiSanPham
    {
        private static ManagementSanPham instance;


        //public static ManagementSanPham Instance
        //{
        //    get
        //    {
        //        if (instance == null)
        //            instance = new ManagementSanPham();

        //        return instance;
        //    }
        //    private set => instance = value;
        //}

        public DataTable layDanhSach()
        {
            DataProvider dataProvider = new DataProvider();
            string query = "select * from loaisanpham";

            DataTable table = dataProvider.executeSelect(query, null);

            return table;
        }

        public int InsertTypeGoods(string tenlsp)
        {

            List<object> parameters = new List<object>();
            string query = "insert into loaisanpham values ( @tenlsp )";
            DataProvider dataProvider = new DataProvider();
            parameters.Add((tenlsp));
            return dataProvider.excuteNonQueryCommand(query, parameters);

        }

        public int deleteTypeGoods(int malsp)
        {

            List<object> parameters = new List<object>();
            string query = "delete from loaisanpham where malsp = @malsp";
            DataProvider dataProvider = new DataProvider();
            parameters.Add(malsp);
            return dataProvider.excuteNonQueryCommand(query, parameters);
        }

        public int UpdateTypeGoods(string tenlsp, int malsp)
        {
            DataProvider dataProvider = new DataProvider();
            List<object> parameters = new List<object>();
            string query = "update loaisanpham set tenlsp = @tenlsp where malsp = @malsp";
            parameters.Add(tenlsp);
            parameters.Add(malsp);
            return dataProvider.excuteNonQueryCommand(query, parameters);
        }
        public void layTenLSP(ComboBox combobox)
        {            
            DataTable listLSP = layDanhSach();
            string tenlsp;
            foreach (DataRow lsp in listLSP.Rows)
            {
                ListViewItem item = new ListViewItem(lsp[1].ToString());
                tenlsp = item.Text;
                combobox.Items.Add(tenlsp);

            }
        }

        public void laymaLSP(ComboBox combobox)
        {
            DataTable listLSP = layDanhSach();
            string malsp;
            foreach (DataRow lsp in listLSP.Rows)
            {
                ListViewItem item = new ListViewItem(lsp[0].ToString());
                malsp = item.Text;
                combobox.Items.Add(malsp);

            }
        }

    }
}
