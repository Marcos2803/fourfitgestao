using Microsoft.AspNetCore.Identity;
using fourfit.sistema_gestao.Domain.Entities.Alunos;
namespace fourfit.sistema_gestao.Domain.Entities.Account
{
    public class User:IdentityUser
    {
        public string NomeCompleto { get; set; }
        public long Cpf { get; set; }
        public string ?Celular { get; set; }
        public string ?Cep { get; set; }
        public string? Endereco { get; set; }
        public int ?Numero  { get; set; }
        public string ?Bairro { get; set; }
        public string ? Cidade { get; set; }
        public string ? Estado { get; set; }
        public DateTime DataNacimento { get; set; }
        public string? Genero { get; set; }

        public ICollection<EntidadeAlunos> Alunos { get; set; }
        

    }
}
