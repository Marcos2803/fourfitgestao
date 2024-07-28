using System.ComponentModel;

namespace fourfit.sistema_gestao.Domain.Enumerables
{
    public enum StatusPagamentosEnum
    {
        [Description("Pago")]
        Pago =1,
        [Description("Não Pago")]
        NaoPago,
        [Description("Pendente ")]
        Pendente

    }
}
