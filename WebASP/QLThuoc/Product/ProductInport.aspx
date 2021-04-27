<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProductInport.aspx.cs" Inherits="QLThuoc.Product.ProductInport" %>

<asp:Content ID="Content2" runat="server" contentplaceholderid="MainContent">
    <script>
        $(function () { $("#NgayNhaphd").datepicker({ dateFormat: "dd/MM/yyyy" }); });
</script>
   <div  >
    <p>Nhập hóa đơn Nhập</p>
    <asp:Label ID="lblThongbao" runat="server" Text="Label"></asp:Label>
        <table style="width:100%;">
            <tr>
                <td>Số hóa đơn Nhập:</td>
                <td>
                    <asp:DropDownList ID="DropDowndSHD" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDowndSHD_SelectedIndexChanged"></asp:DropDownList>
                </td>
                
            </tr>
            <tr>
                <td>Ngày nhập</td>
                <td>
                    <asp:TextBox ID="NgayNhaphd" runat="server" TextMode="Date"></asp:TextBox>
                </td>
                
            </tr>
            <tr>
                <td>Người nhập</td>
                <td>
                    <asp:TextBox ID="txtNguoinhap" runat="server"></asp:TextBox>
                </td>
                
            </tr>
            <tr>
                <td>Nhà cung cấp:</td>
                <td>
                    <asp:TextBox ID="txtNcc" runat="server"></asp:TextBox>
                </td>
                
            </tr>
            <tr>
                <td>Ghi chú:</td>
                <td>
                    <asp:TextBox ID="txtghichu" runat="server"></asp:TextBox>
                </td>
                
            </tr>
             <tr>
                <td colspan="2"> <asp:Button ID="Taohoadon" runat="server" Text="Tạo mới hóa đơn" OnClick="Taohoadon_Click" />
                    <asp:Button ID="Button1" runat="server" Text="Lưu Hóa Đơn" OnClick="Button1_Click" />
                 </td>
                 
                
            </tr>
            <tr>
                <td>Thuốc:</td>
                <td>
                    <asp:DropDownList ID="DropdownlistThuoc" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropdownlistThuoc_SelectedIndexChanged"></asp:DropDownList>
                    <br />
                    <asp:Label ID="lblTenThuoc" runat="server" Text="Ten Thuoc"></asp:Label>
                </td>
                
            </tr>
             <tr>
                <td>Số lượng:</td>
                <td>
                    <asp:TextBox ID="txtSoluong" runat="server" TextMode="Number"></asp:TextBox>
                </td>
                
            </tr>
             <tr>
                <td>Đơn giá:</td>
                <td>
                    <asp:TextBox ID="txtGia" runat="server" TextMode="Number"></asp:TextBox>
                </td>
                
            </tr>
             <tr>
                <td colspan="2"> <asp:Button ID="ThemThuoc" runat="server" Text="Thêm thuốc" OnClick="ThemThuoc_Click" /></td>
                 
                
            </tr>
        </table>
       
   </div> 
    <div>
        <asp:GridView ID="gvChitietthuoc" runat="server" AutoGenerateColumns="False" OnRowCancelingEdit="gvChitietthuoc_RowCancelingEdit" OnRowDeleting="gvChitietthuoc_RowDeleting" OnRowEditing="gvChitietthuoc_RowEditing" OnRowUpdating="gvChitietthuoc_RowUpdating">
            <Columns>
                <asp:BoundField DataField="DonThuocNhapId" HeaderText="Số HĐ" ReadOnly="True" ShowHeader="False" Visible="False" />
                <asp:BoundField DataField="ThuocId" HeaderText="Thuốc ID" ReadOnly="True" ShowHeader="False" Visible="False" />
                <asp:BoundField DataField="Thuoc_ShortName" HeaderText="Tên thuốc" ReadOnly="True" />
                <asp:BoundField DataField="Soluong" HeaderText="Số lượng" />
                <asp:BoundField DataField="Dongia" HeaderText="đơn giá" />
                <asp:BoundField HeaderText="Thành tiền" ReadOnly="True" DataField="ThanhTien" />
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
            </Columns>
        </asp:GridView>
         </div> 


</asp:Content>