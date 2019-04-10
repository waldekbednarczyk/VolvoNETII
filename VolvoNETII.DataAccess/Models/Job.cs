using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace VolvoNETII.DataAccess.Models
{
    public class Job
    {
        [Key]
        public int JobId { get; set; }
        [Required]
        public string JobTitle { get; set; }
        [Required]
        public int MinSalary { get; set; }
        [Required]
        public int MaxSalary { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
