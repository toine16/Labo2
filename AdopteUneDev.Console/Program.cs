using AdopteUneDev.DbTools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdopteUneDev.DbTools;

namespace AdopteUneDev.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            DbConnect db = new DbConnect(@"Data Source=FORMA200\TFTIC;Initial Catalog=AdopteUneDev;Integrated Security=False;User ID=sa;Password=tftic@2012;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            if(db.connect())
            {
                string maquery = "Select * from Client";
                List<Dictionary<string, object>> lesClients =
                    db.Select(maquery).ToList();

                string Query = "Select * from client where idClient=@id";
                Dictionary<string, object> parametres = new Dictionary<string, object>();
                parametres.Add("id", 5);
                List<Dictionary<string, object>> client =
                    db.Select(Query, parametres).ToList();

            }
        }
    }
}
