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
    public partial class Cadastrohrevisao : Form
    {
        int id_cliente;
        revisao revisao = new revisao();
        public Cadastrohrevisao()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Cadastrohrevisao_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            revisaocontrole revisaocontrole = new revisaocontrole();

            try
            {



                //verificar se o campo email foi preenchido
                if (string.IsNullOrEmpty(cadastrorevisao.Text))
                {
                    MessageBox.Show("Campo nome do produto está vazio!");
                    return;
                }
                else
                {
                    revisao.datarevisao = cadastrorevisao.Text;
                }
                revisao.datarevisao = cadastrorevisao.Text;
                revisao.tiporevisao = tiporevisao.Text;
                revisao.listadeserviços = listadeserviços.Text;
                if (revisaocontrole.cadastrar(revisao) == true)
                {
                    MessageBox.Show("revisao cadastrado com sucesso!");
                }
                else
                {
                    MessageBox.Show("Erro no cadastrado da revisao!");

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void codrevisao_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Cadastromotocs form = new Cadastromotocs (id_cliente);
            form.ShowDialog();
        }
    }
}
