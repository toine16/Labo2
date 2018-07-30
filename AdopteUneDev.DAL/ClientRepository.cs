using AdopteUneDev.DAL.Repositories;
using AdopteUneDev.DbTools;
using AdopteUneDev.Models.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdopteUneDev.DAL
{
    public class ClientRepository :BaseRepository<Client, int>
    {
        

        public override string AllCommand
        {
            get
            {
                return "Select * from Client ";
            }
        }

        public override string InsertCommand
        {
            get
            {
                return "INSERT INTO Client (UserName,Password,IdForfait) VALUES (@UserName, @Password,@IdForfait)";
            }
        }

        public override string UpdateCommand
        {
            get
            {
                return "Update Client set UserName=@UserName ,Password=@Password, IdForfait=@IdForfait ) where IdClient=@id";
            }
        }

        public override string DeleteCommand
        {
            get
            {
                return "Delete From Client where IdClient = @id";
            }
        }


        public ClientRepository(string connectionString) : base(connectionString)
        {
        }


        public override int add(Client c)
        {
            int resultat = -1;
            using (DbConnect db = new DbConnect(_connectionString))
            { 

                Dictionary<string, object> parametres = MapFromT(c);
                resultat = db.insert(InsertCommand, parametres);
                 
            }
            return resultat;
        }

        public override Client update(Client c)
        {
            
            using (DbConnect db = new DbConnect(_connectionString))
            {

                Dictionary<string, object> parametres = MapFromT(c);
                int resultat = db.Update(UpdateCommand, parametres);
                if(resultat>0)
                {
                    c = getOne(c.ID);
                }

            }
            return c;
        }

        protected override Client MapToT(Dictionary<string, object> Dico)
        {
            Client c = new Client();
            c.Username = Dico["UserName"].ToString();
            c.Password = Dico["Password"].ToString();
            c.IdEmployeur =(int) Dico["IdEmployeur"];
            c.IdEntreprise = (int)Dico["IdEntreprise"];
            c.IdForfait = (int)Dico[";IdForfait"];
            return c;
        }
       

        protected override Dictionary<string, object> MapFromT(Client c)
        {
            Dictionary<string, object> parametres = new Dictionary<string, object>();
            parametres.Add("UserName", c.Username);
            parametres.Add("Password", c.Password);
            parametres.Add("IdEmployeur", c.IdEmployeur);
            parametres.Add("IdEntreprise", c.IdEntreprise);
            parametres.Add("IdForfait", c.IdForfait);
            return parametres;
        }
    }
    }
}
