//Tạm thời tầng DAL chỉ nên có 1 class nàyusing System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Data.Common;
using Project_QliSieuThi.DTO;
using Project_QliSieuThi.BLL;

namespace Project_QliSieuThi.DAL
{
    /// <summary>
    /// Class DataProvider: Cung cấp dữ liệu cho các lớp khác
    /// </summary>
    internal class DataProvider

    {
        private static DataProvider instance;// Đảm bảo lớp DataProvider chỉ có một thể hiện duy nhất
        public static string connectionStr = "Data Source=MSI\\SQLGIAKIET;Initial Catalog=QliSieuThi_db;Integrated Security=True;";


        /// <summary>
        ///Thiết lập geter và setter cho instance
        /// </summary>
        public static DataProvider Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DataProvider();
                }
                return instance;

            }
            private set => instance = value;
        }

        /// <summary>
        /// Hàm executeSelect trả về một bảng dữ liệu
        /// </summary>
        /// <param name="query"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public DataTable executeSelect(string query, List<object> parameters = null)//List<object>: Danh sách các đối tượng kiểu object
        {
            DataTable table = new DataTable();//tạo vùng nhớ dưới dạng bảng

            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    if (parameters != null)
                    {
                        string[] lam = query.Split(' ');//Split: được sử dụng để tách một chuỗi thành các phần tử con
                        int i = 0;
                        foreach (string s in lam)// vòng lặp qua mảng "lam"
                        {
                            if (s.Contains("@"))// contains: kt giá trị có chứa (...)
                            {
                                cmd.Parameters.AddWithValue(s, parameters[i]);// thêm mảng s vào list 
                                i++;
                            }
                        }

                        ////Hàm này dùng khi câu select có Where
                        //for (int i = 0; i < parameters.Count; i++)
                        //{
                        //    cmd.Parameters.AddWithValue($"@param{i}", parameters[i]);
                        //    //Hàm này công dụng y như hàm cũ nhưng viết gọn hơn
                        //}



                    }
                    Console.WriteLine(cmd.CommandText);
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(table);
                    }

                    return table;
                }
            }
        }


        /// <summary>
        /// Hàm excuteNonQueryCommand trả về số dòng bị thay đổi
        /// </summary>
        /// <param name="query"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public int excuteNonQueryCommand(string query, List<object> parameters = null)
        {
            int lineChanged = 0;
            //string connectionStr = null;
            using (SqlConnection connection = new SqlConnection(connectionStr))
            {

                connection.Open();

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {

                    if (parameters != null)
                    {
                        string[] lam = query.Split(' ');//Split: được sử dụng để tách một chuỗi thành các phần tử con,
                        int i = 0;
                        foreach (string s in lam)// vòng lặp qua mảng "lam"
                        {
                            if (s.Contains("@"))// contains: kt giá trị có chứa (...)
                            {
                                cmd.Parameters.AddWithValue(s, parameters[i]);// thêm mảng s vào list 
                                i++;
                            }
                        }
                        //for (int i = 0; i < parameters.Count; i++)
                        //{
                        //    cmd.Parameters.AddWithValue($"@param{i}", parameters[i]);
                        //    //Hàm này công dụng y như hàm cũ nhưng viết gọn hơn
                        //}
                    }

                    lineChanged = cmd.ExecuteNonQuery();
                }
            }

            return lineChanged;

        }

        /// <summary>
        /// Hàm thực thi câu lệnh truy vấn trả về một danh sách sản phẩm
        /// </summary>
        /// <returns></returns>
        public List<SanPham> executeListSanPham()
        {
            //Tạo câu select
            string query = $"SELECT masp, tensp, tenlsp, soluong, dongiaban, dongianhap FROM sanpham, loaisanpham WHERE sanpham.malsp = loaisanpham.malsp";

            DataTable data = executeSelect(query);
            List<SanPham> result = new List<SanPham>();
            foreach (DataRow row in data.Rows)
            {
                SanPham sp = new SanPham();
                sp.MaSP = Convert.ToInt32(row[0].ToString());
                sp.TenSP = row[1].ToString();
                sp.MaSP= Convert.ToInt32(row[2].ToString());
                sp.SoLuong = Convert.ToInt32(row[3].ToString());
                sp.DonGiaNhap = float.Parse(row[4].ToString());
                sp.DonGiaBan = float.Parse(row[5].ToString());
                result.Add(sp);
            }

            return result;

        }
    }
}

