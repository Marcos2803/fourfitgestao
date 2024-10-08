namespace UiTestes
{
    partial class FormGerenciarMensalidades
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
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Cpf = new DataGridViewTextBoxColumn();
            PrimeiroNome = new DataGridViewTextBoxColumn();
            Celular = new DataGridViewTextBoxColumn();
            gbpControles = new GroupBox();
            btnProcurar = new Button();
            txtProcurar = new TextBox();
            btnMensalidade = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            gbpControles.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(12, 119);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(962, 333);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lista de Mensalidades";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, Cpf, PrimeiroNome, Celular });
            dataGridView1.Location = new Point(33, 34);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1655, 503);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.Visible = false;
            // 
            // Cpf
            // 
            Cpf.DataPropertyName = "Cpf";
            Cpf.HeaderText = "CPF";
            Cpf.Name = "Cpf";
            // 
            // PrimeiroNome
            // 
            PrimeiroNome.DataPropertyName = "PrimeiroNome";
            PrimeiroNome.HeaderText = "Nome";
            PrimeiroNome.Name = "PrimeiroNome";
            // 
            // Celular
            // 
            Celular.DataPropertyName = "Celular";
            Celular.HeaderText = "Celular";
            Celular.Name = "Celular";
            // 
            // gbpControles
            // 
            gbpControles.BackColor = SystemColors.ActiveBorder;
            gbpControles.Controls.Add(btnProcurar);
            gbpControles.Controls.Add(txtProcurar);
            gbpControles.Controls.Add(btnMensalidade);
            gbpControles.Dock = DockStyle.Top;
            gbpControles.Location = new Point(0, 0);
            gbpControles.Name = "gbpControles";
            gbpControles.Size = new Size(1031, 76);
            gbpControles.TabIndex = 2;
            gbpControles.TabStop = false;
            gbpControles.Text = "Controles";
            // 
            // btnProcurar
            // 
            btnProcurar.Location = new Point(889, 22);
            btnProcurar.Name = "btnProcurar";
            btnProcurar.Size = new Size(109, 34);
            btnProcurar.TabIndex = 2;
            btnProcurar.Text = "Procurar";
            btnProcurar.UseVisualStyleBackColor = true;
            // 
            // txtProcurar
            // 
            txtProcurar.Location = new Point(616, 28);
            txtProcurar.Name = "txtProcurar";
            txtProcurar.Size = new Size(266, 23);
            txtProcurar.TabIndex = 1;
            // 
            // btnMensalidade
            // 
            btnMensalidade.Location = new Point(23, 22);
            btnMensalidade.Name = "btnMensalidade";
            btnMensalidade.Size = new Size(109, 34);
            btnMensalidade.TabIndex = 0;
            btnMensalidade.Text = "Cadastro";
            btnMensalidade.UseVisualStyleBackColor = true;
            btnMensalidade.Click += button1_Click;
            // 
            // FormGerenciarMensalidades
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1031, 492);
            Controls.Add(groupBox1);
            Controls.Add(gbpControles);
            Name = "FormGerenciarMensalidades";
            Text = "FormGerenciarMensalidades";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            gbpControles.ResumeLayout(false);
            gbpControles.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Cpf;
        private DataGridViewTextBoxColumn PrimeiroNome;
        private DataGridViewTextBoxColumn Celular;
        private GroupBox gbpControles;
        private Button btnProcurar;
        private TextBox txtProcurar;
        private Button btnMensalidade;
    }
}