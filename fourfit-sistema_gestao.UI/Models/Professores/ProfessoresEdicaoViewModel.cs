namespace fourfit_sistema_gestao.UI.Models.Professores
{
    public class ProfessoresEdicaoViewModel
    {
        public int Id { get; set; }
        public string? NomeCompleto { get; set; }
        //public int? Cpf { get; set; }
        public int? Cref { get; set; }
        public string? Especialidade { get; set; }
        public byte[]? Foto { get; set; }
        public string? Observacaes { get; set; }
    }
}
