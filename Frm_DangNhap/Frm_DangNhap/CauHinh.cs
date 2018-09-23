using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Common;
using System.Data.Sql;

namespace Frm_DangNhap
{
 public  class CauHinh 
    {
     public static int Check_Config()
     {
         if (Properties.Settings.Default.LTWNC == string.Empty)
             return 1;//chuỗi cấu hình không tồn tại
         SqlConnection _sqlconn = new SqlConnection(Properties.Settings.Default.LTWNC);
         try
         {
             if (_sqlconn.State == System.Data.ConnectionState.Closed)
                 _sqlconn.Open();
             return 0;//Kết nối thành công chuỗi cấu hình hợp lệ
         }
         catch
         {
             return 2; //Chuỗi cấu hình không phù hợp
         }
     }
     public static int Check_User(string pUser, string ppass)
     {
         SqlDataAdapter daUser = new SqlDataAdapter("select* from account where Username='" + pUser + "' and Password='" + ppass + "'", Properties.Settings.Default.LTWNC);
         System.Data.DataTable dt = new System.Data.DataTable();
         daUser.Fill(dt);
         if (dt.Rows.Count == 0)
             return 0;//User k tồn tại
         else if (dt.Rows[0]["tinhtrang"] ==null || dt.Rows[0]["tinhtrang"].ToString() == "false")
         {
             return 1;//không hoạt động
         }
         return 2;//đăng nhập thành công
     }
     public static System.Data.DataTable GetSeverName()
     { 
         SqlDataSourceEnumerator instance=SqlDataSourceEnumerator.Instance;
         System.Data.DataTable table = instance.GetDataSources();
                 return table;

     }
    }

}
