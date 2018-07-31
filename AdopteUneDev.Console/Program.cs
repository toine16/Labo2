using AdopteUneDev.DbTools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdopteUneDev.DbTools;
using AdopteUneDev.Models.Global;

namespace AdopteUneDev.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Developpeur o = new Developpeur();
            UnitOfWork unit = new UnitOfWork();

            o.DateDeNaissance = "1977/10/19";
            o.Nom = "Zlatan";
            o.Prenom = "Poulinitschk";
            o.Sexe = false;
            o.Photo = "~/images/profil2.jpg";


            System.Console.WriteLine(unit.DeveloppeurRepository.Add(o));
            System.Console.ReadLine();


        }
    }
}
