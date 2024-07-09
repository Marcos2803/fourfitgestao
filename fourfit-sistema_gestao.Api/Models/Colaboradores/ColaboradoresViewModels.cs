using fourfit_sistema_gestao.Api.Models.EntityGenerics;

namespace fourfit_sistema_gestao.Api.Models.Colaboradores
{
    public class ColaboradoresViewModels : GenericsViewModels
    {
        public int Id { get; set; }
        public string? UserId { get; set; }
        public byte[]? Foto { get; set; }
        public bool Ativo { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
