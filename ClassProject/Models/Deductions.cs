using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassProject.Models
{
    public class Deductions
    {
        public int DeductionID { get; set; }
        public int EmployeeID { get; set; }
        public double INSS {  get; set; }
        public double IR {  get; set; }
        
        public Employees Employees { get; set; }
    }
}
