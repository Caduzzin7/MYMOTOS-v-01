using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace telas
{
    internal class revisaocontrole
    {
        conexao con = new conexao();

        //metodo para cadastrar usuario
        public bool cadastrar(revisao revisao)
        {
            //inicializar a variavel resultado do operacao 
            bool resultado = false;
            try
            {


                //monta o script sql de cadastrar as informações no banco
                string sql = "insert into dadosrevisao (datarevisao,tiporevisao,kmmoto,servicosrealizados,pecassubstituidas)values(@datarevisao,@tiporevisao,@kmmoto,@servicosrealizados,@pecassubstituidas)";
                //monto o vetor de atributos da tabela usuario
                string[] campos = { "@datarevisao", "@tiporevisao", "@kmmoto", "@servicosrealizados", "@pecassubstituidas" };
                //monto o vetor com os valores do formulario
                string[] valores = { revisao.datarevisao, revisao.tiporevisao, revisao.pecassubstituidas };
                //testar o insert no banco de dados
                if (con.cadastrar(0, campos, valores, sql) >= 1)
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
        public bool excluir(revisao revisao)
        {
            bool resultado = false;
            try
            {


                //monta o script sql de cadastrar as informações no banco
                string sql = "delete from Cadastrohrevisao where codcadprodutos=@id)";
                //monto o vetor de atributos da tabela usuario


                //testar o insert no banco de dados
                if (con.excluir(revisao.cod_revisao, sql) >= 1)
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
        public bool editar(revisao revisao)
        {
            bool resultado = false;
            try
            {


                //monta o script sql de cadastrar as informações no banco
                string sql = "update cadastrohrevisao set datarevisao=@datarevisao,tiporevisao=@tiporevisao, servicosrealizados=@servicosrealizados, where cod_revisao=@id)";
                //monto o vetor de atributos da tabela usuario
                string[] campos = { "@datarevisao", "@tiporevisao", "@servicosrealizados" };
                //monto o vetor com os valores do formulario
                string[] valores = { revisao.datarevisao, revisao.tiporevisao };
                //testar o insert no banco de dados
                if (con.cadastrar(revisao.cod_revisao, campos, valores, sql) >= 1)
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
