using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassProject.Models
{
    public class Incomes
    {
        public int IncomeId { get; set; }
        public int EmployeeID { get; set; }
        public double SalarioOrdinario { get; set; }
        public double RiesgoLaboral { get; set; }
        public double Nocturnidad { get; set; }
        public double HorasExtras { get; set; }

        public Employees Employees { get; set; }
    }
}
