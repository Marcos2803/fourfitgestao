using fourfit.sistema_gestao.Domain.Entities.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fourfit.sistema_gestao.Domain.Entities.Alunos
{
    public class AvaliacaoFisica
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public EntidadeAlunos Alunos { get; set; }
        public string? AlunosId { get; set; }
        public DateTime Idade { get; set; }
        public string Altura { get; set; }
        public string Peso { get; set; }
        public string PorcentualGordura { get; set; }
        public string? MassaMagra { get; set; }
        public string? TaxaMetabolica { get; set; }
        public string? GorduraViceral { get; set; }
        public string? Imc { get; set; }
        public string? IdadeCorporal { get; set; }
        public string? BicepsRelaxadoD { get; set; }
        public string? BicepsRelaxadoE { get; set; }
        public string? BicepsContraidoD { get; set; }
        public string? BicepsContraidoE { get; set; }
        public string? AntebracoDireito { get; set; }
        public string? AntebracoEsquerdo { get; set; }
        public string? Costa { get; set; }
        public string? Peitoral { get; set; }
        public string? Cintura { get; set; }
        public string? Abdomen { get; set; }
        public string? Quadril { get; set; }
        public string? CoxaDireita { get; set; }
        public string? CoxaEsqueda { get; set; }
        public string? PanturrilhaDireita { get; set; }
        public string? PaturrilhaEsquerdo { get; set; }
    }
}
