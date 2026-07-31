namespace AgeDaysCalculator
{
    partial class Form1
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblAgeDays = new System.Windows.Forms.Label();
            this.pictureCalendar = new System.Windows.Forms.PictureBox();
            this.panelDetails = new System.Windows.Forms.Panel();
            this.btnClear = new Guna.UI2.WinForms.Guna2Button();
            this.panelTotalHours = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTotalHours = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblTotalHrs = new System.Windows.Forms.Label();
            this.panelTotalDays = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTotalDays = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblTotalDys = new System.Windows.Forms.Label();
            this.panelNextBirthday = new Guna.UI2.WinForms.Guna2Panel();
            this.lblNextBirthdayDays = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblDaysToGo = new System.Windows.Forms.Label();
            this.lblNextBirthday = new System.Windows.Forms.Label();
            this.panelExactAge = new Guna.UI2.WinForms.Guna2Panel();
            this.lblDays = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblMonths = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblYears = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbldys = new System.Windows.Forms.Label();
            this.lblmons = new System.Windows.Forms.Label();
            this.lblyrs = new System.Windows.Forms.Label();
            this.lblExactAge = new System.Windows.Forms.Label();
            this.panelInput = new System.Windows.Forms.Panel();
            this.panelSelectDate = new System.Windows.Forms.Panel();
            this.guna2DateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnCalculate = new Guna.UI2.WinForms.Guna2Button();
            this.lblSelectYourDate = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCalendar)).BeginInit();
            this.panelDetails.SuspendLayout();
            this.panelTotalHours.SuspendLayout();
            this.panelTotalDays.SuspendLayout();
            this.panelNextBirthday.SuspendLayout();
            this.panelExactAge.SuspendLayout();
            this.panelInput.SuspendLayout();
            this.panelSelectDate.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.btnExit);
            this.panelHeader.Controls.Add(this.panelTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(800, 217);
            this.panelHeader.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Image = global::AgeDaysCalculator.Properties.Resources._CITYPNG_COM_Blue_Round_Close_X_Icon_HD_PNG___700x700;
            this.btnExit.Location = new System.Drawing.Point(712, 24);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(46, 40);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExit.TabIndex = 3;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panelTitle.Controls.Add(this.lblSubtitle);
            this.panelTitle.Controls.Add(this.lblAgeDays);
            this.panelTitle.Controls.Add(this.pictureCalendar);
            this.panelTitle.Location = new System.Drawing.Point(183, 74);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(459, 104);
            this.panelTitle.TabIndex = 0;
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.BackColor = System.Drawing.Color.Transparent;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitle.ForeColor = System.Drawing.Color.Gray;
            this.lblSubtitle.Location = new System.Drawing.Point(29, 55);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(299, 20);
            this.lblSubtitle.TabIndex = 2;
            this.lblSubtitle.Text = "Discover your exact age and milestone stats";
            // 
            // lblAgeDays
            // 
            this.lblAgeDays.AutoSize = true;
            this.lblAgeDays.BackColor = System.Drawing.Color.Transparent;
            this.lblAgeDays.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgeDays.ForeColor = System.Drawing.Color.White;
            this.lblAgeDays.Location = new System.Drawing.Point(75, 18);
            this.lblAgeDays.Name = "lblAgeDays";
            this.lblAgeDays.Size = new System.Drawing.Size(244, 31);
            this.lblAgeDays.TabIndex = 1;
            this.lblAgeDays.Text = "Age / Days Calculator";
            // 
            // pictureCalendar
            // 
            this.pictureCalendar.Image = global::AgeDaysCalculator.Properties.Resources.calendar__2_;
            this.pictureCalendar.Location = new System.Drawing.Point(32, 14);
            this.pictureCalendar.Name = "pictureCalendar";
            this.pictureCalendar.Size = new System.Drawing.Size(37, 35);
            this.pictureCalendar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureCalendar.TabIndex = 0;
            this.pictureCalendar.TabStop = false;
            // 
            // panelDetails
            // 
            this.panelDetails.Controls.Add(this.btnClear);
            this.panelDetails.Controls.Add(this.panelTotalHours);
            this.panelDetails.Controls.Add(this.panelTotalDays);
            this.panelDetails.Controls.Add(this.panelNextBirthday);
            this.panelDetails.Controls.Add(this.panelExactAge);
            this.panelDetails.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelDetails.Location = new System.Drawing.Point(0, 476);
            this.panelDetails.Name = "panelDetails";
            this.panelDetails.Size = new System.Drawing.Size(800, 424);
            this.panelDetails.TabIndex = 1;
            // 
            // btnClear
            // 
            this.btnClear.BorderColor = System.Drawing.Color.Transparent;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClear.FillColor = System.Drawing.Color.Transparent;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Gray;
            this.btnClear.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnClear.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(367, 366);
            this.btnClear.Name = "btnClear";
            this.btnClear.PressedColor = System.Drawing.Color.Transparent;
            this.btnClear.Size = new System.Drawing.Size(86, 32);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // panelTotalHours
            // 
            this.panelTotalHours.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panelTotalHours.Controls.Add(this.lblTotalHours);
            this.panelTotalHours.Controls.Add(this.lblTotalHrs);
            this.panelTotalHours.Location = new System.Drawing.Point(426, 246);
            this.panelTotalHours.Name = "panelTotalHours";
            this.panelTotalHours.Size = new System.Drawing.Size(216, 100);
            this.panelTotalHours.TabIndex = 3;
            // 
            // lblTotalHours
            // 
            this.lblTotalHours.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalHours.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalHours.ForeColor = System.Drawing.Color.White;
            this.lblTotalHours.Location = new System.Drawing.Point(34, 45);
            this.lblTotalHours.Name = "lblTotalHours";
            this.lblTotalHours.Size = new System.Drawing.Size(16, 33);
            this.lblTotalHours.TabIndex = 9;
            this.lblTotalHours.Text = "0";
            // 
            // lblTotalHrs
            // 
            this.lblTotalHrs.AutoSize = true;
            this.lblTotalHrs.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalHrs.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalHrs.ForeColor = System.Drawing.Color.Gray;
            this.lblTotalHrs.Location = new System.Drawing.Point(30, 18);
            this.lblTotalHrs.Name = "lblTotalHrs";
            this.lblTotalHrs.Size = new System.Drawing.Size(109, 20);
            this.lblTotalHrs.TabIndex = 6;
            this.lblTotalHrs.Text = "TOTAL HOURS";
            // 
            // panelTotalDays
            // 
            this.panelTotalDays.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panelTotalDays.Controls.Add(this.lblTotalDays);
            this.panelTotalDays.Controls.Add(this.lblTotalDys);
            this.panelTotalDays.Location = new System.Drawing.Point(183, 246);
            this.panelTotalDays.Name = "panelTotalDays";
            this.panelTotalDays.Size = new System.Drawing.Size(214, 100);
            this.panelTotalDays.TabIndex = 2;
            // 
            // lblTotalDays
            // 
            this.lblTotalDays.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalDays.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDays.ForeColor = System.Drawing.Color.White;
            this.lblTotalDays.Location = new System.Drawing.Point(33, 45);
            this.lblTotalDays.Name = "lblTotalDays";
            this.lblTotalDays.Size = new System.Drawing.Size(16, 33);
            this.lblTotalDays.TabIndex = 8;
            this.lblTotalDays.Text = "0";
            // 
            // lblTotalDys
            // 
            this.lblTotalDys.AutoSize = true;
            this.lblTotalDys.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalDys.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDys.ForeColor = System.Drawing.Color.Gray;
            this.lblTotalDys.Location = new System.Drawing.Point(28, 18);
            this.lblTotalDys.Name = "lblTotalDys";
            this.lblTotalDys.Size = new System.Drawing.Size(96, 20);
            this.lblTotalDys.TabIndex = 5;
            this.lblTotalDys.Text = "TOTAL DAYS";
            // 
            // panelNextBirthday
            // 
            this.panelNextBirthday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panelNextBirthday.Controls.Add(this.lblNextBirthdayDays);
            this.panelNextBirthday.Controls.Add(this.lblDaysToGo);
            this.panelNextBirthday.Controls.Add(this.lblNextBirthday);
            this.panelNextBirthday.Location = new System.Drawing.Point(183, 125);
            this.panelNextBirthday.Name = "panelNextBirthday";
            this.panelNextBirthday.Size = new System.Drawing.Size(459, 100);
            this.panelNextBirthday.TabIndex = 1;
            // 
            // lblNextBirthdayDays
            // 
            this.lblNextBirthdayDays.BackColor = System.Drawing.Color.Transparent;
            this.lblNextBirthdayDays.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNextBirthdayDays.ForeColor = System.Drawing.Color.Lime;
            this.lblNextBirthdayDays.Location = new System.Drawing.Point(35, 44);
            this.lblNextBirthdayDays.Name = "lblNextBirthdayDays";
            this.lblNextBirthdayDays.Size = new System.Drawing.Size(19, 39);
            this.lblNextBirthdayDays.TabIndex = 8;
            this.lblNextBirthdayDays.Text = "0";
            // 
            // lblDaysToGo
            // 
            this.lblDaysToGo.AutoSize = true;
            this.lblDaysToGo.BackColor = System.Drawing.Color.Transparent;
            this.lblDaysToGo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDaysToGo.ForeColor = System.Drawing.Color.Gray;
            this.lblDaysToGo.Location = new System.Drawing.Point(88, 57);
            this.lblDaysToGo.Name = "lblDaysToGo";
            this.lblDaysToGo.Size = new System.Drawing.Size(94, 23);
            this.lblDaysToGo.TabIndex = 7;
            this.lblDaysToGo.Text = "days to go";
            // 
            // lblNextBirthday
            // 
            this.lblNextBirthday.AutoSize = true;
            this.lblNextBirthday.BackColor = System.Drawing.Color.Transparent;
            this.lblNextBirthday.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNextBirthday.ForeColor = System.Drawing.Color.Gray;
            this.lblNextBirthday.Location = new System.Drawing.Point(28, 14);
            this.lblNextBirthday.Name = "lblNextBirthday";
            this.lblNextBirthday.Size = new System.Drawing.Size(127, 20);
            this.lblNextBirthday.TabIndex = 4;
            this.lblNextBirthday.Text = "NEXT BIRTHDAY";
            // 
            // panelExactAge
            // 
            this.panelExactAge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panelExactAge.Controls.Add(this.lblDays);
            this.panelExactAge.Controls.Add(this.lblMonths);
            this.panelExactAge.Controls.Add(this.lblYears);
            this.panelExactAge.Controls.Add(this.lbldys);
            this.panelExactAge.Controls.Add(this.lblmons);
            this.panelExactAge.Controls.Add(this.lblyrs);
            this.panelExactAge.Controls.Add(this.lblExactAge);
            this.panelExactAge.Location = new System.Drawing.Point(183, 6);
            this.panelExactAge.Name = "panelExactAge";
            this.panelExactAge.Size = new System.Drawing.Size(459, 100);
            this.panelExactAge.TabIndex = 0;
            // 
            // lblDays
            // 
            this.lblDays.BackColor = System.Drawing.Color.Transparent;
            this.lblDays.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDays.ForeColor = System.Drawing.Color.White;
            this.lblDays.Location = new System.Drawing.Point(329, 45);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(19, 39);
            this.lblDays.TabIndex = 9;
            this.lblDays.Text = "0";
            // 
            // lblMonths
            // 
            this.lblMonths.BackColor = System.Drawing.Color.Transparent;
            this.lblMonths.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonths.ForeColor = System.Drawing.Color.White;
            this.lblMonths.Location = new System.Drawing.Point(187, 45);
            this.lblMonths.Name = "lblMonths";
            this.lblMonths.Size = new System.Drawing.Size(19, 39);
            this.lblMonths.TabIndex = 8;
            this.lblMonths.Text = "0";
            // 
            // lblYears
            // 
            this.lblYears.BackColor = System.Drawing.Color.Transparent;
            this.lblYears.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYears.ForeColor = System.Drawing.Color.White;
            this.lblYears.Location = new System.Drawing.Point(61, 45);
            this.lblYears.Name = "lblYears";
            this.lblYears.Size = new System.Drawing.Size(19, 39);
            this.lblYears.TabIndex = 7;
            this.lblYears.Text = "0";
            // 
            // lbldys
            // 
            this.lbldys.AutoSize = true;
            this.lbldys.BackColor = System.Drawing.Color.Transparent;
            this.lbldys.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldys.ForeColor = System.Drawing.Color.Gray;
            this.lbldys.Location = new System.Drawing.Point(362, 50);
            this.lbldys.Name = "lbldys";
            this.lbldys.Size = new System.Drawing.Size(52, 28);
            this.lbldys.TabIndex = 6;
            this.lbldys.Text = "days";
            // 
            // lblmons
            // 
            this.lblmons.AutoSize = true;
            this.lblmons.BackColor = System.Drawing.Color.Transparent;
            this.lblmons.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmons.ForeColor = System.Drawing.Color.Gray;
            this.lblmons.Location = new System.Drawing.Point(220, 50);
            this.lblmons.Name = "lblmons";
            this.lblmons.Size = new System.Drawing.Size(49, 28);
            this.lblmons.TabIndex = 5;
            this.lblmons.Text = "mos";
            // 
            // lblyrs
            // 
            this.lblyrs.AutoSize = true;
            this.lblyrs.BackColor = System.Drawing.Color.Transparent;
            this.lblyrs.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblyrs.ForeColor = System.Drawing.Color.Gray;
            this.lblyrs.Location = new System.Drawing.Point(107, 50);
            this.lblyrs.Name = "lblyrs";
            this.lblyrs.Size = new System.Drawing.Size(37, 28);
            this.lblyrs.TabIndex = 4;
            this.lblyrs.Text = "yrs";
            // 
            // lblExactAge
            // 
            this.lblExactAge.AutoSize = true;
            this.lblExactAge.BackColor = System.Drawing.Color.Transparent;
            this.lblExactAge.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExactAge.ForeColor = System.Drawing.Color.Gray;
            this.lblExactAge.Location = new System.Drawing.Point(29, 14);
            this.lblExactAge.Name = "lblExactAge";
            this.lblExactAge.Size = new System.Drawing.Size(92, 20);
            this.lblExactAge.TabIndex = 3;
            this.lblExactAge.Text = "EXACT AGR";
            // 
            // panelInput
            // 
            this.panelInput.Controls.Add(this.panelSelectDate);
            this.panelInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInput.Location = new System.Drawing.Point(0, 217);
            this.panelInput.Name = "panelInput";
            this.panelInput.Size = new System.Drawing.Size(800, 259);
            this.panelInput.TabIndex = 2;
            // 
            // panelSelectDate
            // 
            this.panelSelectDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panelSelectDate.Controls.Add(this.guna2DateTimePicker1);
            this.panelSelectDate.Controls.Add(this.btnCalculate);
            this.panelSelectDate.Controls.Add(this.lblSelectYourDate);
            this.panelSelectDate.Location = new System.Drawing.Point(183, 16);
            this.panelSelectDate.Name = "panelSelectDate";
            this.panelSelectDate.Size = new System.Drawing.Size(459, 220);
            this.panelSelectDate.TabIndex = 0;
            // 
            // guna2DateTimePicker1
            // 
            this.guna2DateTimePicker1.BorderRadius = 10;
            this.guna2DateTimePicker1.Checked = true;
            this.guna2DateTimePicker1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2DateTimePicker1.FillColor = System.Drawing.Color.White;
            this.guna2DateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.guna2DateTimePicker1.Location = new System.Drawing.Point(42, 75);
            this.guna2DateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.guna2DateTimePicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.guna2DateTimePicker1.Name = "guna2DateTimePicker1";
            this.guna2DateTimePicker1.Size = new System.Drawing.Size(370, 36);
            this.guna2DateTimePicker1.TabIndex = 6;
            this.guna2DateTimePicker1.Value = new System.DateTime(2026, 7, 31, 21, 8, 32, 879);
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.Transparent;
            this.btnCalculate.BorderRadius = 10;
            this.btnCalculate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalculate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCalculate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCalculate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCalculate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCalculate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnCalculate.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.ForeColor = System.Drawing.Color.White;
            this.btnCalculate.Location = new System.Drawing.Point(42, 128);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(370, 60);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "Calculate Age";
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblSelectYourDate
            // 
            this.lblSelectYourDate.AutoSize = true;
            this.lblSelectYourDate.BackColor = System.Drawing.Color.Transparent;
            this.lblSelectYourDate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectYourDate.ForeColor = System.Drawing.Color.White;
            this.lblSelectYourDate.Location = new System.Drawing.Point(29, 33);
            this.lblSelectYourDate.Name = "lblSelectYourDate";
            this.lblSelectYourDate.Size = new System.Drawing.Size(214, 23);
            this.lblSelectYourDate.TabIndex = 2;
            this.lblSelectYourDate.Text = "Select your Date of Birth:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(800, 900);
            this.Controls.Add(this.panelInput);
            this.Controls.Add(this.panelDetails);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCalendar)).EndInit();
            this.panelDetails.ResumeLayout(false);
            this.panelTotalHours.ResumeLayout(false);
            this.panelTotalHours.PerformLayout();
            this.panelTotalDays.ResumeLayout(false);
            this.panelTotalDays.PerformLayout();
            this.panelNextBirthday.ResumeLayout(false);
            this.panelNextBirthday.PerformLayout();
            this.panelExactAge.ResumeLayout(false);
            this.panelExactAge.PerformLayout();
            this.panelInput.ResumeLayout(false);
            this.panelSelectDate.ResumeLayout(false);
            this.panelSelectDate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label lblAgeDays;
        private System.Windows.Forms.PictureBox pictureCalendar;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Panel panelDetails;
        private System.Windows.Forms.Panel panelInput;
        private System.Windows.Forms.Panel panelSelectDate;
        private System.Windows.Forms.Label lblSelectYourDate;
        private Guna.UI2.WinForms.Guna2Button btnCalculate;
        private Guna.UI2.WinForms.Guna2Panel panelExactAge;
        private Guna.UI2.WinForms.Guna2Panel panelTotalHours;
        private Guna.UI2.WinForms.Guna2Panel panelTotalDays;
        private Guna.UI2.WinForms.Guna2Panel panelNextBirthday;
        private System.Windows.Forms.Label lblExactAge;
        private System.Windows.Forms.Label lbldys;
        private System.Windows.Forms.Label lblmons;
        private System.Windows.Forms.Label lblyrs;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblDays;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblMonths;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblYears;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNextBirthdayDays;
        private System.Windows.Forms.Label lblDaysToGo;
        private System.Windows.Forms.Label lblNextBirthday;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTotalHours;
        private System.Windows.Forms.Label lblTotalHrs;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTotalDays;
        private System.Windows.Forms.Label lblTotalDys;
        private Guna.UI2.WinForms.Guna2Button btnClear;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker1;
        private System.Windows.Forms.PictureBox btnExit;
    }
}

