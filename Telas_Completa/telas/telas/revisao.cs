using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace telas
{
    public class revisao
    {
        public int cod_revisao;
        public string datarevisao;
        public string tiporevisao;
        public string listadeserviços;
        public string pecassubstituidas;

        public revisao()
        {
            datarevisao = "";
            tiporevisao = "";
            listadeserviços = "";
            pecassubstituidas = "";

        }
    }
}
