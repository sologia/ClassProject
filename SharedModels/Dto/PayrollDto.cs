﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedModels.Dto
{
    public class PayrollDto
    {
        [Required]
        public int PayrollId { get; set; }
        [Required]
        public int EmployeeID { get; set; }
    }
}