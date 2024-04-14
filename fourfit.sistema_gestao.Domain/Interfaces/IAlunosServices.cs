using fourfit.sistema_gestao.Domain.Entities.Alunos;
using fourfit.sistema_gestao.Domain.Interfaces.Base;
using System.Xml.Schema;

namespace fourfit.sistema_gestao.Domain.Interfaces
{
    public interface IAlunosServices:IBaseServices<EntidadeAlunos>
    {
        Task<IEnumerable<EntidadeAlunos>> ObterAlunosPorCpf(string cpf);

        Task<IEnumerable<EntidadeAlunos>> ObterAlunosExistentes();

        Task<EntidadeAlunos> ObterAlunosUsuariosPorId(int Id);
    }
}
