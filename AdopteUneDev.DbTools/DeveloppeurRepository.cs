using AdopteUneDev.Models.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdopteUneDev.DbTools
{
    class DeveloppeurRepository : BaseRepository<Developpeur>
    {
        private string _InsertCommand = "Insert into Developpeur(Nom,Prenom,DateDeNaissance,Sexe,photo) output Inserted.IdDeveloppeur Values(@Nom,@Prenom,@DateDeNaissance,@Sexe,@Photo)";
        private string _UpdateCommand = "Update Developpeur set Nom =@Nom,Prenom =@Prenom,DateDeNaissance =@DateDeNaissance,Sexe =@Sexe, Photo =@Photo where IdDeveloppeur=@IdDeveloppeur";

        public override int Add(Developpeur o)
        {
            using (DbConnect db = new DbConnect(_cnsrt))
            {
                db.connect();
                Dictionary<string, object> dico = MapTtoDico(o);

                return db.insert(InsertCommand, dico);
            }
        }

        public override int Update(Developpeur o)
        {
            using (DbConnect db = new DbConnect(_cnsrt))
            {
                db.connect();
                Dictionary<string, object> dico = MapTtoDico(o);

                return db.Update(InsertCommand, dico);
            }
        }
        public Dictionary<string, object> MapTtoDico(Developpeur o)
        {
            Dictionary<string, object> dico = new Dictionary<string, object>();
            dico.Add("IdDeveloppeur", o.IdDeveloppeur);
            dico.Add("Nom", o.Nom);
            dico.Add("Prenom", o.Prenom);
            dico.Add("DateDeNaissance", o.DateDeNaissance);
            dico.Add("Sexe", o.Sexe);
            dico.Add("Photo", o.Photo);

            return dico;
        }

        public Developpeur MapDicoToT(Dictionary<string, object> dico)
        {
            Developpeur o = new Developpeur();
            o.IdDeveloppeur = (int)dico["IdDeveloppeur"];
            o.Nom = dico["Nom"].ToString();
            o.Prenom = dico["Prenom"].ToString();
            o.DateDeNaissance = dico["DateDeNaissance"].ToString();
            o.Sexe = (bool)dico["Sexe"];
            o.Photo = dico["Photo"].ToString();

            return o;
        }
    }
}
