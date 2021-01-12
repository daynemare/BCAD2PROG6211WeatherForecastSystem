using System;

namespace weatherForecastAppPOE
{
    partial class frmNewEntry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewEntry));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCityName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.tbMinTemp = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbMaxTemp = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbPrecipitation = new System.Windows.Forms.TextBox();
            this.lbHumidity = new System.Windows.Forms.Label();
            this.tbHumidity = new System.Windows.Forms.TextBox();
            this.lbWindSpeed = new System.Windows.Forms.Label();
            this.tbWindSpeed = new System.Windows.Forms.TextBox();
            this.btSaveFore = new System.Windows.Forms.Button();
            this.btClearAll = new System.Windows.Forms.Button();
            this.btReturnMain = new System.Windows.Forms.Button();
            this.lblTitleInpit = new System.Windows.Forms.Label();
            this.cblCityPreferences = new System.Windows.Forms.CheckedListBox();
            this.btSaveGen = new System.Windows.Forms.Button();
            this.lblAvailRecords = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Bernard MT Condensed", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 10, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1280, 58);
            this.label2.TabIndex = 2;
            this.label2.Text = "Weather Forecast Application";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveBorderlessFormOnMouseDown);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(359, 161);
            this.label3.Margin = new System.Windows.Forms.Padding(350, 10, 4, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "City Name";
            // 
            // tbCityName
            // 
            this.tbCityName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCityName.Location = new System.Drawing.Point(359, 188);
            this.tbCityName.Margin = new System.Windows.Forms.Padding(4, 5, 100, 5);
            this.tbCityName.Name = "tbCityName";
            this.tbCityName.Size = new System.Drawing.Size(580, 29);
            this.tbCityName.TabIndex = 4;
            this.tbCityName.TextChanged += new System.EventHandler(this.tbCityName_TextChanged);
            this.tbCityName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCityName_KeyPress);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(359, 219);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "Date";
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "dd/MM/yyyy";
            this.dtpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(359, 247);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(580, 29);
            this.dtpDate.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(359, 278);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(313, 22);
            this.label5.TabIndex = 7;
            this.label5.Text = "Minimum Temperature ( °C )";
            // 
            // tbMinTemp
            // 
            this.tbMinTemp.BackColor = System.Drawing.Color.White;
            this.tbMinTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMinTemp.Location = new System.Drawing.Point(360, 306);
            this.tbMinTemp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbMinTemp.Name = "tbMinTemp";
            this.tbMinTemp.Size = new System.Drawing.Size(580, 29);
            this.tbMinTemp.TabIndex = 8;
            this.tbMinTemp.TextChanged += new System.EventHandler(this.tbMinTemp_TextChanged);
            this.tbMinTemp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMinTemp_KeyPress);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(359, 342);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(444, 21);
            this.label6.TabIndex = 9;
            this.label6.Text = "Maximum Temperature ( °C )";
            // 
            // tbMaxTemp
            // 
            this.tbMaxTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaxTemp.Location = new System.Drawing.Point(359, 369);
            this.tbMaxTemp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbMaxTemp.Name = "tbMaxTemp";
            this.tbMaxTemp.Size = new System.Drawing.Size(580, 29);
            this.tbMaxTemp.TabIndex = 10;
            this.tbMaxTemp.TextChanged += new System.EventHandler(this.tbMaxTemp_TextChanged);
            this.tbMaxTemp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMaxTemp_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(359, 400);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 1);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Precipitation ( % )";
            // 
            // tbPrecipitation
            // 
            this.tbPrecipitation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrecipitation.Location = new System.Drawing.Point(359, 427);
            this.tbPrecipitation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbPrecipitation.Name = "tbPrecipitation";
            this.tbPrecipitation.Size = new System.Drawing.Size(580, 29);
            this.tbPrecipitation.TabIndex = 12;
            this.tbPrecipitation.TextChanged += new System.EventHandler(this.tbPrecipitation_TextChanged);
            this.tbPrecipitation.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPrecipitation_KeyPress);
            // 
            // lbHumidity
            // 
            this.lbHumidity.AutoSize = true;
            this.lbHumidity.BackColor = System.Drawing.Color.Transparent;
            this.lbHumidity.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHumidity.ForeColor = System.Drawing.Color.Black;
            this.lbHumidity.Location = new System.Drawing.Point(359, 458);
            this.lbHumidity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 1);
            this.lbHumidity.Name = "lbHumidity";
            this.lbHumidity.Size = new System.Drawing.Size(96, 20);
            this.lbHumidity.TabIndex = 13;
            this.lbHumidity.Text = "Humidity ( % )";
            // 
            // tbHumidity
            // 
            this.tbHumidity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHumidity.Location = new System.Drawing.Point(360, 485);
            this.tbHumidity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 1);
            this.tbHumidity.Name = "tbHumidity";
            this.tbHumidity.Size = new System.Drawing.Size(580, 29);
            this.tbHumidity.TabIndex = 14;
            this.tbHumidity.TextChanged += new System.EventHandler(this.tbHumidity_TextChanged);
            this.tbHumidity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbHumidity_KeyPress);
            // 
            // lbWindSpeed
            // 
            this.lbWindSpeed.AutoSize = true;
            this.lbWindSpeed.BackColor = System.Drawing.Color.Transparent;
            this.lbWindSpeed.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWindSpeed.ForeColor = System.Drawing.Color.Black;
            this.lbWindSpeed.Location = new System.Drawing.Point(359, 516);
            this.lbWindSpeed.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.lbWindSpeed.Name = "lbWindSpeed";
            this.lbWindSpeed.Size = new System.Drawing.Size(139, 20);
            this.lbWindSpeed.TabIndex = 15;
            this.lbWindSpeed.Text = "Wind Speed ( Km/h )";
            // 
            // tbWindSpeed
            // 
            this.tbWindSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbWindSpeed.Location = new System.Drawing.Point(359, 537);
            this.tbWindSpeed.Margin = new System.Windows.Forms.Padding(4, 10, 4, 10);
            this.tbWindSpeed.Name = "tbWindSpeed";
            this.tbWindSpeed.Size = new System.Drawing.Size(580, 29);
            this.tbWindSpeed.TabIndex = 16;
            this.tbWindSpeed.TextChanged += new System.EventHandler(this.tbWindSpeed_TextChanged);
            this.tbWindSpeed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbWindSpeed_KeyPress);
            // 
            // btSaveFore
            // 
            this.btSaveFore.BackColor = System.Drawing.Color.White;
            this.btSaveFore.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSaveFore.ForeColor = System.Drawing.Color.Black;
            this.btSaveFore.Location = new System.Drawing.Point(359, 596);
            this.btSaveFore.Margin = new System.Windows.Forms.Padding(100, 0, 10, 10);
            this.btSaveFore.Name = "btSaveFore";
            this.btSaveFore.Size = new System.Drawing.Size(180, 33);
            this.btSaveFore.TabIndex = 17;
            this.btSaveFore.Text = "Save ";
            this.btSaveFore.UseVisualStyleBackColor = false;
            this.btSaveFore.Click += new System.EventHandler(this.btSaveEntry_Click);
            // 
            // btClearAll
            // 
            this.btClearAll.BackColor = System.Drawing.Color.Black;
            this.btClearAll.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClearAll.ForeColor = System.Drawing.Color.White;
            this.btClearAll.Location = new System.Drawing.Point(559, 596);
            this.btClearAll.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.btClearAll.Name = "btClearAll";
            this.btClearAll.Size = new System.Drawing.Size(212, 33);
            this.btClearAll.TabIndex = 18;
            this.btClearAll.Text = "Clear All";
            this.btClearAll.UseVisualStyleBackColor = false;
            this.btClearAll.Click += new System.EventHandler(this.btClearAll_Click);
            // 
            // btReturnMain
            // 
            this.btReturnMain.AutoSize = true;
            this.btReturnMain.BackColor = System.Drawing.Color.Black;
            this.btReturnMain.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReturnMain.ForeColor = System.Drawing.Color.White;
            this.btReturnMain.Location = new System.Drawing.Point(791, 596);
            this.btReturnMain.Margin = new System.Windows.Forms.Padding(10, 5, 100, 5);
            this.btReturnMain.Name = "btReturnMain";
            this.btReturnMain.Size = new System.Drawing.Size(150, 33);
            this.btReturnMain.TabIndex = 19;
            this.btReturnMain.Text = "Main Menu";
            this.btReturnMain.UseVisualStyleBackColor = false;
            this.btReturnMain.Click += new System.EventHandler(this.btReturnMain_Click);
            // 
            // lblTitleInpit
            // 
            this.lblTitleInpit.BackColor = System.Drawing.Color.White;
            this.lblTitleInpit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTitleInpit.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitleInpit.Font = new System.Drawing.Font("Bernard MT Condensed", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleInpit.ForeColor = System.Drawing.Color.Black;
            this.lblTitleInpit.Location = new System.Drawing.Point(0, 58);
            this.lblTitleInpit.Margin = new System.Windows.Forms.Padding(6, 10, 6, 0);
            this.lblTitleInpit.Name = "lblTitleInpit";
            this.lblTitleInpit.Size = new System.Drawing.Size(1280, 51);
            this.lblTitleInpit.TabIndex = 20;
            this.lblTitleInpit.Text = "Create New Forecast Entry";
            this.lblTitleInpit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cblCityPreferences
            // 
            this.cblCityPreferences.BackColor = System.Drawing.Color.White;
            this.cblCityPreferences.FormattingEnabled = true;
            this.cblCityPreferences.Location = new System.Drawing.Point(357, 161);
            this.cblCityPreferences.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cblCityPreferences.Name = "cblCityPreferences";
            this.cblCityPreferences.Size = new System.Drawing.Size(584, 422);
            this.cblCityPreferences.TabIndex = 30;
            // 
            // btSaveGen
            // 
            this.btSaveGen.BackColor = System.Drawing.Color.Black;
            this.btSaveGen.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSaveGen.ForeColor = System.Drawing.Color.White;
            this.btSaveGen.Location = new System.Drawing.Point(357, 596);
            this.btSaveGen.Margin = new System.Windows.Forms.Padding(100, 0, 10, 10);
            this.btSaveGen.Name = "btSaveGen";
            this.btSaveGen.Size = new System.Drawing.Size(182, 33);
            this.btSaveGen.TabIndex = 31;
            this.btSaveGen.Text = "Save ";
            this.btSaveGen.UseVisualStyleBackColor = false;
            this.btSaveGen.Click += new System.EventHandler(this.btSaveGen_Click);
            // 
            // lblAvailRecords
            // 
            this.lblAvailRecords.AutoSize = true;
            this.lblAvailRecords.Location = new System.Drawing.Point(359, 138);
            this.lblAvailRecords.Name = "lblAvailRecords";
            this.lblAvailRecords.Size = new System.Drawing.Size(154, 20);
            this.lblAvailRecords.TabIndex = 32;
            this.lblAvailRecords.Text = "Available City Records";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.Image = global::weatherForecastAppPOE.Properties.Resources.CloseButtonOneBlackAndWhite;
            this.button1.Location = new System.Drawing.Point(1222, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 58);
            this.button1.TabIndex = 33;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btExit_Click);
            // 
            // frmNewEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblAvailRecords);
            this.Controls.Add(this.btSaveGen);
            this.Controls.Add(this.cblCityPreferences);
            this.Controls.Add(this.lblTitleInpit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbCityName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btReturnMain);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbWindSpeed);
            this.Controls.Add(this.btSaveFore);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btClearAll);
            this.Controls.Add(this.lbWindSpeed);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbMinTemp);
            this.Controls.Add(this.tbPrecipitation);
            this.Controls.Add(this.tbHumidity);
            this.Controls.Add(this.tbMaxTemp);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbHumidity);
            this.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1280, 720);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "frmNewEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Weather Forecast Application - Create New Weather Forecast Entry";
            this.Load += new System.EventHandler(this.frmNewEntry_Load);
            this.VisibleChanged += new System.EventHandler(this.Form1_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Form1_VisibleChanged(object sender, EventArgs e)
        {
           
        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbCityName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbMinTemp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbMaxTemp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbPrecipitation;
        private System.Windows.Forms.Label lbHumidity;
        private System.Windows.Forms.TextBox tbHumidity;
        private System.Windows.Forms.Label lbWindSpeed;
        private System.Windows.Forms.TextBox tbWindSpeed;
        private System.Windows.Forms.Button btSaveFore;
        private System.Windows.Forms.Button btClearAll;
        private System.Windows.Forms.Button btReturnMain;
		private System.Windows.Forms.Label lblTitleInpit;
		private System.Windows.Forms.CheckedListBox cblCityPreferences;
		private System.Windows.Forms.Button btSaveGen;
		private System.Windows.Forms.Label lblAvailRecords;
        private System.Windows.Forms.Button button1;
    }
}