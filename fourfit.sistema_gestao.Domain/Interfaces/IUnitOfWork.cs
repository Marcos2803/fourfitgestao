namespace fourfit.sistema_gestao.Domain.Interfaces
{
    public interface IUnitOfWork
    {
        IAlunosServices AlunosServices { get; }
        ITipoPlanoServices TipoPlano { get; }
        ITipoPagamentoServices TipoPagamento { get; }
        ITipoPagamentoPcServices TipoPagamentoPc { get; }
        IUserServices UserServices { get; }
    }
}
