using fourfit.sistema_gestao.Domain.Entities.Store.Venda;

namespace fourfit_sistema_gestao.Api.Models.Venda
{
    public class VendasViewModels
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public List<VendaItens> VendaItens { get; set; } = new List<VendaItens>();
        public int PagamentosId { get; set; }
        public DateTime DataVenda { get; set; }
        public string StatusPagamentos { get; set; }
    }
}
