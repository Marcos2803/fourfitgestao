namespace fourfit.sistema_gestao.Domain.Entities.Financas
{
    public class TipoPagamentoPc
    {
        public int Id { get; set; }
        public string Tipo { get; set; }
        public virtual ICollection<TipoPagamento> TipoPagamento { get; set; }
    }
}