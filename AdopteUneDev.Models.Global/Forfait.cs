using AdopteUneDev.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdopteUneDev.Models.Global
{
    public class Forfait : IEntity
    {
        #region Fields
        private Int32 _idForfait;
        private String _libelle;
        private String _prix;
        #endregion
        #region Properties
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

        public string Libelle
        {
            get
            {
                return _libelle;
            }

            set
            {
                _libelle = value;
            }
        }

        public string Prix
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
