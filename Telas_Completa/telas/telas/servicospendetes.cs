using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace telas
{
    public partial class servicospendetes : Form
    {
        conexao con = new conexao();
        int index = 0;
        int id_cliente = 0;
        DataTable dt_pedido = new DataTable();
        DataGridViewRow row = new DataGridViewRow();
        string serv;
        public servicospendetes(int id)
        {
            this.id_cliente = id;
            InitializeComponent();
        }

        private void CarregarDadosRevisao()
        {
            try
            {
                // Definindo a query SQL para selecionar os dados da tabela dadosrevisao
                string query = "SELECT cliente.nome AS NomeCliente, cliente.telefone AS TelefoneCliente, moto.marcamoto AS MarcaMoto, cadastroprodutos.nomeproduto AS NomeProduto, cliente.Codcliente AS CodigoCliente, cadastroprodutos.codcadprodutos AS CodigoProduto, moto.Codmoto AS CodigoMoto FROM cliente INNER JOIN moto ON cliente.Codcliente = moto.codigo_cliente CROSS JOIN cadastroprodutos;\r\n";

                // Chamando o método obterdados da classe conexao
                DataTable dt = new DataTable();
                dt = con.obterdados(query);

                // Atribuindo o DataTable como fonte de dados do DataGridView
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                // Exibe mensagem de erro em caso de falha na conexão ou consulta
                MessageBox.Show("Erro ao carregar os dados: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void excluir_Click(object sender, EventArgs e)
        {
            Hide();
            menu_oficina form = new menu_oficina();
            form.ShowDialog();

        }

        private void servicospendetes_Load(object sender, EventArgs e)
        {
            CarregarDadosRevisao();
            DataTable dt_mec = con.obterdados($"select * from cadastromecanico where codcadmecanico = {id_cliente}");
            String NomeMec = dt_mec.Rows[0]["nomemecanico"].ToString();
            string Nomeofc = dt_mec.Rows[0]["nomeooficina"].ToString();


        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            DataGridView dvg = (DataGridView)sender;
            //Check first if datagridview has data and
            //Check if you are selecting a valid row
            if (dvg.Rows.Count > 0 && dvg.CurrentCell.RowIndex > 0)
            {
                index = dvg.CurrentCell.RowIndex;
                row = dvg.Rows[index];

                label1.Text = row.Cells[0].Value.ToString();

                clintname.Text = row.Cells[0].Value.ToString();
                serv = row.Cells[5].Value.ToString();
                clintmoto.Text = row.Cells[2].Value.ToString();
                dt_pedido = con.obterdados($"select * from cadastroprodutos where codcadprodutos={serv}");

                serv_Pend.Text = dt_pedido.Rows[0]["descricaogeral"].ToString();


                deletar.Visible = true;


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.excluir(0, $"DELETE FROM moto where codigo_cliente = {row.Cells[6].Value} AND marcamoto = '{row.Cells[2].Value}'"); //moto cliente produto 
            con.excluir(0, $"DELETE FROM cadastroprodutos where codigo_cliente = {row.Cells[6].Value} AND nomeproduto = '{row.Cells[3].Value}'");
            //nomeproduto


            //aqui ele leva para a tela com o produto expecifico = index

            MessageBox.Show("Mecânico selecionou serviço com sucesso!");
            CarregarDadosRevisao();
        }

        private void clintmoto_Click(object sender, EventArgs e)
        {

        }
    }
}
