﻿using fourfit.sistema_gestao.Domain.Entities.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fourfit.sistema_gestao.Domain.Entities.Profission
{
    public class EntidadeColaboradores
    {
        public int Id { get; set; }
        public User User { get; set; }
        public string? UserId { get; set; }
        public string? NomeCompleto { get; set; }
        public long Cpf { get; set; }
        public bool Ativo { get; set; }
        public byte[]? Foto { get; set; }
        public string? Observacaes { get; set; }
    }
}
