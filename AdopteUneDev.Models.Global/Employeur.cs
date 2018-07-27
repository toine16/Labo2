using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdopteUneDev.Models.Global
{
    public class Employeur
    {
        #region Fields
        private Int32 _idEmployeur;
        private String _nom;
        private String _prenom;
        private String _dateDeNaissance;
        private bool? _sexe;
        private Int32 _idEntreprise;
        #endregion

        #region Properties
        public int IdEmployeur
        {
            get
            {
                return _idEmployeur;
            }

            set
            {
                _idEmployeur = value;
            }
        }

        public string Nom
        {
            get
            {
                return _nom;
            }

            set
            {
                _nom = value;
            }
        }

        public string Prenom
        {
            get
            {
                return _prenom;
            }

            set
            {
                _prenom = value;
            }
        }

        public string DateDeNaissance
        {
            get
            {
                return _dateDeNaissance;
            }

            set
            {
                _dateDeNaissance = value;
            }
        }

        public bool Sexe
        {
            get
            {
                return (bool)_sexe;
            }

            set
            {
                _sexe = value;
            }
        }
        public int IdEntreprise
        {
            get
            {
                return _idEntreprise;
            }

            set
            {
                _idEntreprise = value;
            }
        }


        #endregion
        //Associations
        public Entreprise Entreprise
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }
    }
}
