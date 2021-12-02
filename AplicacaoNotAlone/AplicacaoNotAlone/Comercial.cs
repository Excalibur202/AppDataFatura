using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacaoNotAlone
{
    [Serializable()]
    public class Comercial
    {
        public List<Encomendas> encomendas = new List<Encomendas>();
        private int comercialID;

        public int GetComercialID {
            get { return comercialID; }
        }

        public Comercial(int comercialID)
        {
            this.comercialID = comercialID;
        }
    }
}
