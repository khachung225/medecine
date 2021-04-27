using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QLThuoc.Entity
{
    public class MySQLBase
    {
        protected MySqlConnection GetMySQLConnect()
        {
            try {
                var con = new MySqlConnection("Data Source=localhost;Database=ql_thuoc;User ID=root;Password=Lekhachung!!!@86");
                
                return con;
            }
            catch (Exception ex)
            { }
            return null;
        }

        private List<DonThuocNhap> GetAllHoaDon()
        {
            var list = new List<DonThuocNhap>();
            try
            {
                using (MySqlConnection conn = GetMySQLConnect())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("select top 20 * from DonThuocNhap", conn);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new DonThuocNhap()
                            {
                                DonThuocNhapId = Convert.ToInt32(reader["DonThuocNhapId"]),
                                SoHoaDon = reader["SoHoaDon"].ToString(),
                                NgayLap = Convert.ToDateTime(reader["NgayLap"]),
                                NguoiLap = reader["NguoiLap"].ToString(),
                                Cpty = reader["Cpty"].ToString(),
                                GhiChu = reader["GhiChu"].ToString()
                            });
                        }
                    }
                }  
               
            }
            catch (Exception ex)
            { }
            return list;
        }


    }
}