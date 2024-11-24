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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace telas
{
    public partial class loginoficina : Form
    {
        conexao con = new conexao();
        int id_cliente = 0;
        int codcliente;
        public loginoficina(int id)
        {
            this.id_cliente = id;
            InitializeComponent();
        }

        private void loginoficina_Load(object sender, EventArgs e)
        {
            DataTable dt_Oficina = new DataTable();


            CbClint.DataSource = con.obterdados("select * from cadastromecanico");
            CbClint.ValueMember = "codcadmecanico";
            CbClint.DisplayMember = "nomemecanico";
            CbClint.SelectedIndex = id_cliente - 1;

            nomeoficina.Text = "";
            nomemecanico.Text = "";
            emailmecanico.Text = "";
            senhamecanico.Text = "";
            codmecanico.Text = "";

            //dataGridView1.DataSource = con.obterdados("select * from dadosrevisao");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cadastromecanico mecanico = new cadastromecanico();
            mecanicocontrole mecanicocontrole = new mecanicocontrole();


           
                try
            {
                if (string.IsNullOrEmpty(nomeoficina.Text))
                {
                    MessageBox.Show("Campo nome da oficina está vazio!");
                    return;
                }
                else
                {
                    mecanico.nomeoficina = nomeoficina.Text;

                }
                mecanico.nomeoficina = nomeoficina.Text;
                mecanico.nomemecanico = nomemecanico.Text;
                mecanico.emailmecanico = emailmecanico.Text;
                mecanico.senhamecanico = senhamecanico.Text;
                if (mecanicocontrole.cadastrar(mecanico) == true)
                {
                    MessageBox.Show("mecanico cadastrado com sucesso!");
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

        private void editar_Click(object sender, EventArgs e)
        {
            cadastromecanico mecanico = new cadastromecanico();
            mecanicocontrole mecanicocontrole = new mecanicocontrole();
            mecanico.cod_mecanico = Convert.ToInt32(codmecanico.Text);
            mecanico.nomeoficina = nomeoficina.Text;
            mecanico.nomemecanico = nomemecanico.Text;
            mecanico.emailmecanico = emailmecanico.Text;
            mecanico.senhamecanico = senhamecanico.Text;
            if (mecanicocontrole.editar(mecanico) == true)
            {
                MessageBox.Show("mecanico cadastrado com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro no cadastrado do mecanico!");
            }
        }

        private void excluir_Click(object sender, EventArgs e)
        {
            cadastromecanico mecanico = new cadastromecanico();
            mecanicocontrole mecanicocontrole = new mecanicocontrole();
            mecanico.cod_mecanico = Convert.ToInt32(codmecanico.Text);
            if (mecanicocontrole.excluir(mecanico) == true)
            {

                MessageBox.Show("mecanico cadastrado com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro no cadastrado do mecanico!");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Hide();
            servicospendetes form = new servicospendetes(CbClint.SelectedIndex+1);
            form.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Hide();
            menu_oficina formm = new menu_oficina();
            formm.ShowDialog();
        }

        private void CbClint_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbClint.SelectedIndex > -1)
            {
                codcliente = Convert.ToInt32(((DataRowView)CbClint.SelectedItem)["codcadmecanico"]);
                DataTable dt = con.obterdados("select * from cadastromecanico where codcadmecanico =" + codcliente);
                nomeoficina.Text = dt.Rows[0][0].ToString();
                nomemecanico.Text = dt.Rows[0][1].ToString();
                emailmecanico.Text = dt.Rows[0][2].ToString();
                //senhamecanico.Text = dt.Rows[0][3].ToString();
                codmecanico.Text = dt.Rows[0][4].ToString();
                codcliente = codcliente;//Convert.ToInt32(textBox1.Text)
            }
        }

        private void nomeoficina_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            CbClint.DataSource = con.obterdados("select * from cadastromecanico");
            CbClint.ValueMember = "codcadmecanico";
            CbClint.DisplayMember = "nomemecanico";
            CbClint.SelectedIndex = -1;

            label3.Text = "";
            label1.Text = "";
            label2.Text = "";
            label4.Text = "";
            label5.Text = "";
        }

        //if (txtnome.Text != string.Empty && txtemail.Text != string.Empty && txtsenha.Text != string.Empty && txttelefone.Text != string.Empty && textBox1.Text != string.Empty)
        //{
        //    Hide();
        //    Cadastromotocs cmoto = new Cadastromotocs(cliente.cod_usuario);
        //    cmoto.ShowDialog();
        //}
        //else { MessageBox.Show("Faltou preencher todos os campos"); }

        }
    }

