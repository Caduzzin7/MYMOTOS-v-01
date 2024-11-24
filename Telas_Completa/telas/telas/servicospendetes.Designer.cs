namespace telas
{
    partial class servicospendetes
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
            dataGridView1 = new DataGridView();
            excluir = new Button();
            deletar = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            clintmoto = new Label();
            clintname = new Label();
            serv_Pend = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(57, 27);
            label1.Name = "label1";
            label1.Size = new Size(381, 37);
            label1.TabIndex = 0;
            label1.Text = "Serviços Disponiveis:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(57, 199);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(795, 283);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.Click += dataGridView1_Click;
            // 
            // excluir
            // 
            excluir.Location = new Point(40, 508);
            excluir.Name = "excluir";
            excluir.Size = new Size(237, 67);
            excluir.TabIndex = 31;
            excluir.Text = "Voltar Menu";
            excluir.UseVisualStyleBackColor = true;
            excluir.Click += excluir_Click;
            // 
            // deletar
            // 
            deletar.Location = new Point(614, 508);
            deletar.Name = "deletar";
            deletar.Size = new Size(238, 67);
            deletar.TabIndex = 32;
            deletar.Text = "Pegar serviço";
            deletar.UseVisualStyleBackColor = true;
            deletar.Visible = false;
            deletar.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold);
            label2.Location = new Point(858, 114);
            label2.Name = "label2";
            label2.Size = new Size(237, 37);
            label2.TabIndex = 33;
            label2.Text = "Nome Cliente";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold);
            label3.Location = new Point(858, 165);
            label3.Name = "label3";
            label3.Size = new Size(240, 37);
            label3.TabIndex = 34;
            label3.Text = "Moto Cliente";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold);
            label4.Location = new Point(858, 213);
            label4.Name = "label4";
            label4.Size = new Size(315, 37);
            label4.TabIndex = 35;
            label4.Text = "Serviço Pendente";
            // 
            // clintmoto
            // 
            clintmoto.AutoSize = true;
            clintmoto.Location = new Point(1104, 182);
            clintmoto.Name = "clintmoto";
            clintmoto.Size = new Size(50, 20);
            clintmoto.TabIndex = 37;
            clintmoto.Text = "label6";
            clintmoto.Click += clintmoto_Click;
            // 
            // clintname
            // 
            clintname.AutoSize = true;
            clintname.Location = new Point(1104, 128);
            clintname.Name = "clintname";
            clintname.Size = new Size(50, 20);
            clintname.TabIndex = 36;
            clintname.Text = "label7";
            // 
            // serv_Pend
            // 
            serv_Pend.AutoSize = true;
            serv_Pend.Location = new Point(1179, 228);
            serv_Pend.Name = "serv_Pend";
            serv_Pend.Size = new Size(50, 20);
            serv_Pend.TabIndex = 38;
            serv_Pend.Text = "label5";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(57, 128);
            label5.Name = "label5";
            label5.Size = new Size(548, 23);
            label5.TabIndex = 39;
            label5.Text = "Selecione o serviço desejado clicando na primeira coluna da tabela:";
            // 
            // servicospendetes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1333, 649);
            Controls.Add(label5);
            Controls.Add(serv_Pend);
            Controls.Add(clintmoto);
            Controls.Add(clintname);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(deletar);
            Controls.Add(excluir);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "servicospendetes";
            Text = "servicospendetes";
            Load += servicospendetes_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Button excluir;
        private Button deletar;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label clintmoto;
        private Label clintname;
        private Label serv_Pend;
        private Label label5;
    }
}