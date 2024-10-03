using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UiTestes
{
    public partial class FormGerenciarAlunos : Form
    {
        public FormGerenciarAlunos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAlunos formAlunos = new FormAlunos();
            formAlunos.ShowDialog();
        }
    }
}
