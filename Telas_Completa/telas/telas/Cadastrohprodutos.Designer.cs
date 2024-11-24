namespace telas
{
    partial class Cadastrohprodutos
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
            label7 = new Label();
            label8 = new Label();
            descricaogeralproduto = new TextBox();
            anodapeca = new TextBox();
            precototal = new TextBox();
            nomedoproduto = new TextBox();
            label4 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cadastrar = new Button();
            proximatela = new Button();
            button1 = new Button();
            CbClint = new ComboBox();
            label9 = new Label();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Sitka Banner", 22.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.Location = new Point(497, 73);
            label7.Name = "label7";
            label7.Size = new Size(226, 53);
            label7.TabIndex = 20;
            label7.Text = "cadastro peças";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Sitka Small", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label8.Location = new Point(475, 135);
            label8.Name = "label8";
            label8.Size = new Size(194, 21);
            label8.TabIndex = 21;
            label8.Text = "Informações do produto:";
            // 
            // descricaogeralproduto
            // 
            descricaogeralproduto.BackColor = Color.White;
            descricaogeralproduto.Location = new Point(475, 274);
            descricaogeralproduto.Name = "descricaogeralproduto";
            descricaogeralproduto.Size = new Size(292, 27);
            descricaogeralproduto.TabIndex = 24;
            // 
            // anodapeca
            // 
            anodapeca.BackColor = Color.White;
            anodapeca.Location = new Point(475, 323);
            anodapeca.Name = "anodapeca";
            anodapeca.Size = new Size(292, 27);
            anodapeca.TabIndex = 25;
            // 
            // precototal
            // 
            precototal.BackColor = Color.White;
            precototal.Location = new Point(475, 367);
            precototal.Name = "precototal";
            precototal.Size = new Size(292, 27);
            precototal.TabIndex = 26;
            // 
            // nomedoproduto
            // 
            nomedoproduto.BackColor = Color.White;
            nomedoproduto.Location = new Point(475, 232);
            nomedoproduto.Name = "nomedoproduto";
            nomedoproduto.Size = new Size(292, 27);
            nomedoproduto.TabIndex = 27;
            nomedoproduto.TextChanged += textBox4_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(337, 370);
            label4.Name = "label4";
            label4.Size = new Size(86, 20);
            label4.TabIndex = 28;
            label4.Text = "Preco Total:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(337, 326);
            label1.Name = "label1";
            label1.Size = new Size(94, 20);
            label1.TabIndex = 29;
            label1.Text = "Ano da Peça:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(337, 277);
            label2.Name = "label2";
            label2.Size = new Size(109, 20);
            label2.TabIndex = 30;
            label2.Text = "Desçriao Geral:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(337, 239);
            label3.Name = "label3";
            label3.Size = new Size(116, 20);
            label3.TabIndex = 31;
            label3.Text = "Nome Produtos:";
            // 
            // cadastrar
            // 
            cadastrar.Location = new Point(613, 462);
            cadastrar.Name = "cadastrar";
            cadastrar.Size = new Size(134, 29);
            cadastrar.TabIndex = 32;
            cadastrar.Text = "cadastrar:";
            cadastrar.UseVisualStyleBackColor = true;
            cadastrar.Click += button1_Click;
            // 
            // proximatela
            // 
            proximatela.Location = new Point(780, 462);
            proximatela.Name = "proximatela";
            proximatela.Size = new Size(141, 29);
            proximatela.TabIndex = 35;
            proximatela.Text = "ir para o relatorio:";
            proximatela.UseVisualStyleBackColor = true;
            proximatela.Click += proximatela_Click;
            // 
            // button1
            // 
            button1.Location = new Point(348, 462);
            button1.Name = "button1";
            button1.Size = new Size(64, 29);
            button1.TabIndex = 36;
            button1.Text = "Voltar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_2;
            // 
            // CbClint
            // 
            CbClint.FormattingEnabled = true;
            CbClint.Items.AddRange(new object[] { "0" });
            CbClint.Location = new Point(997, 98);
            CbClint.Name = "CbClint";
            CbClint.Size = new Size(102, 28);
            CbClint.TabIndex = 41;
            CbClint.SelectedIndexChanged += CbClint_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(839, 98);
            label9.Name = "label9";
            label9.Size = new Size(118, 23);
            label9.TabIndex = 40;
            label9.Text = "Usuário Ativo";
            label9.Click += label9_Click;
            // 
            // Cadastrohprodutos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cornsilk;
            ClientSize = new Size(1333, 649);
            Controls.Add(CbClint);
            Controls.Add(label9);
            Controls.Add(button1);
            Controls.Add(proximatela);
            Controls.Add(cadastrar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(nomedoproduto);
            Controls.Add(precototal);
            Controls.Add(anodapeca);
            Controls.Add(descricaogeralproduto);
            Controls.Add(label8);
            Controls.Add(label7);
            Name = "Cadastrohprodutos";
            Text = "Cadastrohprodutos";
            Load += Cadastrohprodutos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private Label label8;
        private TextBox descricaogeralproduto;
        private TextBox anodapeca;
        private TextBox precototal;
        private TextBox nomedoproduto;
        private Label label4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button cadastrar;
        private Button proximatela;
        private Button button1;
        private ComboBox CbClint;
        private Label label9;
    }
}