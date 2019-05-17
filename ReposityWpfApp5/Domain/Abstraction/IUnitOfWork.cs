using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReposityWpfApp5.Domain.Abstraction
{
    public interface IUnitOfWork
    {
        void SaveChanges();


        IUserRepository UserRepository { get; }
        IStudentRepository StudentRepository { get; }
    }
}
