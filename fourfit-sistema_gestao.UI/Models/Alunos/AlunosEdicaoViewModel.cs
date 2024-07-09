using System.Security.Permissions;

namespace fourfit_sistema_gestao.UI.Models.Alunos
{
    public class AlunosEdicaoViewModel
    {
        public int Id { get; set; }
        public string PrimeiroNome { get; set; }
        public string Cpf { get; set; }
        public string? Celular { get; set; }
        public string? Cep { get; set; }
        public string? Endereco { get; set; }
        public int? Numero { get; set; }
        public string? Bairro { get; set; }
        public string? Cidade { get; set; }
        public string? Estado { get; set; }
        public DateTime DataNacimento { get; set; }
        public string? Genero { get; set; }


    }
}
