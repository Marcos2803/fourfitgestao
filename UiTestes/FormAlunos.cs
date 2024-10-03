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

                            var usuariosComNomeCompleto = usuarios.Select(u => new
                            {
                                u.id,
                                NomeCompleto = $"{u.primeiroNome} {u.sobreNome}"
                            }).ToList();

                            cbxUsuarios.DataSource = usuariosComNomeCompleto;
                            cbxUsuarios.ValueMember = "id";
                            cbxUsuarios.DisplayMember = "NomeCompleto";
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
                var endpoint = "/api/Alunos/Register";
                client.BaseAddress = new Uri($"https://localhost:7069");
                var url = $"https://localhost:7069{endpoint}";

                var usuarioSelecionado = cbxUsuarios.SelectedItem as UserDTO;

                if (usuarioSelecionado == null)
                {
                    MessageBox.Show("Usuário não encontrado");
                    return;
                }
                var aluno = new CadastroAlunosDTO
                {
                    UserId = usuarioSelecionado.id,
                    Cpf = txtCpf.Text,
                    Celular = txtCelular.Text,
                    Cep = txtCep.Text,
                    Endereco = txtEndereco.Text,
                    Numero = int.Parse(txtNumero.Text),
                    Bairro = txtBairro.Text,
                    Cidade = txtCidade.Text,
                    Estado = txtUf.Text,
                    Foto = null,
                    DataNacimento = txtDataNasc.Text
                };

                var jsonContent = JsonSerializer.Serialize(aluno);
                var contentString = new StringContent(jsonContent, Encoding.UTF8, "application/json");
                using (var response = await client.PostAsync(endpoint, contentString))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Aluno cadastrado com sucesso!");
                        LimparCampos();
                    }
                    else
                    {
                        throw new Exception("Erro ao cadastra o aluno: " + response.StatusCode);
                    }
                }


            }
        }


        private void txtEndereco_TextChanged(object sender, EventArgs e)
        {

        }

        private void textUf_TextChanged(object sender, EventArgs e)
        {

        }

        public void LimparCampos()
        {
            txtCpf.Text = string.Empty;
            txtCelular.Text = string.Empty;
            txtCep.Text = string.Empty;
            txtEndereco.Text = string.Empty;
            txtNumero.Text = string.Empty;
            txtBairro.Text = string.Empty;
            txtCidade.Text = string.Empty;
            txtUf.Text = string.Empty;
            txtDataNasc.Text = string.Empty;

        }
    }
}

