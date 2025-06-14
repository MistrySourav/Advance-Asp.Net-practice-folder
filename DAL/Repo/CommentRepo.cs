using DAL.Interface;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    internal class CommentRepo : Database_repo, IRepo<comment, int, bool>
    {
        public bool Create(comment obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<comment> Read()
        {
            throw new NotImplementedException();
        }

        public comment Read(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(comment obj)
        {
            throw new NotImplementedException();
        }
    }
}
