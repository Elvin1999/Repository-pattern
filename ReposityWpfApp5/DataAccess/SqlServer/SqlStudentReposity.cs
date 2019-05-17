using ReposityWpfApp5.Domain.Abstraction;
using ReposityWpfApp5.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReposityWpfApp5.DataAccess.SqlServer
{
    class SqlStudentReposity : IStudentReposity
    {
        public void Add(Student student)
        {
            throw new NotImplementedException();
        }

        public Student GetStudent(int id)
        {
            throw new NotImplementedException();
        }

        public List<Student> GetStudents()
        {
            throw new NotImplementedException();
        }
    }
}
