using fourfit.sistema_gestao.Domain.Entities.Account;

namespace fourfit_sistema_gestao.UI.Models.AvaliacaoFisica
{
    public class AvaliacaoFisica
    {
        public int Id { get; set; }
        public User User { get; set; }
        public string? UserId { get; set; }
        public DateTime Data { get; set; }
        public bool Ativo { get; set; }
        public string Peso { get; set; }
        public string Busto { get; set; }
        public string? Cintura { get; set; }
        public string? Barriga { get; set; }
        public string? Quadril { get; set; }
        public string? PernaDireita { get; set; }
        public string? PernaEsqueda { get; set; }
        public string? BracoDireita { get; set; }
        public string? BracoEsquerdo { get; set; }
        public string? Imc { get; set; }
        public string? GorduraCorporal { get; set; }
        public string? MassaMagra { get; set; }
        public string? GorduraViceral { get; set; }
        public string? CaloriaBasal { get; set; }
        public string? IdadeMetabolica { get; set; }
        public string? Observacao { get; set; }
    }
}

