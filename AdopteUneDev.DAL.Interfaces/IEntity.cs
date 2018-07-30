using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdopteUneDev.DAL.Interfaces
{
    /// <summary>
    /// Permet de definir quelle proprieté est la Primary Key dans la DB
    /// </summary>
    /// <typeparam name="TKey">Le type de l'identifiant</typeparam>
    public interface IEntity<TKey>
       
    {
        /// <summary>
        /// Represente la PK dans la DB
        /// </summary>
        TKey ID { get; }
    }
}
