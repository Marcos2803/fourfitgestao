using fourfit.sistema_gestao.Context;
using fourfit.sistema_gestao.Domain.Entities.Alunos;
using fourfit.sistema_gestao.Domain.Interfaces;
using fourfit.sistema_gestao.Repositories.Repository.Base;

namespace fourfit.sistema_gestao.Repositories.Repository.Alunos
{
    public class TipoPlanoRepository : BaseRepository<TipoPlano>, ITipoPlanoServices
    {
        private readonly DataContext _dataContext;
        public TipoPlanoRepository(DataContext dataContext) : base(dataContext)
        {
            _dataContext = dataContext;
        }
        public Task<IEnumerable<TipoPlano>> ObterPlanosExistentes()
        {
            throw new NotImplementedException();
        }

        public async Task<TipoPlano> ObterPlanosPorId(int Id)
        {
            return await _dataContext.Set<TipoPlano>().FindAsync(Id);
        }

    }


}
