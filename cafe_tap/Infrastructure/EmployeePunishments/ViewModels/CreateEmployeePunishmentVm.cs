﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.EmployeePunishments.ViewModels
{
    public class CreateEmployeePunishmentVm
    {
        [Required, Column(TypeName = "decimal(18,2)")]
        public decimal Amount { get; set; }
        [MaxLength(2080)]
        public string Note { get; set; }
        [DataType(DataType.Date)]
        public DateTime At { get; set; } = DateTime.Now;
        public int EmployeeId { get; set; }
    }
}
