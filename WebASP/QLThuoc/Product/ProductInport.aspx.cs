using QLThuoc.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QLThuoc.Product
{
    public partial class ProductInport : System.Web.UI.Page
    {
        private Dictionary<string, ChiTietDonNhap> DicDonnhap = new Dictionary<string, ChiTietDonNhap>();
        private MySQLDonThuocNhap mysqldonthuocnhap = new MySQLDonThuocNhap();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {              
          
            HoaDonFilData();
            ThuocFillData();
            DisplayGridChitietDon();
            }
        }

        void HoaDonFilData()
        {
            var listDonNhap = new List<DonThuocNhap>();
            listDonNhap.Add(new DonThuocNhap { SoHoaDon="123",NguoiLap="chung",DonThuocNhapId=1});
            listDonNhap.Add(new DonThuocNhap { SoHoaDon = "234", NguoiLap = "chung2", DonThuocNhapId = 2 });
            listDonNhap.Add(new DonThuocNhap { SoHoaDon = "456", NguoiLap = "chung3", DonThuocNhapId = 3 });
           
            DropDowndSHD.DataTextField = "SoHoaDon";
            DropDowndSHD.DataValueField = "DonThuocNhapId";
            DropDowndSHD.DataSource = listDonNhap;
            DropDowndSHD.DataBind();
        }
        void ThuocFillData()
        {
            var listThuoc = new List<Thuoc>();
            listThuoc.Add(new Thuoc { MaThuoc = "123", Thuoc_ShortName = "chung", ThuocId = 1 });
            listThuoc.Add(new Thuoc { MaThuoc = "234", Thuoc_ShortName = "chung2", ThuocId = 2 });
            listThuoc.Add(new Thuoc { MaThuoc = "456", Thuoc_ShortName = "chung3", ThuocId = 3 });

            DropdownlistThuoc.DataTextField = "Thuoc_ShortName";
            DropdownlistThuoc.DataValueField = "ThuocId";
            DropdownlistThuoc.DataSource = listThuoc;
            DropdownlistThuoc.DataBind();
        }
        //
        protected void DropDowndSHD_SelectedIndexChanged(object sender, EventArgs e)
        {
            try {
                var itermselect = DropDowndSHD.SelectedItem.Value;
            }
            catch (Exception ex) { }

        }

        protected void DropdownlistThuoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var itermselect = DropdownlistThuoc.SelectedItem.Value;
                var itermselectText = DropdownlistThuoc.SelectedItem.Text;
                lblTenThuoc.Text = itermselectText;

            }
            catch (Exception ex) { }
        }
        //them thuoc vao don
        protected void ThemThuoc_Click(object sender, EventArgs e)
        {
            try
            {
                var itermselect = DropdownlistThuoc.SelectedItem.Value;
                var itermselectText = DropdownlistThuoc.SelectedItem.Text;
                var soluongtext = txtSoluong.Text;
                var giaText = txtGia.Text;
                if (valideChitietThuoc(soluongtext, giaText))
                {
                    var chitietnhap = GetChitietthuocNhap();
                    if (chitietnhap != null)
                    {
                        //insert db
                        DicDonnhap[chitietnhap.GetKey()] =chitietnhap;
                        LoadChitietNhap();
                        DisplayGridChitietDon();
                    }

                }


            }
            catch (Exception ex) { }
        }
        private void LoadChitietNhap()
        {
            var datatable = new DataTable();
            datatable.Columns.AddRange(new DataColumn[6] { 
             new DataColumn("DonThuocNhapId", typeof(int)), 
             new DataColumn("ThuocId", typeof(int)), 
             new DataColumn("Thuoc_ShortName", typeof(string)),    
                    new DataColumn("Soluong", typeof(int)),    
                    new DataColumn("Dongia",typeof(decimal)),
                    new DataColumn("ThanhTien",typeof(decimal))});
            foreach (var chitietthuoc in DicDonnhap.Values.ToList())
            {
                datatable.Rows.Add(chitietthuoc.DonThuocNhapId,
                            chitietthuoc.ThuocId, chitietthuoc.Thuoc_ShortName,
                            chitietthuoc.Soluong, chitietthuoc.Dongia,
                            chitietthuoc.ThanhTien);
            }

            ViewState["dt"] = datatable;
        }
        private void DisplayGridChitietDon()
        {
 	         try
                    {
             
                    gvChitietthuoc.DataSource = ViewState["dt"] as DataTable;    
                    gvChitietthuoc.DataBind();   
                    }
                    catch (Exception ex) { }
        }

        private bool valideChitietThuoc(string soluongtxt, string giatxt)
        {
            try
            {
                int soluong;
                decimal dongia;
                if (!int.TryParse(soluongtxt, out soluong))
                {
                    lblThongbao.Text = "Số lượng thuốc nhập chưa đúng";
                    return false;
                }
                if (!decimal.TryParse(giatxt, out dongia))
                {
                    lblThongbao.Text = "Số lượng thuốc nhập chưa đúng";
                    return false;
                }
                return true;
            }
            catch (Exception ex) { }
            return false;
        }

        private ChiTietDonNhap GetChitietthuocNhap()
        {
              
            try
            {
                var chitietthuoc = new ChiTietDonNhap();
                   var textshd = DropDowndSHD.SelectedItem.Value;
                var itermselect = DropdownlistThuoc.SelectedItem.Value;
                var itermselectText = DropdownlistThuoc.SelectedItem.Text;
                var soluongtext = txtSoluong.Text;
                var giaText = txtGia.Text;

                chitietthuoc.Thuoc_ShortName = itermselectText;
                chitietthuoc.Soluong = int.Parse(soluongtext);
                chitietthuoc.Dongia = decimal.Parse(giaText);
                chitietthuoc.DonThuocNhapId = int.Parse(textshd);
                chitietthuoc.ThuocId = int.Parse(itermselect);

                return chitietthuoc; 
            }
            catch (Exception ex) { }
            return null;
        }

        protected void gvChitietthuoc_RowEditing(object sender, GridViewEditEventArgs e)
        {
            try
            {
                gvChitietthuoc.EditIndex = e.NewEditIndex;
                DisplayGridChitietDon();
            }
            catch (Exception ex) { }
        }

        protected void gvChitietthuoc_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {

            }
            catch (Exception ex) { }
        }

        protected void gvChitietthuoc_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {          
            var row = (sender as GridView).Rows[e.RowIndex];
            string soluongtext = (row.Cells[3].Controls[0] as TextBox).Text;
            string giaText = (row.Cells[4].Controls[0] as TextBox).Text;

           if (valideChitietThuoc(soluongtext, giaText))
            {
                DataTable dt = ViewState["dt"] as DataTable;
                dt.Rows[row.RowIndex]["Soluong"] = int.Parse(soluongtext);
                dt.Rows[row.RowIndex]["Dongia"] = decimal.Parse(giaText);
                dt.Rows[row.RowIndex]["ThanhTien"] = int.Parse(soluongtext) * decimal.Parse(giaText);
                ViewState["dt"] = dt;

                gvChitietthuoc.EditIndex = -1;
                DisplayGridChitietDon();
            }
            else
            { lblThongbao.Text = "Loi sưa chi tiet nhap"; }
           
        }

        protected void gvChitietthuoc_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            //Reset the edit index.
            gvChitietthuoc.EditIndex = -1;
            //Bind data to the GridView control.
            DisplayGridChitietDon();
        }
        //tao moi hoa don.
        protected void Taohoadon_Click(object sender, EventArgs e)
        {
            setdefaultHoaDonnhap();
        }
        void setdefaultHoaDonnhap()
        {
            //Reset the edit index.
            gvChitietthuoc.EditIndex = -1;
            gvChitietthuoc.DataSource = null;
            //set ngay tao hoa don.
            NgayNhaphd.Text = DateTime.Now.ToString("yyyy-MM-dd");
            txtNguoinhap.Text = string.Format("{0}", Session["user"]);
            txtNcc.Text = "";
            txtghichu.Text = "";
        }
        //luu hoa don
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (checkHoaDonNhap())
            {
                var hoadonnhap = new DonThuocNhap {
                GhiChu = txtghichu.Text,
                NguoiLap = txtNguoinhap.Text,
                NgayLap = DateTime.Parse(NgayNhaphd.Text),
                SoHoaDon = DropDowndSHD.Text
                };
                var themthuoc = mysqldonthuocnhap.ThemDonThuocNhap(hoadonnhap);
                if (themthuoc)
                { }
                else
                {

                }
            }
        }

        private bool checkHoaDonNhap()
        {
            try {

                return true;
            }
            catch (Exception ex)
            {
 
            }
            return false;
        }

        
    }
}