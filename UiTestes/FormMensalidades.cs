
using System.Text.Json;
using UiTestes.DTO;

namespace UiTestes
{
    public partial class FormMensalidades : Form
    {
        public FormMensalidades()
        {
            InitializeComponent();
            CarregarAlunosPendente();
        }

        public async Task CarregarAlunosPendente()
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
                    var endpoint = "/api/Mensalidades/BuscarAlunosMensalidades";
                    using (var response = await client.GetAsync(endpoint))
                    {
                        if (response.IsSuccessStatusCode)
                        {
                            var content = await response.Content.ReadAsStringAsync();

                            var usuarios = JsonSerializer.Deserialize<List<UserDTO>>(content);

                            var usuariosComNomeCompleto = usuarios.Select(u => new
                            {
                                u.id,
                                NomeCompleto = $"{u.primeiroNome} {u.sobreNome}"
                            }).ToList();

                            cbxAlunos.DataSource = usuariosComNomeCompleto;
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

        private void FormMensalidades_Load(object sender, EventArgs e)
        {

        }

        private void cbxAlunos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
