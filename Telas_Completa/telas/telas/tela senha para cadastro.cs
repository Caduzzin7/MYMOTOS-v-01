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
    public partial class tela_senha_para_cadastro : Form
    {
        int id_cliente = 0;
        public tela_senha_para_cadastro(int id)
        {
            this.id_cliente = id;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Cliente zusuario = new Cliente();
            zusuario.senha = txtsenha.Text;

            Clientecontrole1 cusuario = new Clientecontrole1();
            if (zusuario.senha == "mymotos")
            {
                MessageBox.Show("Acesso autorizado!");
                loginoficina moto = new loginoficina(id_cliente);
                moto.ShowDialog();
            }
            else
            {
                MessageBox.Show("Acesso não autorizado!");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            menu_oficina form = new menu_oficina();
            form.ShowDialog();
        }
    }
}
