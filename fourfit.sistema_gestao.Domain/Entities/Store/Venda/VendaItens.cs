﻿

using fourfit.sistema_gestao.Domain.Entities.Store.ControleEstoque;

namespace fourfit.sistema_gestao.Domain.Entities.Store.Venda
{
    public class VendaItens
    {
        public int Id { get; set; }
        public int ProdutosId { get; set; }
        public Produtos Produtos { get; set; }
        public int Quantidade { get; set; }

        public ICollection<Vendas> Vendas { get; set; }
    }
}
