namespace fourfit.sistema_gestao.Domain.Entities.Alunos
{
    public class TipoPlano
    {
        public int Id { get; set; }
        public string DescTipoPlano { get; set; }

        public virtual ICollection<Mensalidades> Mensalidades { get; set; }




    }
}
