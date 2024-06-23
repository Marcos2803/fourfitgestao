using fourfit.sistema_gestao.Domain.Entities.Account;

namespace fourfit.sistema_gestao.Domain.Entities.Modalidades
{
    public class Modalidades
    {
        public int Id { get; set; }
        public User User { get; set; }
        public string? UserId { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string PermiteCheckin { get; set; }
        public bool Ativo { get; set; }
    }
}
