using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace telas
{
    internal class produtocontrole
    {
        conexao con = new conexao();

        //metodo para cadastrar usuario
        public bool cadastrar(cadastroproduto produto)
        {
            //inicializar a variavel resultado do operacao 
            bool resultado = false;
            try
            {


                //monta o script sql de cadastrar as informações no banco
                string sql = "insert into cadastroprodutos (nomeproduto,descricaogeral,anodapeca,preco,codigo_cliente)values(@nomeproduto,@descricaogeral,@anodapeca,@preco,@codigo_cliente)";
                //monto o vetor de atributos da tabela usuario
                string[] campos = { "@nomeproduto", "@descricaogeral", "@anodapeca","@preco","@codigo_cliente"};
                //monto o vetor com os valores do formulario
                string[] valores = { produto.nomeproduto, produto.descricaogeral, produto.anodapeca, produto.precototal , produto.cod_cliente.ToString()};
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
        public bool excluir(cadastroproduto produto)
        {
            bool resultado = false;
            try
            {


                //monta o script sql de cadastrar as informações no banco
                string sql = "delete from cadastroprodutos where codcadprodutos=@id)";
                //monto o vetor de atributos da tabela usuario
               
                
                //testar o insert no banco de dados
                if (con.excluir(produto.cod_produto, sql) >= 1)
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
        public bool editar(cadastroproduto produto)
        {
            bool resultado = false;
            try
            {


                //monta o script sql de cadastrar as informações no banco
                string sql = "update cadastroprodutos set nomeproduto=@nomeproduto,descricaogeral=@descricaogeral,anodapeca=@anodapeca,preco=@preco, where codcadprodutos=@id)";
                //monto o vetor de atributos da tabela usuario
                string[] campos = { "@nomeproduto", "@descricaogeral", "@anodapeca", "@preco" };
                //monto o vetor com os valores do formulario
                string[] valores = { produto.nomeproduto, produto.descricaogeral, produto.anodapeca, produto.precototal};
                //testar o insert no banco de dados
                if (con.cadastrar(produto.cod_produto, campos, valores, sql) >= 1)
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

