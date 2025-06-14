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
        public int Id { get; set; }
        [Required]
        public string CommentText { get; set; }
        public DateTime Time { get; set; }
        [ForeignKey("user")]
        public string CommentedBy { get; set; }
        [ForeignKey("post")]
        public int? PostId { get; set; }
        public virtual post post { get; set; }
        public virtual user user { get; set; }

    }
}