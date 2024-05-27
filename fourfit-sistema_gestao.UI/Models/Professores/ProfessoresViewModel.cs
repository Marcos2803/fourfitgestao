namespace fourfit_sistema_gestao.UI.Models.Professores
{
    public class ProfessoresViewModel
    {
        public int Id { get; set; }
        public string? NomeCompleto { get; set; }
        public string UserId { get; set; }
        public int? Cpf { get; set; }
        public int? Cref { get; set; }
        public string? Especialidade { get; set; }
        public bool Ativo { get; set; }
        public byte[]? Foto { get; set; }
        public string? Observacaes { get; set; }
    }
}
