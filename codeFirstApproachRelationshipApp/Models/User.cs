using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace codeFirstApproachRelationshipApp.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        [Required]
        [StringLength(10)]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string City{ get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
        [Required]
        [Range(18,50)]
        public int Age { get; set; }

    }
}
