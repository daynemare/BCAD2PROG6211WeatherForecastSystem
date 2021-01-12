using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppExtensionPOE
{
    public partial class GeneralUserLogin : System.Web.UI.Page
    {
        SqlDataAdapter adp = new SqlDataAdapter();
        SqlCommand cmd;
        SqlConnection con = new SqlConnection(Global.connection);
        DataSet ds = new DataSet();

  

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btSave_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand($"SELECT * FROM GEN_USER_LOGIN_DETAILS WHERE GEN_USERNAME='{tbUsername.Text}'AND GEN_PASSWORD = '{tbPassword.Text}'", con);
            adp = new SqlDataAdapter(cmd);
            adp.Fill(ds);
            int i = ds.Tables[0].Rows.Count;
            if (i > 0)
            {
                Session["Username"] = tbUsername.Text;
                Response.Redirect("~/LatestWeatherForecasts.aspx");

            }
            else
            {
                lblError.Text = "Username or password are incorrect. Please check your spelling and try again";
              
            }
        }

        protected void btClearAll_Click(object sender, EventArgs e)
        {
            lblError.Text = "";
            tbPassword.Text = "";
            tbUsername.Text = "";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}