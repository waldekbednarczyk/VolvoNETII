using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace VolvoNETII.DataAccess.Models
{
    public class Location
    {
        [Key]
        public int LocationId { get; set; }
        [Required]
        public string StreetName { get; set; }
        [Required]
        public int StreetNumber { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public int CountryId { get; set; }
        public Country Country { get; set; }
        public virtual ICollection<Department> Departments { get; set; }
    }
}
