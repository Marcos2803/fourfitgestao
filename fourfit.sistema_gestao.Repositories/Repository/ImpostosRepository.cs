using fourfit.sistema_gestao.Context;
using fourfit.sistema_gestao.Domain.Entities.Alunos;
using fourfit.sistema_gestao.Domain.Entities.Financas;
using fourfit.sistema_gestao.Domain.Interfaces;
using fourfit.sistema_gestao.Repositories.Repository.Base;
using Microsoft.EntityFrameworkCore;

namespace fourfit.sistema_gestao.Repositories.Repository
{
    public class ImpostosRepository : BaseRepository<Impostos>, IImpostosServices
    {
        private readonly DataContext _dataContext;
        public ImpostosRepository(DataContext dataContext) : base(dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<IEnumerable<Impostos>> ObterImpostosPorId()

        {
            return await _dataContext.Set<Impostos>().FindAsync(Id);
        }
    }
}
