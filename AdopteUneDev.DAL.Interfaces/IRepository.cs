using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdopteUneDev.DAL.Interfaces
{
    public interface IRepository<T,TKey>
        where T : IEntity<TKey>, new()

    {
        string OneCommand { get; }
        string AllCommand { get;   }
        string InsertCommand { get;  }
        string UpdateCommand { get;   }
        string DeleteCommand { get;  } 

        TKey add(T Entity);
        bool remove(int Id);
        T update(T Entity);
        T getOne(int Id);
        List<T> getAll();
    }
}
