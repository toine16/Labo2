using System.Collections.Generic;

namespace AdopteUneDev.Interface
{
    public interface IRepository<T, U> where T : IEntity
    {
        int Add(T o);
        bool Remove(T o);
        int Update(T o);
        Dictionary<string, object> GetOne(T o);
        IEnumerable<Dictionary<string, object>> GetAll(T o);
    }
}