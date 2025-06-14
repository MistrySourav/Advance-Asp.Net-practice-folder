using DAL.Interface;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    internal class PostRepo : Database_repo, IRepo<post, int, bool>
    {
        public bool Create(post obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<post> Read()
        {
            return db.post.ToList();        }

        public post Read(int id)
        {
            return db.post.Find(id);
        }

        public bool Update(post obj)
        {
            throw new NotImplementedException();
        }
    }
}
