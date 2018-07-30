using AdopteUneDev.Models.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdopteUneDev.DbTools
{
    class EntrepriseRepository : BaseRepository<Entreprise,int>
    {
        private string _InsertCommand = "Insert into Entreprise(Nom,Bio,Rue,Numero,CP,Ville) output Inserted.IdEntreprise Values(@Nom,@Bio,@Rue,@Numero,@CP,@Ville)";
        private string _UpdateCommand = "Update Entreprise set Nom = @Nom,Bio = @Bio,Rue = @Rue,Numero =@Numero,CP =@CP,Ville = @Ville where IdEntreprise = @IdEntreprise";
        public override int Add(Entreprise o)
        {
            using (DbConnect db = new DbConnect(_cnsrt))
            {
                db.connect();
                Dictionary<string, object> dico = MapTtoDico(o);
                
                return db.insert(_InsertCommand, dico);
            }
        }

        public override int Update(Entreprise o)
        {
            using (DbConnect db = new DbConnect(_cnsrt))
            {
                db.connect();
                Dictionary<string, object> dico = MapTtoDico(o);

                return db.Update(_UpdateCommand, dico);
            }
        }

        public Dictionary<string,object> MapTtoDico(Entreprise o)
        {
            Dictionary<string, object> dico = new Dictionary<string, object>();
            dico.Add("IdEntreprise", o.IdEntreprise);
            dico.Add("Nom", o.Nom);
            dico.Add("Bio", o.Bio);
            dico.Add("Rue", o.Rue);
            dico.Add("Numero", o.Numero);
            dico.Add("CP", o.CP);
            dico.Add("Ville", o.Ville);

            return dico;
        }

        public Entreprise MapDicoToT(Dictionary<string, object> dico)
        {
            Entreprise o = new Entreprise();
            o.IdEntreprise = (int) dico["IdEntreprise"];
            o.Nom = dico["Nom"].ToString();
            o.Bio = dico["Bio"].ToString();
            o.Rue = dico["Rue"].ToString();
            o.Numero = dico["Numero"].ToString();
            o.CP = dico["CP"].ToString();
            o.Ville =dico["Ville"].ToString();
            
            return o;
        }
    }
}
