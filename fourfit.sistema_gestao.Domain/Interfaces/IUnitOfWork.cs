namespace fourfit.sistema_gestao.Domain.Interfaces
{
    public interface IUnitOfWork
    {
        IAlunosServices AlunosServices { get; }
        ITipoPlanoServices TipoPlano { get; }
        ITipoPagamentoServices TipoPagamento { get; }
        ITipoPagamentoPcServices TipoPagamentoPc { get; }
        IUserServices UserServices { get; }
        IProfessoresServices ProfessoresServices { get; }
        IColaboradoresServices ColaboradoresServices { get; }
        ICheckinsServices CheckinsServices { get; }
        IMensalidadesServices MensalidadesServices { get; }
        IModalidadesServices ModalidadesServices { get; }
        IAvaliacaoFisicaServices AvaliacaoFisicaServices { get; }
        IDespesasServices DespesasServices { get; }
        ITipoPlanoServices TipoPlanoServices { get; }
        IInvestimentosServices InvestimentosServices { get; }
        IHorariosServices HorariosServices { get; }
        IContasBancariasServices ContasBancariasServices { get; }
        IFornecedoresServices FornecedoresServices { get; }
        IPersonalRecordServices PersonalRecordServices { get; }
        IParqServices ParqServices { get; }
        IProdutosServices ProdutosServices { get; }
        IAulaExperimentalServices AulaExperimentalServices { get; }
        IImpostosServices ImpostosServices { get; }
        IVendasServices VendasServices { get; }
        IPagamentosServices PagamentosServices { get; }

    }
}
