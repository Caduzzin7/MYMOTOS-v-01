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
    public partial class relatoriogeral : Form
    {
        conexao con = new conexao();
        int id_cliente;
        public relatoriogeral(int id_cliente)
        {
            this.id_cliente = id_cliente;
            InitializeComponent();
        }

        private void relatoriogeral_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = con.obterdados("select cliente.nome,\r\n cliente.telefone,\r\n moto.marcamoto,\r\n moto.modelomoto,\r\n cadastroprodutos.nomeproduto,\r\n cliente.Codcliente,\r\n moto.Codmoto,\r\n cadastroprodutos.codcadprodutos\r\n from cadastroprodutos \r\n inner join cliente on cadastroprodutos.codigo_cliente = cliente.Codcliente\r\n inner join moto on cadastroprodutos.codigo_cliente = moto.codigo_cliente;");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Cadastro_Tela_2_C form = new Cadastro_Tela_2_C(id_cliente);
            form.ShowDialog();
        }
    }
    }

