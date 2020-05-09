using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WedAp_Core.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string FirstName { get; set; }
        [MaxLength(20)]
        public string Email { get; set; }
    }
}
