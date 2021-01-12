namespace weatherForecastAppPOE
{
	partial class frmLoginPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoginPage));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbRegGeneralUser = new System.Windows.Forms.CheckBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.cbRegForecaster = new System.Windows.Forms.CheckBox();
            this.tcLogin = new System.Windows.Forms.TabControl();
            this.tpReg = new System.Windows.Forms.TabPage();
            this.btRegister = new System.Windows.Forms.Button();
            this.tbRegPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbRegUsername = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tpLog = new System.Windows.Forms.TabPage();
            this.btLogSubmit = new System.Windows.Forms.Button();
            this.tbLogPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbLogGenUser = new System.Windows.Forms.CheckBox();
            this.tbLogUsername = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbLogForecaster = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.llGoToWebOne = new System.Windows.Forms.LinkLabel();
            this.llGoToWebTwo = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tcLogin.SuspendLayout();
            this.tpReg.SuspendLayout();
            this.tpLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.label1.TabIndex = 5;
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
            this.label2.TabIndex = 6;
            this.label2.Text = "User Login";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cbRegGeneralUser
            // 
            this.cbRegGeneralUser.AutoSize = true;
            this.cbRegGeneralUser.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRegGeneralUser.Location = new System.Drawing.Point(6, 168);
            this.cbRegGeneralUser.Name = "cbRegGeneralUser";
            this.cbRegGeneralUser.Size = new System.Drawing.Size(113, 24);
            this.cbRegGeneralUser.TabIndex = 7;
            this.cbRegGeneralUser.Text = "General User";
            this.cbRegGeneralUser.UseVisualStyleBackColor = true;
            this.cbRegGeneralUser.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbRegGeneralUser_MouseClick_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(233, 39);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // cbRegForecaster
            // 
            this.cbRegForecaster.AutoSize = true;
            this.cbRegForecaster.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRegForecaster.Location = new System.Drawing.Point(125, 168);
            this.cbRegForecaster.Name = "cbRegForecaster";
            this.cbRegForecaster.Size = new System.Drawing.Size(158, 24);
            this.cbRegForecaster.TabIndex = 11;
            this.cbRegForecaster.Text = "Weather Forecaster";
            this.cbRegForecaster.UseVisualStyleBackColor = true;
            this.cbRegForecaster.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbRegForecaster_MouseClick_1);
            // 
            // tcLogin
            // 
            this.tcLogin.Controls.Add(this.tpReg);
            this.tcLogin.Controls.Add(this.tpLog);
            this.tcLogin.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcLogin.Location = new System.Drawing.Point(359, 146);
            this.tcLogin.Name = "tcLogin";
            this.tcLogin.SelectedIndex = 0;
            this.tcLogin.Size = new System.Drawing.Size(592, 468);
            this.tcLogin.TabIndex = 14;
            // 
            // tpReg
            // 
            this.tpReg.Controls.Add(this.llGoToWebOne);
            this.tpReg.Controls.Add(this.btRegister);
            this.tpReg.Controls.Add(this.tbRegPassword);
            this.tpReg.Controls.Add(this.label6);
            this.tpReg.Controls.Add(this.label3);
            this.tpReg.Controls.Add(this.cbRegGeneralUser);
            this.tpReg.Controls.Add(this.tbRegUsername);
            this.tpReg.Controls.Add(this.label7);
            this.tpReg.Controls.Add(this.cbRegForecaster);
            this.tpReg.Controls.Add(this.label5);
            this.tpReg.Controls.Add(this.pictureBox2);
            this.tpReg.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpReg.Location = new System.Drawing.Point(4, 32);
            this.tpReg.Name = "tpReg";
            this.tpReg.Padding = new System.Windows.Forms.Padding(3);
            this.tpReg.Size = new System.Drawing.Size(584, 432);
            this.tpReg.TabIndex = 0;
            this.tpReg.Text = "User Registration";
            this.tpReg.UseVisualStyleBackColor = true;
            // 
            // btRegister
            // 
            this.btRegister.BackColor = System.Drawing.Color.Black;
            this.btRegister.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRegister.ForeColor = System.Drawing.Color.White;
            this.btRegister.Location = new System.Drawing.Point(0, 343);
            this.btRegister.Margin = new System.Windows.Forms.Padding(465, 6, 5, 6);
            this.btRegister.Name = "btRegister";
            this.btRegister.Size = new System.Drawing.Size(584, 42);
            this.btRegister.TabIndex = 21;
            this.btRegister.Text = "Register";
            this.btRegister.UseVisualStyleBackColor = false;
            this.btRegister.Click += new System.EventHandler(this.btRegister_Click_1);
            // 
            // tbRegPassword
            // 
            this.tbRegPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRegPassword.Location = new System.Drawing.Point(5, 303);
            this.tbRegPassword.Margin = new System.Windows.Forms.Padding(4, 5, 100, 5);
            this.tbRegPassword.Name = "tbRegPassword";
            this.tbRegPassword.Size = new System.Drawing.Size(579, 29);
            this.tbRegPassword.TabIndex = 19;
            this.tbRegPassword.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(2, 276);
            this.label6.Margin = new System.Windows.Forms.Padding(350, 10, 4, 1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(189, 21);
            this.label6.TabIndex = 18;
            this.label6.Text = "Password";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(2, 205);
            this.label3.Margin = new System.Windows.Forms.Padding(350, 10, 4, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 21);
            this.label3.TabIndex = 17;
            this.label3.Text = "Username";
            // 
            // tbRegUsername
            // 
            this.tbRegUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRegUsername.Location = new System.Drawing.Point(4, 232);
            this.tbRegUsername.Margin = new System.Windows.Forms.Padding(4, 5, 100, 5);
            this.tbRegUsername.Name = "tbRegUsername";
            this.tbRegUsername.Size = new System.Drawing.Size(580, 29);
            this.tbRegUsername.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(2, 143);
            this.label7.Margin = new System.Windows.Forms.Padding(350, 10, 4, 1);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(189, 21);
            this.label7.TabIndex = 15;
            this.label7.Text = "User Type :";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("Bernard MT Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 10, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(584, 36);
            this.label5.TabIndex = 15;
            this.label5.Text = "Register New User Account :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tpLog
            // 
            this.tpLog.Controls.Add(this.llGoToWebTwo);
            this.tpLog.Controls.Add(this.btLogSubmit);
            this.tpLog.Controls.Add(this.tbLogPassword);
            this.tpLog.Controls.Add(this.label4);
            this.tpLog.Controls.Add(this.label8);
            this.tpLog.Controls.Add(this.cbLogGenUser);
            this.tpLog.Controls.Add(this.tbLogUsername);
            this.tpLog.Controls.Add(this.label9);
            this.tpLog.Controls.Add(this.cbLogForecaster);
            this.tpLog.Controls.Add(this.label10);
            this.tpLog.Controls.Add(this.pictureBox1);
            this.tpLog.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpLog.Location = new System.Drawing.Point(4, 32);
            this.tpLog.Name = "tpLog";
            this.tpLog.Padding = new System.Windows.Forms.Padding(3);
            this.tpLog.Size = new System.Drawing.Size(584, 432);
            this.tpLog.TabIndex = 1;
            this.tpLog.Text = "User Login";
            this.tpLog.UseVisualStyleBackColor = true;
            // 
            // btLogSubmit
            // 
            this.btLogSubmit.BackColor = System.Drawing.Color.Black;
            this.btLogSubmit.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogSubmit.ForeColor = System.Drawing.Color.White;
            this.btLogSubmit.Location = new System.Drawing.Point(0, 343);
            this.btLogSubmit.Margin = new System.Windows.Forms.Padding(465, 6, 5, 6);
            this.btLogSubmit.Name = "btLogSubmit";
            this.btLogSubmit.Size = new System.Drawing.Size(584, 42);
            this.btLogSubmit.TabIndex = 31;
            this.btLogSubmit.Text = "Submit";
            this.btLogSubmit.UseVisualStyleBackColor = false;
            this.btLogSubmit.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // tbLogPassword
            // 
            this.tbLogPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLogPassword.Location = new System.Drawing.Point(5, 303);
            this.tbLogPassword.Margin = new System.Windows.Forms.Padding(4, 5, 100, 5);
            this.tbLogPassword.Name = "tbLogPassword";
            this.tbLogPassword.Size = new System.Drawing.Size(579, 29);
            this.tbLogPassword.TabIndex = 30;
            this.tbLogPassword.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(2, 276);
            this.label4.Margin = new System.Windows.Forms.Padding(350, 10, 4, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 21);
            this.label4.TabIndex = 29;
            this.label4.Text = "Password";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(2, 205);
            this.label8.Margin = new System.Windows.Forms.Padding(350, 10, 4, 1);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(189, 21);
            this.label8.TabIndex = 28;
            this.label8.Text = "Username";
            // 
            // cbLogGenUser
            // 
            this.cbLogGenUser.AutoSize = true;
            this.cbLogGenUser.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLogGenUser.Location = new System.Drawing.Point(6, 168);
            this.cbLogGenUser.Name = "cbLogGenUser";
            this.cbLogGenUser.Size = new System.Drawing.Size(113, 24);
            this.cbLogGenUser.TabIndex = 22;
            this.cbLogGenUser.Text = "General User";
            this.cbLogGenUser.UseVisualStyleBackColor = true;
            this.cbLogGenUser.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbLogGenUser_MouseClick_1);
            // 
            // tbLogUsername
            // 
            this.tbLogUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLogUsername.Location = new System.Drawing.Point(4, 232);
            this.tbLogUsername.Margin = new System.Windows.Forms.Padding(4, 5, 100, 5);
            this.tbLogUsername.Name = "tbLogUsername";
            this.tbLogUsername.Size = new System.Drawing.Size(580, 29);
            this.tbLogUsername.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(2, 143);
            this.label9.Margin = new System.Windows.Forms.Padding(350, 10, 4, 1);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(189, 21);
            this.label9.TabIndex = 25;
            this.label9.Text = "User Type :";
            // 
            // cbLogForecaster
            // 
            this.cbLogForecaster.AutoSize = true;
            this.cbLogForecaster.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLogForecaster.Location = new System.Drawing.Point(125, 168);
            this.cbLogForecaster.Name = "cbLogForecaster";
            this.cbLogForecaster.Size = new System.Drawing.Size(158, 24);
            this.cbLogForecaster.TabIndex = 24;
            this.cbLogForecaster.Text = "Weather Forecaster";
            this.cbLogForecaster.UseVisualStyleBackColor = true;
            this.cbLogForecaster.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbLogForecaster_MouseClick_1);
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Black;
            this.label10.Font = new System.Drawing.Font("Bernard MT Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(0, 0);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 10, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(584, 36);
            this.label10.TabIndex = 26;
            this.label10.Text = "Sign In :";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(233, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.Image = global::weatherForecastAppPOE.Properties.Resources.CloseButtonOneBlackAndWhite;
            this.button1.Location = new System.Drawing.Point(1222, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 58);
            this.button1.TabIndex = 15;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.ExitButton);
            // 
            // llGoToWebOne
            // 
            this.llGoToWebOne.AutoSize = true;
            this.llGoToWebOne.Location = new System.Drawing.Point(206, 391);
            this.llGoToWebOne.Margin = new System.Windows.Forms.Padding(206, 0, 3, 0);
            this.llGoToWebOne.Name = "llGoToWebOne";
            this.llGoToWebOne.Size = new System.Drawing.Size(172, 20);
            this.llGoToWebOne.TabIndex = 22;
            this.llGoToWebOne.TabStop = true;
            this.llGoToWebOne.Text = "Go To Web Application";
            this.llGoToWebOne.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GoToWebAppLoginLLOne);
            // 
            // llGoToWebTwo
            // 
            this.llGoToWebTwo.AutoSize = true;
            this.llGoToWebTwo.Location = new System.Drawing.Point(206, 391);
            this.llGoToWebTwo.Margin = new System.Windows.Forms.Padding(206, 0, 3, 0);
            this.llGoToWebTwo.Name = "llGoToWebTwo";
            this.llGoToWebTwo.Size = new System.Drawing.Size(172, 20);
            this.llGoToWebTwo.TabIndex = 32;
            this.llGoToWebTwo.TabStop = true;
            this.llGoToWebTwo.Text = "Go To Web Application";
            this.llGoToWebTwo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GoToWebAppLoginLLTwo);
            // 
            // frmLoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tcLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "frmLoginPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginPage";
            this.Load += new System.EventHandler(this.LoginPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tcLogin.ResumeLayout(false);
            this.tpReg.ResumeLayout(false);
            this.tpReg.PerformLayout();
            this.tpLog.ResumeLayout(false);
            this.tpLog.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.CheckBox cbRegGeneralUser;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.CheckBox cbRegForecaster;
		private System.Windows.Forms.TabControl tcLogin;
		private System.Windows.Forms.TabPage tpReg;
		private System.Windows.Forms.TabPage tpLog;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox tbRegUsername;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tbRegPassword;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button btRegister;
		private System.Windows.Forms.Button btLogSubmit;
		private System.Windows.Forms.TextBox tbLogPassword;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.CheckBox cbLogGenUser;
		private System.Windows.Forms.TextBox tbLogUsername;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.CheckBox cbLogForecaster;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel llGoToWebOne;
        private System.Windows.Forms.LinkLabel llGoToWebTwo;
    }
}