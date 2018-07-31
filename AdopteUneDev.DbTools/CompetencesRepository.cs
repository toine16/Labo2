using AdopteUneDev.Models.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdopteUneDev.DbTools
{
    class CompetencesRepository : BaseRepository<Competences, int>
    {
        public CompetencesRepository()
        {

        }
        public override int Add(Competences o)
        {
            throw new NotImplementedException();
        }

        public override Competences MapDicoToT(Dictionary<string, object> dico)
        {
            throw new NotImplementedException();
        }

        public override Dictionary<string, object> MapTtoDico(Competences o)
        {
            throw new NotImplementedException();
        }

        public override int Update(Competences o)
        {
            throw new NotImplementedException();
        }
    }
}
