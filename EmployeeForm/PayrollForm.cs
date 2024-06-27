﻿using System;
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
    public partial class PayrollForm : Form
    {
        private readonly ApiClient _apiClient;
        public PayrollForm(ApiClient apiClient)
        {
            InitializeComponent();
            _apiClient = apiClient;
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            EmployeeForm employeeForm = new EmployeeForm(_apiClient);
            employeeForm.ShowDialog();
        }

        private void PayrollForm_Load(object sender, EventArgs e)
        {

        }
    }
}
