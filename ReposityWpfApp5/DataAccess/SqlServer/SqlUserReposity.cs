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
    class SqlUserRepository : IUserRepository
    {
        SqlContext db;
        public SqlUserRepository(SqlContext db)
        {
            this.db = db;
        }

        public void Add(User obj)
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

        public User Get(string username)
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

