using AdopteUneDev.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace AdopteUneDev.DbTools
{
     public abstract class BaseRepository<T,U> : IRepository<T,int> where T : IEntity

    {
        protected string _cnsrt = @"Data Source=FORMA210\TFTIC;Initial Catalog=AdopteBD;Persist Security Info=True;User ID=sa;Password=Test1234=";
        public string OneCommand;
        public string UpdateCommand;
        public string DeleteCommand;
        public string InsertCommand;
        public string AllCommand;

        public abstract int Add(T o);
        public abstract int Update(T o);

        public bool Remove(T o)
        {
            using (DbConnect db = new DbConnect(_cnsrt))
            {
                db.connect();
                Dictionary<string, object> dico = new Dictionary<string, object>();

                foreach (PropertyInfo i in o.GetType().GetProperties())
                {
                    dico.Add(i.Name, i.GetValue(i));
                }

                string query = "Delete " + o.GetType().Name + " where @Id =" + o.id;
                bool ttt = db.Delete(query, dico);
                return ttt;
            } 
        }
        
        public Dictionary<string, object> GetOne(T o)
        {
            Dictionary<string, object> retour = new Dictionary<string, object>();

            using (DbConnect db = new DbConnect(_cnsrt))
            {
                db.connect();
                Dictionary<string, object> dico = new Dictionary<string, object>();

                foreach (PropertyInfo i in o.GetType().GetProperties())
                {
                    dico.Add(i.Name, i.GetValue(i));
                }

                string query = "Select * from "+ o.GetType().Name +" where @Id = " + o.id;
                retour = db.Select(query, dico).FirstOrDefault();

            }

            return retour;
        }

        public IEnumerable<Dictionary<string, object>> GetAll(T o)
        {
            List<Dictionary<string, object>> retour = new List<Dictionary<string, object>>();

            using (DbConnect db = new DbConnect(_cnsrt))
            {
                db.connect();
               /* Dictionary<string, object> dico = new Dictionary<string, object>();

                foreach (PropertyInfo i in o.GetType().GetProperties())
                {
                    dico.Add(i.Name, i.GetValue(i));
                }*/

                string query = "Select * from " + o.GetType().Name;
                retour = db.Select(query, null);

            }

            return retour;
        }

        public abstract Dictionary<string, object> MapTtoDico(T o);
        public abstract T MapDicoToT(Dictionary<string, object> dico);
    }
}


/*Type type = obj.GetType();
 
2 - Pour avoir la liste de ses propriétés :

PropertyInfo []propz = type.GetProperties(...);
- Les options en paramètres dépendent de ce que tu veux :
(public/protégées, Instance/statiques, héritée ou déclarée, ...) Voir
la doc de .Net

- Pour la liste de méthodes, c'est pareil avec MethodInfo . Pour les champs FieldInfo.

 
3 - Pour récupérer une valeur : GetValue(...)
PropertyInfo prop = ...

object value = prop.GetValue(obj, null);
 
4 - Pour modifier une valeur : SetValue(...)
PropertyInfo prop = ...

prop.SetValue(obj, value, null);
*/