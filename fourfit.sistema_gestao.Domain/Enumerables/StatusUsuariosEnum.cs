using System.ComponentModel;

namespace fourfit.sistema_gestao.Domain.Enumerables
{
    public enum StatusUsuariosEnum
    {
        [Description("Ativo")]
        Ativo =1,
        [Description("Inativo")]
        Inativo,
        [Description("Pendente por falta de pagamento")]
        pendente

    }
}
