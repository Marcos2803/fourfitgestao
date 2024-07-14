namespace fourfit.sistema_gestao.Domain.Entities.Store.ControleEstoque
{
    public class ControleEstoque
    {
        public int Id { get; set; }
        public int QuantidadeEstoque { get; set; }
        public int EstoqueMinimo { get; set; }

        public virtual ICollection<Produtos> Produtos { get; set; }


    }
}
