using fourfit.sistema_gestao.Domain.Entities;
using fourfit.sistema_gestao.Domain.Entities.Profission;
using fourfit.sistema_gestao.Domain.Interfaces.Base;

namespace fourfit.sistema_gestao.Domain.Interfaces
{
    public interface IModalidadesServices : IBaseServices<Modalidades>
    {
        Task<IEnumerable<Modalidades>> ObterModalidadesExistentes();
    }
}
