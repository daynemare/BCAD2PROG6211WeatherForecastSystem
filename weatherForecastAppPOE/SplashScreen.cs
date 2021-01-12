using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace weatherForecastAppPOE
{
	public partial class SplashScreen : Form
	{
		public SplashScreen()
		{
			InitializeComponent();
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			pbSplash.Increment(1);
			if (pbSplash.Value == 100)
			{
				timer1.Stop();
				frmLoginPage lp = new frmLoginPage();
				this.Hide();
				
				lp.Show();

			}
		}

		private void SplashScreen_Load(object sender, EventArgs e)
		{
			timer1.Start();
		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
