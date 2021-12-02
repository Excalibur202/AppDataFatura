using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacaoNotAlone
{
    [Serializable()]
    public class Encomendas
    {
        public string Encomenda { get; set; }
        public string OP { get; set; }
        public Double EnTotal { get; }
        public bool Faturado { get; }
        public string Data { get; set; }

        public Encomendas(string data, string encomenda, string op, Double enTotal, bool faturado)
        {
            this.Encomenda = encomenda;
            this.OP = op;
            this.EnTotal = enTotal;
            this.Faturado = faturado;
            this.Data = data;
        }

    }
}