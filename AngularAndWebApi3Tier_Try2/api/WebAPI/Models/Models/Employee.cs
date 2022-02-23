using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Models.Models
{
    [Table("Employee")]
    public partial class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        [StringLength(500)]
        public string EmployeeName { get; set; }
        [StringLength(500)]
        public string Department { get; set; }
        [Column(TypeName = "date")]
        public DateTime? DateofJoining { get; set; }
        [StringLength(500)]
        public string PhotoFileName { get; set; }
    }
}
