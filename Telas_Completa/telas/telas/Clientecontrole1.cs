using Microsoft.Win32;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace telas
{
    internal class Clientecontrole1
    {
        conexao con = new conexao();

        //metodo para cadastrar usuario
        public bool cadastrar(Cliente usuario)
        {
            //inicializar a variavel resultado do operacao 
            bool resultado = false;
            try
            {


                //monta o script sql de cadastrar as informações no banco
                string sql = "insert into cliente (nome,email,telefone, senha )values(@nome,@email,@telefone, @senha)";
                //monto o vetor de atributos da tabela usuario
                string[] campos = { "@nome", "@email", "@telefone","@senha"};
                //monto o vetor com os valores do formulario
                string[] valores = { usuario.nome, usuario.email, usuario.telefone, usuario.senha };
                //testar o insert no banco de dados
                usuario.cod_usuario = con.cadastrar(0, campos, valores, sql);
                if (usuario.cod_usuario >= 1)
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

        public long obterrgistro(long registro)
        {

            return registro;
        }
        public bool editar(Cliente usuario)
        {
            bool resultado = false;
            try
            {


                //monta o script sql de cadastrar as informações no banco
                string sql = "update cliente set nome=@nome,email=@email,telefone=@telefone, where cod_usuario=@id)";
                //monto o vetor de atributos da tabela usuario
                string[] campos = { "@nome", "@email", "@telefone" };
                //monto o vetor com os valores do formulario
                string[] valores = { usuario.nome, usuario.email, usuario.telefone };
                //testar o insert no banco de dados
                if (con.cadastrar(usuario.cod_usuario, campos, valores, sql) >= 1)
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
        public DataTable logar(Cliente usuario)
        {
            //iniciar variavel zerada
            DataTable registro = new DataTable();
            try
            {
                
                //preparo a consulta 
                string sql = "select * from cliente where email=@mail and senha=@password";
                MySqlConnection com = con.getConexao();//abro o banco de dados
                com.Open();
                MySqlCommand cmd = new MySqlCommand(sql, com);//preparo a execução
                cmd.Parameters.AddWithValue("@mail", usuario.email);
                cmd.Parameters.AddWithValue("@password", usuario.senha);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(registro);
                

            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            return registro;// retorna o ID

        }
        public bool excluir(Cliente usuario)
        {
            bool resultado = false;
            try
            {


                //monta o script sql de cadastrar as informações no banco
                string sql = "delete from cliente where Codcliente=@id";
                //monto o vetor de atributos da tabela usuario
                if (con.excluir(usuario.cod_usuario, sql) >= 1)
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

            return resultado;
        }
    }
}


