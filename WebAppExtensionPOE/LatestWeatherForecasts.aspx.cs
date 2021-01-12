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
    public partial class LatestWeatherForecasts : System.Web.UI.Page
    {
        SqlDataAdapter adp = new SqlDataAdapter();
        SqlCommand cmd;
        SqlConnection con = new SqlConnection(Global.connection);
        DataSet ds = new DataSet();

        public void populateGridView1()
        {
            SqlCommand cmd = new SqlCommand($"SELECT c.CITY_NAME ,w.WF_DATE, w.MIN_TEMP,w.MAX_TEMP,w.PRECIPITATION,w.HUMIDITY,w.WIND_SPEED FROM CITY_PREFERENCE_GEN_USER c inner join WEATHER_FORECAST w ON c.CITY_NAME = w.CITY_NAME WHERE c.GEN_USERNAME = '{Session["Username"].ToString()}' order by wf_date desc", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);

            GridView1.DataSource = ds;
            GridView1.DataBind();
        }

        protected void Page_Load(object sender, EventArgs e)
        {

            if (DropDownListPreferences.Items.Count==1)
            {
                
                SqlCommand cmd = new SqlCommand($"SELECT CITY_NAME FROM [CITY_PREFERENCE_GEN_USER] WHERE GEN_USERNAME = '{Session["Username"]}'", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    DropDownListPreferences.Items.Add(ds.Tables[0].Rows[i]["CITY_NAME"].ToString());
                }

                

            }


            populateGridView1();


            GridView2.Visible = true;


        }

        protected void btViewSpecificFavCity_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand($"SELECT c.CITY_NAME,w.WF_DATE, w.MIN_TEMP,w.MAX_TEMP,w.PRECIPITATION,w.HUMIDITY,w.WIND_SPEED FROM CITY_PREFERENCE_GEN_USER c inner join WEATHER_FORECAST w ON c.CITY_NAME = w.CITY_NAME WHERE c.GEN_USERNAME = '{Session["Username"].ToString()}' AND c.CITY_NAME = '{DropDownListPreferences.SelectedItem.Value.ToString()}' order by wf_date desc", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);

            GridView2.DataSource = ds;
            GridView2.DataBind();

            GridView2.Visible = true;
            GridView1.Visible = false;
        }

        protected void btViewAllRecords_Click(object sender, EventArgs e)
        {
           GridView2.Visible = false;
           GridView1.Visible = true;
        }

        protected void btSignOut_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/GeneralUserLogin.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}