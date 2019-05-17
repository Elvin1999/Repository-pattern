using ReposityWpfApp5.Domain.Abstraction;
using ReposityWpfApp5.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ReposityWpfApp5.DataAccess.SqlServer
{
    class SqlUserReposity : IReposity<User>
    {
        public void Add(User obj)
        {
            throw new NotImplementedException();
        }

        public User Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<User> Get()
        {
            throw new NotImplementedException();
        }
    }
}

