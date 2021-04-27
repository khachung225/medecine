using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.Security;
using System.Web.UI.WebControls;
using QLThuoc.Entity;

namespace QLThuoc.Account
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                var username = TextBox2.Text;

                var userinfosql = new MySQLUserInfo();
                var userinfo = userinfosql.GetUserInfo(username);
                if (userinfo != null)
                {
                   // var pasen = EncryptString.Encode(TextBox1.Text);
                    var pasen = TextBox1.Text;
                    if (userinfo.Passwold == pasen)
                    {
                        Label1.Text = "Dang nhap " + username;
                        Session["user"] = username;
                        Response.Redirect("~/Default.aspx");
                    }else
                    {
                        Label1.Text = "Username hoac password không đúng";
                    }
                }
            }
            catch (Exception ex) { }
        }
    }
}