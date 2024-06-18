using fourfit.sistema_gestao.Domain.Entities.Account;
using System.ComponentModel.DataAnnotations;

namespace fourfit_sistema_gestao.UI.Models.Alunos
{
    public class AlunosViewModel
    {
        public int Id { get; set; }
        public byte[]? Foto { get; set; }
        public string NomeCompleto { get; set; }
        public string? UserId { get; set; }
        public bool Ativo { get; set; }
        public int TipoPlanoId { get; set; }
        public int TipoPagamentoId { get; set; }

    }
}
