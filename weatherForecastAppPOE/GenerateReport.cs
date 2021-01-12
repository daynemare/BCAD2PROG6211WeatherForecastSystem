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
    public partial class frmGenerateReport : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        //list of forecast data class objects and main menu class declared and placed within class constructor to access relevant methods and data of both classes.

        public static List<string> cityPreference = new List<string>();
        
        frmMainMenu mm;
        
        private string oldRecord;
        private string tempValue;
        public static int recordCount = 0;
        public static string compKeyCityName = "";
        public static string compKeyDate = "";


        SqlDataAdapter adp = new SqlDataAdapter();
        SqlCommand cmd;
        SqlConnection con = new SqlConnection(Program.connection);
        DataSet ds = new DataSet();

        
        public frmGenerateReport(frmMainMenu cmm)
        {

            InitializeComponent();
           
            this.mm = cmm;

        }

        public ref string SetOldRecord(string rec)
        {
            this.oldRecord = rec;
            return ref oldRecord;
        }

        public ref string SetTempValue(string val)
        {
            this.tempValue = val;
            return ref tempValue;
        }
        
        public void PopulateUserSelectionComponents()
        {

            //array to hold city name values to populate checkListBox
            List<string> cblMultipleCitySelectPop = new List<string>();
            cblMultipleCitySelectPop.Clear();
            cbCityNamesSingle.Items.Clear();
            cblMultipleCitySelect.Items.Clear();

            //general user == 0 
            if (frmMainMenu.userType == 0)
            {
                cmd = new SqlCommand($"SELECT CITY_NAME FROM CITY_PREFERENCE_GEN_USER WHERE GEN_USERNAME = '{frmMainMenu.currentUserName}'", con);
                adp = new SqlDataAdapter(cmd);
                adp.Fill(ds);


                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    cblMultipleCitySelect.Items.Add(ds.Tables[0].Rows[i]["CITY_NAME"].ToString());
                    cbCityNamesSingle.Items.Add(ds.Tables[0].Rows[i]["CITY_NAME"].ToString());



                }

                ds.Clear();
                /*
                for (int i = 0; i < cityPreference.Count; i++)
                {
                    if (!cbCityNamesSingle.Items.Contains(cityPreference[i]))
                    {

                        cbCityNamesSingle.Items.Add(cityPreference[i]);

                    }
                }

                for (int i = 0; i < cbCityNamesSingle.Items.Count; i++)
                {

                    cblMultipleCitySelectPop.Add(cityPreference[i]);
                }


                foreach (string values in cblMultipleCitySelectPop)
                {
                    cblMultipleCitySelect.Items.Add(values);
                }
                */
            }
            else
            {

                cmd = new SqlCommand($"SELECT CITY_NAME FROM WEATHER_FORECAST", con);
                adp = new SqlDataAdapter(cmd);
                adp.Fill(ds);


                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    if (!cbCityNamesSingle.Items.Contains(ds.Tables[0].Rows[i]["CITY_NAME"].ToString()))
                    {

                        cbCityNamesSingle.Items.Add(ds.Tables[0].Rows[i]["CITY_NAME"].ToString());
                        cblMultipleCitySelect.Items.Add(ds.Tables[0].Rows[i]["CITY_NAME"].ToString());
                    }
                    
                  



                }

                ds.Clear();
                /*
                for (int i = 0; i < fdl.Count; i++)
                {
                    if (!cbCityNamesSingle.Items.Contains(fdl[i].cityName))
                    {

                        cbCityNamesSingle.Items.Add(fdl[i].cityName);

                    }
                }*/
                /*
                for (int i = 0; i < cbCityNamesSingle.Items.Count; i++)
                {

                    cblMultipleCitySelectPop.Add(cbCityNamesSingle.Items[i].ToString());
                }

                foreach (string values in cblMultipleCitySelectPop)
                {
                    cblMultipleCitySelect.Items.Add(values);
                }*/
            }


        }

        //Method that detects where other values in an array match the min Value or max value identified out of a set of records and then hilights the matching index.
        public int DetectMatch(List<double> array, double mv, int cellId, int colour, List<int> hS, int iH)
        {

            int drawCount = 0;
            if (colour == 1)
            {
                int r = array.Count();
                for (int i = 0; i < r; i++)
                {
                    if (array[i] == mv)
                    {

                        dgResults.Rows[i + hS[iH]].Cells[cellId].Style.BackColor = Color.Chartreuse;
                        drawCount++;
                    }

                }

                return drawCount;

            }
            else
            {
                int r = array.Count();
                for (int i = 0; i < r; i++)
                {
                    if (array[i] == mv)
                    {

                        dgResults.Rows[i + hS[iH]].Cells[cellId].Style.BackColor = Color.SpringGreen;
                        drawCount++;
                    }

                }

                return drawCount;
            }





        }

        //Method that determines and hilights the minimum, maximum, and matching values out of a set of records detemined by city name(s) and a date range 
        public void HighlightValues()
        {
            //Declaration of int count used to store the amount of rows that dgResults dataGridView is populated with.
            int count = dgResults.Rows.Count;

            //Declaration of int array used to store the number of indexs or records pertaining to a certain date range or city name(s).
            int[] indexTrack = new int[count];

            //Declaration of temp arrays used to temporarily hold a list of records pertaining to a certain date range and city name(s)
            List<double> compareMinTemp = new List<double>();
            List<double> compareMaxTemp = new List<double>();
            List<double> comparePrecipitation = new List<double>();
            List<double> compareHumidity = new List<double>();
            List<double> compareWindSpeed = new List<double>();

            //Declaration of list that indexTrack's data is passed to due to the need for index 0 to equal 0 for adding purposes to determine which index in the datagrid the system should start hilighting values at
            List<int> indexTrackList = new List<int>();

            //Declaration of list dates and specificDates - dates holds all the date records in the system whereas specific dates hold only a list of unique dates 
            List<string> dates = new List<string>();
            List<string> specificDates = new List<string>();

            //Clearing lists to reset method operations
            compareMinTemp.Clear();
            compareMaxTemp.Clear();
            comparePrecipitation.Clear();
            compareHumidity.Clear();
            compareWindSpeed.Clear();
            indexTrackList.Clear();
            dates.Clear();
            specificDates.Clear();

            //first index of list indexTrackList needs to be zero to ensure hilighting begins at the starting row of the dataGridView dgResults
            indexTrackList.Add(0);

            //List to store index values as to where the system should begin hilighting values in the dataGridView
            List<int> hilightStart = new List<int>();

            //0 is added to the first index to ensure for the first set of records that hilighting begins at index 0
            hilightStart.Add(0);

            //Declaration of variables to temporarily hold the min, max values of a temp array of records and a variable to hold the index where the min,max value stands in the dataGridView
            double minValue;
            double maxValue;
            int highlightIndex;

            //Declaration  of string name which gets to the name of the current tab selected to determine which report to output in the following decision structure
            string name = tabReports.SelectedTab.Name;

           

            //for loop that populates dates list with all date records in the system
            for (int i = 0; i < recordCount; i++)
            {
               
                    dates.Add(dgResults.Rows[i].Cells[1].Value.ToString());
                 

            }




            //Outer if statement to determine which report to ouput based on name of tab currently selected
            if (name.Equals("tbSingleCity"))
            {

                //for loop that populates specificDates list with unique dates
                for (int i = 0; i < dates.Count; i++)
                {

                    if (!specificDates.Contains(dates[i]))
                        specificDates.Add(dates[i]);

                }

                //for loop that retrieves all ordered records of a single city from the dataGridView (not displayed but stored implicitly) and stores them in a relevant temporary list based on date range and city name(s)
                for (int j = 0; j < specificDates.Count; j++)
                {
                    for (int i = 0; i < dates.Count; i++)
                    {
                        //sets background color of datagridview for the amount of retrieved records to light blue
                        dgResults.Rows[i].Cells[0].Style.BackColor = Color.LightBlue;
                        dgResults.Rows[i].Cells[1].Style.BackColor = Color.LightBlue;
                        dgResults.Rows[i].Cells[2].Style.BackColor = Color.LightBlue;
                        dgResults.Rows[i].Cells[3].Style.BackColor = Color.LightBlue;
                        dgResults.Rows[i].Cells[4].Style.BackColor = Color.LightBlue;
                        dgResults.Rows[i].Cells[5].Style.BackColor = Color.LightBlue;
                        dgResults.Rows[i].Cells[6].Style.BackColor = Color.LightBlue;

                        //adding forecast records to their relevant temporary lists
                        compareMinTemp.Add(Convert.ToDouble(dgResults.Rows[i].Cells[2].Value.ToString()));
                        compareMaxTemp.Add(Convert.ToDouble(dgResults.Rows[i].Cells[3].Value.ToString()));
                        comparePrecipitation.Add(Convert.ToDouble(dgResults.Rows[i].Cells[4].Value.ToString()));
                        compareHumidity.Add(Convert.ToDouble(dgResults.Rows[i].Cells[5].Value.ToString()));
                        compareWindSpeed.Add(Convert.ToDouble(dgResults.Rows[i].Cells[6].Value.ToString()));

                    }

                    //hilighting algorithm for single city follows

                    //declaration of cellId which stores what column needs to be hilighted 
                    int cellId;
                    //declaration of drawCount which stores the amount(if any) of any matched records that were detected in the DetectMatch record
                    int drawCount;
                    //Declaration of colour that determines a colour type to enhance clarity of hilighted values and to make identifying a record sets hilighted values  easier
                    int colour = 0;
                    //Not used in this context but required in the DetectMatch method argument (used in multiple cities report)
                    int iH = 0;

                    //.Min() and .Max() used to determine the min/max value in the temporary lists
                    //Min/max value,hilightStart,cellId,colour, ih passed to Detectmatch to detect if any matches exist and then hilights their relevant cells if they do
                    cellId = 2;
                    minValue = compareMinTemp.Min();
                    drawCount = DetectMatch(compareMinTemp, minValue, cellId, colour, hilightStart, iH);
                    //if drawCount returned a value that equals 1(meaning no matches found) then the standard colour for hilighting is used on the min/max value
                    if (drawCount == 1)
                    {
                        highlightIndex = compareMinTemp.ToList().IndexOf(minValue);
                        dgResults.Rows[highlightIndex].Cells[2].Style.BackColor = Color.Yellow;
                    }


                    cellId = 3;
                    maxValue = compareMaxTemp.Max();
                    drawCount = DetectMatch(compareMaxTemp, maxValue, cellId, colour, hilightStart, iH);
                    if (drawCount == 1)
                    {
                        highlightIndex = compareMaxTemp.ToList().IndexOf(maxValue);
                        dgResults.Rows[highlightIndex].Cells[3].Style.BackColor = Color.Yellow;
                    }

                    cellId = 4;
                    maxValue = comparePrecipitation.Max();
                    drawCount = DetectMatch(comparePrecipitation, maxValue, cellId, colour, hilightStart, iH);
                    if (drawCount == 1)
                    {
                        highlightIndex = comparePrecipitation.ToList().IndexOf(maxValue);
                        dgResults.Rows[highlightIndex].Cells[4].Style.BackColor = Color.Yellow;
                    }

                    cellId = 5;
                    maxValue = compareHumidity.Max();
                    drawCount = DetectMatch(compareHumidity, maxValue, cellId, colour, hilightStart, iH);
                    if (drawCount == 1)
                    {
                        highlightIndex = compareHumidity.ToList().IndexOf(maxValue);
                        dgResults.Rows[highlightIndex].Cells[5].Style.BackColor = Color.Yellow;
                    }

                    cellId = 6;
                    maxValue = compareWindSpeed.Max();
                    drawCount = DetectMatch(compareWindSpeed, maxValue, cellId, colour, hilightStart, iH);
                    if (drawCount == 1)
                    {
                        highlightIndex = compareWindSpeed.ToList().IndexOf(maxValue);
                        dgResults.Rows[highlightIndex].Cells[6].Style.BackColor = Color.Yellow;
                    }

                    //resetting temp arrays once above operations have been completed
                    compareMinTemp.Clear();
                    compareMaxTemp.Clear();
                    comparePrecipitation.Clear();
                    compareHumidity.Clear();
                    compareWindSpeed.Clear();
                }

            }
            else
            {
                //this section pertains to hilighting min/max, and matching values for multiple city reports
                compareMinTemp.Clear();
                compareMaxTemp.Clear();
                comparePrecipitation.Clear();
                compareHumidity.Clear();
                compareWindSpeed.Clear();

                //The following code determines the amount of rows pertaining to each record set
                for (int i = 0; i < dates.Count; i++)
                {
                    if (!specificDates.Contains(dates[i]))
                        specificDates.Add(dates[i]);

                }

                for (int j = 0; j < specificDates.Count; j++)
                {
                    for (int i = 0; i < dates.Count; i++)
                    {
                        if (specificDates[j].Equals(dates[i]))
                        {

                            indexTrack[j] = indexTrack[j] + 1;

                        }

                    }

                }

                for (int i = 0; i < indexTrack.Length; i++)
                {
                    indexTrackList.Add(indexTrack[i]);
                }

                for (int i = 1; i < indexTrackList.Count - 1; i++)
                {

                    hilightStart.Add(indexTrackList[i - 1] + indexTrackList[i]);

                }

                int changeColor = 0;
                //if specific date[j] matches any date[i] value then values are added to temporary lists and their datagridview row is changed to its relevant grouped background colour
                for (int j = 0; j < specificDates.Count; j++)
                {
                    for (int i = 0; i < dates.Count; i++)
                    {
                        if (specificDates[j].Equals(dates[i]))
                        {
                            if (changeColor == 0)
                            {
                                dgResults.Rows[i].Cells[0].Style.BackColor = Color.LightBlue;
                                dgResults.Rows[i].Cells[1].Style.BackColor = Color.LightBlue;
                                dgResults.Rows[i].Cells[2].Style.BackColor = Color.LightBlue;
                                dgResults.Rows[i].Cells[3].Style.BackColor = Color.LightBlue;
                                dgResults.Rows[i].Cells[4].Style.BackColor = Color.LightBlue;
                                dgResults.Rows[i].Cells[5].Style.BackColor = Color.LightBlue;
                                dgResults.Rows[i].Cells[6].Style.BackColor = Color.LightBlue;

                                compareMinTemp.Add(Convert.ToDouble(dgResults.Rows[i].Cells[2].Value.ToString()));
                                compareMaxTemp.Add(Convert.ToDouble(dgResults.Rows[i].Cells[3].Value.ToString()));
                                comparePrecipitation.Add(Convert.ToDouble(dgResults.Rows[i].Cells[4].Value.ToString()));
                                compareHumidity.Add(Convert.ToDouble(dgResults.Rows[i].Cells[5].Value.ToString()));
                                compareWindSpeed.Add(Convert.ToDouble(dgResults.Rows[i].Cells[6].Value.ToString()));


                            }
                            else
                            {

                                dgResults.Rows[i].Cells[0].Style.BackColor = Color.LightSeaGreen;
                                dgResults.Rows[i].Cells[1].Style.BackColor = Color.LightSeaGreen;
                                dgResults.Rows[i].Cells[2].Style.BackColor = Color.LightSeaGreen;
                                dgResults.Rows[i].Cells[3].Style.BackColor = Color.LightSeaGreen;
                                dgResults.Rows[i].Cells[4].Style.BackColor = Color.LightSeaGreen;
                                dgResults.Rows[i].Cells[5].Style.BackColor = Color.LightSeaGreen;
                                dgResults.Rows[i].Cells[6].Style.BackColor = Color.LightSeaGreen;

                                compareMinTemp.Add(Convert.ToDouble(dgResults.Rows[i].Cells[2].Value.ToString()));
                                compareMaxTemp.Add(Convert.ToDouble(dgResults.Rows[i].Cells[3].Value.ToString()));
                                comparePrecipitation.Add(Convert.ToDouble(dgResults.Rows[i].Cells[4].Value.ToString()));
                                compareHumidity.Add(Convert.ToDouble(dgResults.Rows[i].Cells[5].Value.ToString()));
                                compareWindSpeed.Add(Convert.ToDouble(dgResults.Rows[i].Cells[6].Value.ToString()));

                            }


                        }

                    }

                    if (changeColor == 0)
                    {
                        int cellId;
                        int drawCount;
                        int colour = 0;
                        //Stores for loop j to set appropriate row index in the datagridview to a certain colour. In this context hilightStart list with this variable assists in determining the cell to hilight
                        int iH = j;

                        cellId = 2;
                        minValue = compareMinTemp.Min();
                        drawCount = DetectMatch(compareMinTemp, minValue, cellId, colour, hilightStart, iH);
                        if (drawCount == 1)
                        {
                            highlightIndex = compareMinTemp.ToList().IndexOf(minValue);
                            dgResults.Rows[highlightIndex + hilightStart[j]].Cells[2].Style.BackColor = Color.Yellow;
                        }


                        cellId = 3;
                        maxValue = compareMaxTemp.Max();
                        drawCount = DetectMatch(compareMaxTemp, maxValue, cellId, colour, hilightStart, iH);
                        if (drawCount == 1)
                        {
                            highlightIndex = compareMaxTemp.ToList().IndexOf(maxValue);
                            dgResults.Rows[highlightIndex + hilightStart[j]].Cells[3].Style.BackColor = Color.Yellow;
                        }

                        cellId = 4;
                        maxValue = comparePrecipitation.Max();
                        drawCount = DetectMatch(comparePrecipitation, maxValue, cellId, colour, hilightStart, iH);
                        if (drawCount == 1)
                        {
                            highlightIndex = comparePrecipitation.ToList().IndexOf(maxValue);
                            dgResults.Rows[highlightIndex + hilightStart[j]].Cells[4].Style.BackColor = Color.Yellow;
                        }

                        cellId = 5;
                        maxValue = compareHumidity.Max();
                        drawCount = DetectMatch(compareHumidity, maxValue, cellId, colour, hilightStart, iH);
                        if (drawCount == 1)
                        {
                            highlightIndex = compareHumidity.ToList().IndexOf(maxValue);
                            dgResults.Rows[highlightIndex + hilightStart[j]].Cells[5].Style.BackColor = Color.Yellow;
                        }

                        cellId = 6;
                        maxValue = compareWindSpeed.Max();
                        drawCount = DetectMatch(compareWindSpeed, maxValue, cellId, colour, hilightStart, iH);
                        if (drawCount == 1)
                        {
                            highlightIndex = compareWindSpeed.ToList().IndexOf(maxValue);
                            dgResults.Rows[highlightIndex + hilightStart[j]].Cells[6].Style.BackColor = Color.Yellow;
                        }
                        compareMinTemp.Clear();
                        compareMaxTemp.Clear();
                        comparePrecipitation.Clear();
                        compareHumidity.Clear();
                        compareWindSpeed.Clear();
                    }
                    else
                    {
                        int cellId;
                        int drawCount;
                        int colour = 1;
                        int iH = j;

                        cellId = 2;
                        minValue = compareMinTemp.Min();
                        drawCount = DetectMatch(compareMinTemp, minValue, cellId, colour, hilightStart, iH);
                        if (drawCount == 1)
                        {
                            highlightIndex = compareMinTemp.ToList().IndexOf(minValue);
                            dgResults.Rows[highlightIndex + hilightStart[j]].Cells[2].Style.BackColor = Color.Orange;
                        }


                        cellId = 3;
                        maxValue = compareMaxTemp.Max();
                        drawCount = DetectMatch(compareMaxTemp, maxValue, cellId, colour, hilightStart, iH);
                        if (drawCount == 1)
                        {
                            highlightIndex = compareMaxTemp.ToList().IndexOf(maxValue);
                            dgResults.Rows[highlightIndex + hilightStart[j]].Cells[3].Style.BackColor = Color.Orange;
                        }

                        cellId = 4;
                        maxValue = comparePrecipitation.Max();
                        drawCount = DetectMatch(comparePrecipitation, maxValue, cellId, colour, hilightStart, iH);
                        if (drawCount == 1)
                        {
                            highlightIndex = comparePrecipitation.ToList().IndexOf(maxValue);
                            dgResults.Rows[highlightIndex + hilightStart[j]].Cells[4].Style.BackColor = Color.Orange;
                        }

                        cellId = 5;
                        maxValue = compareHumidity.Max();
                        drawCount = DetectMatch(compareHumidity, maxValue, cellId, colour, hilightStart, iH);
                        if (drawCount == 1)
                        {
                            highlightIndex = compareHumidity.ToList().IndexOf(maxValue);
                            dgResults.Rows[highlightIndex + hilightStart[j]].Cells[5].Style.BackColor = Color.Orange;
                        }

                        cellId = 6;
                        maxValue = compareWindSpeed.Max();
                        drawCount = DetectMatch(compareWindSpeed, maxValue, cellId, colour, hilightStart, iH);
                        if (drawCount == 1)
                        {
                            highlightIndex = compareWindSpeed.ToList().IndexOf(maxValue);
                            dgResults.Rows[highlightIndex + hilightStart[j]].Cells[6].Style.BackColor = Color.Orange;
                        }

                        compareMinTemp.Clear();
                        compareMaxTemp.Clear();
                        comparePrecipitation.Clear();
                        compareHumidity.Clear();
                        compareWindSpeed.Clear();
                    }

                    //changes the colour once a certain set of records have been processed
                    if (changeColor == 0)
                    {
                        changeColor = 1;
                    }
                    else
                    {
                        changeColor = 0;
                    }
                }

            }
            
        }
        
        //method to add columns and appropriate column heading names to the dataGridView dgResults
        public void AddDataGridColumnHeadings()
        {

            dgResults.Columns.Add("City Name", "City Name");
            dgResults.Columns.Add("Date", "Date");
            dgResults.Columns.Add("Minimum Temperature(°C)", "Minimum Temperature(°C)");
            dgResults.Columns.Add("Maximum Temperature(°C)", "Maximum Temperature(°C)");
            dgResults.Columns.Add("Precipitation(%)", "Precipitation(%)");
            dgResults.Columns.Add("Humidity(%)", "Humidity(%)");
            dgResults.Columns.Add("Wind Speed(Km/h)", "Wind Speed(Km/h)");
        }

        private void GenerateReport_Load(object sender, EventArgs e)
        {
            if (mm.GetMenuOption() == 1)
            {
                pnGenRepLegend.Hide();
                btGenReportSingle.Text = "Search Records To Edit";
                btGenReportMult.Text = "Search Records To Edit";
                lblResultHeader.Text = "Search Results";
                lblEditHelp.Show();
                lblEditHelpMult.Show();
                dgResults.ReadOnly = false;
                lblTitleResults.Text = "Edit Forecast Entries";
                btPrintReportOne.Visible = false;
                btPrintReportTwo.Visible = false;

            }
            else
            {
                pnGenRepLegend.Show();
                btGenReportSingle.Text = "Generate Report";
                btGenReportMult.Text = "Generate Report";
                lblResultHeader.Text = "Report Results";
                lblEditHelp.Hide();
                lblEditHelpMult.Show();
                dgResults.ReadOnly = true;
                lblTitleResults.Text = "Generate Forecast Report";
                btPrintReportOne.Visible = true;
                btPrintReportTwo.Visible = true;

            }

            this.dgResults.SelectionMode = DataGridViewSelectionMode.CellSelect;
            this.dgResults.MultiSelect = false;

            if (dgResults.Columns.Count == 0)
            {
                AddDataGridColumnHeadings();
            }

            PopulateUserSelectionComponents();

            dgResults.AllowUserToAddRows = false;
            dgResults.ClearSelection();

        }

        private void btGenReportSingle_Click(object sender, EventArgs e)
        {
            
            dgResults.DataSource = null;
            List<ForecastData> results = new List<ForecastData>();
            
            string selected = cbCityNamesSingle.GetItemText(cbCityNamesSingle.SelectedItem);

            DateTime start = Convert.ToDateTime(dtpStartDateSingle.Text);
            DateTime end = Convert.ToDateTime(dtpEndDateSingle.Text);
            recordCount = 0;
            
            dgResults.Rows.Clear();
            
            if (start > end)
            {

                MessageBox.Show("Start date range greater than end date range", "ERROR");
                dtpStartDateSingle.ResetText();
            }
            else
            {
                cmd = new SqlCommand($"SELECT * FROM WEATHER_FORECAST", con);
                adp = new SqlDataAdapter(cmd);
                adp.Fill(ds);
                
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    DateTime dt = Convert.ToDateTime(ds.Tables[0].Rows[i]["WF_DATE"].ToString());


                    if (ds.Tables[0].Rows[i]["CITY_NAME"].ToString().Equals(selected) && dt >= start && dt <= end)
                    {
                        
                        dgResults.Rows.Add(ds.Tables[0].Rows[i]["CITY_NAME"].ToString(), ds.Tables[0].Rows[i]["WF_DATE"].ToString().Substring(0, 10), ds.Tables[0].Rows[i]["MIN_TEMP"].ToString(), ds.Tables[0].Rows[i]["MAX_TEMP"].ToString(), ds.Tables[0].Rows[i]["PRECIPITATION"].ToString(), ds.Tables[0].Rows[i]["HUMIDITY"].ToString(), ds.Tables[0].Rows[i]["WIND_SPEED"].ToString());
                        recordCount++;
                    }


                }

                ds.Clear();
          

                if (recordCount == 0)
                {
                    MessageBox.Show("There are no records that fall under the selected date range", "MESSAGE");
                }


                this.dgResults.Sort(this.dgResults.Columns["Date"], ListSortDirection.Ascending);

                if (mm.GetMenuOption() != 1)
                {
                    HighlightValues();
                }
                
                dgResults.ClearSelection();
                

            }

        }

        private void genReportMult_Click(object sender, EventArgs e)
        {
            List<ForecastData> results = new List<ForecastData>();
            List<string> cblMultipleCitySelectedCheck = new List<string>();
            DateTime start = Convert.ToDateTime(dtpStartDateMult.Text);
            DateTime end = Convert.ToDateTime(dtpEndDateMult.Text);
            dgResults.AllowUserToAddRows = false;
            recordCount = 0;




            dgResults.Rows.Clear();



            for (int i = 0; i < cblMultipleCitySelect.Items.Count; i++)
            {
                if (cblMultipleCitySelect.GetItemCheckState(i) == CheckState.Checked)
                {
                    cblMultipleCitySelectedCheck.Add(cblMultipleCitySelect.Items[i].ToString());
                }

            }

            if (start > end)
            {

                MessageBox.Show("Start date range greater than end date range", "ERROR");
                dtpStartDateSingle.ResetText();
            }
            else if (cblMultipleCitySelectedCheck.Count == 0)
            {
                MessageBox.Show("No City Name(s) were selected", "ERROR");
            }
            else
            {
                cmd = new SqlCommand($"SELECT * FROM WEATHER_FORECAST", con);
                adp = new SqlDataAdapter(cmd);
                adp.Fill(ds);
                
                int numItemsSelected = cblMultipleCitySelect.CheckedItems.Count;
                if (numItemsSelected == 1)
                {
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        DateTime dt = Convert.ToDateTime(ds.Tables[0].Rows[i]["WF_DATE"].ToString());

                        if (ds.Tables[0].Rows[i]["CITY_NAME"].ToString().Equals(cblMultipleCitySelectedCheck[0]) && dt >= start && dt <= end)
                        {
                          
                            dgResults.Rows.Add(ds.Tables[0].Rows[i]["CITY_NAME"].ToString(), ds.Tables[0].Rows[i]["WF_DATE"].ToString().Substring(0, 10), ds.Tables[0].Rows[i]["MIN_TEMP"].ToString(), ds.Tables[0].Rows[i]["MAX_TEMP"].ToString(), ds.Tables[0].Rows[i]["PRECIPITATION"].ToString(), ds.Tables[0].Rows[i]["HUMIDITY"].ToString(), ds.Tables[0].Rows[i]["WIND_SPEED"].ToString());
                            recordCount++;
                        }
                    }
                }   
                else
                {
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        for (int j = 0; j < cblMultipleCitySelectedCheck.Count; j++)
                        {
                            DateTime dt = Convert.ToDateTime(ds.Tables[0].Rows[i]["WF_DATE"].ToString());
                            if (ds.Tables[0].Rows[i]["CITY_NAME"].ToString().Equals(cblMultipleCitySelectedCheck[j]) && dt >= start && dt <= end)
                            {

                                dgResults.Rows.Add(ds.Tables[0].Rows[i]["CITY_NAME"].ToString(), ds.Tables[0].Rows[i]["WF_DATE"].ToString().Substring(0, 10), ds.Tables[0].Rows[i]["MIN_TEMP"].ToString(), ds.Tables[0].Rows[i]["MAX_TEMP"].ToString(), ds.Tables[0].Rows[i]["PRECIPITATION"].ToString(), ds.Tables[0].Rows[i]["HUMIDITY"].ToString(), ds.Tables[0].Rows[i]["WIND_SPEED"].ToString());
                                recordCount++;
                            }
                        }

                    }
                }


                dgResults.Sort(dgResults.Columns["Date"], ListSortDirection.Ascending);

                cblMultipleCitySelectedCheck.Clear();
                ds.Clear();

                if (mm.GetMenuOption() != 1)
                {
                    HighlightValues();
                }


                dgResults.ClearSelection();

            }



        }
        
        private void cbCityNamesSingle_SelectedIndexChanged_1(object sender, EventArgs e)
        {	//enables the generate report button for the single citys table when a city is selected from the drop down
            btGenReportSingle.Enabled = true;
            btGenReportSingle.ForeColor = Color.White;
            btGenReportSingle.BackColor = Color.Black;

        }
        
        private void tabControlCityDisplayType_SelectedIndexChanged(object sender, EventArgs e)
        {   //when the tab index is changed the datagridview dgResults is cleared of all its data
            dgResults.Rows.Clear();


        }
        
        private void btMainMenu_Click(object sender, EventArgs e)
        {
            mm.Show();
            this.Dispose();
            
        }
        
        private void dgResults_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //Gets the index of the row to be edited
            int editedRow = dgResults.CurrentCell.RowIndex;
            //counts the number of columns in the record
            int editedCol = dgResults.CurrentCell.ColumnIndex;
            
            if (dgResults.CurrentCell.Value == null)
            {
                MessageBox.Show("Value can not be left blank", "Error");
                dgResults.CurrentCell.Value = this.tempValue;
                return;
            }

           //Gets the values of each gridview column 
             double minTempCompare = Convert.ToDouble(dgResults.Rows[editedRow].Cells[2].Value.ToString());
             double maxTempCompare = Convert.ToDouble(dgResults.Rows[editedRow].Cells[3].Value.ToString());
             double precipCompare = Convert.ToDouble(dgResults.Rows[editedRow].Cells[4].Value.ToString());
             double humidityCompare = Convert.ToDouble(dgResults.Rows[editedRow].Cells[5].Value.ToString());
             double num;
             string[] format = new string[] { "yyyy/MM/dd" };

         DateTime dateTime;
           
        if (editedCol == 0)
        {

            bool containsInt = dgResults.CurrentCell.Value.ToString().Any(char.IsDigit);

            if (containsInt == false)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to update this record?", "Confirmation", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    dgResults.CurrentCell.Value = dgResults.CurrentCell.Value.ToString().ToUpper();

                        string sqlq = "";
                        con.Open();

                        sqlq = $"UPDATE WEATHER_FORECAST SET CITY_NAME = '{dgResults.CurrentCell.Value}' WHERE CITY_NAME = '{compKeyCityName}'AND WF_DATE = '{compKeyDate}'";
                        cmd = new SqlCommand(sqlq, con);

                        adp.DeleteCommand = new SqlCommand(sqlq, con);
                        adp.DeleteCommand.ExecuteNonQuery();

                        cmd.Dispose();
                        con.Close();
                 
                        MessageBox.Show("Record Updated", "Success!");
                        
                    GenerateReport_Load(sender, e);
                        
                    cbCityNamesSingle.Text = "";

                }
                else
                {

                    dgResults.CurrentCell.Value = this.tempValue;

                }
            }
            else
            {
                MessageBox.Show("The input you provided contains digits. Please Try again", "ERROR");
                dgResults.CurrentCell.Value = this.tempValue;

            }
        }
        else if (editedCol == 1)
        {
               if (DateTime.TryParseExact(dgResults.CurrentCell.Value.ToString(), format, CultureInfo.InvariantCulture, DateTimeStyles.NoCurrentDateDefault, out dateTime))
               {

                   DialogResult dialogResult = MessageBox.Show("Are you sure you want to update this record?", "Confirmation", MessageBoxButtons.YesNo);

                   if (dialogResult == DialogResult.Yes)
                   {
                       dgResults.CurrentCell.Value = dgResults.CurrentCell.Value.ToString().ToUpper();
                        try
                        {
                            string sqlq = "";
                            con.Open();
                            
                            sqlq = $"UPDATE WEATHER_FORECAST SET WF_DATE = '{dgResults.CurrentCell.Value}' WHERE CITY_NAME = '{compKeyCityName}'AND WF_DATE = '{compKeyDate}'";
                            cmd = new SqlCommand(sqlq, con);

                            adp.UpdateCommand = new SqlCommand(sqlq, con);
                            adp.UpdateCommand.ExecuteNonQuery();

                            cmd.Dispose();
                            con.Close();

                            MessageBox.Show("Record Updated", "Success!");

                            GenerateReport_Load(sender, e);

                            cbCityNamesSingle.Text = "";
                        }
                        catch (SqlException ex)
                        {

                            if (ex.Number == 2627)
                            {
                                MessageBox.Show("Record already exists for the date and city specified", "Error");
                                dgResults.CurrentCell.Value = this.tempValue;
                            }

                            con.Close();
                        }
                       
                   }
                   else
                   {
                       dgResults.CurrentCell.Value = this.tempValue;
                   }

               }
               else
               {
                   MessageBox.Show("The input you provided is not in the date format yyyy/MM/dd . Please Try again", "ERROR");

                   dgResults.CurrentCell.Value = this.tempValue;
               }

        }
        else if (editedCol >= 2)
        {

               if (double.TryParse(dgResults.CurrentCell.Value.ToString(), out num))
               {
                   if (minTempCompare > maxTempCompare)
                   {
                       MessageBox.Show("The minimum temperature cannot to be higher than the maximum temperature", "ERROR");
                       btGenReportSingle_Click(sender, e);
                       return;

                   }//This if statement throws up an error message on the screen if the user inputs a value over 100% for the precipitation field.
                   else if (precipCompare > 100)
                   {
                       MessageBox.Show("The value you entered for precipitation cannot be above 100%", "ERROR");
                       btGenReportSingle_Click(sender, e);
                       return;


                   }//This if statement throws up an error message on the screen if the user inputs a value over 100% for the humidity field.
                   else if (humidityCompare > 100)
                   {
                       MessageBox.Show("The value you entered for humidity cannot be above 100%", "ERROR");
                       btGenReportSingle_Click(sender, e);
                       return;

                   }


                   DialogResult dialogResult = MessageBox.Show("Are you sure you want to update this record?", "Confirmation", MessageBoxButtons.YesNo);

                   if (dialogResult == DialogResult.Yes)
                   {
                        List<string> colNames = new List<string>(new string[]{ "MIN_TEMP", "MAX_TEMP", "PRECIPITATION","HUMIDITY", "WIND_SPEED" });
                       
                        string sqlq = "";
                        con.Open();
                        string column = colNames[editedCol - 2];

                        sqlq = $"UPDATE WEATHER_FORECAST SET {column} = '{dgResults.CurrentCell.Value}' WHERE CITY_NAME = '{compKeyCityName}'AND WF_DATE = '{compKeyDate}'";
                        cmd = new SqlCommand(sqlq, con);

                        adp.UpdateCommand = new SqlCommand(sqlq, con);
                        adp.UpdateCommand.ExecuteNonQuery();

                        cmd.Dispose();
                        con.Close();

                        MessageBox.Show("Record Updated", "Success!");

                        GenerateReport_Load(sender, e);

                        cbCityNamesSingle.Text = "";

                   }
                   else
                   {
                       dgResults.CurrentCell.Value = this.tempValue;
                   }

               }
               else
               {
                   MessageBox.Show("The input you provided is not a number", "ERROR");

                   dgResults.CurrentCell.Value = this.tempValue;
               }

           }

          

        }

        private void dgResults_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            compKeyCityName = "";
            compKeyDate = "";

            //Gets the index of the row to be edited
            int editedRow = dgResults.CurrentCell.RowIndex;
            
            //counts the number of columns in the record
            int colCount = dgResults.ColumnCount;
          
            //sets the old value in case of cancelation
            SetTempValue(dgResults.CurrentCell.Value.ToString());

            compKeyCityName = dgResults.Rows[editedRow].Cells[0].Value.ToString();
            compKeyDate = dgResults.Rows[editedRow].Cells[1].Value.ToString();

        }

        private void btPrintReport_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd= new SaveFileDialog();
            sfd.Filter = "Text File | *.txt";
            sfd.FileName = "default file name.txt";
            string printPath = "";

        

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                printPath = saveFileDialog.FileName;
            }
            StreamWriter writer = new StreamWriter(sfd.OpenFile());

            string stringCityName = "City Name";
           
            string stringDate = "Date";
           
            string stringMinTemp = "Min. Temp.(C°)";

            string stringMaxTemp = "Max. Temp.(C°)";

            string stringPrec = "Precipitation(%)";
          
            string stringHum = "Humidity(%)";
          
            string stringWind = "Wind Speed (km/h)";
            
         

            writer.Write(stringCityName + "\t" + stringDate + "\t\t" + stringMinTemp + "\t" + stringMaxTemp + "\t" + stringPrec + "\t" + stringHum + "\t" + stringWind);
            writer.WriteLine("");

            for (int i = 0; i < dgResults.Rows.Count; i++)
            {
                for (int j = 0; j < dgResults.Columns.Count; j++)
                {
                    writer.Write(dgResults.Rows[i].Cells[j].Value.ToString() + "\t\t");
                }
               
                writer.WriteLine("");
               
            }
            writer.Dispose();
            writer.Close();
            MessageBox.Show("Report Saved Successfully");
        }

        
        private void BtPrintReportTwo_Click(object sender, EventArgs e)
        {
            btPrintReport_Click(sender, e);
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

        private void lblTitleResults_Click(object sender, EventArgs e)
        {

        }
    }
}
