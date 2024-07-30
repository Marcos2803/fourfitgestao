using fourfit.sistema_gestao.Domain.Entities.Financas;

namespace fourfit.sistema_gestao.Domain.Entities.Store.Venda
{
    public class Pagamentos
    {
        public int Id { get; set; }
        public int TipoPagamentoPcId { get; set; }
        public TipoPagamentoPc TipoPagamentoPc { get; set; }
        public int ContasBancariasId { get; set; }
        public ContasBancarias ContasBancarias { get; set; }
        public DateTime? DataPagamento { get; set; }
        public decimal ValorVenda { get; set; }
        public decimal? Desconto { get; set; }
        public decimal ValorComDesconto { get; set; }
        public decimal ValorPago { get; set; }
        public decimal Troco { get; set; }
        public string StatusPagamentos { get; set; }

        public ICollection<Vendas> Vendas { get; set; }
    }
}
