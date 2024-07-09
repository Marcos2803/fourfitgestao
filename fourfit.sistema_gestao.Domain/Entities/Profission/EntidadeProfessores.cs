using fourfit.sistema_gestao.Domain.Entities.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fourfit.sistema_gestao.Domain.Entities.Profission
{
    public class EntidadeProfessores  : Generics
    {
        public int Id { get; set; }
        public string? UserId { get; set; }
        public User User { get; set; }
        public int? Cref { get; set; }
        public string? Especialidade { get; set; }
        public bool Ativo { get; set; }
        public byte[]? Foto { get; set; }
        public DateTime DataCadastro { get; set; }


    }
}
