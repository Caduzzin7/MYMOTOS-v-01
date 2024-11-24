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
    public partial class Cadastrohprodutos : Form
    {
        int id_cliente;
        conexao conexao = new conexao();
        public Cadastrohprodutos(int id_cliente)
        {
            this.id_cliente = id_cliente;
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            cadastroproduto produto = new cadastroproduto();
            produtocontrole produtocontrole = new produtocontrole();

            try
            {



                //verificar se o campo email foi preenchido
                if (string.IsNullOrEmpty(nomedoproduto.Text))
                {
                    MessageBox.Show("Campo nome do produto está vazio!");
                    return;
                }
                else
                {
                    produto.nomeproduto = nomedoproduto.Text;
                }
                produto.descricaogeral = descricaogeralproduto.Text;
                produto.anodapeca = anodapeca.Text;
                produto.precototal = precototal.Text;
                produto.cod_cliente = id_cliente;
                if (produtocontrole.cadastrar(produto) == true)
                {
                    MessageBox.Show("produto cadastrado com sucesso!");
                }
                else
                {
                    MessageBox.Show("Erro no cadastrado do produto!");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }
        }



        //private void button1_Click_1(object sender, EventArgs e)
        //{
        //    cadastroproduto produto = new cadastroproduto();
        //    produtocontrole produtocontrole = new produtocontrole();

        //    produto.nomeproduto = nomedoproduto.Text;

        //    produto.descricaogeral = descricaogeralproduto.Text;
        //    produto.anodapeca = anodapeca.Text;
        //    produto.precototal = precototal.Text;
        //    if (produtocontrole.editar(produto) == true)
        //    {
        //        MessageBox.Show("produto cadastrado com sucesso!");
        //    }
        //    else
        //    {
        //        MessageBox.Show("Erro no cadastrado do produto!");

        //    }
        //}

        //private void excluir_Click(object sender, EventArgs e)
        //{
        //    cadastroproduto produto = new cadastroproduto();
        //    produtocontrole produtocontrole = new produtocontrole();

        //    if (produtocontrole.excluir(produto) == true)
        //    {
        //        MessageBox.Show("produto cadastrado com sucesso!");
        //    }
        //    else
        //    {
        //        MessageBox.Show("Erro no cadastrado do produto!");

        //    }
        //}

        //private void codproduto_TextChanged(object sender, EventArgs e)
        //{

        //} CASO QUEIRA VOLTAR OS BOTÕES DE EXLCUIR E EDITAR CADASTRO DE PEÇAS NA TELA MOTOS.

        private void Cadastrohprodutos_Load(object sender, EventArgs e)
        {
            CbClint.DataSource = conexao.obterdados("select * from cliente");
            CbClint.ValueMember = "Codcliente";
            CbClint.DisplayMember = "nome";
            CbClint.SelectedIndex = id_cliente - 1;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Hide();
            Cadastromotocs Form = new Cadastromotocs(id_cliente);
            Form.ShowDialog();
        }

        private void CbClint_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void proximatela_Click(object sender, EventArgs e)
        {
            relatoriogeral relt = new relatoriogeral(id_cliente);
            this.Hide();
            relt.ShowDialog();
        }
    }
}
