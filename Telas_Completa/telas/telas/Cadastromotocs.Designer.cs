namespace telas
{
    partial class Cadastromotocs
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
            txtnome = new TextBox();
            textBox2 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label3 = new Label();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            label7 = new Label();
            label8 = new Label();
            button1 = new Button();
            button2 = new Button();
            label6 = new Label();
            pesquisacliente = new ComboBox();
            button3 = new Button();
            label9 = new Label();
            CbClint = new ComboBox();
            button4 = new Button();
            SuspendLayout();
            // 
            // txtnome
            // 
            txtnome.BackColor = Color.White;
            txtnome.Location = new Point(449, 180);
            txtnome.Name = "txtnome";
            txtnome.Size = new Size(292, 27);
            txtnome.TabIndex = 4;
            txtnome.TextChanged += txtnome_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(449, 223);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(292, 27);
            textBox2.TabIndex = 6;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(449, 312);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(292, 27);
            textBox4.TabIndex = 8;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(449, 362);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(292, 27);
            textBox5.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(266, 183);
            label3.Name = "label3";
            label3.Size = new Size(93, 20);
            label3.TabIndex = 10;
            label3.Text = "Marca Moto:";
            label3.Click += label3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(266, 226);
            label1.Name = "label1";
            label1.Size = new Size(104, 20);
            label1.TabIndex = 11;
            label1.Text = "Modelo Moto:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(266, 319);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 13;
            label4.Text = "Km Moto:";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(266, 362);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 14;
            label5.Text = "Cor Moto:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Sitka Banner", 22.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.Location = new Point(481, 69);
            label7.Name = "label7";
            label7.Size = new Size(222, 53);
            label7.TabIndex = 16;
            label7.Text = "cadastro moto";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Sitka Small", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label8.Location = new Point(437, 134);
            label8.Name = "label8";
            label8.Size = new Size(175, 21);
            label8.TabIndex = 17;
            label8.Text = "Informações da Moto:";
            // 
            // button1
            // 
            button1.Location = new Point(692, 444);
            button1.Name = "button1";
            button1.Size = new Size(111, 29);
            button1.TabIndex = 29;
            button1.Text = "proxima tela";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(593, 444);
            button2.Name = "button2";
            button2.Size = new Size(93, 31);
            button2.TabIndex = 30;
            button2.Text = "cadastrar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(767, 139);
            label6.Name = "label6";
            label6.Size = new Size(139, 23);
            label6.TabIndex = 32;
            label6.Text = "Cadastro rapido";
            // 
            // pesquisacliente
            // 
            pesquisacliente.FormattingEnabled = true;
            pesquisacliente.Items.AddRange(new object[] { "0" });
            pesquisacliente.Location = new Point(946, 134);
            pesquisacliente.Name = "pesquisacliente";
            pesquisacliente.Size = new Size(102, 28);
            pesquisacliente.TabIndex = 31;
            pesquisacliente.SelectedIndexChanged += pesquisacliente_SelectedIndexChanged;
            // 
            // button3
            // 
            button3.Location = new Point(277, 457);
            button3.Name = "button3";
            button3.Size = new Size(64, 29);
            button3.TabIndex = 35;
            button3.Text = "Voltar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(788, 92);
            label9.Name = "label9";
            label9.Size = new Size(118, 23);
            label9.TabIndex = 36;
            label9.Text = "Usuário Ativo";
            // 
            // CbClint
            // 
            CbClint.FormattingEnabled = true;
            CbClint.Items.AddRange(new object[] { "0" });
            CbClint.Location = new Point(946, 92);
            CbClint.Name = "CbClint";
            CbClint.Size = new Size(102, 28);
            CbClint.TabIndex = 37;
            CbClint.SelectedIndexChanged += CbClint_SelectedIndexChanged;
            // 
            // button4
            // 
            button4.Location = new Point(818, 446);
            button4.Name = "button4";
            button4.Size = new Size(111, 29);
            button4.TabIndex = 38;
            button4.Text = "Atualizar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Cadastromotocs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cornsilk;
            ClientSize = new Size(1333, 649);
            Controls.Add(button4);
            Controls.Add(CbClint);
            Controls.Add(label9);
            Controls.Add(button3);
            Controls.Add(label6);
            Controls.Add(pesquisacliente);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox2);
            Controls.Add(txtnome);
            Name = "Cadastromotocs";
            Text = "Cadastromotocs";
            Load += Cadastromotocs_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtnome;
        private TextBox textBox2;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label3;
        private Label label1;
        private Label label4;
        private Label label5;
        private Label label7;
        private Label label8;
        private Button button1;
        private Button button2;
        private Label label6;
        private ComboBox pesquisacliente;
        private Button button3;
        private Label label9;
        private ComboBox CbClint;
        private Button button4;
    }
}