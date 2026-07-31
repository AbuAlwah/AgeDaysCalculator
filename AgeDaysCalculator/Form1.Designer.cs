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
            Guna.UI2.WinForms.Guna2DateTimePicker dtpBirthDate;
            this.panelHeader = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelDetails = new System.Windows.Forms.Panel();
            this.panelTotalHours = new Guna.UI2.WinForms.Guna2Panel();
            this.panelTotalDays = new Guna.UI2.WinForms.Guna2Panel();
            this.panelNextBirthday = new Guna.UI2.WinForms.Guna2Panel();
            this.panelExactAge = new Guna.UI2.WinForms.Guna2Panel();
            this.lblDays = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblMonths = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblYears = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblExactAge = new System.Windows.Forms.Label();
            this.panelInput = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCalculate = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNextBirthday = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblNextBirthdayDays = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblTotalDys = new System.Windows.Forms.Label();
            this.lblTotalDays = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblTotalHrs = new System.Windows.Forms.Label();
            this.lblTotalHours = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnClear = new Guna.UI2.WinForms.Guna2Button();
            dtpBirthDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.panelHeader.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelDetails.SuspendLayout();
            this.panelTotalHours.SuspendLayout();
            this.panelTotalDays.SuspendLayout();
            this.panelNextBirthday.SuspendLayout();
            this.panelExactAge.SuspendLayout();
            this.panelInput.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.panel2);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(800, 217);
            this.panelHeader.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(183, 74);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(459, 104);
            this.panel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(29, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(279, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Discover your exact age and milestone stats";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(85, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Age / Days Calculator";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(32, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 35);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelDetails
            // 
            this.panelDetails.Controls.Add(this.btnClear);
            this.panelDetails.Controls.Add(this.panelTotalHours);
            this.panelDetails.Controls.Add(this.panelTotalDays);
            this.panelDetails.Controls.Add(this.panelNextBirthday);
            this.panelDetails.Controls.Add(this.panelExactAge);
            this.panelDetails.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelDetails.Location = new System.Drawing.Point(0, 459);
            this.panelDetails.Name = "panelDetails";
            this.panelDetails.Size = new System.Drawing.Size(800, 424);
            this.panelDetails.TabIndex = 1;
            // 
            // panelTotalHours
            // 
            this.panelTotalHours.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panelTotalHours.Controls.Add(this.lblTotalHours);
            this.panelTotalHours.Controls.Add(this.lblTotalHrs);
            this.panelTotalHours.Location = new System.Drawing.Point(426, 262);
            this.panelTotalHours.Name = "panelTotalHours";
            this.panelTotalHours.Size = new System.Drawing.Size(216, 100);
            this.panelTotalHours.TabIndex = 3;
            // 
            // panelTotalDays
            // 
            this.panelTotalDays.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panelTotalDays.Controls.Add(this.lblTotalDays);
            this.panelTotalDays.Controls.Add(this.lblTotalDys);
            this.panelTotalDays.Location = new System.Drawing.Point(183, 262);
            this.panelTotalDays.Name = "panelTotalDays";
            this.panelTotalDays.Size = new System.Drawing.Size(214, 100);
            this.panelTotalDays.TabIndex = 2;
            // 
            // panelNextBirthday
            // 
            this.panelNextBirthday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panelNextBirthday.Controls.Add(this.lblNextBirthdayDays);
            this.panelNextBirthday.Controls.Add(this.label9);
            this.panelNextBirthday.Controls.Add(this.lblNextBirthday);
            this.panelNextBirthday.Location = new System.Drawing.Point(183, 141);
            this.panelNextBirthday.Name = "panelNextBirthday";
            this.panelNextBirthday.Size = new System.Drawing.Size(459, 100);
            this.panelNextBirthday.TabIndex = 1;
            // 
            // panelExactAge
            // 
            this.panelExactAge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panelExactAge.Controls.Add(this.lblDays);
            this.panelExactAge.Controls.Add(this.lblMonths);
            this.panelExactAge.Controls.Add(this.lblYears);
            this.panelExactAge.Controls.Add(this.label7);
            this.panelExactAge.Controls.Add(this.label6);
            this.panelExactAge.Controls.Add(this.label5);
            this.panelExactAge.Controls.Add(this.lblExactAge);
            this.panelExactAge.Location = new System.Drawing.Point(183, 22);
            this.panelExactAge.Name = "panelExactAge";
            this.panelExactAge.Size = new System.Drawing.Size(459, 100);
            this.panelExactAge.TabIndex = 0;
            // 
            // lblDays
            // 
            this.lblDays.BackColor = System.Drawing.Color.Transparent;
            this.lblDays.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDays.ForeColor = System.Drawing.Color.White;
            this.lblDays.Location = new System.Drawing.Point(184, 45);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(18, 39);
            this.lblDays.TabIndex = 9;
            this.lblDays.Text = "1";
            // 
            // lblMonths
            // 
            this.lblMonths.BackColor = System.Drawing.Color.Transparent;
            this.lblMonths.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonths.ForeColor = System.Drawing.Color.White;
            this.lblMonths.Location = new System.Drawing.Point(105, 45);
            this.lblMonths.Name = "lblMonths";
            this.lblMonths.Size = new System.Drawing.Size(18, 39);
            this.lblMonths.TabIndex = 8;
            this.lblMonths.Text = "1";
            // 
            // lblYears
            // 
            this.lblYears.BackColor = System.Drawing.Color.Transparent;
            this.lblYears.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYears.ForeColor = System.Drawing.Color.White;
            this.lblYears.Location = new System.Drawing.Point(38, 45);
            this.lblYears.Name = "lblYears";
            this.lblYears.Size = new System.Drawing.Size(18, 39);
            this.lblYears.TabIndex = 7;
            this.lblYears.Text = "1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(205, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 28);
            this.label7.TabIndex = 6;
            this.label7.Text = "days";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(124, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 28);
            this.label6.TabIndex = 5;
            this.label6.Text = "mos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(59, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 28);
            this.label5.TabIndex = 4;
            this.label5.Text = "yrs";
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
            this.panelInput.Controls.Add(this.panel1);
            this.panelInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInput.Location = new System.Drawing.Point(0, 217);
            this.panelInput.Name = "panelInput";
            this.panelInput.Size = new System.Drawing.Size(800, 242);
            this.panelInput.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panel1.Controls.Add(dtpBirthDate);
            this.panel1.Controls.Add(this.btnCalculate);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(183, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(459, 220);
            this.panel1.TabIndex = 0;
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.Transparent;
            this.btnCalculate.BorderRadius = 10;
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
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(29, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Age / Days Calculator";
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
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Gray;
            this.label9.Location = new System.Drawing.Point(88, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 28);
            this.label9.TabIndex = 7;
            this.label9.Text = "days to go";
            // 
            // lblNextBirthdayDays
            // 
            this.lblNextBirthdayDays.BackColor = System.Drawing.Color.Transparent;
            this.lblNextBirthdayDays.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNextBirthdayDays.ForeColor = System.Drawing.Color.Lime;
            this.lblNextBirthdayDays.Location = new System.Drawing.Point(35, 44);
            this.lblNextBirthdayDays.Name = "lblNextBirthdayDays";
            this.lblNextBirthdayDays.Size = new System.Drawing.Size(51, 39);
            this.lblNextBirthdayDays.TabIndex = 8;
            this.lblNextBirthdayDays.Text = "365";
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.BorderRadius = 10;
            dtpBirthDate.Checked = true;
            dtpBirthDate.FillColor = System.Drawing.Color.White;
            dtpBirthDate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dtpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtpBirthDate.Location = new System.Drawing.Point(42, 72);
            dtpBirthDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            dtpBirthDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new System.Drawing.Size(370, 36);
            dtpBirthDate.TabIndex = 0;
            dtpBirthDate.Value = new System.DateTime(2026, 7, 31, 19, 39, 49, 643);
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
            // lblTotalDays
            // 
            this.lblTotalDays.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalDays.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDays.ForeColor = System.Drawing.Color.White;
            this.lblTotalDays.Location = new System.Drawing.Point(33, 45);
            this.lblTotalDays.Name = "lblTotalDays";
            this.lblTotalDays.Size = new System.Drawing.Size(42, 33);
            this.lblTotalDays.TabIndex = 8;
            this.lblTotalDays.Text = "365";
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
            // lblTotalHours
            // 
            this.lblTotalHours.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalHours.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalHours.ForeColor = System.Drawing.Color.White;
            this.lblTotalHours.Location = new System.Drawing.Point(34, 45);
            this.lblTotalHours.Name = "lblTotalHours";
            this.lblTotalHours.Size = new System.Drawing.Size(61, 33);
            this.lblTotalHours.TabIndex = 9;
            this.lblTotalHours.Text = "8,760";
            // 
            // btnClear
            // 
            this.btnClear.BorderColor = System.Drawing.Color.Transparent;
            this.btnClear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClear.FillColor = System.Drawing.Color.Transparent;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Gray;
            this.btnClear.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnClear.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(367, 380);
            this.btnClear.Name = "btnClear";
            this.btnClear.PressedColor = System.Drawing.Color.Transparent;
            this.btnClear.Size = new System.Drawing.Size(86, 32);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(800, 883);
            this.Controls.Add(this.panelInput);
            this.Controls.Add(this.panelDetails);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelHeader.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelDetails;
        private System.Windows.Forms.Panel panelInput;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button btnCalculate;
        private Guna.UI2.WinForms.Guna2Panel panelExactAge;
        private Guna.UI2.WinForms.Guna2Panel panelTotalHours;
        private Guna.UI2.WinForms.Guna2Panel panelTotalDays;
        private Guna.UI2.WinForms.Guna2Panel panelNextBirthday;
        private System.Windows.Forms.Label lblExactAge;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblDays;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblMonths;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblYears;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNextBirthdayDays;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblNextBirthday;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTotalHours;
        private System.Windows.Forms.Label lblTotalHrs;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTotalDays;
        private System.Windows.Forms.Label lblTotalDys;
        private Guna.UI2.WinForms.Guna2Button btnClear;
    }
}

