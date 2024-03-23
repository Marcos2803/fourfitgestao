using fourfit.sistema_gestao.Domain.Entities.Alunos;

namespace fourfit.sistema_gestao.Domain.Interfaces
{
    public interface IAlunosServices
    {
        Task Cadastrar(EntidadeAlunos entidadeAlunos);
        Task Alterar(EntidadeAlunos entidadeAlunos);
        Task<EntidadeAlunos> BuscarPorNome(string nome );
    }
}
