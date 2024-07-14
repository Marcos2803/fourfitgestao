using fourfit.sistema_gestao.Domain.Entities.Profission;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fourfit.sistema_gestao.Domain.Entities.Financas
{
    public class TipoDespesas
    {
        public int Id { get; set; }
        public int ImpostosId { get; set; }
        public Impostos Impostos { get; set; }
        public int ColaboradoresId { get; set; }
        public EntidadeColaboradores Colaboradores { get; set; }
        public int FornecedoresId { get; set; }
        public Fornecedores Fornecedores { get; set; }

        public virtual ICollection<Despesas> Despesas { get; set; }
    }
}
