using AdopteUneDev.Models.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdopteUneDev.Interface
{
    public interface IUnitOfWork
    {
        IRepository<Client, int> ClientRepository
        {
            get;
        }
        IRepository<Categorie, int> CategorieRepository
        {
            get;
        }
        IRepository<Competences, int> CompetencesRepository
        {
            get;
        }
        IRepository<Developpeur, int> DeveloppeurRepository
        {
            get;
        }
        IRepository<Employeur, int> EmployeurRepository
        {
            get;
        }
        IRepository<Entreprise, int> EntrepriseRepository
        {
            get;
        }
        IRepository<Forfait, int> ForfaitRepository
        {
            get;
        }
        IRepository<Langage, int> LangageRepository
        {
            get;
        }
        IRepository<Softskills, int> SoftskillsRepository
        {
            get;
        }
        IRepository<Tarif, int> TarifRepository
        {
            get;
        }
    }
}
