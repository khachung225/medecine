using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QLThuoc.Entity
{
    public class MySQLDonThuocNhap: MySQLBase
    {
                   
        public List<DonThuocNhap> GetAllDonThuocNhap()
        {
            var listdonthuoc = new List<DonThuocNhap>();
            try
            {
                using (MySqlConnection conn = GetMySQLConnect())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("select * from donthuocnhap", conn);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            var entry = Mappingdata(reader);
                            if (entry != null) listdonthuoc.Add(entry);
                        }
                    }
                }  
               
            }
            catch (Exception ex)
            { }
            return listdonthuoc;
        }

        private DonThuocNhap Mappingdata(MySqlDataReader reader)
        {
            try {
                var data = new DonThuocNhap();
                data.DonThuocNhapId = Convert.ToInt32(reader["DonThuocNhapId"]);
                data.SoHoaDon = reader["SoHoaDon"].ToString();
                data.NgayLap = Convert.ToDateTime(reader["NgayLap"]);
                data.NguoiLap = reader["NguoiLap"].ToString();
                data.Cpty = reader["Cpty"].ToString();
                data.GhiChu = reader["GhiChu"].ToString();               

            }
            catch (Exception ex)
            { }
            return null;
        }

        public bool ThemDonThuocNhap(DonThuocNhap data)
        {
            try
            {
                

            }
            catch (Exception ex)
            { }

            return false;
        }


    }
}