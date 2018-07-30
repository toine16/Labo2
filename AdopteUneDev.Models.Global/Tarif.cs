using AdopteUneDev.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdopteUneDev.Models.Global
{
    public class Tarif : IEntity
    {
        #region Fields
        private Int32 idTarif;
        private String type;
        #endregion

        #region Properties
        public int IdTarif
        {
            get
            {
                return idTarif;
            }

            set
            {
                idTarif = value;
            }
        }

        public string Type
        {
            get
            {
                return type;
            }

            set
            {
                type = value;
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
