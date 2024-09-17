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
            grpCadastroAlunos = new GroupBox();
            lblUsuario = new Label();
            cbxAlunos = new ComboBox();
            grpCadastroAlunos.SuspendLayout();
            SuspendLayout();
            // 
            // grpCadastroAlunos
            // 
            grpCadastroAlunos.Controls.Add(cbxAlunos);
            grpCadastroAlunos.Controls.Add(lblUsuario);
            grpCadastroAlunos.Dock = DockStyle.Fill;
            grpCadastroAlunos.Location = new Point(0, 0);
            grpCadastroAlunos.Name = "grpCadastroAlunos";
            grpCadastroAlunos.Size = new Size(954, 450);
            grpCadastroAlunos.TabIndex = 0;
            grpCadastroAlunos.TabStop = false;
            grpCadastroAlunos.Text = "Cadastro de Alunos";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(29, 40);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(50, 15);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Usuário:";
            // 
            // cbxAlunos
            // 
            cbxAlunos.FormattingEnabled = true;
            cbxAlunos.Location = new Point(81, 31);
            cbxAlunos.Name = "cbxAlunos";
            cbxAlunos.Size = new Size(121, 23);
            cbxAlunos.TabIndex = 1;
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
        private Label lblUsuario;
        private ComboBox cbxAlunos;
    }
}