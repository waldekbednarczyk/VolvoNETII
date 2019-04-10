using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace VolvoNETII.DataAccess.Models
{
    public class Country
    {
        [Key]
        public int CountryId { get; set; }
        [Required]
        public string CountryName { get; set; }
        public virtual ICollection<Location> Locations { get; set; }
    }
}