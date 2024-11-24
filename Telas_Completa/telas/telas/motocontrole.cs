using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace telas
{
    internal class motocontrole
    {
        conexao con = new conexao();


        public bool cadastrar(motomodelo moto)
        {

            bool resultado = false;
            try
            {



                string sql = "insert into moto (marcamoto,modelomoto,kmmoto,cormoto, codigo_cliente)" +
                    "values(@marcamoto,@modelomoto,@kmmoto,@cormoto, @CD_cliente)";

                string[] campos = { "@marcamoto", "@modelomoto", "@kmmoto", "@cormoto", "@CD_cliente" };

                object[] valores = { moto.marcamoto, moto.modelomoto, moto.kmmoto, moto.cormoto, moto.cod_cliente };

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
    
        public bool editar(motomodelo motom)
        {
            bool resultado = false;
            try
            {


               
                string sql = "update moto set marcamoto=@maracmoto, modelomoto=@modelomoto, kmmoto=@kmmoto,cormoto=@cormoto, where cod_moto=@id)";
               
                string[] campos = { "@maracmoto", "@modelomoto", "@kmmoto",  "@cormoto"};
                
                string[] valores = { motom.marcamoto, motom.modelomoto, motom.kmmoto, motom.cormoto };
                
                if (con.cadastrar(motom.codigo, campos, valores, sql) >= 1)
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
