namespace weatherForecastAppPOE
{
    partial class frmGenerateReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGenerateReport));
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpStartDateSingle = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDateSingle = new System.Windows.Forms.DateTimePicker();
            this.btGenReportSingle = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblResultHeader = new System.Windows.Forms.Label();
            this.tabReports = new System.Windows.Forms.TabControl();
            this.tbSingleCity = new System.Windows.Forms.TabPage();
            this.btPrintReportOne = new System.Windows.Forms.Button();
            this.lblEditHelp = new System.Windows.Forms.Label();
            this.cbCityNamesSingle = new System.Windows.Forms.ComboBox();
            this.tbMultipleCity = new System.Windows.Forms.TabPage();
            this.btPrintReportTwo = new System.Windows.Forms.Button();
            this.cblMultipleCitySelect = new System.Windows.Forms.CheckedListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpStartDateMult = new System.Windows.Forms.DateTimePicker();
            this.btGenReportMult = new System.Windows.Forms.Button();
            this.dtpEndDateMult = new System.Windows.Forms.DateTimePicker();
            this.lblEditHelpMult = new System.Windows.Forms.Label();
            this.dgResults = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.lblTitleResults = new System.Windows.Forms.Label();
            this.btLegendFour = new System.Windows.Forms.Button();
            this.btLegendThree = new System.Windows.Forms.Button();
            this.btLegendTwo = new System.Windows.Forms.Button();
            this.btLegendOne = new System.Windows.Forms.Button();
            this.lblLegendOne = new System.Windows.Forms.Label();
            this.lblLegendTwo = new System.Windows.Forms.Label();
            this.pnGenRepLegend = new System.Windows.Forms.Panel();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.lblTest = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tabReports.SuspendLayout();
            this.tbSingleCity.SuspendLayout();
            this.tbMultipleCity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgResults)).BeginInit();
            this.pnGenRepLegend.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 6);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "City Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(740, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Start Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(990, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "End Date";
            // 
            // dtpStartDateSingle
            // 
            this.dtpStartDateSingle.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartDateSingle.CustomFormat = "dd/MM/yyyy";
            this.dtpStartDateSingle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartDateSingle.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDateSingle.Location = new System.Drawing.Point(744, 29);
            this.dtpStartDateSingle.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.dtpStartDateSingle.Name = "dtpStartDateSingle";
            this.dtpStartDateSingle.Size = new System.Drawing.Size(240, 26);
            this.dtpStartDateSingle.TabIndex = 8;
            // 
            // dtpEndDateSingle
            // 
            this.dtpEndDateSingle.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndDateSingle.CustomFormat = "dd/MM/yyyy";
            this.dtpEndDateSingle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndDateSingle.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDateSingle.Location = new System.Drawing.Point(994, 29);
            this.dtpEndDateSingle.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.dtpEndDateSingle.Name = "dtpEndDateSingle";
            this.dtpEndDateSingle.Size = new System.Drawing.Size(240, 26);
            this.dtpEndDateSingle.TabIndex = 9;
            // 
            // btGenReportSingle
            // 
            this.btGenReportSingle.BackColor = System.Drawing.Color.White;
            this.btGenReportSingle.Enabled = false;
            this.btGenReportSingle.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGenReportSingle.ForeColor = System.Drawing.Color.Black;
            this.btGenReportSingle.Location = new System.Drawing.Point(744, 67);
            this.btGenReportSingle.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btGenReportSingle.Name = "btGenReportSingle";
            this.btGenReportSingle.Size = new System.Drawing.Size(490, 42);
            this.btGenReportSingle.TabIndex = 18;
            this.btGenReportSingle.Text = "Generate Report";
            this.btGenReportSingle.UseVisualStyleBackColor = false;
            this.btGenReportSingle.Click += new System.EventHandler(this.btGenReportSingle_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(482, 384);
            this.button2.Margin = new System.Windows.Forms.Padding(465, 6, 5, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(350, 33);
            this.button2.TabIndex = 20;
            this.button2.Text = "Main Menu";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btMainMenu_Click);
            // 
            // lblResultHeader
            // 
            this.lblResultHeader.AutoSize = true;
            this.lblResultHeader.Font = new System.Drawing.Font("Impact", 14F);
            this.lblResultHeader.Location = new System.Drawing.Point(14, 424);
            this.lblResultHeader.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblResultHeader.Name = "lblResultHeader";
            this.lblResultHeader.Size = new System.Drawing.Size(125, 23);
            this.lblResultHeader.TabIndex = 22;
            this.lblResultHeader.Text = "Report Results";
            // 
            // tabReports
            // 
            this.tabReports.Controls.Add(this.tbSingleCity);
            this.tabReports.Controls.Add(this.tbMultipleCity);
            this.tabReports.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabReports.Location = new System.Drawing.Point(14, 136);
            this.tabReports.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tabReports.Name = "tabReports";
            this.tabReports.SelectedIndex = 0;
            this.tabReports.Size = new System.Drawing.Size(1252, 243);
            this.tabReports.TabIndex = 23;
            this.tabReports.SelectedIndexChanged += new System.EventHandler(this.tabControlCityDisplayType_SelectedIndexChanged);
            // 
            // tbSingleCity
            // 
            this.tbSingleCity.Controls.Add(this.btPrintReportOne);
            this.tbSingleCity.Controls.Add(this.lblEditHelp);
            this.tbSingleCity.Controls.Add(this.cbCityNamesSingle);
            this.tbSingleCity.Controls.Add(this.label3);
            this.tbSingleCity.Controls.Add(this.label1);
            this.tbSingleCity.Controls.Add(this.label2);
            this.tbSingleCity.Controls.Add(this.dtpStartDateSingle);
            this.tbSingleCity.Controls.Add(this.btGenReportSingle);
            this.tbSingleCity.Controls.Add(this.dtpEndDateSingle);
            this.tbSingleCity.Location = new System.Drawing.Point(4, 32);
            this.tbSingleCity.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tbSingleCity.Name = "tbSingleCity";
            this.tbSingleCity.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tbSingleCity.Size = new System.Drawing.Size(1244, 207);
            this.tbSingleCity.TabIndex = 0;
            this.tbSingleCity.Text = "Single City Report ";
            this.tbSingleCity.UseVisualStyleBackColor = true;
            // 
            // btPrintReportOne
            // 
            this.btPrintReportOne.BackColor = System.Drawing.Color.Black;
            this.btPrintReportOne.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPrintReportOne.ForeColor = System.Drawing.Color.White;
            this.btPrintReportOne.Location = new System.Drawing.Point(744, 121);
            this.btPrintReportOne.Margin = new System.Windows.Forms.Padding(465, 6, 5, 6);
            this.btPrintReportOne.Name = "btPrintReportOne";
            this.btPrintReportOne.Size = new System.Drawing.Size(490, 42);
            this.btPrintReportOne.TabIndex = 34;
            this.btPrintReportOne.Text = "Print Report";
            this.btPrintReportOne.UseVisualStyleBackColor = false;
            this.btPrintReportOne.Click += new System.EventHandler(this.btPrintReport_Click);
            // 
            // lblEditHelp
            // 
            this.lblEditHelp.AutoSize = true;
            this.lblEditHelp.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditHelp.Location = new System.Drawing.Point(11, 81);
            this.lblEditHelp.Name = "lblEditHelp";
            this.lblEditHelp.Size = new System.Drawing.Size(386, 180);
            this.lblEditHelp.TabIndex = 31;
            this.lblEditHelp.Text = "To edit a record : \r\n- double click the cell of the record you want to change. \r\n" +
    "- type in the new value.\r\n- then finally, press enter or click out of the cell t" +
    "o save.\r\n\r\n\r\n\r\n\r\n\r\n\r\n";
            // 
            // cbCityNamesSingle
            // 
            this.cbCityNamesSingle.FormattingEnabled = true;
            this.cbCityNamesSingle.Location = new System.Drawing.Point(14, 29);
            this.cbCityNamesSingle.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cbCityNamesSingle.Name = "cbCityNamesSingle";
            this.cbCityNamesSingle.Size = new System.Drawing.Size(647, 31);
            this.cbCityNamesSingle.TabIndex = 30;
            this.cbCityNamesSingle.Text = "--SELECT CITY NAME--";
            this.cbCityNamesSingle.SelectedIndexChanged += new System.EventHandler(this.cbCityNamesSingle_SelectedIndexChanged_1);
            // 
            // tbMultipleCity
            // 
            this.tbMultipleCity.Controls.Add(this.btPrintReportTwo);
            this.tbMultipleCity.Controls.Add(this.cblMultipleCitySelect);
            this.tbMultipleCity.Controls.Add(this.label5);
            this.tbMultipleCity.Controls.Add(this.label6);
            this.tbMultipleCity.Controls.Add(this.label7);
            this.tbMultipleCity.Controls.Add(this.dtpStartDateMult);
            this.tbMultipleCity.Controls.Add(this.btGenReportMult);
            this.tbMultipleCity.Controls.Add(this.dtpEndDateMult);
            this.tbMultipleCity.Location = new System.Drawing.Point(4, 32);
            this.tbMultipleCity.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tbMultipleCity.Name = "tbMultipleCity";
            this.tbMultipleCity.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tbMultipleCity.Size = new System.Drawing.Size(1244, 207);
            this.tbMultipleCity.TabIndex = 1;
            this.tbMultipleCity.Text = "Multiple City Report";
            this.tbMultipleCity.UseVisualStyleBackColor = true;
            // 
            // btPrintReportTwo
            // 
            this.btPrintReportTwo.BackColor = System.Drawing.Color.Black;
            this.btPrintReportTwo.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPrintReportTwo.ForeColor = System.Drawing.Color.White;
            this.btPrintReportTwo.Location = new System.Drawing.Point(744, 121);
            this.btPrintReportTwo.Margin = new System.Windows.Forms.Padding(465, 6, 5, 6);
            this.btPrintReportTwo.Name = "btPrintReportTwo";
            this.btPrintReportTwo.Size = new System.Drawing.Size(490, 42);
            this.btPrintReportTwo.TabIndex = 35;
            this.btPrintReportTwo.Text = "Print Report";
            this.btPrintReportTwo.UseVisualStyleBackColor = false;
            this.btPrintReportTwo.Click += new System.EventHandler(this.BtPrintReportTwo_Click);
            // 
            // cblMultipleCitySelect
            // 
            this.cblMultipleCitySelect.FormattingEnabled = true;
            this.cblMultipleCitySelect.Location = new System.Drawing.Point(14, 29);
            this.cblMultipleCitySelect.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cblMultipleCitySelect.Name = "cblMultipleCitySelect";
            this.cblMultipleCitySelect.Size = new System.Drawing.Size(647, 134);
            this.cblMultipleCitySelect.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 6);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "City Name(s)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(740, 6);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "Start Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(990, 6);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 20);
            this.label7.TabIndex = 24;
            this.label7.Text = "End Date";
            // 
            // dtpStartDateMult
            // 
            this.dtpStartDateMult.CustomFormat = "dd/MM/yyyy";
            this.dtpStartDateMult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartDateMult.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDateMult.Location = new System.Drawing.Point(744, 29);
            this.dtpStartDateMult.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.dtpStartDateMult.Name = "dtpStartDateMult";
            this.dtpStartDateMult.Size = new System.Drawing.Size(240, 26);
            this.dtpStartDateMult.TabIndex = 25;
            // 
            // btGenReportMult
            // 
            this.btGenReportMult.BackColor = System.Drawing.Color.Black;
            this.btGenReportMult.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGenReportMult.ForeColor = System.Drawing.Color.White;
            this.btGenReportMult.Location = new System.Drawing.Point(744, 67);
            this.btGenReportMult.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btGenReportMult.Name = "btGenReportMult";
            this.btGenReportMult.Size = new System.Drawing.Size(490, 42);
            this.btGenReportMult.TabIndex = 27;
            this.btGenReportMult.Text = "Generate Report";
            this.btGenReportMult.UseVisualStyleBackColor = false;
            this.btGenReportMult.Click += new System.EventHandler(this.genReportMult_Click);
            // 
            // dtpEndDateMult
            // 
            this.dtpEndDateMult.CustomFormat = "dd/MM/yyyy";
            this.dtpEndDateMult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndDateMult.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDateMult.Location = new System.Drawing.Point(994, 29);
            this.dtpEndDateMult.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.dtpEndDateMult.Name = "dtpEndDateMult";
            this.dtpEndDateMult.Size = new System.Drawing.Size(240, 26);
            this.dtpEndDateMult.TabIndex = 26;
            // 
            // lblEditHelpMult
            // 
            this.lblEditHelpMult.AutoSize = true;
            this.lblEditHelpMult.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditHelpMult.Location = new System.Drawing.Point(147, 385);
            this.lblEditHelpMult.Name = "lblEditHelpMult";
            this.lblEditHelpMult.Size = new System.Drawing.Size(332, 64);
            this.lblEditHelpMult.TabIndex = 32;
            this.lblEditHelpMult.Text = "To edit a record : \r\n- double click the cell of the record you want to change. \r\n" +
    "- type in the new value.\r\n- then finally, press enter or click out of the cell t" +
    "o save.\r\n";
            // 
            // dgResults
            // 
            this.dgResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgResults.Location = new System.Drawing.Point(14, 453);
            this.dgResults.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.dgResults.Name = "dgResults";
            this.dgResults.Size = new System.Drawing.Size(1252, 252);
            this.dgResults.TabIndex = 24;
            this.dgResults.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgResults_CellBeginEdit);
            this.dgResults.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgResults_CellEndEdit);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Black;
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Font = new System.Drawing.Font("Bernard MT Condensed", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Margin = new System.Windows.Forms.Padding(7, 11, 7, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(1280, 59);
            this.label8.TabIndex = 25;
            this.label8.Text = "Weather Forecast Application";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveBorderlessFormOnMouseDown);
            // 
            // lblTitleResults
            // 
            this.lblTitleResults.BackColor = System.Drawing.Color.White;
            this.lblTitleResults.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTitleResults.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitleResults.Font = new System.Drawing.Font("Bernard MT Condensed", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleResults.ForeColor = System.Drawing.Color.Black;
            this.lblTitleResults.Location = new System.Drawing.Point(0, 59);
            this.lblTitleResults.Margin = new System.Windows.Forms.Padding(7, 11, 7, 0);
            this.lblTitleResults.Name = "lblTitleResults";
            this.lblTitleResults.Size = new System.Drawing.Size(1280, 60);
            this.lblTitleResults.TabIndex = 26;
            this.lblTitleResults.Text = "Generate Forecast Report";
            this.lblTitleResults.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTitleResults.Click += new System.EventHandler(this.lblTitleResults_Click);
            // 
            // btLegendFour
            // 
            this.btLegendFour.BackColor = System.Drawing.Color.Yellow;
            this.btLegendFour.Location = new System.Drawing.Point(333, 31);
            this.btLegendFour.Name = "btLegendFour";
            this.btLegendFour.Size = new System.Drawing.Size(25, 25);
            this.btLegendFour.TabIndex = 27;
            this.btLegendFour.UseVisualStyleBackColor = false;
            // 
            // btLegendThree
            // 
            this.btLegendThree.BackColor = System.Drawing.Color.Orange;
            this.btLegendThree.Location = new System.Drawing.Point(302, 31);
            this.btLegendThree.Name = "btLegendThree";
            this.btLegendThree.Size = new System.Drawing.Size(25, 25);
            this.btLegendThree.TabIndex = 28;
            this.btLegendThree.UseVisualStyleBackColor = false;
            // 
            // btLegendTwo
            // 
            this.btLegendTwo.BackColor = System.Drawing.Color.Chartreuse;
            this.btLegendTwo.Location = new System.Drawing.Point(333, 4);
            this.btLegendTwo.Name = "btLegendTwo";
            this.btLegendTwo.Size = new System.Drawing.Size(25, 25);
            this.btLegendTwo.TabIndex = 29;
            this.btLegendTwo.UseVisualStyleBackColor = false;
            // 
            // btLegendOne
            // 
            this.btLegendOne.BackColor = System.Drawing.Color.SpringGreen;
            this.btLegendOne.Location = new System.Drawing.Point(302, 4);
            this.btLegendOne.Name = "btLegendOne";
            this.btLegendOne.Size = new System.Drawing.Size(25, 25);
            this.btLegendOne.TabIndex = 30;
            this.btLegendOne.UseVisualStyleBackColor = false;
            // 
            // lblLegendOne
            // 
            this.lblLegendOne.AutoSize = true;
            this.lblLegendOne.Font = new System.Drawing.Font("Impact", 12.25F);
            this.lblLegendOne.Location = new System.Drawing.Point(5, 6);
            this.lblLegendOne.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblLegendOne.Name = "lblLegendOne";
            this.lblLegendOne.Size = new System.Drawing.Size(289, 21);
            this.lblLegendOne.TabIndex = 31;
            this.lblLegendOne.Text = "Where Lowest/Highest Values Are Equal";
            // 
            // lblLegendTwo
            // 
            this.lblLegendTwo.AutoSize = true;
            this.lblLegendTwo.Font = new System.Drawing.Font("Impact", 12F);
            this.lblLegendTwo.Location = new System.Drawing.Point(47, 32);
            this.lblLegendTwo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblLegendTwo.Name = "lblLegendTwo";
            this.lblLegendTwo.Size = new System.Drawing.Size(247, 20);
            this.lblLegendTwo.TabIndex = 32;
            this.lblLegendTwo.Text = "Indicates The Lowest/Highest Values";
            // 
            // pnGenRepLegend
            // 
            this.pnGenRepLegend.Controls.Add(this.lblLegendOne);
            this.pnGenRepLegend.Controls.Add(this.btLegendFour);
            this.pnGenRepLegend.Controls.Add(this.lblLegendTwo);
            this.pnGenRepLegend.Controls.Add(this.btLegendThree);
            this.pnGenRepLegend.Controls.Add(this.btLegendTwo);
            this.pnGenRepLegend.Controls.Add(this.btLegendOne);
            this.pnGenRepLegend.Location = new System.Drawing.Point(899, 384);
            this.pnGenRepLegend.Name = "pnGenRepLegend";
            this.pnGenRepLegend.Size = new System.Drawing.Size(363, 60);
            this.pnGenRepLegend.TabIndex = 33;
            // 
            // lblTest
            // 
            this.lblTest.AutoSize = true;
            this.lblTest.Location = new System.Drawing.Point(18, 70);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(0, 24);
            this.lblTest.TabIndex = 34;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.Image = global::weatherForecastAppPOE.Properties.Resources.CloseButtonOneBlackAndWhite;
            this.button1.Location = new System.Drawing.Point(1222, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 58);
            this.button1.TabIndex = 35;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btExit_Click);
            // 
            // frmGenerateReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblTest);
            this.Controls.Add(this.lblEditHelpMult);
            this.Controls.Add(this.pnGenRepLegend);
            this.Controls.Add(this.lblTitleResults);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgResults);
            this.Controls.Add(this.tabReports);
            this.Controls.Add(this.lblResultHeader);
            this.Controls.Add(this.button2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.Name = "frmGenerateReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Weather Forecast Application - Generate Weather Forecast Report";
            this.Load += new System.EventHandler(this.GenerateReport_Load);
            this.tabReports.ResumeLayout(false);
            this.tbSingleCity.ResumeLayout(false);
            this.tbSingleCity.PerformLayout();
            this.tbMultipleCity.ResumeLayout(false);
            this.tbMultipleCity.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgResults)).EndInit();
            this.pnGenRepLegend.ResumeLayout(false);
            this.pnGenRepLegend.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpStartDateSingle;
        private System.Windows.Forms.DateTimePicker dtpEndDateSingle;
        private System.Windows.Forms.Button btGenReportSingle;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblResultHeader;
        private System.Windows.Forms.TabControl tabReports;
        private System.Windows.Forms.TabPage tbSingleCity;
        private System.Windows.Forms.TabPage tbMultipleCity;
        private System.Windows.Forms.DataGridView dgResults;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpStartDateMult;
        private System.Windows.Forms.Button btGenReportMult;
        private System.Windows.Forms.DateTimePicker dtpEndDateMult;
        private System.Windows.Forms.ComboBox cbCityNamesSingle;
        private System.Windows.Forms.CheckedListBox cblMultipleCitySelect;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label lblTitleResults;
		private System.Windows.Forms.Button btLegendFour;
		private System.Windows.Forms.Button btLegendThree;
		private System.Windows.Forms.Button btLegendTwo;
		private System.Windows.Forms.Button btLegendOne;
		private System.Windows.Forms.Label lblLegendOne;
		private System.Windows.Forms.Label lblLegendTwo;
		private System.Windows.Forms.Panel pnGenRepLegend;
		private System.Windows.Forms.Label lblEditHelp;
		private System.Windows.Forms.Label lblEditHelpMult;
		private System.Windows.Forms.Button btPrintReportOne;
		private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button btPrintReportTwo;
        private System.Windows.Forms.Label lblTest;
        private System.Windows.Forms.Button button1;
    }
}