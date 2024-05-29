using fourfit.sistema_gestao.Domain.Entities.Account;

namespace fourfit_sistema_gestao.UI.Models.Colaboradores
{
    public class ColaboradoresViewModel
    {
        public int Id { get; set; }
        public string? UserId { get; set; }
        public string? NomeCompleto { get; set; }
        public long Cpf { get; set; }
        public bool Ativo { get; set; }
        public byte[]? Foto { get; set; }
        public string? Observacaes { get; set; }
    }
}
