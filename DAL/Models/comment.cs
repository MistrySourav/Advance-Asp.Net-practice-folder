using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class comment
    {
        public int id {  get; set; }

        [Required]
        public string commentText { get; set; }

        public DateTime time { get; set; }

        [ForeignKey("user")]

        public string commentedBy { get; set; }


        [ForeignKey("post")]
        public int PostId { get; set; }

        public virtual post post { get; set; }

        public virtual user user { get; set; }
    }
}
