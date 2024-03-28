﻿using System.Security.Permissions;

namespace fourfit_sistema_gestao.UI.Models
{
    public class AlunosEdicaoViewModel
    {
        public int Id { get; set; }
        public string NomeCompleto { get; set; }
        public DateTime DataInicio{get;set;}
        public DateTime DataFim { get; set; }
        public int TipoPlanoId { get; set; }
        public int TipoPagamentoId { get; set; }

    }
}