using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QLThuoc.Entity
{
    public class DonThuocNhap
    {
        public int DonThuocNhapId { get; set; }
        public string SoHoaDon { get; set; }
        public DateTime NgayLap { get; set; }
        public string NguoiLap { get; set; }
        public string Cpty { get; set; }
        public string GhiChu { get; set; }
    }
    public class Thuoc
    {
        public int ThuocId { get; set; }
        public string MaThuoc { get; set; }        
        public string Thuoc_ShortName { get; set; }
        public string Thuoc_FullName { get; set; }
       
    }

    public class ChiTietDonNhap
    {
        public ChiTietDonNhap()
        {
            Soluong = 0;
            Dongia = 0;
        }
        public int DonThuocNhapId { get; set; }
        public int ThuocId { get; set; }      
        public string Thuoc_ShortName { get; set; }
        public int Soluong { get; set; }
        public Decimal Dongia { get; set; }

        public Decimal ThanhTien { get { return Soluong * Dongia; } }

        public string GetKey()
        {
            return string.Format("{0}_{1}", DonThuocNhapId, ThuocId);
        }
    }
    public class UserInfo
    {

        public int UserInfoId { get; set; }
        public string UserLogin { get; set; }
        public string Passwold { get; set; }
        public DateTime LastloginTime { get; set; }

             
    }
}