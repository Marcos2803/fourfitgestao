
//using fourfit.sistema_gestao.Domain.Enumerables;

namespace UiTestes.DTO
{
    public class IndexAlunosDTO : GenericDTO
    {
        public int Id { get; set; }
        public string? UserId { get; set; }
        //public StatusAlunosEnum StatusAlunos { get; set; }
        public byte[]? Foto { get; set; }
    }
}
