using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassProject.Models
{
    public class Employees
    {
        public int EmployeeId { get; set; }
        public string? Cedula { get; set; }

        public int INSS { get; set; }
        public int RUC { get; set; }


        public string? FirstName { get; set; }
        public string? SecondName { get; set; }
        public string? LastName { get; set; }
        public string? LastName2 { get; set; }

        public DateOnly Nacimiento { get; set; }
        public string? Sexo { get; set; }
        public string? EstadoCivil { get; set; }

        public string? Direccion { get; set; }
        public int Telefono { get; set; }
        public int Celular { get; set; }

        public DateOnly Contratacion { get; set; }
        public DateOnly FinContratacion { get; set; }
        public int Salario { get; set; }
        public bool Activo { get; set; }
        public double SalarioNeto {  get; set; }
        public int PayrollId { get; set; }
        public Payroll Payroll { get; set; }
        public ICollection<Incomes> Incomes { get; set; }
        public ICollection<Deductions> Deductions { get; set;}





    }
}
