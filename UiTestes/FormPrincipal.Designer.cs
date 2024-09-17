namespace UiTestes
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlNavBar = new Panel();
            pnlSidbar = new Panel();
            btnAlunos = new FontAwesome.Sharp.IconButton();
            pnlSidbar.SuspendLayout();
            SuspendLayout();
            // 
            // pnlNavBar
            // 
            pnlNavBar.BackColor = Color.FromArgb(0, 64, 64);
            pnlNavBar.Dock = DockStyle.Top;
            pnlNavBar.Location = new Point(0, 0);
            pnlNavBar.Name = "pnlNavBar";
            pnlNavBar.Size = new Size(929, 50);
            pnlNavBar.TabIndex = 0;
            // 
            // pnlSidbar
            // 
            pnlSidbar.BackColor = Color.FromArgb(0, 64, 64);
            pnlSidbar.Controls.Add(btnAlunos);
            pnlSidbar.Dock = DockStyle.Left;
            pnlSidbar.Location = new Point(0, 50);
            pnlSidbar.Name = "pnlSidbar";
            pnlSidbar.Size = new Size(165, 400);
            pnlSidbar.TabIndex = 1;
            // 
            // btnAlunos
            // 
            btnAlunos.AutoSize = true;
            btnAlunos.FlatStyle = FlatStyle.Flat;
            btnAlunos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAlunos.ForeColor = Color.White;
            btnAlunos.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnAlunos.IconColor = Color.White;
            btnAlunos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAlunos.IconSize = 30;
            btnAlunos.ImageAlign = ContentAlignment.MiddleLeft;
            btnAlunos.Location = new Point(12, 23);
            btnAlunos.Name = "btnAlunos";
            btnAlunos.Size = new Size(101, 42);
            btnAlunos.TabIndex = 1;
            btnAlunos.Text = "Alunos";
            btnAlunos.TextAlign = ContentAlignment.MiddleRight;
            btnAlunos.UseVisualStyleBackColor = true;
            btnAlunos.Click += btnAlunos_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(929, 450);
            Controls.Add(pnlSidbar);
            Controls.Add(pnlNavBar);
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            WindowState = FormWindowState.Maximized;
            pnlSidbar.ResumeLayout(false);
            pnlSidbar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlNavBar;
        private Panel pnlSidbar;
        private FontAwesome.Sharp.IconButton btnAlunos;
    }
}
