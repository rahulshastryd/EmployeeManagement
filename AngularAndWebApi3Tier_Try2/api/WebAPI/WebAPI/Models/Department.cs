using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebAPI.Models
{
    [Table("Department")]
    public partial class Department
    {
        [Key]
        public int DepartmentId { get; set; }
        [StringLength(500)]
        public string DepartmentName { get; set; }
    }
}
