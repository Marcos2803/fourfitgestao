using fourfit.sistema_gestao.Context;
using fourfit.sistema_gestao.Domain.Entities.Alunos;
using fourfit.sistema_gestao.Domain.Interfaces;
using fourfit.sistema_gestao.Repositories.Repository.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fourfit.sistema_gestao.Repositories.Repository
{
    public class AlunosRepository : BaseRepository<EntidadeAlunos>, IAlunosServices
    {
        private readonly DataContext _dataContext;

        public AlunosRepository(DataContext dataContext) : base(dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<IEnumerable<EntidadeAlunos>> ObterAlunosPorCpf(string cpf)
        {
            return await _dataContext.Set<EntidadeAlunos>()
                .Where(x => x.UserId == cpf)
                .AsNoTracking()
                .ToListAsync();
        }
    }
}
