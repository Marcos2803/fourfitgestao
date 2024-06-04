using fourfit.sistema_gestao.Domain.Entities.Checkin;
using fourfit.sistema_gestao.Domain.Interfaces.Base;

namespace fourfit.sistema_gestao.Domain.Interfaces
{
    public interface ICheckinServices : IBaseServices<Checkin>
    {
        Task<IEnumerable<Checkin>> ObterCheckinExistentes();

        Task<Checkin> ObterCheckinUsuariosPorId(int Id);
    }
}
