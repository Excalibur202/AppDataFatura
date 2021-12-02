using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacaoNotAlone
{
    [Serializable()]
    public class Empresa
    {
        public int EmpresaID { get;  } 
        public string empresaNome;

        public List<Comercial> comercials = new List<Comercial>();

        public Empresa(int empresaID, string empresaNome)
        {
            this.EmpresaID = empresaID;
            this.empresaNome = empresaNome;
        }
        public void AddCom()
        {
            comercials.Add(new Comercial(comercials.Count));
        }
    }
}
