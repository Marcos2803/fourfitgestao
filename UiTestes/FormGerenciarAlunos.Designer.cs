namespace UiTestes
{
    partial class FormGerenciarAlunos
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
            gbpControles = new GroupBox();
            btnProcurar = new Button();
            txtProcurar = new TextBox();
            button1 = new Button();
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Cpf = new DataGridViewTextBoxColumn();
            PrimeiroNome = new DataGridViewTextBoxColumn();
            Celular = new DataGridViewTextBoxColumn();
            gbpControles.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // gbpControles
            // 
            gbpControles.BackColor = SystemColors.ActiveBorder;
            gbpControles.Controls.Add(btnProcurar);
            gbpControles.Controls.Add(txtProcurar);
            gbpControles.Controls.Add(button1);
            gbpControles.Dock = DockStyle.Top;
            gbpControles.Location = new Point(0, 0);
            gbpControles.Name = "gbpControles";
            gbpControles.Size = new Size(1011, 76);
            gbpControles.TabIndex = 0;
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
            // button1
            // 
            button1.Location = new Point(23, 22);
            button1.Name = "button1";
            button1.Size = new Size(109, 34);
            button1.TabIndex = 0;
            button1.Text = "Cadastro";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(15, 105);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(962, 333);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lista de Alunos";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, Cpf, PrimeiroNome, Celular });
            dataGridView1.Location = new Point(33, 34);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(893, 270);
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
            // FormGerenciarAlunos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1011, 450);
            Controls.Add(groupBox1);
            Controls.Add(gbpControles);
            Name = "FormGerenciarAlunos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormGerenciarAlunos";
            gbpControles.ResumeLayout(false);
            gbpControles.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbpControles;
        private Button button1;
        private Button btnProcurar;
        private TextBox txtProcurar;
        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Cpf;
        private DataGridViewTextBoxColumn PrimeiroNome;
        private DataGridViewTextBoxColumn Celular;
 
    }
}