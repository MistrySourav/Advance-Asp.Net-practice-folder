using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class user
    {
        [Key]
        public string uname { get; set; }

        [Required]
        [StringLength(50)]
        public string password { get; set; }
        [EmailAddress]
        public string email { get; set; }

        [Required,StringLength(50)]
        public string name { get; set; }
        public string type { get; set; }

    }
}
