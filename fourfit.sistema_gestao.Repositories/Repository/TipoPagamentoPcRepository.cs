using fourfit.sistema_gestao.Context;
using fourfit.sistema_gestao.Domain.Entities.Alunos;
using fourfit.sistema_gestao.Domain.Interfaces;
using fourfit.sistema_gestao.Repositories.Repository.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fourfit.sistema_gestao.Repositories.Repository
{
    public class TipoPagamentoPcRepository : BaseRepository<TipoPagamentoPc>, ITipoPagamentoPcServices
    {
        public TipoPagamentoPcRepository(DataContext dataContext) : base(dataContext)
        {
            
        }
    }
}
