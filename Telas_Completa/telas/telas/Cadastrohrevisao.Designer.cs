namespace telas
{
    partial class Cadastrohrevisao
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
            label8 = new Label();
            label7 = new Label();
            listadeserviços = new TextBox();
            textBox1 = new TextBox();
            tiporevisao = new TextBox();
            cadastrorevisao = new TextBox();
            pecassubstituidas = new Label();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            proximatela = new Label();
            editar = new Button();
            excluir = new Button();
            cadastrar = new Button();
            codrevisao = new TextBox();
            label3 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Sitka Small", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label8.Location = new Point(304, 71);
            label8.Name = "label8";
            label8.Size = new Size(196, 23);
            label8.TabIndex = 18;
            label8.Text = "Informações da Revisão:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Sitka Banner", 22.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.Location = new Point(326, 9);
            label7.Name = "label7";
            label7.Size = new Size(142, 53);
            label7.TabIndex = 19;
            label7.Text = "cadastro";
            // 
            // listadeserviços
            // 
            listadeserviços.BackColor = Color.White;
            listadeserviços.Location = new Point(326, 221);
            listadeserviços.Name = "listadeserviços";
            listadeserviços.Size = new Size(292, 27);
            listadeserviços.TabIndex = 20;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.Location = new Point(326, 264);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(292, 27);
            textBox1.TabIndex = 21;
            // 
            // tiporevisao
            // 
            tiporevisao.BackColor = Color.White;
            tiporevisao.Location = new Point(326, 179);
            tiporevisao.Name = "tiporevisao";
            tiporevisao.Size = new Size(292, 27);
            tiporevisao.TabIndex = 22;
            // 
            // cadastrorevisao
            // 
            cadastrorevisao.BackColor = Color.White;
            cadastrorevisao.Location = new Point(326, 139);
            cadastrorevisao.Name = "cadastrorevisao";
            cadastrorevisao.Size = new Size(292, 27);
            cadastrorevisao.TabIndex = 23;
            cadastrorevisao.TextChanged += textBox3_TextChanged;
            // 
            // pecassubstituidas
            // 
            pecassubstituidas.AutoSize = true;
            pecassubstituidas.Location = new Point(172, 267);
            pecassubstituidas.Name = "pecassubstituidas";
            pecassubstituidas.Size = new Size(132, 20);
            pecassubstituidas.TabIndex = 24;
            pecassubstituidas.Text = "Pecas Substituidas:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(172, 228);
            label1.Name = "label1";
            label1.Size = new Size(121, 20);
            label1.TabIndex = 25;
            label1.Text = "Lista de Servicos:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(172, 186);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 26;
            label2.Text = "Tipo Revisao:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(172, 142);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 27;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(172, 142);
            label5.Name = "label5";
            label5.Size = new Size(95, 20);
            label5.TabIndex = 28;
            label5.Text = "Data revisao:";
            // 
            // proximatela
            // 
            proximatela.AutoSize = true;
            proximatela.Location = new Point(655, 410);
            proximatela.Name = "proximatela";
            proximatela.Size = new Size(97, 20);
            proximatela.TabIndex = 29;
            proximatela.Text = "Proxima Tela:";
            proximatela.Click += label6_Click;
            // 
            // editar
            // 
            editar.Location = new Point(429, 406);
            editar.Name = "editar";
            editar.Size = new Size(94, 29);
            editar.TabIndex = 30;
            editar.Text = "editar:";
            editar.UseVisualStyleBackColor = true;
            // 
            // excluir
            // 
            excluir.Location = new Point(304, 406);
            excluir.Name = "excluir";
            excluir.Size = new Size(94, 29);
            excluir.TabIndex = 31;
            excluir.Text = "excluir:";
            excluir.UseVisualStyleBackColor = true;
            // 
            // cadastrar
            // 
            cadastrar.Location = new Point(544, 406);
            cadastrar.Name = "cadastrar";
            cadastrar.Size = new Size(94, 29);
            cadastrar.TabIndex = 32;
            cadastrar.Text = "cadastar:";
            cadastrar.UseVisualStyleBackColor = true;
            cadastrar.Click += button3_Click;
            // 
            // codrevisao
            // 
            codrevisao.Location = new Point(326, 106);
            codrevisao.Name = "codrevisao";
            codrevisao.Size = new Size(292, 27);
            codrevisao.TabIndex = 33;
            codrevisao.TextChanged += codrevisao_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(172, 106);
            label3.Name = "label3";
            label3.Size = new Size(131, 20);
            label3.TabIndex = 34;
            label3.Text = "código da revisão:";
            // 
            // button1
            // 
            button1.Location = new Point(12, 410);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 35;
            button1.Text = "Voltar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Cadastrohrevisao
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cornsilk;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(codrevisao);
            Controls.Add(cadastrar);
            Controls.Add(excluir);
            Controls.Add(editar);
            Controls.Add(proximatela);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pecassubstituidas);
            Controls.Add(cadastrorevisao);
            Controls.Add(tiporevisao);
            Controls.Add(textBox1);
            Controls.Add(listadeserviços);
            Controls.Add(label7);
            Controls.Add(label8);
            Name = "Cadastrohrevisao";
            Text = "Cadastrohrevisao";
            Load += Cadastrohrevisao_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label8;
        private Label label7;
        private TextBox listadeserviços;
        private TextBox textBox1;
        private TextBox tiporevisao;
        private TextBox cadastrorevisao;
        private Label pecassubstituidas;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label proximatela;
        private Button editar;
        private Button excluir;
        private Button cadastrar;
        private TextBox codrevisao;
        private Label label3;
        private Button button1;
    }
}