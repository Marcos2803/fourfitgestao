using fourfit.sistema_gestao.Context;
using fourfit.sistema_gestao.Domain.Entities.Account;
using fourfit.sistema_gestao.Domain.Entities.Alunos;
using fourfit.sistema_gestao.Domain.Interfaces;
using fourfit_sistema_gestao.UI.Models;
using fourfit_sistema_gestao.UI.Models.Account;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace fourfit_sistema_gestao.UI.Controllers
{
    public class AlunosController : Controller
    {
        
        private readonly IUnitOfWork _unitOfwork;

        public AlunosController(IUnitOfWork unitOfwork)
        {
           
            _unitOfwork = unitOfwork;
        }
        public async Task<IActionResult> Index()
        {
            
            var resultado = await _unitOfwork.AlunosServices.ObterAlunosExistentes();


            //ViewBag.Alunos = resultado.Select(x => new
            //{
            //    x.User.NomeCompleto,
            //    x.Foto,
            //    x.Ativo,
            //    x.TipoPlano.DescTipoPlano,
            //    x.TipoPagamento.TipoPagamentoPc.Tipo
            //});

            return View(resultado.ToList());

        }


        public async Task<IActionResult> CadastroAlunos()
        
        {

            //var usuarios = _dbContext.Usuarios.ToList().Where(x => x.EmailConfirmed == true);
            //ViewBag.Usuario = new SelectList(usuarios.Select(x => new
            //{
            //    x.Id,
            //    x.NomeCompleto,
            //}), "Id", "NomeCompleto");

            //var tipoPlano = _dbContext.TipoPlano.ToList();
            //ViewBag.TipoPlano = new SelectList(tipoPlano, "Id", "DescTipoPlano");

            //var tipoPagamentoPc = _dbContext.TipoPagamentoPc.ToList();
            //ViewBag.TipoPagamentoPc = new SelectList(tipoPagamentoPc, "Id", "Tipo");

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
                //await _dbContext.AddAsync(model);
                //await _dbContext.SaveChangesAsync();
                TempData["Msg"] = "Alunos cadastrado com sucesso!";
                return RedirectToAction(nameof(Index));

            }
            catch (Exception ex)
            {

                throw ex;
            }
           
        }

        public async Task<IActionResult> AlterarAlunos(int Id)
        {
            //var alunosUsuario = _dbContext.Alunos.Include("User").Where(x => x.Id == Id);
            var alunosComUsuarios = await _unitOfwork.AlunosServices.ObterAlunosUsuariosPorId(Id);  

             var tipoPlano = await _unitOfwork.TipoPlano.ObterTodos();
             ViewBag.TipoPlano = new SelectList(tipoPlano.ToList(), "Id", "DescTipoPlano");

            var tipoPagamentoPc = await _unitOfwork.TipoPagamentoPc.ObterTodos();
            ViewBag.TipoPagamentoPc = new SelectList(tipoPagamentoPc, "Id", "Tipo");

            var alunosView = new AlunosEdicaoViewModel
            {
                Id = alunosComUsuarios.Id,
                NomeCompleto = alunosComUsuarios.User.NomeCompleto,
                DataInicio = alunosComUsuarios.DataInicio,
                DataFim = alunosComUsuarios.DataFim,
                TipoPagamentoId = alunosComUsuarios.TipoPagamentoId,
                TipoPlanoId = alunosComUsuarios.TipoPlanoId,

            };

            if (alunosComUsuarios != null)
            {
                return View(alunosView);
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AlterarAlunos(AlunosEdicaoViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    
                    var entidade = new EntidadeAlunos
                    { 
                        Id = model.Id,
                       User = new User{NomeCompleto = model.NomeCompleto},                             
                       TipoPagamentoId = model.TipoPagamentoId,
                       TipoPlanoId = model.TipoPlanoId
                    };  
                     await _unitOfwork.AlunosServices.Atualizar(entidade);
                   

                   
                }

                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {

                throw;
            }
           
        }
        public async Task<JsonResult> ExcluirAluno(int Id)
        {
            try
            {

                //var alunos = _dbContext.Alunos.FindAsync(Id).Result;

                //if (alunos != null)
                //{
                //    var al = new EntidadeAlunos()
                //    {
                //        Id = alunos.Id
                //    };
                //    //_dbContext.Alunos.Remove(alunos);
                //    //_dbContext.SaveChanges();

                //    return Json(new { sucesso = true, mensagem = "Aluno excluido com sucesso" });
                //}
                //else
                //{
                //    return Json(new { sucesso = false, mensagem = "Aluno não exite" });
                //}
                return Json(null);
               
                
            }
            catch (Exception ex)
            {

                return Json(new { sucesso = false, mensagem = ex.Message });
            }
           
        }
    }
}
