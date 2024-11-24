namespace telas
{
    partial class Cadastro_Tela_2_Extra

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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Banner", 22.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(304, 9);
            label1.Name = "label1";
            label1.Size = new Size(142, 53);
            label1.TabIndex = 0;
            label1.Text = "cadastro";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Small", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(280, 74);
            label2.Name = "label2";
            label2.Size = new Size(225, 21);
            label2.TabIndex = 1;
            label2.Text = "informações do proprietário:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(192, 125);
            label3.Name = "label3";
            label3.Size = new Size(121, 20);
            label3.TabIndex = 2;
            label3.Text = "Nome completo:";
            // 
            // txtnome
            // 
            txtnome.Location = new Point(381, 118);
            txtnome.Name = "txtnome";
            txtnome.Size = new Size(292, 27);
            txtnome.TabIndex = 3;
            txtnome.TextChanged += textBox1_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(192, 164);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 4;
            label4.Text = "E-mail:";
            // 
            // txtemail
            // 
            txtemail.Location = new Point(381, 164);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(292, 27);
            txtemail.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(192, 211);
            label5.Name = "label5";
            label5.Size = new Size(148, 20);
            label5.TabIndex = 6;
            label5.Text = "Telefone do Contato:";
            label5.Click += label5_Click;
            // 
            // txttelefone
            // 
            txttelefone.Location = new Point(381, 211);
            txttelefone.Name = "txttelefone";
            txttelefone.Size = new Size(292, 27);
            txttelefone.TabIndex = 7;
            // 
            // button1
            // 
            button1.BackColor = Color.OliveDrab;
            button1.Location = new Point(554, 456);
            button1.Name = "button1";
            button1.Size = new Size(328, 29);
            button1.TabIndex = 8;
            button1.Text = "clique aqui e se dirija a próxima página";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // tela_2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OliveDrab;
            ClientSize = new Size(916, 531);
            Controls.Add(button1);
            Controls.Add(txttelefone);
            Controls.Add(label5);
            Controls.Add(txtemail);
            Controls.Add(label4);
            Controls.Add(txtnome);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "tela_2";
            Text = "tela_2";
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
    }
}