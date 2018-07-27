using AdopteUneDev.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdopteUneDev.DbTools
{
    public interface IRepository<T> where T:IEntity
    {
        int Add(T o);
        bool Remove(T o);
        int Update(T o);
        Dictionary<string,object> GetOne(T o);
        IEnumerable<Dictionary<string,object>> GetAll(T o);
    }


}
