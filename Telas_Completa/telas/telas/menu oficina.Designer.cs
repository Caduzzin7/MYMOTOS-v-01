namespace telas
{
    partial class menu_oficina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu_oficina));
            excluir = new Button();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            button2 = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // excluir
            // 
            excluir.BackColor = Color.Transparent;
            excluir.ForeColor = Color.Black;
            excluir.Location = new Point(44, 448);
            excluir.Name = "excluir";
            excluir.Size = new Size(138, 45);
            excluir.TabIndex = 34;
            excluir.Text = "oficina";
            excluir.UseVisualStyleBackColor = false;
            excluir.Click += excluir_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.ForeColor = Color.Black;
            button1.Location = new Point(44, 359);
            button1.Name = "button1";
            button1.Size = new Size(138, 47);
            button1.TabIndex = 38;
            button1.Text = "Cliente";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 24F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(367, 56);
            label1.Name = "label1";
            label1.Size = new Size(607, 47);
            label1.TabIndex = 39;
            label1.Text = "central de oficina MyMotos";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 24F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(511, 9);
            label2.Name = "label2";
            label2.Size = new Size(330, 47);
            label2.TabIndex = 40;
            label2.Text = "Seja Bem Vindo";
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.ForeColor = Color.Black;
            button2.Location = new Point(1112, 534);
            button2.Name = "button2";
            button2.Size = new Size(155, 51);
            button2.TabIndex = 41;
            button2.Text = "sobre nós";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Stencil", 24F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(44, 187);
            label3.Name = "label3";
            label3.Size = new Size(307, 47);
            label3.TabIndex = 42;
            label3.Text = "Quem é você ? ";
            label3.Click += label3_Click;
            // 
            // menu_oficina
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1333, 649);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(excluir);
            Controls.Add(button1);
            ForeColor = SystemColors.ControlLight;
            Name = "menu_oficina";
            Text = "menu_oficina";
            Load += menu_oficina_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button excluir;
        private Button button1;
        private Label label1;
        private Label label2;
        private Button button2;
        private Label label3;
    }
}