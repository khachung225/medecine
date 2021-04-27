using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QLThuoc
{
    public partial class Site : System.Web.UI.MasterPage
    {
        private string UserLoginName = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                if (Session["user"] == null)
                {
                   // Response.Redirect("~/Account/Login.aspx");
                }
                else
                {
                    Label1.Text = Session["user"].ToString();
                }
            }
        }
    }
}