namespace fourfit_sistema_gestao.UI.Models.Colaboradores
{
    public class ColaboradoresEdicaoViewModel
    {
        public int Id { get; set; }
       
        public string? NomeCompleto { get; set; }
        //public long Cpf { get; set; }
        public bool Ativo { get; set; }
        public byte[]? Foto { get; set; }
        public string? Observacaes { get; set; }
    }
}
