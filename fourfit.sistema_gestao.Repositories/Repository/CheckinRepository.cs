using fourfit.sistema_gestao.Context;
using fourfit.sistema_gestao.Domain.Entities.Checkin;
using fourfit.sistema_gestao.Domain.Entities.Profission;
using fourfit.sistema_gestao.Domain.Interfaces;
using fourfit.sistema_gestao.Repositories.Repository.Base;
using Microsoft.EntityFrameworkCore;

namespace fourfit.sistema_gestao.Repositories.Repository
{
    public class CheckinRepository : BaseRepository<Checkin>, ICheckinServices
    {
        private readonly DataContext _dataContext;

        public CheckinRepository(DataContext dataContext) : base(dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<IEnumerable<Checkin>> ObterCheckinExistentes()
        {
            var resultado = await _dataContext.Set<Checkin>()
                .Include(x => x.User)
                .ToListAsync();

            if (resultado != null)
            {
                return resultado;
            }

            return null;
        }
        public async Task<Checkin> ObterCheckinUsuariosPorId(int Id)
        {
            var resultado = await _dataContext.Set<Checkin>()
                .Include(x => x.User).Where(x => x.Id == Id).FirstOrDefaultAsync();


            if (resultado != null)
            {
                return resultado;
            }
            return null;
        }
    }
}
