﻿using System.ComponentModel;

namespace fourfit.sistema_gestao.Domain.Enumerables
{
    public enum StatusAlunosEnum
    {
        [Description("Ativo")]
        Ativo =1,
        [Description("Inativo")]
        Inativo =2,
        [Description("Pendente")]
        Pendente =3

    }
}