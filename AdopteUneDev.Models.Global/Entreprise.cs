using AdopteUneDev.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdopteUneDev.Models.Global
{
    public class Entreprise : IEntity
    {

        #region Fields
        private Int32 _idEntreprise;
        private String _nom;
        private String _bio;
        private String _rue;
        private String _numero;
        private String _cP;
        private String _ville;
        #endregion

        #region Properties
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

        public string Bio
        {
            get
            {
                return _bio;
            }

            set
            {
                _bio = value;
            }
        }

        public string Rue
        {
            get
            {
                return _rue;
            }

            set
            {
                _rue = value;
            }
        }

        public string Numero
        {
            get
            {
                return _numero;
            }

            set
            {
                _numero = value;
            }
        }

        public string CP
        {
            get
            {
                return _cP;
            }

            set
            {
                _cP = value;
            }
        }

        public string Ville
        {
            get
            {
                return _ville;
            }

            set
            {
                _ville = value;
            }
        }

        public int id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }
        #endregion
    }
}
