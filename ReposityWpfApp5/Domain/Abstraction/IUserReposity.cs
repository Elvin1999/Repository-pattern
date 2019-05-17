using ReposityWpfApp5.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReposityWpfApp5.Domain.Abstraction
{
    interface IUserReposity
    {
        void Add(User user);
        User GetUser(int id);
        List<User> GetUsers();
    }
}
