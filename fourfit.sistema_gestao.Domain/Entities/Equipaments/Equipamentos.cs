namespace fourfit.sistema_gestao.Domain.Entities.Equipaments
{
    public class Equipamentos
    {
        public int Id { get; set; }
        public string EquipamentoNome { get; set; }
        public DateTime DataManuntecao { get; set; }
        public string Usuario { get; set; }
        public bool Ativo { get; set; }
    }
}
