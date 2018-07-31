using AdopteUneDev.Models.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdopteUneDev.DbTools
{
    class SoftskillsRepository : BaseRepository<Softskills, int>
    {
        public SoftskillsRepository()
        {

        }
        public override int Add(Softskills o)
        {
            throw new NotImplementedException();
        }

        public override Softskills MapDicoToT(Dictionary<string, object> dico)
        {
            throw new NotImplementedException();
        }

        public override Dictionary<string, object> MapTtoDico(Softskills o)
        {
            throw new NotImplementedException();
        }

        public override int Update(Softskills o)
        {
            throw new NotImplementedException();
        }
    }
}
