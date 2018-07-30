using AdopteUneDev.Models.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace AdopteUneDev.DbTools
{
    class ForfaitRepository : BaseRepository<Forfait>
    {
        private DbConnect db;
        public ForfaitRepository(DbConnect db)
        {
            this.db = db;
        }
        public override int Add(Forfait o)
        {
            using (DbConnect db = new DbConnect(_cnsrt))
            {
                db.connect();
                Dictionary<string, object> dico = new Dictionary<string, object>();
                dico.Add("IdForfait", o.IdForfait);
                dico.Add("Libelle", o.Libelle);
                dico.Add("Prix", o.Prix);

                string query = "Insert into Forfait(Libelle,Prix) output Inserted.IdForfait Values(@Libelle,@Prix)";

                return db.insert(query, dico);

            }
        }

        public override int Update(Forfait o)
        {
            using (DbConnect db = new DbConnect(_cnsrt))
            {
                db.connect();
                Dictionary<string, object> dico = new Dictionary<string, object>();
                dico.Add("IdForfait", o.IdForfait);
                dico.Add("Libelle", o.Libelle);
                dico.Add("Prix", o.Prix);

                string query = "Upda into Forfait set Libelle =@Libelle,Prix=@Prix where @IdForfait = IdForfait";

                return db.Update(query, dico);
            }
        }

        public Forfait MapDicoToForfait(Dictionary<string, object> Dico)
        {
            Forfait retour = new Forfait();

            retour.IdForfait = (int)Dico["IdForfait"];
            retour.Libelle = Dico["Libelle"].ToString();
            retour.Prix = Dico["Prix"].ToString();

            return retour;
        }
    }
}
