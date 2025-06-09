using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class PostContext :DbContext
    {
         public DbSet<user> user { get; set; }
         public DbSet<post> post { get; set; }

         public DbSet<comment> comment { get; set; }

    }
}
