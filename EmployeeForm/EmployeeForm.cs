using PayrolAPI.Repository;
using SharedModels;
using SharedModels.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll
{
    public partial class EmployeeForm : Form
    {
        private readonly ApiClient _apiClient;
        private readonly CalculosRepository _calculosRepo;
    
        public EmployeeForm(ApiClient apiClient)
        {
            InitializeComponent();
            _apiClient = apiClient;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private async void EmployeeForm_Load(object sender, EventArgs e)
        {
            await LoadEmployeeAsync();
        }

        private async Task LoadEmployeeAsync()
        {
            try
            {
                var employee = await _apiClient.Employees.GetAllAsync();
                dgvEmpleados.DataSource = employee.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los ingresos: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            IncomesForm incomesForm = new IncomesForm(_apiClient);
            incomesForm.ShowDialog();
        }

        private void btnDeducciones_Click(object sender, EventArgs e)
        {
            DeductionForm deductionForm = new DeductionForm();
            deductionForm.ShowDialog();
        }

        private async void btnCrear_Click(object sender, EventArgs e)
        {
            var newEmployee = new EmployeeCreateDto
            {
                Activo = chkActivo.Checked,
                Cedula = txtCedula.Text,
                Celular = int.Parse(mskCelular.Text),
                Contratacion = DateOnly.Parse(dtpContrato.Text),
                Direccion = txtDireccion.Text,
                EstadoCivil = cmbEstado.Text,
                FinContratacion = DateOnly.Parse(dtpFinContrato.Text),
                FirstName = txtPrimerNombre.Text,
                LastName = txtPrimerApellido.Text,
                LastName2 = txtSecondApellido.Text,
                Nacimiento = DateOnly.Parse(dtpNacimiento.Text),
                PayrollId = 2,
                RUC = int.Parse(txtRUC.Text),
                SecondName = txtSecondNombre.Text,
                Sexo = cmbSexo.Text,
                Telefono = int.Parse(mskTelefono.Text),
                INSS = int.Parse(txtINSS.Text)

                
            };
            try
            {


                var sucess = await _apiClient.Employees.CreateAsync(newEmployee);

                MessageBox.Show("¡Empleado agregado exitosamente!",
                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearInputFields();
                await LoadEmployeeAsync();
            
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar Empleado: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearInputFields()
        {
            chkActivo.Checked= false;
            txtCedula.Clear();
            mskCelular.Clear();
            dtpContrato.ResetText();
            txtDireccion.Clear();
            cmbEstado.Items.Clear();
            dtpFinContrato.ResetText();
            txtPrimerNombre.Clear();
            txtPrimerApellido.Clear();
            txtSecondApellido.Clear();
            dtpNacimiento.ResetText();
            txtRUC.Clear();
            txtSecondNombre.Clear();
            cmbSexo.Items.Clear();
            mskTelefono.Clear();
        }
    }
}
