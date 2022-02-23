using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Models.Models
{
    [Table("Employeemaster")]
    public partial class Employeemaster
    {
        [Key]
        public int UserId { get; set; }
        [Required]
        [StringLength(50)]
        public string UserName { get; set; }
        [StringLength(50)]
        public string LoginName { get; set; }
        [Required]
        [StringLength(50)]
        public string Password { get; set; }
        [StringLength(50)]
        public string Email { get; set; }
        [StringLength(15)]
        public string ContactNo { get; set; }
        [StringLength(50)]
        public string Address { get; set; }
        public int? IsApporved { get; set; }
        public int? Status { get; set; }
        public int? TotalCnt { get; set; }
    }
}
