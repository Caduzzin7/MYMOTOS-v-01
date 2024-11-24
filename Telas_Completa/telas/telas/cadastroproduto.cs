using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace telas
{
    public class cadastroproduto
    {
        public int cod_cliente;
        public int cod_produto;
        public string nomeproduto;
        public string descricaogeral;
        public string anodapeca;
        public string precototal;

        public cadastroproduto() {
            nomeproduto = "";
            descricaogeral = "";
            anodapeca = "";
            precototal = "";
            cod_cliente = 0;
        }
    }
}
