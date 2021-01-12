using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace weatherForecastAppPOE
{
    public partial class frmNewEntry : Form
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
        DataSet ds2 = new DataSet();
        public static int exists = 0;
        private string username;
     


        //Declaring object of the class main menu to pass it through frmNewEntry class constructor on line 20 to enable access to the main menu form class methods.  
        frmMainMenu mm;
		List<string> cityPrefList = new List<string>();
        List<string> cityList = new List<string>();
        List<string> cityListTemp = new List<string>();
        
        public frmNewEntry(frmMainMenu cmm, string user)
        {
            this.username = user;
            InitializeComponent();
            this.mm = cmm;
        }
	

        public void InsertForecastDetails(string cityName,string date,double minTemp, double maxTemp,double precip,double humidity, double windSpeed)
        {
            try
            {
                string sql = "";
                con.Open();

                sql = $"Insert into WEATHER_FORECAST([CITY_NAME],[WF_DATE],[MIN_TEMP],[MAX_TEMP],[PRECIPITATION],[HUMIDITY],[WIND_SPEED])" +
                    $"values('{cityName}','{date}',{minTemp},{maxTemp},{precip},{humidity},{windSpeed})";
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
                    MessageBox.Show("Record already exists for the date and city specified. Please go to edit records menu if you would like to change this particular forecast", "Error");
                    // all the text boxes in the new entry form are cleared.
                    tbCityName.Text = "";
                    dtpDate.Text = "";
                    tbMinTemp.Text = "";
                    tbMaxTemp.Text = "";
                    tbPrecipitation.Text = "";
                    tbHumidity.Text = "";
                    tbWindSpeed.Text = "";
                    exists = 1;
                }

                con.Close();
            }



        }

        //Method that enables the button btSaveEntry on condition that all text box fields have been filled with text else if all text boxes are not filled then the button remains disabled. 
        public void AllFieldsFilled()
		{
			if (string.IsNullOrWhiteSpace(tbCityName.Text) || string.IsNullOrWhiteSpace(tbMinTemp.Text) || string.IsNullOrWhiteSpace(tbMaxTemp.Text) || string.IsNullOrWhiteSpace(tbHumidity.Text) || string.IsNullOrWhiteSpace(tbPrecipitation.Text) || string.IsNullOrWhiteSpace(tbWindSpeed.Text))
			{
				btSaveFore.Enabled = false;
				btSaveFore.ForeColor = Color.Black;
				btSaveFore.BackColor = Color.White;
			}
			else
			{
				btSaveFore.Enabled = true;
				btSaveFore.ForeColor = Color.White;
				btSaveFore.BackColor = Color.Black;
			}
		}

        private void btSaveEntry_Click(object sender, EventArgs e)
        {
			
			//Declaration of variables used in the following conditional statements to ensure that the data being input by the user meets application input specifications.
			double minTempCompare = Convert.ToDouble(tbMinTemp.Text);
			double maxTempCompare = Convert.ToDouble(tbMaxTemp.Text);
			double precipCompare = Convert.ToDouble(tbPrecipitation.Text);
			double humidityCompare = Convert.ToDouble(tbHumidity.Text);


			//This if statement throws up an error message on the screen if the user inputs a min Temp value that is higher that the max Temp value.
			if (minTempCompare>maxTempCompare)
            {
                MessageBox.Show("The minimum temperature cannot to be higher than the maximum temperature","ERROR");
                tbMinTemp.Text = "";
                tbMaxTemp.Text = "";
			}//This if statement throws up an error message on the screen if the user inputs a value over 100% for the precipitation field.
			else if(precipCompare>100)
            {
                MessageBox.Show("The value you entered for precipitation cannot be above 100%", "ERROR");
                tbPrecipitation.Text = "";

			}//This if statement throws up an error message on the screen if the user inputs a value over 100% for the humidity field.
			else if(humidityCompare > 100)
            {
                 MessageBox.Show("The value you entered for humidity cannot be above 100%", "ERROR");
                tbHumidity.Text = "";
            }
			else {
				
				//Method call to enable the button btGenerateReport now that the system holds data that it can output at the reports menu
				mm.EnableUIControl();

				

				//The following code sets the input to their relative variables in the fdc object class instance of the ForecastData class
				string cityName = tbCityName.Text.ToUpper();
				string forecastDate = Convert.ToDateTime(dtpDate.Text).ToString("yyyy/MM/dd");
                double minTemp = Convert.ToDouble(tbMinTemp.Text);
                double maxTemp = Convert.ToDouble(tbMaxTemp.Text);
				double precipitation = Convert.ToDouble(tbPrecipitation.Text);
				double humidity = Convert.ToDouble(tbHumidity.Text);
				double windSpeed = Convert.ToDouble(tbWindSpeed.Text);

                InsertForecastDetails(cityName,forecastDate,minTemp,maxTemp,precipitation,humidity,windSpeed);
				
                if(exists != 1)
                {
                    //The following decision structure asks the user if they would like to create another new entry, if the user says yes it clears the appropriate text box fields, if the user clicks no then it closes the form and returns to the main menu
                    DialogResult neYesNo = MessageBox.Show("Create another entry?", "Success!", MessageBoxButtons.YesNo);

                    if (neYesNo == DialogResult.Yes)
                    {
                        tbCityName.Text = "";
                        dtpDate.Text = "";
                        tbMinTemp.Text = "";
                        tbMaxTemp.Text = "";
                        tbPrecipitation.Text = "";
                        tbHumidity.Text = "";
                        tbWindSpeed.Text = "";

                    }
                    else
                    {

                        mm.Show();
                        this.Dispose();

                    }
                }

				

			}



		}

        private void btClearAll_Click(object sender, EventArgs e)
        {
			//When the button btClearAll is clicked,  all the text boxes in the new entry form are cleared.
            tbCityName.Text = "";
            dtpDate.Text = "";
            tbMinTemp.Text = "";
            tbMaxTemp.Text = "";
            tbPrecipitation.Text = "";
            tbHumidity.Text = "";
            tbWindSpeed.Text = "";

        }

        private void tbMinTemp_KeyPress(object sender, KeyPressEventArgs e)
        {
			//Restricts the user to only use numererical keyboard inputs
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void tbMaxTemp_KeyPress(object sender, KeyPressEventArgs e)
        {
			//Restricts the user to only use numererical keyboard inputs
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void tbPrecipitation_KeyPress(object sender, KeyPressEventArgs e)
		{   
			//Restricts the user to only use numererical keyboard inputs
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void tbHumidity_KeyPress(object sender, KeyPressEventArgs e)
        {
			//Restricts the user to only use numererical keyboard inputs
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void tbWindSpeed_KeyPress(object sender, KeyPressEventArgs e)
		{   //Restricts the user to only use numererical keyboard inputs
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void tbCityName_KeyPress(object sender, KeyPressEventArgs e)
		{   //Restricts the user to only use alphabetical keyboard inputs
			if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

		private void btReturnMain_Click(object sender, EventArgs e)
		{	
            
            //when the button btReturnMain is clicked, this form closes and the main menu form appears
			frmMainMenu fmm = new frmMainMenu();
			fmm.Show();
			this.Dispose();
		}

		private void frmNewEntry_Load(object sender, EventArgs e)
		{
			//On form load the button btSaveEntry is disabled till conditions are met to enable it 
			btSaveFore.Enabled = false;

			if(frmMainMenu.userType == 0)
			{
				cblCityPreferences.Visible = true;
				lblTitleInpit.Text = "City Preferences";
				btSaveGen.Visible = true;
				btClearAll.Visible = false;
				lblAvailRecords.Visible = true;

                ds.Clear();
                cmd = new SqlCommand($"SELECT DISTINCT CITY_NAME FROM WEATHER_FORECAST", con);
                adp = new SqlDataAdapter(cmd);
                adp.Fill(ds);

                ds2.Clear();
                cmd = new SqlCommand($"SELECT CITY_NAME FROM CITY_PREFERENCE_GEN_USER WHERE GEN_USERNAME = '{username}'", con);
                adp = new SqlDataAdapter(cmd);
                adp.Fill(ds2);

                for (int i = 0; i < ds2.Tables[0].Rows.Count; i++)
                {
                    cityPrefList.Add(ds2.Tables[0].Rows[i]["CITY_NAME"].ToString());

                }

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    cblCityPreferences.Items.Add(ds.Tables[0].Rows[i]["CITY_NAME"].ToString());

                    if( i < cityPrefList.Count)
                    {
                        if (cityPrefList[i].Equals(ds.Tables[0].Rows[i]["CITY_NAME"].ToString()))
                        {
                            cblCityPreferences.SetItemChecked(i, true);
                        }
                    }
                   
                    cityList.Add(ds.Tables[0].Rows[i]["CITY_NAME"].ToString());

                }


            }
			else
			{
				cblCityPreferences.Visible = false;
				lblTitleInpit.Text = "Create New Forecast Entry";
				btSaveGen.Visible = false;
				btSaveFore.Visible = true;
				btClearAll.Visible = true;
				lblAvailRecords.Visible = false;
			}
            
		}

		private void tbWindSpeed_TextChanged(object sender, EventArgs e)
		{	//Method call to ensure this text field as well as others have text with in so that it can enable the button btSaveEntry 
			AllFieldsFilled();
		}

		private void tbCityName_TextChanged(object sender, EventArgs e)
		{
			AllFieldsFilled();
		}

		private void tbMinTemp_TextChanged(object sender, EventArgs e)
		{
			AllFieldsFilled();
		}

		private void tbMaxTemp_TextChanged(object sender, EventArgs e)
		{
			AllFieldsFilled();
		}

		private void tbPrecipitation_TextChanged(object sender, EventArgs e)
		{
			AllFieldsFilled();
		}

		private void tbHumidity_TextChanged(object sender, EventArgs e)
		{
			AllFieldsFilled();
		}

		private void btSaveGen_Click(object sender, EventArgs e)
		{
            cityListTemp = cityList;

            //deletes old records
            foreach (string item in cityList)
            {

                string sqlq = "";
                con.Open();

                sqlq = $"DELETE FROM CITY_PREFERENCE_GEN_USER WHERE [GEN_USERNAME] = '{ frmMainMenu.currentUserName} '";
                cmd = new SqlCommand(sqlq, con);

                adp.DeleteCommand = new SqlCommand(sqlq, con);
                adp.DeleteCommand.ExecuteNonQuery();

                cmd.Dispose();
                con.Close();

            }

            foreach (object itemChecked in cblCityPreferences.CheckedItems)
			{

                



                cityPrefList.Add(itemChecked.ToString());

                string sql = "";
                con.Open();

                sql = $"Insert into CITY_PREFERENCE_GEN_USER ([GEN_USERNAME],[CITY_NAME])values('{frmMainMenu.currentUserName}','{itemChecked.ToString()}')";
                cmd = new SqlCommand(sql, con);

                adp.InsertCommand = new SqlCommand(sql, con);
                adp.InsertCommand.ExecuteNonQuery();

                cmd.Dispose();
                con.Close();



            }

            for (int j = 0; j < cityPrefList.Count; j++)
            {
                for (int i = 0; i < cityList.Count; i++)
                {
                    if (cityPrefList[j] == cityList[i])
                    {
                        cityList.RemoveAt(i);
                    }
                }
            }

            foreach (string item in cityList)
            {

                

                string sql = "";
                con.Open();

                sql = $"DELETE FROM CITY_PREFERENCE_GEN_USER WHERE [GEN_USERNAME] = '{ frmMainMenu.currentUserName}' AND [CITY_NAME] = '{item}'";
                cmd = new SqlCommand(sql, con);
               
                adp.DeleteCommand = new SqlCommand(sql, con);
                adp.DeleteCommand.ExecuteNonQuery();

                cmd.Dispose();
                con.Close();



            }

            


            MessageBox.Show("Save Successful !");

           
           
            cityListTemp.Clear();
            cityPrefList.Clear();
            cblCityPreferences.Items.Clear();
            frmNewEntry_Load(sender, e);
           
            
          
		}

        private void btExit_Click(object sender, EventArgs e)
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

        private void MoveBorderlessFormOnMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
