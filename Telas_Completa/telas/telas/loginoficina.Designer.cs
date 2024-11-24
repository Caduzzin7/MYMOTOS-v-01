
namespace telas
{
    partial class loginoficina
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
            label1 = new Label();
            label3 = new Label();
            nomemecanico = new TextBox();
            nomeoficina = new TextBox();
            label2 = new Label();
            emailmecanico = new TextBox();
            label4 = new Label();
            senhamecanico = new TextBox();
            cadastrar = new Button();
            editar = new Button();
            excluir = new Button();
            button1 = new Button();
            button2 = new Button();
            CbClint = new ComboBox();
            label9 = new Label();
            label5 = new Label();
            codmecanico = new TextBox();
            button4 = new Button();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Sitka Banner", 22.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.Location = new Point(291, 42);
            label7.Name = "label7";
            label7.Size = new Size(142, 53);
            label7.TabIndex = 17;
            label7.Text = "cadastro";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(163, 175);
            label1.Name = "label1";
            label1.Size = new Size(121, 20);
            label1.TabIndex = 23;
            label1.Text = "Nome Mecânico:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(163, 124);
            label3.Name = "label3";
            label3.Size = new Size(125, 20);
            label3.TabIndex = 22;
            label3.Text = "Nome da Oficina:";
            label3.Click += label3_Click;
            // 
            // nomemecanico
            // 
            nomemecanico.Location = new Point(346, 172);
            nomemecanico.Name = "nomemecanico";
            nomemecanico.Size = new Size(292, 27);
            nomemecanico.TabIndex = 19;
            nomemecanico.TextChanged += textBox2_TextChanged;
            // 
            // nomeoficina
            // 
            nomeoficina.BackColor = Color.White;
            nomeoficina.Location = new Point(346, 121);
            nomeoficina.Name = "nomeoficina";
            nomeoficina.Size = new Size(292, 27);
            nomeoficina.TabIndex = 18;
            nomeoficina.TextChanged += nomeoficina_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(163, 230);
            label2.Name = "label2";
            label2.Size = new Size(117, 20);
            label2.TabIndex = 25;
            label2.Text = "Email mecânico:";
            // 
            // emailmecanico
            // 
            emailmecanico.Location = new Point(346, 227);
            emailmecanico.Name = "emailmecanico";
            emailmecanico.Size = new Size(292, 27);
            emailmecanico.TabIndex = 24;
            emailmecanico.TextChanged += textBox1_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(163, 292);
            label4.Name = "label4";
            label4.Size = new Size(120, 20);
            label4.TabIndex = 27;
            label4.Text = "Senha Mecânico:";
            // 
            // senhamecanico
            // 
            senhamecanico.Location = new Point(346, 289);
            senhamecanico.Name = "senhamecanico";
            senhamecanico.Size = new Size(292, 27);
            senhamecanico.TabIndex = 26;
            // 
            // cadastrar
            // 
            cadastrar.Location = new Point(646, 390);
            cadastrar.Name = "cadastrar";
            cadastrar.Size = new Size(112, 29);
            cadastrar.TabIndex = 28;
            cadastrar.Text = "cadastrar";
            cadastrar.UseVisualStyleBackColor = true;
            cadastrar.Click += button1_Click;
            // 
            // editar
            // 
            editar.Location = new Point(499, 390);
            editar.Name = "editar";
            editar.Size = new Size(94, 29);
            editar.TabIndex = 31;
            editar.Text = "editar:";
            editar.UseVisualStyleBackColor = true;
            editar.Click += editar_Click;
            // 
            // excluir
            // 
            excluir.Location = new Point(368, 392);
            excluir.Name = "excluir";
            excluir.Size = new Size(94, 29);
            excluir.TabIndex = 30;
            excluir.Text = "excluir:";
            excluir.UseVisualStyleBackColor = true;
            excluir.Click += excluir_Click;
            // 
            // button1
            // 
            button1.Location = new Point(791, 390);
            button1.Name = "button1";
            button1.Size = new Size(194, 29);
            button1.TabIndex = 34;
            button1.Text = "serviços pendentes";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(189, 392);
            button2.Name = "button2";
            button2.Size = new Size(99, 29);
            button2.TabIndex = 35;
            button2.Text = "Voltar Menu";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // CbClint
            // 
            CbClint.FormattingEnabled = true;
            CbClint.Items.AddRange(new object[] { "0" });
            CbClint.Location = new Point(921, 55);
            CbClint.Name = "CbClint";
            CbClint.Size = new Size(102, 28);
            CbClint.TabIndex = 43;
            CbClint.SelectedIndexChanged += CbClint_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(763, 55);
            label9.Name = "label9";
            label9.Size = new Size(118, 23);
            label9.TabIndex = 42;
            label9.Text = "Login rápido:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(163, 341);
            label5.Name = "label5";
            label5.Size = new Size(129, 20);
            label5.TabIndex = 32;
            label5.Text = "Código Mecânico:";
            // 
            // codmecanico
            // 
            codmecanico.Enabled = false;
            codmecanico.Location = new Point(344, 342);
            codmecanico.Name = "codmecanico";
            codmecanico.Size = new Size(298, 27);
            codmecanico.TabIndex = 33;
            // 
            // button4
            // 
            button4.Location = new Point(852, 332);
            button4.Name = "button4";
            button4.Size = new Size(133, 29);
            button4.TabIndex = 44;
            button4.Text = "Atualizar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // loginoficina
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(1333, 649);
            Controls.Add(button4);
            Controls.Add(CbClint);
            Controls.Add(label9);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(codmecanico);
            Controls.Add(label5);
            Controls.Add(editar);
            Controls.Add(excluir);
            Controls.Add(cadastrar);
            Controls.Add(label4);
            Controls.Add(senhamecanico);
            Controls.Add(label2);
            Controls.Add(emailmecanico);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(nomemecanico);
            Controls.Add(nomeoficina);
            Controls.Add(label7);
            Name = "loginoficina";
            Text = "loginoficina";
            Load += loginoficina_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        #endregion

        private Label label7;
        private Label label1;
        private Label label3;
        private TextBox nomemecanico;
        private TextBox nomeoficina;
        private Label label2;
        private TextBox emailmecanico;
        private Label label4;
        private TextBox senhamecanico;
        private Button cadastrar;
        private Button editar;
        private Button excluir;
        private Button button1;
        private Button button2;
        private ComboBox CbClint;
        private Label label9;
        private Label label5;
        private TextBox codmecanico;
        private Button button4;
    }
}