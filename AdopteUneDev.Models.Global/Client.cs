using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdopteUneDev.Interface;
using AdopteUneDev.Models.Global;

namespace AdopteUneDev.Models.Global
{
    public class Client : IEntity
    {

        #region Fields
        private Int32 _idClient;
        private String _username;
        private String _password;
        private Int32 _idEmployeur;
        private Int32 _idForfait;
        private Int32 _idEntreprise;
        #endregion

        #region Properties
        public int IdClient
        {
            get
            {
                return _idClient;
            }

            set
            {
                _idClient = value;
            }
        }

        public string Username
        {
            get
            {
                return _username;
            }

            set
            {
                _username = value;
            }
        }

        public string Password
        {
            get
            {
                return _password;
            }

            set
            {
                _password = value;
            }
        }

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

        public int IdForfait
        {
            get
            {
                return _idForfait;
            }

            set
            {
                _idForfait = value;
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
        public Forfait Forfait
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public Employeur Employeur
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

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
    }
}
