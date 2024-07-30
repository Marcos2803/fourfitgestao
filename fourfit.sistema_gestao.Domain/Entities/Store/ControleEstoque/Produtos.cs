using fourfit.sistema_gestao.Domain.Entities.Store.Venda;


namespace fourfit.sistema_gestao.Domain.Entities.Store.ControleEstoque
{
    public class Produtos
    {
        public int Id { get; set; }
        public int CategoriasId { get; set; }
        public Categorias Categorias { get; set; }
        public int EstoqueId { get; set; }
        public Estoque Estoque { get; set; }
        public string NomeProduto { get; set; }
        public decimal PrecoCusto { get; set; }
        public decimal PrecoVenda { get; set; }

        public ICollection<Vendas> Vendas { get; set; }

    }
}
