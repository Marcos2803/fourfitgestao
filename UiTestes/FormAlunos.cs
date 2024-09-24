using System.Text;
using System.Text.Json;
using UiTestes.DTO;

namespace UiTestes
{
    public partial class FormAlunos : Form
    {
        public FormAlunos()
        {
            InitializeComponent();
            CarregarUsuarios();
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

                            cbxUsuarios.DataSource = usuarios.ToList(); ;
                            cbxUsuarios.ValueMember = "id";
                            cbxUsuarios.DisplayMember = "primeiroNome";
                            cbxUsuarios.Text = "--Escolha--";

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

        private void grpCadastroAlunos_Enter(object sender, EventArgs e)
        {

        }

        private async void btnCadastrar_Click(object sender, EventArgs e)
        {
            using (HttpClient client = new HttpClient())
            {
                var endpoint = "/api/Auth/Cadastrar";
                client.BaseAddress = new Uri($"http://localhost:5187");
                var url = $"http://localhost:5187{endpoint}";
                var user = new UserDTO
                {
                    primeiroNome = txtCpf.Text,
                    //email = txtEmail.Text,
                    //userName = txtEmail.Text,
                    //emailConfirmed = true,

                };
                var jsonContent = JsonSerializer.Serialize(user);
                var contentString = new StringContent(jsonContent, Encoding.UTF8, "application/json");
                using (var response = await client.PostAsync(endpoint, contentString))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Usuário criado com sucesso!");
                    }
                    else
                    {
                        throw new Exception("Erro ao criar o usuário: " + response.StatusCode);
                    }
                }

            }
        }

        private void txtEndereco_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

