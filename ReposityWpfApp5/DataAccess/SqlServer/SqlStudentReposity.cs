using ReposityWpfApp5.Domain.Abstraction;
using ReposityWpfApp5.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReposityWpfApp5.DataAccess.SqlServer
{
    class SqlStudentReposity : IStudentRepository
    {
        SqlContext db;
        public SqlStudentReposity(SqlContext db)
        {
            this.db = db;
        }



        public void Add(Student obj)
        {
            using (SqlConnection conn = new SqlConnection(db.ConnectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {

                    //

                    //


                    db.AddCommandToTransaction(cmd);
                }


            }
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
