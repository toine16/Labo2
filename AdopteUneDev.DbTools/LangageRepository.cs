using AdopteUneDev.Models.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdopteUneDev.DbTools
{
    class LangageRepository : BaseRepository<Langage, int>
    {
        public LangageRepository()
        {

        }
        public override int Add(Langage o)
        {
            throw new NotImplementedException();
        }

        public override Langage MapDicoToT(Dictionary<string, object> dico)
        {
            throw new NotImplementedException();
        }

        public override Dictionary<string, object> MapTtoDico(Langage o)
        {
            throw new NotImplementedException();
        }

        public override int Update(Langage o)
        {
            throw new NotImplementedException();
        }
    }
}
