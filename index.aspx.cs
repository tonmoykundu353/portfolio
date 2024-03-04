using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace portfolio_assignmemt
{
    public partial class index : System.Web.UI.Page
    {
        
        string cs = ConfigurationManager.ConnectionStrings["dbcs3"].ConnectionString;
        static int i = 2;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SubmitButton_Click(object sender, EventArgs e)
        {
           
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            i = i + 1;
            string query = "INSERT INTO TABLE (id,name,email,message)  VALUES (i,@name,@email,@message)";
            SqlCommand cmd = new SqlCommand(query, con);

            

            cmd.Parameters.AddWithValue("@name",NameTextBox.Text);
            cmd.Parameters.AddWithValue("@email", EmailTextBox.Text);
            cmd.Parameters.AddWithValue("@message", MessageTextBox.Text);
            cmd.ExecuteNonQuery();

            con.Close();


        }
    }
}
