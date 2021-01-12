using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace weatherForecastAppPOE
{
    public partial class frmMainMenu : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        SqlDataAdapter adp = new SqlDataAdapter();
        SqlCommand cmd;
        SqlConnection con = new SqlConnection(Program.connection);
        DataSet ds = new DataSet();

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private int menuOption;
        public static int userType { get; set; }
        public static string currentUserName { get; set; }

        //Method to enable the button btGenerateReport
        public void EnableUIControl()
        {
            btGenerateReport.Enabled = true;
            lblGenForecast.ForeColor = Color.Black;
            btEditEntries.Enabled = true;
            lblEditEntries.ForeColor = Color.Black;
        }

        public ref int SetMenuOption(int opt)
        {
            this.menuOption = opt;
            return ref menuOption;
        }

        public int GetMenuOption()
        {
            return this.menuOption;
        }

        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void btNewEntryOnClick(object sender, EventArgs e)
        {
            //Object instantiation of the new forcast entry form
            frmNewEntry ne = new frmNewEntry(this,currentUserName);

            //When button is clicked hide main menu and show new entry form
            ne.Show();
            this.Hide();
        }

        private void btGenerateReportOnClick(object sender, EventArgs e)
        {
            //Object instantiation of the generate report form
            frmGenerateReport ge = new frmGenerateReport(this);

            SetMenuOption(0);


            //When button is clicked hide main menu and show new entry form
            ge.Show();
            this.Hide();

        }
        
        private void frmMainMenu_Load(object sender, EventArgs e)
        {
            lblCurrentUser.Text = "Logged in as: " + currentUserName;

            if (userType == 0)
            {
                pnGenUser.Visible = true;
                lblCreateNew.Text = "City Preferences";
                lblEditEntries.Visible = false;
                lblGenForecast.Text = "View Weather Forecast";
            }
            else
            {
                pnGenUser.Visible = false;
                lblCreateNew.Text = "Create New Forecast Entry";
                lblEditEntries.Visible = true;
                lblGenForecast.Text = "Generate Forecast Report";
            }

            cmd = new SqlCommand($"SELECT * FROM WEATHER_FORECAST", con);
            adp = new SqlDataAdapter(cmd);
            adp.Fill(ds);
            int i = ds.Tables[0].Rows.Count;
            if (i > 0)
            {
                EnableUIControl();

            }

        }

        private void btExitProgram_Click(object sender, EventArgs e)
        {
            //Code that prompts the user if they would like to exit the application or not. If they click yes the application will close.
            DialogResult yesNo = MessageBox.Show("Do you really want to quit the program", "Exit to windows?", MessageBoxButtons.YesNo);

            if (yesNo == DialogResult.Yes)
            {
                Application.Exit();
            }


        }

        private void btEditForecastRecordsOnClick(object sender, EventArgs e)
        {
            SetMenuOption(1);

            //Object instantiation of the generate report form
            frmGenerateReport ge = new frmGenerateReport(this);
            
            //When button is clicked hide main menu and show new entry form
            ge.Show();
            this.Hide();
        }

        private void btSignOutOnClick(object sender, EventArgs e)
        {
            frmLoginPage lp = new frmLoginPage();

            lp.Show();
            this.Dispose();
        }

        private void btCityPreferences_Click(object sender, EventArgs e)
        {
            frmNewEntry ne = new frmNewEntry(null,currentUserName);
            ne.Show();
            this.Dispose();
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
