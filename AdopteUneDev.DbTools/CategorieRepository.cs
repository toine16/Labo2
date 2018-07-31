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

        public override Categorie MapDicoToT(Dictionary<string, object> dico)
        {
            throw new NotImplementedException();
        }

        public override Dictionary<string, object> MapTtoDico(Categorie o)
        {
            throw new NotImplementedException();
        }

        public override int Update(Categorie o)
        {
            throw new NotImplementedException();
        }
    }
}
