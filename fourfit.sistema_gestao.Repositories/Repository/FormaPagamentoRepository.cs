using fourfit.sistema_gestao.Context;
using fourfit.sistema_gestao.Domain.Entities.Financas;
using fourfit.sistema_gestao.Domain.Interfaces;
using fourfit.sistema_gestao.Repositories.Repository.Base;


namespace fourfit.sistema_gestao.Repositories.Repository
{
    public class FormaPagamentoRepository : BaseRepository<FormaPagamento>, IFormaPagamentoServices
    {
        public FormaPagamentoRepository(DataContext dataContext) : base(dataContext)
        {
            
        }
    }
}
