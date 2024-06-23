namespace fourfit_sistema_gestao.UI.Models.Checkins
{
    public class CheckinViewModel
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public string NomeCompleto { get; set; }
        public string? UserId { get; set; }
        public string Horarios { get; set; }
    }
}
