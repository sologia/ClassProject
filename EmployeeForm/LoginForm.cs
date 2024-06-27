using Payroll;

namespace EmployeeForm
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PayrollForm payrollForm = new PayrollForm();
            payrollForm.ShowDialog();   
            
        }
    }
}
