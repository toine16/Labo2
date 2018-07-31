using AdopteUneDev.Models.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdopteUneDev.DbTools
{
    class ClientRepository : BaseRepository<Client,int>
    {
        public ClientRepository()
        {

        }
        
        public override int Add(Client o)
        {
            using (DbConnect db = new DbConnect(_cnsrt))
            {
                db.connect();
                Dictionary<string, object> dico = new Dictionary<string, object>();
                dico.Add("IdClient",o.IdClient);
                dico.Add("Username", o.Username);
                dico.Add("Password", o.Password);
                dico.Add("IdEmployeur", o.IdEmployeur);
                dico.Add("IdForfait", o.IdForfait);
                
               // Récupéré un forfait déjà cléer en Db 
                string query = "Insert into Client(Username,Password,IdEmployeur,IdForfait) output Inserted.IdClient Values(@Username,@Password,@IdEmployeur,@IdForfait)";

                return db.insert(query,dico);

            }
        }

        public override int Update(Client o)
        {
            using (DbConnect db = new DbConnect(_cnsrt))
            {
                db.connect();
                Dictionary<string, object> dico = new Dictionary<string, object>();
                dico.Add("IdClient", o.IdClient);
                dico.Add("Username", o.Username);
                dico.Add("Password", o.Password);
                dico.Add("IdEmployeur", o.IdEmployeur);
                dico.Add("IdForfait", o.IdForfait);


                string query = "Update Client set Username=Username@,Password=@Password,IdEmployeur=@IdEmployeur,IdForfait=@IdForfait Where IdClient = @IdClient";

                return db.insert(query, dico);

            }
        }

        public override Client MapDicoToT(Dictionary<string, object> Dico)
        {
            Client c = new Client();
            c.Username = Dico["UserName"].ToString();
            c.Password = Dico["Password"].ToString();
            c.IdEmployeur = (int)Dico["IdEmployeur"];
            c.IdEntreprise = (int)Dico["IdEntreprise"];
            c.IdForfait = (int)Dico[";IdForfait"];

            return c;
        }

        public override Dictionary<string, object> MapTtoDico(Client o)
        {
            throw new NotImplementedException();
        }
    }
}
