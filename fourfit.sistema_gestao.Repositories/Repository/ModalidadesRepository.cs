using fourfit.sistema_gestao.Context;
using fourfit.sistema_gestao.Domain.Entities;
using fourfit.sistema_gestao.Domain.Interfaces;
using fourfit.sistema_gestao.Repositories.Repository.Base;

namespace fourfit.sistema_gestao.Repositories.Repository
{
    public class ModalidadesRepository : BaseRepository<Modalidades>, IModalidadesServices
    {
        private readonly DataContext _dataContext;

        public ModalidadesRepository(DataContext dataContext) : base(dataContext)
        {
            _dataContext = dataContext;
        }

        public Task<IEnumerable<Modalidades>> ObterModalidadesExistentes()
        {
            throw new NotImplementedException();
        }
    }
}
