using fourfit.sistema_gestao.Context;
using fourfit.sistema_gestao.Domain.Entities.Alunos;
using fourfit_sistema_gestao.UI.Models.Account;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace fourfit_sistema_gestao.UI.Controllers
{
    public class AlunosController : Controller
    {
        private readonly DataContext _dbContext;

        public AlunosController(DataContext dbContext)
        {
           _dbContext = dbContext;
        }
        public async Task<IActionResult> Index()
        {
            var consulta = (from usuarios in _dbContext.Usuarios
                            join alunos in _dbContext.Alunos on usuarios.Id equals alunos.UserId
                            join tipoPl in _dbContext.TipoPlano on alunos.TipoPlanoId equals tipoPl.Id
                            join tipoPg in _dbContext.TipoPagamento on alunos.TipoPagamentoId equals tipoPg.Id
                            join tipoPlPc in _dbContext.TipoPagamentoPc on tipoPg.IdTipoPagamento equals tipoPlPc.Id
                            select usuarios).ToList();

           var res = consulta.Select(x=> new {
            x.NomeCompleto,
            x.DataNacimento,
            
           });
            
            var result = _dbContext.Usuarios.Include(x => x.Alunos).Where(x => x.Alunos.FirstOrDefault().UserId == x.Id).ToList();
            var teste = result.SelectMany(x => x.Alunos);
            var resultado = _dbContext.Alunos.ToList();
            if (resultado != null)
            {
                return View(resultado);

            }
            return NotFound();
            
        }

        public async Task<IActionResult> CadastroAlunos()
        {
            
            var usuarios = _dbContext.Usuarios.ToList().Where(x=>x.EmailConfirmed == false);
            ViewBag.Usuario = new SelectList(usuarios,"Id", "NomeCompleto");

            var tipoPlano = _dbContext.TipoPlano.ToList();
            ViewBag.TipoPlano = new SelectList(tipoPlano, "Id", "DescTipoPlano");

            var tipoPagamentoPc = _dbContext.TipoPagamentoPc.ToList();
            ViewBag.TipoPagamentoPc = new SelectList(tipoPagamentoPc, "Id", "Tipo");

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CadastroAlunos(AlunosViewModel alunosViewModel)
        {
            try
            {
                 var model = new EntidadeAlunos
                {
                    UserId = alunosViewModel.UserId,
                    DataInicio = DateTime.Now,
                    DataFim = DateTime.Now,
                    TipoPlanoId = alunosViewModel.TipoPlanoId,
                    TipoPagamentoId = alunosViewModel.TipoPagamentoId,
                    Ativo = true
                };
                await _dbContext.AddAsync(model);
                await _dbContext.SaveChangesAsync();
                TempData["Msg"] = "Alunos cadastrado com sucesso!";
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return View(alunosViewModel);
        }
    }
}
