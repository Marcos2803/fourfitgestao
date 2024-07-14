﻿using fourfit.sistema_gestao.Domain.Entities.Financas;

namespace fourfit_sistema_gestao.UI.Models.Financas
{
    public class InvestimentosViewModel
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