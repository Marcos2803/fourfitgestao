

namespace fourfit.sistema_gestao.Domain.Entities.Store.ControleEstoque
{
    public class Produtos
    {
        public int Id { get; set; }
        public int CategoriasId { get; set; }
        public Categorias Categorias { get; set; }
        public int ControleEstoqueId { get; set; }
        public ControleEstoque ControleEstoque { get; set; }
        public string Nome { get; set; }
        public decimal PrecoCusto { get; set; }
        public decimal PrecoVenda { get; set; }

    }
}
