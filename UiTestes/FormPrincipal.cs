using System.Linq.Expressions;
using System.Text.Json;
using UiTestes.DTO;

namespace UiTestes
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();

        }

        private async void btnAlunos_Click(object sender, EventArgs e)
        {
            FormGerenciarAlunos formAlunos = new FormGerenciarAlunos();
            formAlunos.ShowDialog();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnMensalidades_Click(object sender, EventArgs e)
        {
            FormGerenciarMensalidades formMensalidades = new FormGerenciarMensalidades();
            formMensalidades.ShowDialog();

        }
    }
}