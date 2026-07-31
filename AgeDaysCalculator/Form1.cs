using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            DateTime birthDate = dtpBirthDate.Value.Date;
            DateTime today = DateTime.Today;

            // Validate that the birth date is not set in the future
            if (birthDate > today)
            {
                MessageBox.Show("Birth date cannot be in the future!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

        }

    }
}
