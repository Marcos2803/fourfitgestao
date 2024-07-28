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
        private IAulaExperimentalServices _aulaExperimetalServices;
        private ITipoPlanoServices _tipoPlano;
        private ITipoPagamentoServices _tipoPagamento;
        private ITipoPagamentoPcServices _tipoPagamentoPc;
        private IUserServices _userServices;
        private IProfessoresServices _professoresServices;
        private IColaboradoresServices _colaboradoresServices;
        private ICheckinsServices _checkinsServices;
        private IModalidadesServices _modalidadesServices;
        private IDespesasServices _despesasServices;
        private IInvestimentosServices _investimentosServices;
        private IHorariosServices _horariosServices;
        private ITipoPlanoServices _tipoplanoServices;
        private IMensalidadesServices _mensalidadesServices;
        private IAvaliacaoFisicaServices _avaliacaofisicaServices;
        private IContasBancariasServices _contasbancariasServices;
        private IFornecedoresServices _fornecedoresServices;
        private IPersonalRecordServices _personalrecordServices;
        private IParqServices _parqServices;
        private IProdutoServices _produtosServices;
        

        public IAlunosServices AlunosServices => _alunosServices ??= new AlunosRepository(_dataContext);

        public IAulaExperimentalServices AulaExperimentalServices => _aulaExperimetalServices ??= new AulaExperimentalRepository(_dataContext);

        public ITipoPlanoServices TipoPlano => _tipoPlano ??= new TipoPlanoRepository(_dataContext);

        public ITipoPagamentoServices TipoPagamento => _tipoPagamento ??= new TipoPagamentoRepository(_dataContext);

        public ITipoPagamentoPcServices TipoPagamentoPc => _tipoPagamentoPc ??= new TipoPagamentoPcRepository(_dataContext);

        public IUserServices UserServices => _userServices ??= new UserRepository(_dataContext);

        public IProfessoresServices ProfessoresServices => _professoresServices ??= new ProfessoresRepository(_dataContext);

        public IColaboradoresServices ColaboradoresServices => _colaboradoresServices ??= new ColaboradoresRepository(_dataContext);

        public ICheckinsServices CheckinsServices => _checkinsServices ??= new CheckinsRepository(_dataContext);

        public IDespesasServices DespesasServices => _despesasServices ??= new DespesasRepository(_dataContext);

        public IInvestimentosServices InvestimentosServices => _investimentosServices ??= new InvestimentosRepository(_dataContext);

        public IModalidadesServices ModalidadesServices => _modalidadesServices ??= new ModalidadesRepository(_dataContext);

        public IHorariosServices HorariosServices => _horariosServices ??= new HorariosRepository(_dataContext);

        public ITipoPlanoServices TipoPlanoServices => _tipoplanoServices ??= new TipoPlanoRepository(_dataContext);

        public IMensalidadesServices MensalidadesServices => _mensalidadesServices ??= new MensalidadesRepository(_dataContext);

        public IAvaliacaoFisicaServices AvaliacaoFisicaServices => _avaliacaofisicaServices ??= new AvaliacaoFisicaRepository(_dataContext);

        public IContasBancariasServices ContasBancariasServices => _contasbancariasServices ??= new ContasBancariasRepository(_dataContext);

        public IFornecedoresServices FornecedoresServices => _fornecedoresServices ??= new FornecedoresRepository(_dataContext);

        public IPersonalRecordServices PersonalRecordServices => _personalrecordServices ??= new PersonalRecordRepository(_dataContext);

        public IParqServices ParqServices => _parqServices ??= new ParqRepository(_dataContext);

        public IProdutoServices ProdutosServices => _produtosServices ??= new ProdutosRepository(_dataContext);

        
    }    
}