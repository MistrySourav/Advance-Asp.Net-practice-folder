using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DAL.Models
{
    public class post
    {

        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [ForeignKey("user")]
        public string PostedBy { get; set; }
        public DateTime Date { get; set; }
        public virtual user user { get; set; }
        public virtual ICollection<comment> comments { get; set; }
        public post()
        {
            comments = new List<comment>();
        }
    }
}