namespace telas
{
    partial class Cadastro_Tela_2_C
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtnome = new TextBox();
            label4 = new Label();
            txtemail = new TextBox();
            label5 = new Label();
            txttelefone = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            textBox1 = new TextBox();
            label6 = new Label();
            pesquisacliente = new ComboBox();
            label7 = new Label();
            txtsenha = new TextBox();
            label8 = new Label();
            btnlogin = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 24F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(380, 28);
            label1.Name = "label1";
            label1.Size = new Size(395, 47);
            label1.TabIndex = 0;
            label1.Text = "cadastro cliente ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10.2F);
            label2.Location = new Point(472, 119);
            label2.Name = "label2";
            label2.Size = new Size(219, 20);
            label2.TabIndex = 1;
            label2.Text = "informações do proprietário:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10.2F);
            label3.Location = new Point(290, 179);
            label3.Name = "label3";
            label3.Size = new Size(131, 20);
            label3.TabIndex = 2;
            label3.Text = "Nome completo:";
            // 
            // txtnome
            // 
            txtnome.Location = new Point(445, 172);
            txtnome.Name = "txtnome";
            txtnome.Size = new Size(292, 27);
            txtnome.TabIndex = 3;
            txtnome.TextChanged += textBox1_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10.2F);
            label4.Location = new Point(359, 318);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 4;
            label4.Text = "E-mail:";
            // 
            // txtemail
            // 
            txtemail.Location = new Point(445, 311);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(292, 27);
            txtemail.TabIndex = 5;
            txtemail.TextChanged += txtemail_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 10.2F);
            label5.Location = new Point(257, 250);
            label5.Name = "label5";
            label5.Size = new Size(164, 20);
            label5.TabIndex = 6;
            label5.Text = "Telefone do Contato:";
            label5.Click += label5_Click;
            // 
            // txttelefone
            // 
            txttelefone.Location = new Point(445, 243);
            txttelefone.Name = "txttelefone";
            txttelefone.Size = new Size(292, 27);
            txttelefone.TabIndex = 7;
            // 
            // button1
            // 
            button1.BackColor = Color.FloralWhite;
            button1.Location = new Point(805, 591);
            button1.Name = "button1";
            button1.Size = new Size(110, 29);
            button1.TabIndex = 8;
            button1.Text = "cadastrar:";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(529, 591);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 9;
            button2.Text = "excluir:";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(681, 591);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 10;
            button3.Text = "editar:";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(940, 591);
            button4.Name = "button4";
            button4.Size = new Size(133, 29);
            button4.TabIndex = 11;
            button4.Text = "Atualizar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(24, 986);
            button5.Name = "button5";
            button5.Size = new Size(124, 35);
            button5.TabIndex = 12;
            button5.Text = "Voltar Menu";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(445, 376);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(292, 27);
            textBox1.TabIndex = 16;
            textBox1.TextChanged += textBox1_TextChanged_1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Enabled = false;
            label6.Font = new Font("Microsoft Sans Serif", 10.2F);
            label6.Location = new Point(303, 379);
            label6.Name = "label6";
            label6.Size = new Size(123, 20);
            label6.TabIndex = 15;
            label6.Text = "Codigo Cliente:";
            // 
            // pesquisacliente
            // 
            pesquisacliente.FormattingEnabled = true;
            pesquisacliente.Items.AddRange(new object[] { "0" });
            pesquisacliente.Location = new Point(938, 89);
            pesquisacliente.Name = "pesquisacliente";
            pesquisacliente.Size = new Size(102, 28);
            pesquisacliente.TabIndex = 17;
            pesquisacliente.SelectedIndexChanged += pesquisacliente_SelectedIndexChanged;
            pesquisacliente.SelectionChangeCommitted += pesquisacliente_SelectionChangeCommitted;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(785, 89);
            label7.Name = "label7";
            label7.Size = new Size(117, 23);
            label7.TabIndex = 18;
            label7.Text = "Login Rápido";
            label7.Click += button5_Click;
            // 
            // txtsenha
            // 
            txtsenha.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtsenha.Location = new Point(938, 140);
            txtsenha.Name = "txtsenha";
            txtsenha.Size = new Size(102, 27);
            txtsenha.TabIndex = 20;
            txtsenha.TextChanged += txtsenha_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Enabled = false;
            label8.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(806, 147);
            label8.Name = "label8";
            label8.Size = new Size(61, 20);
            label8.TabIndex = 19;
            label8.Text = "Senha";
            // 
            // btnlogin
            // 
            btnlogin.Location = new Point(445, 454);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(292, 96);
            btnlogin.TabIndex = 21;
            btnlogin.Text = "Login";
            btnlogin.UseVisualStyleBackColor = true;
            btnlogin.Click += btnlogin_Click;
            // 
            // Cadastro_Tela_2_C
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cornsilk;
            ClientSize = new Size(1333, 649);
            Controls.Add(btnlogin);
            Controls.Add(txtsenha);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(pesquisacliente);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txttelefone);
            Controls.Add(label5);
            Controls.Add(txtemail);
            Controls.Add(label4);
            Controls.Add(txtnome);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Cadastro_Tela_2_C";
            Text = "tela_2";
            FormClosed += Cadastro_Tela_2_C_FormClosed;
            Load += Cadastro_Tela_2_C_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtnome;
        private Label label4;
        private TextBox txtemail;
        private Label label5;
        private TextBox txttelefone;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private TextBox textBox1;
        private Label label6;
        private ComboBox pesquisacliente;
        private Label label7;
        private TextBox txtsenha;
        private Label label8;
        private Button btnlogin;
    }
}