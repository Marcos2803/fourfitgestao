using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fourfit.sistema_gestao.Domain.Entities.Financas
{
    public class Fornecedores
    {
        public int Id { get; set; }
        public string NomeFornecedor { get; set; }
        public string Tipo { get; set; }
        public long CpfCnpj { get; set; }
        public string Email { get; set; }
        public string? Telefone { get; set; }
        public bool Ativo { get; set; }
        public string Observacao { get; set; }

        public ICollection<TipoDespesas> TipoDespesas { get; set; }
    }
}
