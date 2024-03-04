using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace portfolio_assignmemt
{
    public partial class DASHBOARD : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"]!=null)
            {
                Response.Write("Welcome to my dashboard " + Session["user"].ToString());
            }
            else
            {
                Response.Redirect("LOGIN.aspx");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (Session["user"] != null)
            {
                Session["user"] = null;
                Response.Redirect("login.aspx");
            }
        }
    }
}
