using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace VolvoNETII.DataAccess.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public DateTime HireDate { get; set; }
        [Required]
        public float Salary { get; set; }
        [Required]
        public int JobId { get; set; }
        [Required]
        public int DepartmentId { get; set; }
        public virtual Job Job { get; set; }
        public virtual Department Department { get; set; }

    }
}
