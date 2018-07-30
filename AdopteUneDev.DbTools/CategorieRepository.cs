using AdopteUneDev.Models.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdopteUneDev.DbTools
{
    class CategorieRepository : BaseRepository<Categorie, int>
    {
        public CategorieRepository()
        {

        }
        public override int Add(Categorie o)
        {
            throw new NotImplementedException();
        }

        public override int Update(Categorie o)
        {
            throw new NotImplementedException();
        }
    }
}
