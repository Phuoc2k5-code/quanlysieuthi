using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_QliSieuThi.DAL;
using Project_QliSieuThi.DTO;
using Project_QliSieuThi.PL;


namespace Project_QliSieuThi.BLL
{
    /// <summary>
    /// Xử lý logic cho các chức năng quản lý
    /// </summary>
    internal class ManagementLogic
    {
        private static int idQuanLy = -1;
        public static int IdQuanLy
        {
            get => idQuanLy;
            set => idQuanLy = value;
        }
        public ManagementLogic intance;
        public ManagementLogic Instance
        {
            get
            {
                if (intance == null)
                {
                    intance = new ManagementLogic();
                }
                return intance;
            }
            private set => intance = value;
        }

        public ManagementLogic()
        {
        }

        public ManagementLogic(ManagementLogic intance)
        {
            this.intance = intance;
        }

        /// <summary>
        /// Hàm kiểm tra đăng nhập
        /// </summary>
        /// <param name="taiKhoan"></param>
        /// <param name="matKhau"></param>
        /// <returns></returns>
        public bool checkLogin(string taiKhoan, string matKhau)
        {

            //Console.WriteLine(taiKhoan);
            //Console.WriteLine(matKhau);

            string query = $"SELECT * FROM quanli WHERE tentk = '{taiKhoan}' AND mk = '{matKhau}' ";

            DataProvider dataProvider = new DataProvider();

            //List<object> parameters = new List<object>();
            //parameters.Add(taiKhoan);
            //parameters.Add(matKhau);

         

            DataTable result = dataProvider.executeSelect(query);
            try
            {
                idQuanLy = Convert.ToInt32(result.Rows[0][0].ToString());
            }
            catch
            {
                return false;
            }
            if (result.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Hàm truyền bảng trong database vào listview
        /// </summary>
        /// <param name="table"></param>
        /// <param name="cot"></param>
        /// <returns></returns>
        public ListView fillListView(string table, List<object> cot, string conditonSelect = "")
        {
            ListView result = new ListView();
            DataProvider dataProvider = new DataProvider();

            string cotstr = listIntoString(cot);
            string query = $"SELECT {cotstr} FROM {table} {conditonSelect}";

            DataTable data = dataProvider.executeSelect(query);

            result.View = View.Details;
            //set so cot bang so cot cua data

            foreach (DataColumn column in data.Columns)
            {
                result.Columns.Add(column.ColumnName);
            }

            //add item vao listview
            foreach (DataRow row in data.Rows)
            {
                ListViewItem item = new ListViewItem(row[0].ToString());
                for (int i = 1; i < data.Columns.Count; i++)
                {
                    item.SubItems.Add(row[i].ToString());
                }
                result.Items.Add(item);

            }
            return result;
        }

        /// <summary>
        /// hàm chuyển list<object> thành string
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public string listIntoString(List<object> list)
        {
            string result = "";
            for (int i = 0; i < list.Count; i++)
            {
                result += list[i].ToString();
                if (i != list.Count - 1)
                {
                    result += ", ";
                }
            }
            return result;
        }

        /// <summary>
        /// Hàm lấy thông tin quản lý
        /// </summary>
        /// <returns></returns>
        public QuanLi getInfoQuanLi()
        {
            //Lấy thông tin quản lý từ database
            DataProvider data = new DataProvider();
            string query = $"SELECT * FROM quanli WHERE maql = {IdQuanLy}";
            Console.WriteLine(query);
            DataTable result = data.executeSelect(query);
            DataRow row = result.Rows[0];

            //Chuyển dữ liệu từ database sang đối tượng
            QuanLi quanLi = new QuanLi();
            quanLi.MaQL = Convert.ToInt32(row[0]);
            quanLi.TenQL = row[1].ToString();
            quanLi.TenTK = row[2].ToString();
            quanLi.MatKhau = row[3].ToString();
            quanLi.NgaySinh = row[4].ToString();
            quanLi.Sdt = row[5].ToString();

            return quanLi;
        }

        /// <summary>
        /// Hàm lấy 1 datarow bằng id và table
        /// </summary>
        /// <param name="id"></param>
        /// <param name="table"></param>
        /// <returns></returns>
        
    }
}
