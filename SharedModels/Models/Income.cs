using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedModels
{
    public class Income
    {
        public int IncomeId { get; set; }
        public int EmployeeID { get; set; }
        public double SalarioOrdinario { get; set; }
        public double RiesgoLaboral { get; set; }
        public double Antiguedad { get; set; }
        public double Nocturnidad { get; set; }
        public int CntdHorasExtras { get; set; }
        //Salario que incluye horas extras 
        public double SalarioExtraOrdinario { get; set; }

        public Employee? Employees { get; set; }
    }
}
