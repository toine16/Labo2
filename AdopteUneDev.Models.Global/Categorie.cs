using AdopteUneDev.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdopteUneDev.Models.Global
{
    public class Categorie : IEntity
    {
        #region Fields
        private Int32 _idCategorie;
        private String _libelle;
        #endregion
        #region Properties
        [Required]
        public int IdCategorie
        {
            get
            {
                return _idCategorie;
            }

            set
            {
                _idCategorie = value;
            }
        }
        [Required]
        [MaxLength(50)]
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
        #endregion

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
