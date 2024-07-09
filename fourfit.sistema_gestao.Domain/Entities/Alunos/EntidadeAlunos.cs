using fourfit.sistema_gestao.Domain.Entities.Account;


namespace fourfit.sistema_gestao.Domain.Entities.Alunos
{
    public class EntidadeAlunos : Generics
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
        public DateTime DataCadastro { get; set; }
        public byte[]? Foto { get; set; }
        public bool Ativo { get; set; }









    }
}
