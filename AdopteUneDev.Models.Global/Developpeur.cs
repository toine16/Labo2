using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdopteUneDev.Models.Global
{
    public class Developpeur
    {
        #region Fields
        private Int32 _idDeveloppeur;
        private String _photo;
        private String _nom;
        private String _prenom;
        private String _dateDeNaissance;
        private Boolean _sexe;
        #endregion

        #region Properties
        public int IdDeveloppeur
        {
            get
            {
                return _idDeveloppeur;
            }

            set
            {
                _idDeveloppeur = value;
            }
        }

        public string Photo
        {
            get
            {
                return _photo;
            }

            set
            {
                _photo = value;
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
                return _sexe;
            }

            set
            {
                _sexe = value;
            }
        }


        #endregion

        //Association
        public List<Categorie> Categories
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public List<Langage> Langages
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public List<Competences> Competences
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public List<Softskills> Softskills
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
