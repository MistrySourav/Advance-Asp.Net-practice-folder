using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    internal class Database_repo
    {
        internal PostContext db;

        internal Database_repo()
        {
            db = new PostContext();
        }
       
    }
}
