namespace fourfit.sistema_gestao.Domain.Entities.Financas
{
    public class Investimentos
    {
        public int Id { get; set; }
        public int TipoPagamentoId { get; set; }
        public TipoPagamento TipoPagamento { get; set; }
        public int ContasBancariasId { get; set; }
        public ContasBancarias ContasBancarias { get; set; }
        public string Descricao { get; set; }
        public int ValorInvestido { get; set; }
        public DateTime DataVencimento { get; set; }
        public DateTime DataPagamento { get; set; }
        public bool Status { get; set; }
        public string Observacao { get; set; }

    }
}
