using ReposityWpfApp5.Domain.Abstraction;
using ReposityWpfApp5.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReposityWpfApp5.DataAccess.SqlServer
{
    class SqlUserReposity : IUserReposity
    {
        public void Add(User user)
        {
            throw new NotImplementedException();
        }
        public User GetUser(int id)
        {
            throw new NotImplementedException();
        }
        public List<User> GetUsers()
        {
            throw new NotImplementedException();
        }
    }
}
