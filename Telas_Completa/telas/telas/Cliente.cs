using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace telas
{
    internal class Cliente
    {
        public int cod_usuario;
        public string nome;
        public string email;
        public string telefone;
        public string senha; 
        
        //construtor da classe usuario 
        public Cliente()
        {
            //inicializar as variaveis zeradas
            nome = "";
            email = "";
            telefone = "";
            senha = "";

        }
    }
}
