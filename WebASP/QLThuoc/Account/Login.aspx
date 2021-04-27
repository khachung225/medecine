<%@ Page Language="C#" Title=""  MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="QLThuoc.Account.Login" %>

 
<asp:Content ID="Content2" runat="server" contentplaceholderid="MainContent">
    <div style="text-align: center; display: inline-table; float: inherit;" >
    <p> &nbsp;</p>
    <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        <table style="width:100%;">
            <tr>
                <td>Tên dang nhap</td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    </td>
                
            </tr>
            <tr>
                <td>Mật khẩu</td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server" TextMode="Password"></asp:TextBox>
                </td>
                
            </tr>
             <tr>
                <td colspan="2"> <asp:Button ID="Button1" runat="server" Text="Đăng nhập" OnClick="Button1_Click" /></td>
                 
                
            </tr>
        </table>
       
   </div> 

</asp:Content>
