using AdopteUneDev.Models.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdopteUneDev.DbTools
{
    class Requete
    {
        private string _cnstr = @"Data Source=FORMA210\TFTIC;Initial Catalog=AdopteBD;Persist Security Info=True;User ID=sa;Password=Test1234=";
        private DbConnect _db;

        public DbConnect Db
        {
            get
            {
                return _db;
            }

            set
            {
                _db = value;
            }
        }

        public int AddClient(Client c)
        {

            _db = new DbConnect(_cnstr);
            _db.connect();

            Dictionary<string, object> dico = new Dictionary<string, object>();
            dico.Add("@" + c.Employeur, c.Employeur);
            dico.Add("@" + c.Entreprise, c.Entreprise);
            dico.Add("@" + c.Forfait, c.Forfait);
            dico.Add("@" + c.Password, c.Password);
            dico.Add("@" + c.Username, c.Username);

            string query = "Insert into Client(Employeur,Entreprise,Forfait,Password,Username) output INSERTED.Employeur values(@Employeur,@Entreprise,@Forfait,@Password,@Username)";
            int ttt = _db.insert(query, dico);
            _db.disconnect();

            return ttt;
        }

        public bool RemoveClient(Client c)
        {
            _db = new DbConnect(_cnstr);
            _db.connect();

            Dictionary<string, object> dico = new Dictionary<string, object>();
            dico.Add("@" + c.Employeur, c.Employeur);
            dico.Add("@" + c.Entreprise, c.Entreprise);
            dico.Add("@" + c.Forfait, c.Forfait);
            dico.Add("@" + c.Password, c.Password);
            dico.Add("@" + c.Username, c.Username);

            string query = "Delete Client where @Username = Username";
            bool ttt = _db.Delete(query, dico);
            _db.disconnect();

            return ttt;
        }

        public int UpdateClient(Client c)
        {
            _db = new DbConnect(_cnstr);
            _db.connect();

            Dictionary<string, object> dico = new Dictionary<string, object>();
            dico.Add("@" + c.Employeur, c.Employeur);
            dico.Add("@" + c.Entreprise, c.Entreprise);
            dico.Add("@" + c.Forfait, c.Forfait);
            dico.Add("@" + c.Password, c.Password);
            dico.Add("@" + c.Username, c.Username);

            string query = "Update into Client set Employeur = @Employeur, Entreprise = @Entreprise where Username = @Username";
            int ttt = _db.Update(query, dico);
            _db.disconnect();

            return ttt;
        }

        public List<Dictionary<string, object>> GetOneClient(int id)
        {
            _db = new DbConnect(_cnstr);
            _db.connect();

            Dictionary<string, object> dico = new Dictionary<string, object>();
            dico.Add("@" + id, id);

            
            string query = "Select * from Client where id = @id";
            List<Dictionary<string, object>> ttt = _db.Select(query, dico);
            _db.disconnect();

            return ttt;
        }

        public List<Dictionary<string, object>> GetAllClient()
        {
            _db = new DbConnect(_cnstr);
            _db.connect();
            string query = "Select * from Client";
            List<Dictionary<string, object>> ttt = _db.Select(query, null);
            _db.disconnect();

            return ttt;
        }
    }
}
