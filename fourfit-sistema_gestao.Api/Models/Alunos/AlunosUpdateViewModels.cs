﻿using fourfit_sistema_gestao.Api.Models.EntityGenerics;

namespace fourfit_sistema_gestao.Api.Models.Alunos
{
    public class AlunosUpdateViewModels : GenericsViewModels
    {
        public int Id { get; set; }
        public byte[]? Foto { get; set; }
        public string PrimeiroNome { get; set; }
        public string SobreNome { get; set; }
    }
}
