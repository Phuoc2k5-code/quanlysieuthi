using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_QliSieuThi.DAL;
using Project_QliSieuThi.BLL;

namespace Project_QliSieuThi.BLL
{
    public class UserManager
    {
        public DataProvider dataProvider=new DataProvider();
        
        public bool checkLogin(string tentk,string mk)
        {
            //Ham kiem tra thong tin dang nhap
            DataTable dt = new DataTable();
            string query = $"SELECT * FROM quanli WHERE tentk = '{tentk}' AND mk = '{mk}' ";

            dt = dataProvider.ExcuteQuery(query);

            return dt.Rows.Count > 0;
        }

        public void userInfo(string tentk, string mk)
        {
            //Ham set thong tin quan ly
            DataTable dt = new DataTable();
            DataRow dr;
            string query = $"SELECT * FROM quanli WHERE tentk = '{tentk}' AND mk = '{mk}' ";

            dt = dataProvider.ExcuteQuery(query);

            dr = dt.Rows[0];
            UserInfo.maQl = dr[0].ToString();
            UserInfo.tenQl = dr[1].ToString();
            UserInfo.tenTk = dr[2].ToString();
            UserInfo.matKhau = dr[3].ToString();
            UserInfo.ngaySinh = dr[4].ToString();
            UserInfo.sdt=dr[5].ToString();
        }
    }
}
