namespace fourfit_sistema_gestao.Api.Models.Planos
{
    public class PlanosViewModels
    {
        public int Id { get; set; }
        public string NomePlano { get; set; }
        public string Descricao { get; set; }
        public int DiaPorSemana { get; set; }
        public int DuracaoMes { get; set; }
        public int DuracaoDia { get; set; }
        public decimal ValorPlano { get; set; }
        public string Status { get; set; }
    }
}
