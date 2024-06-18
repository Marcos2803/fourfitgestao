using fourfit.sistema_gestao.Domain.Entities.Alunos;

namespace fourfit.sistema_gestao.Domain.Entities.Checkin
{
    public class Checkin
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public EntidadeAlunos Alunos { get; set; }
        public string? AlunosId { get; set; }
        public string Horarios { get; set; }

        


    }
}
