using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdopteUneDev.Models.Global
{
    public class Tarif_Developpeur
    {

        #region Fields
        private Int32 _idTarif;


        private Int32 _idDeveloppeur;


        private double _prix;
        #endregion

        #region Properties
        public int IdTarif
        {
            get
            {
                return _idTarif;
            }

            set
            {
                _idTarif = value;
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
        #endregion

        //Associations
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

        public Tarif Tarif
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
