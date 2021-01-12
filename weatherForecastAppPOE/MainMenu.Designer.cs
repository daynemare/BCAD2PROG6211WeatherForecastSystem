namespace weatherForecastAppPOE
{
    partial class frmMainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenu));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.createNewEntry = new System.Windows.Forms.ToolTip(this.components);
            this.btNewEntry = new System.Windows.Forms.Button();
            this.btEditEntries = new System.Windows.Forms.Button();
            this.btGenerateReport = new System.Windows.Forms.Button();
            this.generateReport = new System.Windows.Forms.ToolTip(this.components);
            this.btExitProgram = new System.Windows.Forms.Button();
            this.lblCreateNew = new System.Windows.Forms.Label();
            this.lblGenForecast = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblEditEntries = new System.Windows.Forms.Label();
            this.pnGenUser = new System.Windows.Forms.Panel();
            this.btCityPreferences = new System.Windows.Forms.Button();
            this.btSignOut = new System.Windows.Forms.Button();
            this.lblCurrentUser = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pnGenUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Bernard MT Condensed", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 10, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1280, 58);
            this.label1.TabIndex = 4;
            this.label1.Text = "Weather Forecast Application";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveBorderlessFormOnMouseDown);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Bernard MT Condensed", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(0, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 10, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1280, 51);
            this.label2.TabIndex = 5;
            this.label2.Text = "Main Menu";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // createNewEntry
            // 
            this.createNewEntry.BackColor = System.Drawing.SystemColors.InfoText;
            this.createNewEntry.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.createNewEntry.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.createNewEntry.ToolTipTitle = "Create New Weather Forecast Entry";
            // 
            // btNewEntry
            // 
            this.btNewEntry.BackColor = System.Drawing.Color.White;
            this.btNewEntry.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btNewEntry.BackgroundImage")));
            this.btNewEntry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btNewEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNewEntry.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btNewEntry.Location = new System.Drawing.Point(243, 269);
            this.btNewEntry.Margin = new System.Windows.Forms.Padding(234, 260, 4, 4);
            this.btNewEntry.Name = "btNewEntry";
            this.btNewEntry.Size = new System.Drawing.Size(200, 200);
            this.btNewEntry.TabIndex = 2;
            this.createNewEntry.SetToolTip(this.btNewEntry, "This menu allows you to create a new weather forecast record that will be added t" +
        "o the system.");
            this.btNewEntry.UseVisualStyleBackColor = false;
            this.btNewEntry.Click += new System.EventHandler(this.btNewEntryOnClick);
            // 
            // btEditEntries
            // 
            this.btEditEntries.BackColor = System.Drawing.Color.White;
            this.btEditEntries.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btEditEntries.BackgroundImage")));
            this.btEditEntries.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btEditEntries.Enabled = false;
            this.btEditEntries.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEditEntries.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btEditEntries.Location = new System.Drawing.Point(451, 269);
            this.btEditEntries.Margin = new System.Windows.Forms.Padding(4);
            this.btEditEntries.Name = "btEditEntries";
            this.btEditEntries.Size = new System.Drawing.Size(200, 200);
            this.btEditEntries.TabIndex = 10;
            this.createNewEntry.SetToolTip(this.btEditEntries, "This menu allows you to create a new weather forecast record that will be added t" +
        "o the system.");
            this.btEditEntries.UseVisualStyleBackColor = false;
            this.btEditEntries.Click += new System.EventHandler(this.btEditForecastRecordsOnClick);
            // 
            // btGenerateReport
            // 
            this.btGenerateReport.BackColor = System.Drawing.Color.White;
            this.btGenerateReport.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btGenerateReport.BackgroundImage")));
            this.btGenerateReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btGenerateReport.Enabled = false;
            this.btGenerateReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGenerateReport.Location = new System.Drawing.Point(659, 269);
            this.btGenerateReport.Margin = new System.Windows.Forms.Padding(4);
            this.btGenerateReport.Name = "btGenerateReport";
            this.btGenerateReport.Size = new System.Drawing.Size(200, 200);
            this.btGenerateReport.TabIndex = 3;
            this.generateReport.SetToolTip(this.btGenerateReport, "This menu allows you to generate weather forecast reports based on records stored" +
        " in the system.");
            this.btGenerateReport.UseVisualStyleBackColor = false;
            this.btGenerateReport.Click += new System.EventHandler(this.btGenerateReportOnClick);
            // 
            // generateReport
            // 
            this.generateReport.IsBalloon = true;
            this.generateReport.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.generateReport.ToolTipTitle = "Generate Weather Forecast Reports";
            // 
            // btExitProgram
            // 
            this.btExitProgram.BackColor = System.Drawing.Color.White;
            this.btExitProgram.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btExitProgram.BackgroundImage")));
            this.btExitProgram.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btExitProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExitProgram.Location = new System.Drawing.Point(867, 269);
            this.btExitProgram.Margin = new System.Windows.Forms.Padding(4);
            this.btExitProgram.Name = "btExitProgram";
            this.btExitProgram.Size = new System.Drawing.Size(200, 200);
            this.btExitProgram.TabIndex = 8;
            this.btExitProgram.UseVisualStyleBackColor = false;
            this.btExitProgram.Click += new System.EventHandler(this.btExitProgram_Click);
            // 
            // lblCreateNew
            // 
            this.lblCreateNew.AutoSize = true;
            this.lblCreateNew.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateNew.Location = new System.Drawing.Point(239, 473);
            this.lblCreateNew.Name = "lblCreateNew";
            this.lblCreateNew.Size = new System.Drawing.Size(179, 20);
            this.lblCreateNew.TabIndex = 6;
            this.lblCreateNew.Text = "Create New Forecast Entry";
            // 
            // lblGenForecast
            // 
            this.lblGenForecast.AutoSize = true;
            this.lblGenForecast.BackColor = System.Drawing.Color.White;
            this.lblGenForecast.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenForecast.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblGenForecast.Location = new System.Drawing.Point(671, 473);
            this.lblGenForecast.Name = "lblGenForecast";
            this.lblGenForecast.Size = new System.Drawing.Size(176, 20);
            this.lblGenForecast.TabIndex = 7;
            this.lblGenForecast.Text = "Generate Forecast Report";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(910, 473);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Exit To Windows";
            // 
            // lblEditEntries
            // 
            this.lblEditEntries.AutoSize = true;
            this.lblEditEntries.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditEntries.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblEditEntries.Location = new System.Drawing.Point(447, 473);
            this.lblEditEntries.Name = "lblEditEntries";
            this.lblEditEntries.Size = new System.Drawing.Size(142, 20);
            this.lblEditEntries.TabIndex = 11;
            this.lblEditEntries.Text = "Edit Forecast Entries";
            // 
            // pnGenUser
            // 
            this.pnGenUser.Controls.Add(this.btCityPreferences);
            this.pnGenUser.Location = new System.Drawing.Point(243, 269);
            this.pnGenUser.Name = "pnGenUser";
            this.pnGenUser.Size = new System.Drawing.Size(408, 200);
            this.pnGenUser.TabIndex = 12;
            this.pnGenUser.Visible = false;
            // 
            // btCityPreferences
            // 
            this.btCityPreferences.BackColor = System.Drawing.Color.White;
            this.btCityPreferences.ForeColor = System.Drawing.Color.Brown;
            this.btCityPreferences.Image = ((System.Drawing.Image)(resources.GetObject("btCityPreferences.Image")));
            this.btCityPreferences.Location = new System.Drawing.Point(-1, 0);
            this.btCityPreferences.Name = "btCityPreferences";
            this.btCityPreferences.Size = new System.Drawing.Size(410, 200);
            this.btCityPreferences.TabIndex = 0;
            this.btCityPreferences.UseVisualStyleBackColor = false;
            this.btCityPreferences.Click += new System.EventHandler(this.btCityPreferences_Click);
            // 
            // btSignOut
            // 
            this.btSignOut.BackColor = System.Drawing.Color.Black;
            this.btSignOut.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSignOut.ForeColor = System.Drawing.Color.White;
            this.btSignOut.Location = new System.Drawing.Point(549, 499);
            this.btSignOut.Margin = new System.Windows.Forms.Padding(540, 6, 5, 6);
            this.btSignOut.Name = "btSignOut";
            this.btSignOut.Size = new System.Drawing.Size(200, 42);
            this.btSignOut.TabIndex = 21;
            this.btSignOut.Text = "Sign Out";
            this.btSignOut.UseVisualStyleBackColor = false;
            this.btSignOut.Click += new System.EventHandler(this.btSignOutOnClick);
            // 
            // lblCurrentUser
            // 
            this.lblCurrentUser.AutoSize = true;
            this.lblCurrentUser.Location = new System.Drawing.Point(12, 125);
            this.lblCurrentUser.Name = "lblCurrentUser";
            this.lblCurrentUser.Size = new System.Drawing.Size(0, 16);
            this.lblCurrentUser.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.Image = global::weatherForecastAppPOE.Properties.Resources.CloseButtonOneBlackAndWhite;
            this.button1.Location = new System.Drawing.Point(1222, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 58);
            this.button1.TabIndex = 23;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btExit_Click);
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblCurrentUser);
            this.Controls.Add(this.btSignOut);
            this.Controls.Add(this.pnGenUser);
            this.Controls.Add(this.lblEditEntries);
            this.Controls.Add(this.btEditEntries);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btExitProgram);
            this.Controls.Add(this.lblGenForecast);
            this.Controls.Add(this.lblCreateNew);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btGenerateReport);
            this.Controls.Add(this.btNewEntry);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1280, 720);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "frmMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Weather Forecast Application - Main Menu";
            this.Load += new System.EventHandler(this.frmMainMenu_Load);
            this.pnGenUser.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btGenerateReport;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ToolTip createNewEntry;
		private System.Windows.Forms.Button btNewEntry;
		private System.Windows.Forms.ToolTip generateReport;
		private System.Windows.Forms.Label lblCreateNew;
		private System.Windows.Forms.Label lblGenForecast;
		private System.Windows.Forms.Button btExitProgram;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btEditEntries;
		private System.Windows.Forms.Label lblEditEntries;
		private System.Windows.Forms.Panel pnGenUser;
		private System.Windows.Forms.Button btCityPreferences;
		private System.Windows.Forms.Button btSignOut;
		private System.Windows.Forms.Label lblCurrentUser;
        private System.Windows.Forms.Button button1;
    }
}

