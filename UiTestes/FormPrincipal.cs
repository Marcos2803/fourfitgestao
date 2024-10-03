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
           CarregarUsuarios();
        }

        private async void btnAlunos_Click(object sender, EventArgs e)
        {
            FormGerenciarAlunos formAlunos = new FormGerenciarAlunos();
            formAlunos.ShowDialog();
        }

        public async Task CarregarUsuarios()
        {

            try
            {
                var handler = new HttpClientHandler()
                {
                    ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; }
                };
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri("https://localhost:7069");
                    var endpoint = "/api/Alunos/BuscarUsuarios";
                    using (var response = await client.GetAsync(endpoint))
                    {
                        if (response.IsSuccessStatusCode)
                        {
                            var content = await response.Content.ReadAsStringAsync();

                            var usuarios = JsonSerializer.Deserialize<List<UserDTO>>(content);
                            //dataGridUsuarios.AutoGenerateColumns = false;
                            //dataGridUsuarios.DataSource = usuarios.ToList();
                            var usuariosComNomeCompleto = usuarios.Select(u => new
                            {
                                u.id,
                                NomeCompleto = $"{u.primeiroNome} {u.sobreNome}"
                            }).ToList();

                            cbxAlunos.DataSource = usuariosComNomeCompleto; ;
                            cbxAlunos.ValueMember = "id";
                            cbxAlunos.DisplayMember = "NomeCompleto";
                            cbxAlunos.Text = "--Escolha--";

                        }
                        else
                        {
                            throw new Exception("Não foi possível obter os usuários: " + response.StatusCode);
                        }
                    }

                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}