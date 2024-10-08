

using fourfit.sistema_gestao.Domain.Enumerables;

namespace UiTestes.DTO
{
    public class MensalidadesDTO
    {
        public int Id { get; set; }
        public int AlunosId { get; set; }
        public int PlanoId { get; set; }
        public int FormaPagamentoId { get; set; }
        public int ContasBancariasId { get; set; }
        public decimal ValorMensalidade { get; set; }
        public decimal? ValorMatricula { get; set; }
        public string MesReferente { get; set; }
        public DateTime DataInicialPlano { get; set; }
        public DateTime DataPagamento { get; set; }

        public StatusMensalidadesEnum StatusMensalidades { get; set; }
        public StatusPagamentosEnum StatusPagamentos { get; set; }
    }
}
