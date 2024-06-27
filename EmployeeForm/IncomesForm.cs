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
    public partial class IncomesForm : Form
    {
        private readonly ApiClient _apiClient;
        public IncomesForm(ApiClient apiClient)
        {
            InitializeComponent();
            _apiClient = apiClient;
        }

        private async void IncomesForm_Load(object sender, EventArgs e)
        {
            await LoadIncomesAsync();
        }

        private async Task LoadIncomesAsync()
        {
            try
            {
                var incomes = await _apiClient.Incomes.GetAllAsync();
                dgvIncomes.DataSource = incomes.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los ingresos: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
