using DAL.Interface;
using DAL.Models;
using DAL.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        public static IRepo<post, int, bool> PostData()
        {
            return new PostRepo();
        }

        public static IRepo<user, string, user> UserData()
        {
            return new UserRepo();
        }

        public static IRepo<comment, int, bool> CommentData()
        {
            return new CommentRepo();
        }

    }
}
    
