using MySqlX.XDevAPI;
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
    public partial class menu_oficina : Form

    {
        int id_cliente = 0;
        public menu_oficina()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void menu_oficina_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Hide();
            Cadastro_Tela_2_C form = new Cadastro_Tela_2_C(id_cliente);
            form.ShowDialog();

        }

        private void excluir_Click(object sender, EventArgs e)
        {

            Hide();
            tela_senha_para_cadastro form = new tela_senha_para_cadastro(id_cliente);
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            sobrenos form = new sobrenos();
            form.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
