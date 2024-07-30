using fourfit.sistema_gestao.Domain.Entities.Account;
using fourfit.sistema_gestao.Domain.Entities.Store.ControleEstoque;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fourfit.sistema_gestao.Domain.Entities.Store.Venda
{
    public class Vendas
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
        public int ProdutosId { get; set; }
        public Produtos Produtos { get; set; }
        public int PagamentosId { get; set; }
        public Pagamentos Pagamentos { get; set; }
        public DateTime DataVenda { get; set; }
        public string StatusPagamentos { get; set; }
    }
}
