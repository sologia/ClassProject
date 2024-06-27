using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll
{
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            IncomesForm incomesForm = new IncomesForm();
            incomesForm.ShowDialog();
        }

        private void btnDeducciones_Click(object sender, EventArgs e)
        {
            DeductionForm deductionForm = new DeductionForm();  
            deductionForm.ShowDialog(); 
        }
    }
}
