using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_QliSieuThi.DAL
{
    public class DataProvider
    {
        string connectionSTR = "Data Source=MSI\\SQLGIAKIET;Initial Catalog=QliSieuThi_db;Integrated Security=True;";

        public DataTable ExcuteQuery (string query) 
        {
            //Ham truy van bang cau lenh Select

            DataTable data= new DataTable ();

            //using cho phep giai phong vung nho khi chay het lenh trong khoi hoac co mot dong trong khoi bi loi
            using (SqlConnection conn = new SqlConnection(connectionSTR))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(data);

                conn.Close();
            }
            return data;

           
        }
    }
}
