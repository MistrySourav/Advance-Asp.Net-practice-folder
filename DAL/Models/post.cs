using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class post
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }

        [ForeignKey("user")]
        public string PostedBy { get; set; }
        public DateTime date { get; set; }
        public virtual user user { get; set; }
    
        public virtual ICollection<comment> posts { get; set; }
        public post()
        {


            posts = new List<comment>();
        }

    }
}
