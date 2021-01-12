using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Data.SqlClient;
using System.Diagnostics;

namespace weatherForecastAppPOE
{
    public partial class frmLoginPage : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();


        SqlDataAdapter adp = new SqlDataAdapter();
        SqlCommand cmd;
        SqlConnection con = new SqlConnection(Program.connection);
        DataSet ds = new DataSet();
        List<string> defaultCityPrefList = new List<string>();

        public static int exists = 0;
     
        frmMainMenu mm = new frmMainMenu();

        public frmLoginPage()
        {

            InitializeComponent();

        }

        public void InsertLoginDetailsGenUser()
        {
            try
            {
                string sql = "";
                con.Open();

                sql = $"Insert into GEN_USER_LOGIN_DETAILS([GEN_USERNAME],[GEN_PASSWORD])values('{tbRegUsername.Text}','{tbRegPassword.Text}')";
                cmd = new SqlCommand(sql, con);

                adp.InsertCommand = new SqlCommand(sql, con);
                adp.InsertCommand.ExecuteNonQuery();

                cmd.Dispose();
                con.Close();

                ds.Clear();
                cmd = new SqlCommand($"SELECT DISTINCT CITY_NAME FROM WEATHER_FORECAST", con);
                adp = new SqlDataAdapter(cmd);
                adp.Fill(ds);

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    defaultCityPrefList.Add(ds.Tables[0].Rows[i]["CITY_NAME"].ToString());

                }

                foreach (var item in defaultCityPrefList)
                {
                    con.Open();

                    sql = $"Insert into CITY_PREFERENCE_GEN_USER([GEN_USERNAME],[CITY_NAME])values('{tbRegUsername.Text}','{item}')";
                    cmd = new SqlCommand(sql, con);

                    adp.InsertCommand = new SqlCommand(sql, con);
                    adp.InsertCommand.ExecuteNonQuery();

                    cmd.Dispose();
                    con.Close();
                }




            }
            catch (SqlException ex)
            {

                if (ex.Number == 2627)
                {
                    MessageBox.Show("Username already exists. Please choose a diiferent username and try again", "Error");
                    tbRegUsername.Text = "";
                    tbRegPassword.Text = "";
                    exists = 1;
                }

                con.Close();
            }



        }

        public void InsertLoginDetailsForecaster()
        {

            try
            {
                string sql = "";
                con.Open();

                sql = $"Insert into FORECASTER_LOGIN_DETAILS([FORE_USERNAME],[FORE_PASSWORD])values('{tbRegUsername.Text}','{tbRegPassword.Text}')";
                cmd = new SqlCommand(sql, con);

                adp.InsertCommand = new SqlCommand(sql, con);
                adp.InsertCommand.ExecuteNonQuery();

                cmd.Dispose();
                con.Close();



            }
            catch (SqlException ex)
            {

                if (ex.Number == 2627)
                {
                    MessageBox.Show("Username already exists. Please choose a diiferent username and try again", "Error");
                    tbRegUsername.Text = "";
                    tbRegPassword.Text = "";
                    exists = 1;
                }

                con.Close();
            }



        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
            this.Hide();
            this.Show();


        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            if (cbLogForecaster.Checked == false && cbLogGenUser.Checked == false)
            {
                MessageBox.Show("No user type selected. Please select what type of user you are and try again", "Error");
                return;
            }

            //if user type forecaster is checked do following actions else
            if (cbLogForecaster.Checked == true)
            {
                cmd = new SqlCommand($"SELECT * FROM FORECASTER_LOGIN_DETAILS WHERE FORE_USERNAME='{tbLogUsername.Text}'AND FORE_PASSWORD = '{tbLogPassword.Text}'",con);
                adp = new SqlDataAdapter(cmd);
                adp.Fill(ds);
                int i = ds.Tables[0].Rows.Count;
                if (i > 0)
                {
                    frmMainMenu.currentUserName = tbLogUsername.Text;
                    frmMainMenu.userType = 1;
                    mm.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Username or password are incorrect. Please check your spelling and try again", "Error");
                    tbLogUsername.Text = "";
                    tbLogPassword.Text = "";
                }
                
            }
            else
            {
                try
                {
                    cmd = new SqlCommand($"SELECT * FROM GEN_USER_LOGIN_DETAILS WHERE GEN_USERNAME='{tbLogUsername.Text}'AND GEN_PASSWORD = '{tbLogPassword.Text}'", con);
                    adp = new SqlDataAdapter(cmd);
                    adp.Fill(ds);
                    int i = ds.Tables[0].Rows.Count;
                    if (i > 0)
                    {
                        frmMainMenu.currentUserName = tbLogUsername.Text;
                        frmMainMenu.userType = 0;
                        mm.Show();
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("Username or password are incorrect. Please check your spelling and try again", "Error");
                        tbLogUsername.Text = "";
                        tbLogPassword.Text = "";
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("Outdated MSSQLLocalDB Server Version", "Error: The database file could not be accessed");
                }

             

            }
        }

        private void btRegister_Click_1(object sender, EventArgs e)
        {
            //Checks if user type has been selected
            if (cbRegForecaster.Checked == false && cbRegGeneralUser.Checked == false)
            {
                MessageBox.Show("No user type selected. Please select what type of user you are and try again", "Error");
                return;
            }

            //if user type forecaster is checked do following actions else
            if (cbRegForecaster.Checked == true)
            {

                InsertLoginDetailsForecaster();

                if (exists != 1)
                {
                    
                    MessageBox.Show("Registration Successful. You may now login!", "Registration Successful");

                    tbRegUsername.Text = "";
                    tbRegPassword.Text = "";
                    tcLogin.SelectedTab = tpLog;
                    cbRegGeneralUser.Checked = false;
                   
                }

                exists = 0;


            }
            else
            {

                InsertLoginDetailsGenUser();
                
                
                if(exists != 1)
                {
                    MessageBox.Show("Registration Successful. You may now login!", "Registration Successful");
                    tbRegUsername.Text = "";
                    tbRegPassword.Text = "";
                    tcLogin.SelectedTab = tpLog;
                    cbRegForecaster.Checked = false;
                  
                }

                exists = 0;
            }

        }
    
		private void cbRegForecaster_MouseClick_1(object sender, MouseEventArgs e)
		{
			if (cbRegGeneralUser.Checked)//if checked, uncheck it
			{
				cbRegGeneralUser.Checked = false;
			}
		}

		private void cbRegGeneralUser_MouseClick_1(object sender, MouseEventArgs e)
		{
			if (cbRegForecaster.Checked)//if checked, uncheck it
			{
				cbRegForecaster.Checked = false;
			}
		}
        
		private void cbLogForecaster_MouseClick_1(object sender, MouseEventArgs e)
		{
			if (cbLogGenUser.Checked)//if checked, uncheck it
			{
				cbLogGenUser.Checked = false;
			}
		}

		private void cbLogGenUser_MouseClick_1(object sender, MouseEventArgs e)
		{
			if (cbLogForecaster.Checked)//if checked, uncheck it
			{
				cbLogForecaster.Checked = false;
			}
		}

        private void MoveBorderlessFormOnMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void ExitButton(object sender, EventArgs e)
        {
            const string message = "Are you sure you want to leave?";
            const string caption = "EXIT";

            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (result == DialogResult.Yes)
            {
                this.Close();
            }

        }

      
        private void GoToWebAppLoginLLOne(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://localhost:56810/GeneralUserLogin.aspx");
        }

        private void GoToWebAppLoginLLTwo(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GoToWebAppLoginLLOne(sender,  e);
        }
    }
}
