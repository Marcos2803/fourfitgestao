using fourfit.sistema_gestao.Context;
using fourfit.sistema_gestao.Domain.Interfaces;

namespace fourfit.sistema_gestao.Repositories.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext _dataContext;

        public UnitOfWork(DataContext dataContext)
        {
           _dataContext = dataContext;
        }

        private IAlunosServices _alunosServices;
        private ITipoPlanoServices _tipoPlano;
        private ITipoPagamentoServices _tipoPagamento;
        private ITipoPagamentoPcServices _tipoPagamentoPc;
        private IUserServices _userServices;
        private IProfessoresServices _professoresServices;
        private IColaboradoresServices _colaboradoresServices;

        public IAlunosServices AlunosServices => _alunosServices ??=new AlunosRepository(_dataContext);

        public ITipoPlanoServices TipoPlano => _tipoPlano ??=new TipoPlanoRepository(_dataContext);

        public ITipoPagamentoServices TipoPagamento => _tipoPagamento ??= new TipoPagamentoRepository(_dataContext);

        public ITipoPagamentoPcServices TipoPagamentoPc => _tipoPagamentoPc ??= new TipoPagamentoPcRepository(_dataContext);

        public IUserServices UserServices => _userServices ??= new UserRepository(_dataContext);

        public IProfessoresServices ProfessoresServices => _professoresServices ??= new ProfessoresRepository(_dataContext);

        public IColaboradoresServices ColaboradoresServices => _colaboradoresServices ??= new ColaboradoresRepository(_dataContext);
    }
}
