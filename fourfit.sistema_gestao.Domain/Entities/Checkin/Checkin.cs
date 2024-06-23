using fourfit.sistema_gestao.Domain.Entities.Account;


namespace fourfit.sistema_gestao.Domain.Entities.Checkin
{
    public class Checkin
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public User User { get; set; }
        public string? UserId { get; set; }
        public string Horarios { get; set; }

        


    }
}
