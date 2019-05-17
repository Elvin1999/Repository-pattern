using ReposityWpfApp5.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReposityWpfApp5.Domain.Abstraction
{
   public interface IStudentReposity
    {
        void Add(Student student);
        Student GetStudent(int id);
        List<Student> GetStudents();
    }
}
