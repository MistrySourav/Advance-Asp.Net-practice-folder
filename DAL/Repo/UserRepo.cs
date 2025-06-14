using DAL.Interface;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    internal class UserRepo : Database_repo, IRepo<user, string, user>
    {
        // Implementation for User Repository
        public user Create(user obj)
        {
           db.user.Add(obj);
            if(db.SaveChanges() > 0) return obj;
            {
                return null;
            }
        }

        public bool Delete(string id)
        {
            throw new NotImplementedException();
        }

        public List<user> Read()
        {
           return db.user.ToList();
        }

        public user Read(string id)
        {
           return db.user.Find(id);
        }

        public user Update(user obj)
        {
            var ex = Read(obj.Uname);
            db.Entry(ex).CurrentValues.SetValues(obj);
            if (db.SaveChanges()>0)return obj;
            {
                return null;
            }
        }
    }
}
