using Payroll;

namespace EmployeeForm
{
    public partial class LoginForm : Form
    {
        private readonly ApiClient _client;
        public LoginForm()
        {
            InitializeComponent();
            _client = new ApiClient();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PayrollForm payrollForm = new PayrollForm(_client);
            payrollForm.ShowDialog();

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
