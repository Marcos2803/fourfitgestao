using fourfit.sistema_gestao.Context;
using fourfit.sistema_gestao.Domain.Entities;
using fourfit.sistema_gestao.Domain.Interfaces;
using fourfit.sistema_gestao.Repositories.Repository.Base;

namespace fourfit.sistema_gestao.Repositories.Repository
{
    public class TipoPlanoRepository : BaseRepository<TipoPlano>, ITipoPlanoServices
    {
        public TipoPlanoRepository(DataContext dataContext) : base(dataContext)
        {
        }
    }
}
