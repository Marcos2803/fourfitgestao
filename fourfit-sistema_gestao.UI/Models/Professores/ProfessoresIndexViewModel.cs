using fourfit.sistema_gestao.Domain.Entities.Account;

namespace fourfit_sistema_gestao.UI.Models.Professores
{
    public class ProfessoresIndexViewModel
    {
        public int Id { get; set; }
        public string? UserId { get; set; }
        public string? NomeCompleto { get; set; }
        public int? Cpf { get; set; }
        public int? Cref { get; set; }
        public string? Especialidade { get; set; }
        public bool Ativo { get; set; }
        public byte[]? Foto { get; set; }
        public string? Observaçães { get; set; }
    }
}
