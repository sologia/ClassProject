﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedModels.Dto
{
    public class PayrollCreateDto
    {
        [Required]
        public int EmployeeID { get; set; }
    }
}
