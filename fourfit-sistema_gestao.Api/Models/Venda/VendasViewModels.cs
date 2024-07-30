namespace fourfit_sistema_gestao.Api.Models.Venda
{
    public class VendasViewModels
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public int ProdutosId { get; set; }
        public int PagamentosId { get; set; }
        public DateTime DataVenda { get; set; }
        public string StatusPagamentos { get; set; }
    }
}
