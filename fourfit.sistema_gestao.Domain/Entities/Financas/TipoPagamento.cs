using fourfit.sistema_gestao.Domain.Entities.Alunos;

namespace fourfit.sistema_gestao.Domain.Entities.Financas
{
    public class TipoPagamento
    {
        public int Id { get; set; }
        public int TipoPagamentoPcId { get; set; }
        public TipoPagamentoPc TipoPagamentoPc { get; set; }
        public virtual ICollection<Mensalidades> Mensalidades { get; set; }
        public virtual ICollection<Despesas> Despesas { get; set; }
        public virtual ICollection<Investimentos> Investimentos { get; set; }
    }
}