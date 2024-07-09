using fourfit.sistema_gestao.Domain.Entities.Account;
using fourfit.sistema_gestao.Domain.Entities.Alunos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fourfit.sistema_gestao.Domain.Entities.Financas
{
    public class Despesas
    {
        public int Id { get; set; }
        public string Tipo { get; set; }
        public string Descricao { get; set; }
        public int Valor { get; set; }
        public DateTime Vencimento { get; set; }
        public DateTime Pagamento { get; set; }
        public int TipoPagamentoId { get; set; }
        public TipoPagamento TipoPagamento { get; set; }
        public bool Ativo { get; set; }
        public string Observacao { get; set; }
    }
}