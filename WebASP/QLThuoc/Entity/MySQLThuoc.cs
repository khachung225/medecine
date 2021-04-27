using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QLThuoc.Entity
{
    public class MySQLThuoc : MySQLBase
    {

        public UserInfo GetUserInfo(string username)
        {
            var useinfo = new UserInfo();
            try
            {
                using (MySqlConnection conn = GetMySQLConnect())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("select * from UserInfo where UserLogin ='" + username + "'", conn);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                             
                                useinfo.UserInfoId = Convert.ToInt32(reader["UserInfoId"]);
                                useinfo.UserLogin = reader["UserLogin"].ToString();
                                useinfo.Passwold = reader["Passwold"].ToString();
                                useinfo.LastloginTime = Convert.ToDateTime(reader["LastloginTime"]);
                            
                        }
                    }
                }  
               
            }
            catch (Exception ex)
            { }
            return useinfo;
        }


    }
}