namespace telas
{
    partial class tela_senha_para_cadastro
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
            button1 = new Button();
            txtsenha = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(335, 300);
            button1.Name = "button1";
            button1.Size = new Size(141, 31);
            button1.TabIndex = 0;
            button1.Text = "login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtsenha
            // 
            txtsenha.Location = new Point(368, 199);
            txtsenha.Name = "txtsenha";
            txtsenha.Size = new Size(125, 27);
            txtsenha.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(90, 81);
            label1.Name = "label1";
            label1.Size = new Size(650, 37);
            label1.TabIndex = 3;
            label1.Text = "Para passar coloque a senha correta";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(233, 202);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 4;
            label2.Text = "Senha";
            label2.Click += label2_Click;
            // 
            // button2
            // 
            button2.Location = new Point(25, 407);
            button2.Name = "button2";
            button2.Size = new Size(141, 31);
            button2.TabIndex = 5;
            button2.Text = "Voltar Menu";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // tela_senha_para_cadastro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cornsilk;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtsenha);
            Controls.Add(button1);
            Name = "tela_senha_para_cadastro";
            Text = "tela_senha_para_cadastro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox txtsenha;
        private Label label1;
        private Label label2;
        private Button button2;
    }
}