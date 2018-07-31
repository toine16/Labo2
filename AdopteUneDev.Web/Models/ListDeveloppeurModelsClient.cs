using AdopteUneDev.Models.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdopteUneDev.Web.Models
{
    public class ListDeveloppeurModelsClient
    {
        public ListDeveloppeurModelsClient()
        {
            Developpeurs = new List<Developpeur>();
        }
        public List<Developpeur> Developpeurs { get; set; }



    }
}