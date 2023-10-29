using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult exit = MessageBox.Show("Do you want to exit the Payroll Calculator?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (exit == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string Name = textBoxname.Text;
            string Ssn = textBoxssn.Text;
            if (!double.TryParse(textBoxhrswrked.Text, out double hourlyRate) || !double.TryParse(textBoxhrswrked.Text, out double hoursWorked))
            {
                MessageBox.Show("Invalid hourly rate or hours worked. Please enter valid numeric values.");
                return;
            }

            double GrossPay = hourlyRate * hoursWorked;
            double FederalWithholding = 0.15 * GrossPay;
            double StateWithholding = 0.05 * GrossPay;
            double netPay = GrossPay - FederalWithholding - StateWithholding;

            MessageBox.Show($"Name: {Name}\nSSN: {Ssn}\nHourly Pay Rate: ${hourlyRate:F2}\nHours Worked: {hoursWorked} hours\n\nGross Pay: ${GrossPay:F2}\nFederal Withholding Tax: ${FederalWithholding:F2}" +
                $"\nState Withholding Tax: ${StateWithholding:F2}\nNet Pay: ${netPay:F2}");
        }
    }
}
