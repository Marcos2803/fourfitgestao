using fourfit.sistema_gestao.Domain.Entities.Alunos;

namespace fourfit.sistema_gestao.Domain.Entities.Financas
{
    public class ContasBancarias
    {
        public int Id { get; set; }
        public string Bancos { get; set; }
        public string Descricao { get; set; }
        public bool Status { get; set; }

        public virtual ICollection<Mensalidades> Mensalidades { get; set; }
        public virtual ICollection<Despesas>Despesas { get; set; }
        public virtual ICollection<Investimentos> Investimentos { get; set; }
    }
}
