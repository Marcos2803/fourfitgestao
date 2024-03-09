using fourfit.sistema_gestao.Domain.Entities.Alunos;

namespace fourfit.sistema_gestao.Domain.Entities
{
    public class TipoPlano
    {
        public int Id { get; set; }
        public string DescTipoPlano { get; set; }
        public virtual ICollection<EntidadeAlunos> EntidadeAlunos { get; set; }
    }
}
