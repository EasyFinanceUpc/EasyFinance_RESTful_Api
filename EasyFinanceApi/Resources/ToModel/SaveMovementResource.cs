﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EasyFinanceApi.Resources.ToModel
{
    public class SaveMovementResource
    {
        [Required]
        public decimal Amount { get; set; }
        [MaxLength(100)]
        public string Note { get; set; }
        public int CategoryId { get; set; }
    }
}
