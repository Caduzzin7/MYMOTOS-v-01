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
    public partial class Cadastro_Tela_2_Extra : Form
    {
        public Cadastro_Tela_2_Extra()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            Clientecontrole1 clientecontrole = new Clientecontrole1();

            try
            {


                cliente.nome = txtnome.Text;
                //verificar se o campo email foi preenchido
                if (string.IsNullOrEmpty(txtemail.Text))
                {
                    MessageBox.Show("Campo e-mail está vazio!");
                    return;
                }
                else
                {
                    cliente.email = txtemail.Text;
                }
                cliente.telefone = txttelefone.Text;
                if (clientecontrole.cadastrar(cliente) == true)
                {
                    MessageBox.Show("Usuário cadastrado com sucesso!");
                }
                else
                {
                    MessageBox.Show("Erro no cadastrado do usuário!");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {



            /*
            //populo meu objeto usuário
            Cliente.cod_usurio = Convert.ToInt32(txtCodigo.Text);
            mUsuario.nome = txtNome.Text;
            mUsuario.senha = txtSenha.Text;
            mUsuario.cargo = Convert.ToInt32(txtCargo.Text);
            mUsuario.email = txtEmail.Text;
            //chama o metodo de editar as informações do usuario
            if (cUsuario.editar(mUsuario) == true)
            {
                MessageBox.Show("Atualizado o usuário com sucesso");
            }
            else
            {
                MessageBox.Show("Erro ao atualizar as infomrações");
            }*/

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
