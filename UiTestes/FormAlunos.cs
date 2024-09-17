using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UiTestes.DTO;

namespace UiTestes
{
    public partial class FormAlunos : Form
    {
        public FormAlunos()
        {
            InitializeComponent();
            CarregarComboBoxAlunos();
        }

        public async Task CarregarComboBoxAlunos()
        {
            using (HttpClient client = new HttpClient())
            {
                // Definindo a BaseAddress uma vez para todas as requisições
                client.BaseAddress = new Uri("http://localhost:7069");

                // Caminho da API (relativo)
                var endpoint = "/api/alunos/BuscarAlunos";
                HttpResponseMessage response = await client.GetAsync(endpoint);

                if (response.IsSuccessStatusCode)
                {
                    // Lendo o conteúdo da resposta
                    var responseContent = await response.Content.ReadAsStringAsync();

                    // Desserializando o JSON para uma lista de AlunosDTO
                    var alunos = JsonConvert.DeserializeObject<List<AlunosDTO>>(responseContent);

                    // Processar a lista de alunos conforme necessário...
                }
                else
                {
                    // Tratar erro
                    MessageBox.Show($"Erro: {response.StatusCode}");
                }
            }
        }
    }
}
