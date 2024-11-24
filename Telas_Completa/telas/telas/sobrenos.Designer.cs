namespace telas
{
    partial class sobrenos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sobrenos));
            label8 = new Label();
            button2 = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label2 = new Label();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Sitka Small", 40F, FontStyle.Italic);
            label8.Location = new Point(197, 9);
            label8.Name = "label8";
            label8.Size = new Size(384, 97);
            label8.TabIndex = 44;
            label8.Text = "Sobre nós ";
            label8.Click += label8_Click_1;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.ForeColor = Color.Black;
            button2.Location = new Point(12, 872);
            button2.Name = "button2";
            button2.Size = new Size(364, 149);
            button2.TabIndex = 42;
            button2.Text = "Voltar Menu";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(label2);
            flowLayoutPanel1.Location = new Point(55, 134);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1254, 362);
            flowLayoutPanel1.TabIndex = 44;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // label2
            // 
            label2.AutoEllipsis = true;
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Font = new Font("Segoe UI", 22F);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(1236, 350);
            label2.TabIndex = 0;
            label2.Text = resources.GetString("label2.Text");
            label2.Click += label2_Click_1;
            // 
            // sobrenos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Imagem_moto_1234;
            ClientSize = new Size(1333, 649);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(button2);
            Controls.Add(label8);
            Name = "sobrenos";
            Text = "sobrenos";
            Load += sobrenos_Load;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label8;
        private Button button2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label2;
    }
}