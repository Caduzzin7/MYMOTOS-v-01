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
    public partial class relatorio : Form
    {
        int id_cliente; 
        public relatorio(int cod_usuario)
        {
            id_cliente = cod_usuario;

            InitializeComponent();
        }

        private void relatorio_Load(object sender, EventArgs e)
        {
            conexao com = new conexao();
            dataGridView1.DataSource = com.obterdados("select * from dadosrevisao where codigo_cliente = "+ id_cliente );


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
