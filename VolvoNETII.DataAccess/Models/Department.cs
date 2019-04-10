using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace VolvoNETII.DataAccess.Models
{
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }
        [Required]
        public string DepartmentName { get; set; }
        [Required]
        public int LocationId { get; set; }
        public virtual Location Location { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
