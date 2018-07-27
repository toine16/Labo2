using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdopteUneDev.Models.Global
{
    public class Employeur_Developpeur
    {

        #region Fields
        private int _idEmployeur;
        private int _idDeveloppeur;
        private double _prix;
        private DateTime _dateDeb;
        private DateTime _dateFin;
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

        public double Prix
        {
            get
            {
                return _prix;
            }

            set
            {
                _prix = value;
            }
        }

        public DateTime DateDeb
        {
            get
            {
                return _dateDeb;
            }

            set
            {
                _dateDeb = value;
            }
        }

        public DateTime DateFin
        {
            get
            {
                return _dateFin;
            }

            set
            {
                _dateFin = value;
            }
        }
        #endregion

        //Associations
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

        public Developpeur Developpeur
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
