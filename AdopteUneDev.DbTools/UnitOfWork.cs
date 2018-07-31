using AdopteUneDev.Interface;
using AdopteUneDev.Models.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdopteUneDev.DbTools
{
    public class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork()
        {

        }
        public IRepository<Client, int> ClientRepository
        {
            get
            {
                return new ClientRepository();
            }
        }

        public IRepository<Categorie, int> CategorieRepository
        {
            get
            {
                return new CategorieRepository();
            }
        }

        public IRepository<Competences, int> CompetencesRepository
        {
            get
            {
                return new CompetencesRepository();
            }
        }

        public IRepository<Developpeur, int> DeveloppeurRepository
        {
            get
            {
                return new DeveloppeurRepository();
            }
        }

        public IRepository<Employeur, int> EmployeurRepository
        {
            get
            {
                return new EmployeurRepository();
            }
        }

        public IRepository<Entreprise, int> EntrepriseRepository
        {
            get
            {
                return new EntrepriseRepository();
            }
        }

        public IRepository<Forfait, int> ForfaitRepository
        {
            get
            {
                return new ForfaitRepository(new DbConnect(""));
            }
        }

        public IRepository<Langage, int> LangageRepository
        {
            get
            {
                return new LangageRepository();
            }
        }

        public IRepository<Softskills, int> SoftskillsRepository
        {
            get
            {
                return new SoftskillsRepository();
            }
        }

        public IRepository<Tarif, int> TarifRepository
        {
            get
            {
                return new TarifRepository();
            }
        }
    }
}
