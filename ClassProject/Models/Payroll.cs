using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassProject.Models
{
    public class Payroll
    {
        public int PayrollId {  get; set; }
        public ICollection<Employees> Employees { get; set; }
    }
}
