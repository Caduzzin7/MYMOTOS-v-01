using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace telas
{
    public partial class Cadastro_Tela_2_C : Form
    {
        DataTable dt = new DataTable();
        int codcliente;
        Cliente cliente = new Cliente();
        Clientecontrole1 clientecontrole = new Clientecontrole1();
        conexao conexao = new conexao();
        int id_cliente = 0;
        public Cadastro_Tela_2_C(int id)
        {
            this.id_cliente = id;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {


                cliente.nome = txtnome.Text;
                //verificar se o campo email foi preenchido
                if (txtnome.Text == string.Empty || txtemail.Text == string.Empty || txtsenha.Text == string.Empty || txttelefone.Text == string.Empty)  //|| textBox1.Text == string.Empty
                {
                    MessageBox.Show("Faltou preencher todos campos!");
                    return;
                }
                else
                {
                    cliente.email = txtemail.Text;

                    cliente.telefone = txttelefone.Text;
                    cliente.senha = txtsenha.Text;
                    if (clientecontrole.cadastrar(cliente) == true)
                    {
                        MessageBox.Show("Usuário cadastrado com sucesso!");
                        textBox1.Text = cliente.cod_usuario.ToString();
                    }
                    else
                    {

                        MessageBox.Show("Erro no cadastrado do usuário!");

                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Cadastro_Tela_2_C_Load(object sender, EventArgs e)
        {
            pesquisacliente.DataSource = conexao.obterdados("select Codcliente,  nome from cliente");
            pesquisacliente.ValueMember = "Codcliente";
            pesquisacliente.DisplayMember = "nome";
            pesquisacliente.SelectedIndex = -1;



            if (pesquisacliente.SelectedIndex >= 1)
            {
                //Codcliente = Convert.ToInt32(((DataRowView)pesquisacliente.SelectedItem)["Codcliente"]);
                dt = conexao.obterdados("select * from cliente where Codcliente=" + codcliente);
                txtnome.Text = dt.Rows[0][0].ToString();
                txtemail.Text = dt.Rows[0][2].ToString();
                txttelefone.Text = dt.Rows[0][1].ToString();

            }
            else
            {
                txtnome.Clear();
                txttelefone.Clear();
                txtemail.Clear();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {


            //if (txtnome.Text != string.Empty && txtemail.Text != string.Empty && txtsenha.Text != string.Empty && txttelefone.Text != string.Empty && textBox1.Text != string.Empty)
            //{
            //    Hide();
            //    Cadastromotocs cmoto = new Cadastromotocs(cliente.cod_usuario);
            //    cmoto.ShowDialog();
            //}
            //else { MessageBox.Show("Faltou preencher todos os campos"); }

            pesquisacliente.DataSource = conexao.obterdados("select Codcliente,  nome from cliente");
            pesquisacliente.ValueMember = "Codcliente";
            pesquisacliente.DisplayMember = "nome";
            pesquisacliente.SelectedIndex = -1;

            txtnome.Text = "";
            txtemail.Text = "";
            txtsenha.Text = "";
            txttelefone.Text = "";

        }

        private void txtemail_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Hide();
            menu_oficina oficina = new menu_oficina();
            oficina.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pesquisacliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pesquisacliente.SelectedIndex > -1)
            {
                codcliente = Convert.ToInt32(((DataRowView)pesquisacliente.SelectedItem)["Codcliente"]);
                dt = conexao.obterdados("select * from cliente where codcliente=" + codcliente);
                txtnome.Text = dt.Rows[0][0].ToString();
                txtemail.Text = dt.Rows[0][2].ToString();
                txttelefone.Text = dt.Rows[0][1].ToString();
                textBox1.Text = dt.Rows[0][4].ToString();
                cliente.cod_usuario = codcliente;//Convert.ToInt32(textBox1.Text)
            }

        }

        private void pesquisacliente_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            Cliente musuario = new Cliente();
            musuario.senha = txtsenha.Text;
            musuario.email = txtemail.Text;

            Clientecontrole1 cusuario = new Clientecontrole1();

            DataTable dt_clint = cusuario.logar(musuario);

            if (dt_clint.Rows.Count > 0)
            {
                if (Convert.ToInt32(dt_clint.Rows[0]["Codcliente"]) > 0)
                {
                    MessageBox.Show("Acesso autorizado!");

                    Cadastromotocs moto = new Cadastromotocs(codcliente);
                    this.Hide();
                    moto.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Acesso não autorizado!");

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (clientecontrole.excluir(cliente) == true)
            {
                MessageBox.Show("registro excluido com sucesso");
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Cadastro_Tela_2_C_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void txtsenha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}