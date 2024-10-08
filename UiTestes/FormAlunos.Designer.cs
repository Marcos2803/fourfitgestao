namespace UiTestes
{
    partial class FormAlunos
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
            components = new System.ComponentModel.Container();
            grpCadastroAlunos = new GroupBox();
            lblUf = new Label();
            txtUf = new TextBox();
            btnCadastrar = new Button();
            lblUsuarios = new Label();
            cbxUsuarios = new ComboBox();
            lblDataNasc = new Label();
            txtDataNasc = new TextBox();
            lblCep = new Label();
            txtCep = new TextBox();
            lblCidade = new Label();
            txtCidade = new TextBox();
            lblBairro = new Label();
            txtBairro = new TextBox();
            lblNumero = new Label();
            txtNumero = new TextBox();
            txtEndereco = new TextBox();
            lblEndereco = new Label();
            txtCelular = new TextBox();
            lblCelular = new Label();
            txtCpf = new TextBox();
            lblCpf = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            grpCadastroAlunos.SuspendLayout();
            SuspendLayout();
            // 
            // grpCadastroAlunos
            // 
            grpCadastroAlunos.Controls.Add(lblUf);
            grpCadastroAlunos.Controls.Add(txtUf);
            grpCadastroAlunos.Controls.Add(btnCadastrar);
            grpCadastroAlunos.Controls.Add(lblUsuarios);
            grpCadastroAlunos.Controls.Add(cbxUsuarios);
            grpCadastroAlunos.Controls.Add(lblDataNasc);
            grpCadastroAlunos.Controls.Add(txtDataNasc);
            grpCadastroAlunos.Controls.Add(lblCep);
            grpCadastroAlunos.Controls.Add(txtCep);
            grpCadastroAlunos.Controls.Add(lblCidade);
            grpCadastroAlunos.Controls.Add(txtCidade);
            grpCadastroAlunos.Controls.Add(lblBairro);
            grpCadastroAlunos.Controls.Add(txtBairro);
            grpCadastroAlunos.Controls.Add(lblNumero);
            grpCadastroAlunos.Controls.Add(txtNumero);
            grpCadastroAlunos.Controls.Add(txtEndereco);
            grpCadastroAlunos.Controls.Add(lblEndereco);
            grpCadastroAlunos.Controls.Add(txtCelular);
            grpCadastroAlunos.Controls.Add(lblCelular);
            grpCadastroAlunos.Controls.Add(txtCpf);
            grpCadastroAlunos.Controls.Add(lblCpf);
            grpCadastroAlunos.Dock = DockStyle.Fill;
            grpCadastroAlunos.Location = new Point(0, 0);
            grpCadastroAlunos.Name = "grpCadastroAlunos";
            grpCadastroAlunos.Size = new Size(954, 450);
            grpCadastroAlunos.TabIndex = 0;
            grpCadastroAlunos.TabStop = false;
            grpCadastroAlunos.Text = "Cadastro de Alunos";
            grpCadastroAlunos.Enter += grpCadastroAlunos_Enter;
            // 
            // lblUf
            // 
            lblUf.AutoSize = true;
            lblUf.Location = new Point(683, 173);
            lblUf.Name = "lblUf";
            lblUf.Size = new Size(19, 15);
            lblUf.TabIndex = 20;
            lblUf.Text = "Uf";
            // 
            // txtUf
            // 
            txtUf.CharacterCasing = CharacterCasing.Lower;
            txtUf.Location = new Point(717, 169);
            txtUf.Name = "txtUf";
            txtUf.Size = new Size(162, 23);
            txtUf.TabIndex = 19;
            txtUf.TextChanged += textUf_TextChanged;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(100, 231);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(223, 54);
            btnCadastrar.TabIndex = 18;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            btnCadastrar.MouseCaptureChanged += btnCadastrar_Click;
            // 
            // lblUsuarios
            // 
            lblUsuarios.AutoSize = true;
            lblUsuarios.Location = new Point(238, 182);
            lblUsuarios.Name = "lblUsuarios";
            lblUsuarios.Size = new Size(47, 15);
            lblUsuarios.TabIndex = 17;
            lblUsuarios.Text = "Usuário";
            // 
            // cbxUsuarios
            // 
            cbxUsuarios.FormattingEnabled = true;
            cbxUsuarios.Location = new Point(291, 173);
            cbxUsuarios.Name = "cbxUsuarios";
            cbxUsuarios.Size = new Size(121, 23);
            cbxUsuarios.TabIndex = 16;
            // 
            // lblDataNasc
            // 
            lblDataNasc.AutoSize = true;
            lblDataNasc.Location = new Point(37, 181);
            lblDataNasc.Name = "lblDataNasc";
            lblDataNasc.Size = new Size(60, 15);
            lblDataNasc.TabIndex = 15;
            lblDataNasc.Text = "Data Nasc";
            // 
            // txtDataNasc
            // 
            txtDataNasc.CharacterCasing = CharacterCasing.Lower;
            txtDataNasc.Location = new Point(100, 174);
            txtDataNasc.Name = "txtDataNasc";
            txtDataNasc.Size = new Size(126, 23);
            txtDataNasc.TabIndex = 14;
            // 
            // lblCep
            // 
            lblCep.AutoSize = true;
            lblCep.Location = new Point(426, 177);
            lblCep.Name = "lblCep";
            lblCep.Size = new Size(28, 15);
            lblCep.TabIndex = 13;
            lblCep.Text = "Cep";
            // 
            // txtCep
            // 
            txtCep.CharacterCasing = CharacterCasing.Lower;
            txtCep.Location = new Point(475, 177);
            txtCep.Name = "txtCep";
            txtCep.Size = new Size(162, 23);
            txtCep.TabIndex = 12;
            // 
            // lblCidade
            // 
            lblCidade.AutoSize = true;
            lblCidade.Location = new Point(568, 118);
            lblCidade.Name = "lblCidade";
            lblCidade.Size = new Size(44, 15);
            lblCidade.TabIndex = 11;
            lblCidade.Text = "Cidade";
            // 
            // txtCidade
            // 
            txtCidade.CharacterCasing = CharacterCasing.Lower;
            txtCidade.Location = new Point(618, 114);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(226, 23);
            txtCidade.TabIndex = 10;
            // 
            // lblBairro
            // 
            lblBairro.AutoSize = true;
            lblBairro.Location = new Point(196, 119);
            lblBairro.Name = "lblBairro";
            lblBairro.Size = new Size(38, 15);
            lblBairro.TabIndex = 9;
            lblBairro.Text = "Bairro";
            // 
            // txtBairro
            // 
            txtBairro.CharacterCasing = CharacterCasing.Lower;
            txtBairro.Location = new Point(236, 116);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(326, 23);
            txtBairro.TabIndex = 8;
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(37, 114);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(21, 15);
            lblNumero.TabIndex = 7;
            lblNumero.Text = "N°";
            // 
            // txtNumero
            // 
            txtNumero.CharacterCasing = CharacterCasing.Lower;
            txtNumero.Location = new Point(61, 111);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(126, 23);
            txtNumero.TabIndex = 6;
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(460, 38);
            txtEndereco.Multiline = true;
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(371, 23);
            txtEndereco.TabIndex = 5;
            // 
            // lblEndereco
            // 
            lblEndereco.AutoSize = true;
            lblEndereco.Location = new Point(398, 42);
            lblEndereco.Name = "lblEndereco";
            lblEndereco.Size = new Size(56, 15);
            lblEndereco.TabIndex = 4;
            lblEndereco.Text = "Endereco";
            // 
            // txtCelular
            // 
            txtCelular.Location = new Point(236, 38);
            txtCelular.Name = "txtCelular";
            txtCelular.Size = new Size(156, 23);
            txtCelular.TabIndex = 3;
            // 
            // lblCelular
            // 
            lblCelular.AutoSize = true;
            lblCelular.Location = new Point(190, 43);
            lblCelular.Name = "lblCelular";
            lblCelular.Size = new Size(44, 15);
            lblCelular.TabIndex = 2;
            lblCelular.Text = "Celular";
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(61, 38);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(126, 23);
            txtCpf.TabIndex = 1;
            // 
            // lblCpf
            // 
            lblCpf.AutoSize = true;
            lblCpf.Location = new Point(30, 42);
            lblCpf.Name = "lblCpf";
            lblCpf.Size = new Size(28, 15);
            lblCpf.TabIndex = 0;
            lblCpf.Text = "CPF";
            // 
            // FormAlunos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(954, 450);
            Controls.Add(grpCadastroAlunos);
            Name = "FormAlunos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAlunos";
            grpCadastroAlunos.ResumeLayout(false);
            grpCadastroAlunos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpCadastroAlunos;
        private Label lblCpf;
        private TextBox txtCpf;
        private Label lblCelular;
        private TextBox txtCelular;
        private TextBox txtEndereco;
        private Label lblEndereco;
        private TextBox txtNumero;
        private Label lblNumero;
        private Label lblBairro;
        private TextBox txtBairro;
        private Label lblCidade;
        private TextBox txtCidade;
        private Label lblUf;
        private TextBox txtUF;
        private Label lblDataNasc;
        private TextBox txtDataNasc;
        private Label lblUsuarios;
        private ComboBox cbxUsuarios;
        private Button btnCadastrar;
        private Label lblCep;
        private TextBox txtCep;
        private System.Windows.Forms.Timer timer1;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox1;
        private TextBox txtUf;
    }
}