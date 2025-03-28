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
            string query = "SELECT * FROM dbo.quanli WHERE tentk = @taiKhoan AND mk = @matKhau";

            DataProvider dataProvider = new DataProvider();

            List<object> parameters = new List<object>();
            parameters.Add(taiKhoan);
            parameters.Add(matKhau);

            DataTable result = dataProvider.executeSelect(query, parameters);
            if (result.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }
    }
}
