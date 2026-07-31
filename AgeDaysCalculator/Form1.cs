using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace AgeDaysCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Get the selected birth date and current system date
            DateTime birthDate = guna2DateTimePicker1.Value.Date;
            DateTime today = DateTime.Today;

            // Validate that the birth date is not set in the future
            if (birthDate > today)
            {
                MessageBox.Show("Birth date cannot be in the future!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 1. Calculate exact age (Years, Months, Days)
            int years = today.Year - birthDate.Year;
            int months = today.Month - birthDate.Month;
            int days = today.Day - birthDate.Day;

            // Adjust days if the current day of the month is less than the birth day
            if (days < 0)
            {
                months--;
                DateTime previousMonth = today.AddMonths(-1);
                days += DateTime.DaysInMonth(previousMonth.Year, previousMonth.Month);
            }

            // Adjust months if the current month is less than the birth month
            if (months < 0)
            {
                years--;
                months += 12;
            }

            // Display exact age values in labels
            lblYears.Text = years.ToString();
            lblMonths.Text = months.ToString();
            lblDays.Text = days.ToString();

            // 2. Calculate remaining days to the next birthday
            DateTime nextBirthday = new DateTime(today.Year, birthDate.Month, birthDate.Day);

            // If the birthday has already passed this year, set it to next year
            if (nextBirthday < today)
            {
                nextBirthday = nextBirthday.AddYears(1);
            }

            int daysToNextBirthday = (nextBirthday - today).Days;

            // Display remaining days to next birthday
            lblNextBirthdayDays.Text = daysToNextBirthday.ToString();

            // 3. Calculate total days and total hours lived
            TimeSpan totalDifference = today - birthDate;
            double totalDays = totalDifference.TotalDays;
            double totalHours = totalDifference.TotalHours;

            // Display total values with number formatting (e.g., 8,760)
            lblTotalDays.Text = string.Format("{0:N0}", totalDays);
            lblTotalHours.Text = string.Format("{0:N0}", totalHours);

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Reset date picker to today
            guna2DateTimePicker1.Value = DateTime.Today;

            // Reset all labels to initial values
            lblYears.Text = "0";
            lblMonths.Text = "0";
            lblDays.Text = "0";
            lblNextBirthdayDays.Text = "0";
            lblTotalDays.Text = "0";
            lblTotalHours.Text = "0";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
