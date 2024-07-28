using fourfit.sistema_gestao.Domain.Entities.Alunos;
using fourfit.sistema_gestao.Domain.Entities.Financas;

namespace fourfit_sistema_gestao.Api.Models.Mensalidade
{
    public class MensalidadesViewModels
    {
        public int Id { get; set; }
        public int AlunosId { get; set; }
        public int PlanoId { get; set; }
        public int PagamentosId { get; set; }
        public int ContasBancariasId { get; set; }
        public decimal ValorMensalidade { get; set; }
        public decimal? ValorMatricula { get; set; }
        public string MesReferente { get; set; }
        public DateTime DataInicialPlano { get; set; }
        public DateTime DataPagamento { get; set; }
        public string StatusPagamentos { get; set; }
    }
}
