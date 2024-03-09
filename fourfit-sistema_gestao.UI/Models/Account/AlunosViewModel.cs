using fourfit.sistema_gestao.Domain.Entities.Account;
using System.ComponentModel.DataAnnotations;

namespace fourfit_sistema_gestao.UI.Models.Account
{
    public class AlunosViewModel
    {
        public int Id { get; set; }
        public string? UserId { get; set; }
        [Display(Name ="Data Inicial")]
        public DateTime DataInicio { get; set; }
        [Display(Name = "Data Final")]
        public DateTime DataFim { get; set; }
        public bool Ativo { get; set; }
        public int TipoPlanoId { get; set; }
        public int TipoPagamentoId { get; set; }
        public byte[]? Foto { get; set; }
    }
}
