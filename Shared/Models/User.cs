using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorEFCoreApp.Shared.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int userId { get; set; }
        [Required]
        public string username { get; set; }
        [Required]
        public string lastname { get; set; }
        [Required]
        [MinLength(5)]
        public string login { get; set; }
        [Required]
        [MinLength(5)]
        [DataType(DataType.Password)]
        public string password { get; set; }
        [Required]
        public int age { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime birthdate { get; set; }

    }
}
