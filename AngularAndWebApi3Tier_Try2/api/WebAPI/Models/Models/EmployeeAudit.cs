using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Models.Models
{
    [Keyless]
    [Table("Employee Audit")]
    public partial class EmployeeAudit
    {
        public int EmployeeId { get; set; }
        [StringLength(255)]
        public string EmployeeName { get; set; }
        [StringLength(255)]
        public string Department { get; set; }
        [Column(TypeName = "date")]
        public DateTime? DateofJoining { get; set; }
        [Column("photofilename")]
        [StringLength(500)]
        public string Photofilename { get; set; }
        [StringLength(255)]
        public string AuditType { get; set; }
        [Column(TypeName = "date")]
        public DateTime? AuditDate { get; set; }
    }
}
