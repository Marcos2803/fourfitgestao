using fourfit.sistema_gestao.Context;
using fourfit.sistema_gestao.Domain.Entities.Account;
using fourfit.sistema_gestao.Domain.Interfaces;
using fourfit.sistema_gestao.Repositories.Repository.Base;

namespace fourfit.sistema_gestao.Repositories.Repository
{
    public class UserRepository : BaseRepository<User>, IUserServices
    {
        private readonly DataContext _dataContext;

        public UserRepository(DataContext dataContext) : base(dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<User> ObterPorUserId(string UserId)
        {
            return await _dataContext.Set<User>().FindAsync(UserId);
        }
    }
}
