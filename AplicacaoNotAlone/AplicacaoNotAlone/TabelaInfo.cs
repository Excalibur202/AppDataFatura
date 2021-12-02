using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacaoNotAlone
{ 
    public enum tabelaType {TabelaEncomendaFat = 0, TabelaOpFat = 1, TabelaEncomendaNfat = 2, TabelaOpNfat = 3, TabelaEnOpFat = 4, TabelaEnOpNfat = 5 }
    public class TabelaInfo
    {          
        private int comercialId;
        private int type;

        public TabelaInfo(int comercialid, int type )
        {
            this.comercialId = comercialid;
            this.type = type;
        }

    }
}
