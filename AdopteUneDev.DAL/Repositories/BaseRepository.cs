using AdopteUneDev.DAL.Interfaces;
using AdopteUneDev.DbTools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdopteUneDev.DAL.Repositories
{
    public abstract class  BaseRepository<T, TKey> : IRepository<T, TKey>
        where T : IEntity<TKey>, new()

    {
        protected string _connectionString;

       
        /// <summary>
        /// string qui represente la selectCommand
        /// </summary>
        public abstract string AllCommand { get; }
        /// <summary>
        /// string qui represente la insertCommand
        /// </summary>
        public abstract string InsertCommand { get; }
        /// <summary>
        /// string qui represente la updateCommand
        /// </summary>
        public abstract string UpdateCommand { get; }
        /// <summary>
        /// string qui represente la deleteCommand
        /// </summary>
        public abstract string DeleteCommand { get; }
        /// <summary>
        /// string qui represente la get One command
        /// </summary>
        public virtual string OneCommand
        {
            get
            {
                
                return string.Format("{0} where {1} = @id", AllCommand, IEntityExtension.GetPKey<T>());

            }
        }


        public BaseRepository(string connectionString)
        {
            this._connectionString = connectionString;
        }

        public List<T> getAll()
        {
            List<T> ret = new List<T>();
            using (DbConnect db = new DbConnect(_connectionString))
            {            
                List<Dictionary<string, object>> rep = db.Select(AllCommand);
                foreach (Dictionary<string, object> item in rep)
                {
                    ret.Add(MapToT(item));
                } 
            }
            return ret;
        }

        public T getOne(int Id)
        {
            T ret = default(T);
            using (DbConnect db = new DbConnect(_connectionString))
            {
                Dictionary<string, object> dico = new Dictionary<string, object>();
                dico.Add("id", Id);
                List<Dictionary<string, object>> rep= db.Select(OneCommand, dico);
                if(rep.Count>0)
                {
                    ret = MapToT(rep.First());
                }
            }
            return ret;    
        }
       

        public bool remove(int Id)
        {
            bool ret = false;
            using(DbConnect db = new DbConnect(_connectionString))
            {
                Dictionary<string, object> dico = new Dictionary<string, object>();
                dico.Add("id", Id);
                ret = db.Delete(DeleteCommand, dico);
                
            }
            return ret;
        }

        public abstract T update(T Entity);
        public abstract TKey add(T Entity);

        protected abstract T MapToT(Dictionary<string, object> Dico);
        protected abstract Dictionary<string, object> MapFromT(T Entity);
    }
}
