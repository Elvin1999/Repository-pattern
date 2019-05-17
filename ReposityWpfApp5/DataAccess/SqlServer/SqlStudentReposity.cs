using ReposityWpfApp5.Domain.Abstraction;
using ReposityWpfApp5.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReposityWpfApp5.DataAccess.SqlServer
{
    class SqlStudentReposity : IReposity<Student>

    {
        public void Add(Student obj)
        {
            throw new NotImplementedException();
        }

        public Student Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Student> Get()
        {
            throw new NotImplementedException();
        }
    }
}
