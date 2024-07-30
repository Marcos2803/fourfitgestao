using fourfit.sistema_gestao.Domain.Entities.Store.Venda;
using fourfit.sistema_gestao.Domain.Interfaces.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fourfit.sistema_gestao.Domain.Interfaces
{
    public interface IPagamentosServices :IBaseServices<Pagamentos>
    {
        Task<IEnumerable<Pagamentos>> ObterPagamentosExistentes();

        Task<Pagamentos> ObterPagamentosPorId(int Id);
    }
}
