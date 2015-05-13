using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryCalculatorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        EmployeeSalary empSalaryObj = new EmployeeSalary();
        private void showSalaryButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "" || basicAmountTextBox.Text == "" || percentageHRentTextBox.Text == "" ||
                percentageMAllowenceTextBox.Text == "")
            {
                
                MessageBox.Show("Enter the value.");
            }
            else
            {
                empSalaryObj.employeeName = nameTextBox.Text;
                empSalaryObj.basicSalary = Convert.ToDouble(basicAmountTextBox.Text);
                empSalaryObj.houseRentPercentage = Convert.ToDouble(percentageHRentTextBox.Text);
                empSalaryObj.medicalAllowancePercentage = Convert.ToDouble(percentageMAllowenceTextBox.Text);


                MessageBox.Show(empSalaryObj.employeeName +", "+"your total salary : " + empSalaryObj.GetSalary());

                ClearAllField();
            }
           
        }

        private void ClearAllField()
        {
            nameTextBox.Text = "";
            basicAmountTextBox.Text = "";
            percentageHRentTextBox.Text = "";
            percentageMAllowenceTextBox.Text = "";

        }
    }
}
