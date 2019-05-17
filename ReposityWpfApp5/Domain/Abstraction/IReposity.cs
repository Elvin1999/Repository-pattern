using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReposityWpfApp5.Domain.Abstraction
{
    interface IReposity<T>
    {
        void Add(T obj);
        T Get(int id);
        List<T> Get();
    }
}
