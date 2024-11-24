using Google.Protobuf.WellKnownTypes;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace telas
{
    internal class mecanicocontrole
    {
        conexao con = new conexao();
        public bool cadastrar(cadastromecanico mecanico)
        {
            bool resultado = false;
            try
            {
                string sql = "insert into cadastromecanico (nomeooficina,nomemecanico,emailmecanico,senhamecanico)values(@nomeoficina,@nomemecanico,@emailmecanico,@senhamecanico)";
                string[] campos = { "@nomeoficina", "@nomemecanico", "@emailmecanico", "@senhamecanico" };
                string[] valores = { mecanico.nomeoficina, mecanico.nomemecanico, mecanico.emailmecanico, mecanico.senhamecanico };

                if (con.cadastrar(0, campos,valores,sql) >= 1)
                {
                    resultado = true;
                }
                else
                {
                    resultado = false;
                }
                return resultado;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }
        public bool excluir(cadastromecanico mecanico)
        {
            bool resultado = false;
            try
            {
                string sql = "(delete from cadastromecanico where codcadmecanico = @id)";

                if (con.excluir(mecanico.cod_mecanico, sql) >= 1)
                {
                    resultado = true;
                }
                else
                {
                    resultado = false;
                }
                return resultado;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }
        public bool editar(cadastromecanico mecanico)
        {
            bool resultado = false;
            try
            {
                string sql = "update cadastromecanico set nomeoficina=@nomeoficina,nomemecanico=@nomemecanico,emailmecanico=@emailmecanico,senhamecanic=@senhamecanico, where codcadmecanico=@id)";
                string[] campos = { "@nomeoficina", "nomemecanico", "emailmecanico", "senhamecanico" };
                string[] valores = { mecanico.nomeoficina,mecanico.nomemecanico,mecanico.emailmecanico,mecanico.senhamecanico };

                if (con.cadastrar(mecanico.cod_mecanico, campos,valores, sql) >= 1)
                {
                    resultado = true;
                }
                else
                {
                    resultado = false;
                }
                return resultado;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }
    }
}









