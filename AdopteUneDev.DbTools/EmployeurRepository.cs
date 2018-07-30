using AdopteUneDev.Models.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdopteUneDev.DbTools
{

    class EmployeurRepository : BaseRepository<Employeur,int>
    {
        private string _InsertCommand = "Insert into Employeur(IdEntreprise,Nom,Prenom,DateDeNaissance,Sexe) output Inserted.IdEmployeur Values(@IdEntreprise,@Nom,@Prenom,@DateDeNaissance,@Sexe)";
        private string _UpdateCommand = "Update Employeur set IdEntreprise = @IdEntreprise,Nom =@Nom,Prenom =@Prenom,DateDeNaissance =@DateDeNaissance,Sexe =@Sexe where IdEmployeur=@IdEmployeur";

        public override int Add(Employeur o)
        {
            using (DbConnect db = new DbConnect(_cnsrt))
            {
                db.connect();
                Dictionary<string, object> dico = MapTtoDico(o);

                return db.insert(InsertCommand, dico);
            }
        }

        public override int Update(Employeur o)
        {
            using (DbConnect db = new DbConnect(_cnsrt))
            {
                db.connect();
                Dictionary<string, object> dico = MapTtoDico(o);

                return db.Update(InsertCommand, dico);
            }
        }
        public Dictionary<string, object> MapTtoDico(Employeur o)
        {
            Dictionary<string, object> dico = new Dictionary<string, object>();
            dico.Add("IdEntreprise", o.IdEntreprise);
            dico.Add("IdEmployeur", o.IdEmployeur);
            dico.Add("Nom", o.Nom);
            dico.Add("Prenom", o.Prenom);
            dico.Add("DateDeNaissance", o.DateDeNaissance);
            dico.Add("Sexe", o.Sexe);

            return dico;
        }

        public Employeur MapDicoToT(Dictionary<string, object> dico)
        {
            Employeur o = new Employeur();
            o.IdEntreprise = (int)dico["IdEntreprise"];
            o.IdEmployeur = (int)dico["IdEmployeur"];
            o.Nom = dico["Nom"].ToString();
            o.Prenom = dico["Prenom"].ToString();
            o.DateDeNaissance = dico["DateDeNaissance"].ToString();
            o.Sexe = (bool)dico["Sexe"];

            return o;
        }
    }
}
