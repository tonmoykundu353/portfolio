using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;

namespace portfolio_assignmemt
{
    public partial class LOGIN : System.Web.UI.Page
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs2"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from login where username = @user and password = @pass";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@user", UserTextBox.Text);
            cmd.Parameters.AddWithValue("@pass", PassTextBox.Text);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if(dr.HasRows)
            {
                //using session
                Session["user"] = UserTextBox.Text;

                Page.ClientScript.RegisterStartupScript(this.GetType(),"scripts", "<script>alert('entering dashboard page !!')</script>");
                Response.Redirect("DASHBOARD.aspx");
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(),"scripts", "<script>alert('login failed !!')</script>");
            }
            con.Close();

        }
    }
}
