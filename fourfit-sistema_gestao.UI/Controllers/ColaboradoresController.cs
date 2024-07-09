using fourfit.sistema_gestao.Domain.Entities.Profission;
using fourfit.sistema_gestao.Domain.Interfaces;
using fourfit_sistema_gestao.UI.Models.Colaboradores;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace fourfit_sistema_gestao.UI.Controllers
{
    [Authorize]
    public class ColaboradoresController : Controller
    {
        private readonly IUnitOfWork _unitOfwork;


        public ColaboradoresController(IUnitOfWork unitOfwork)
        {

            _unitOfwork = unitOfwork;
        }
        public async Task<IActionResult> Index()
        {
            var resultado = await _unitOfwork.ColaboradoresServices.ObterColaboradoresExistentes();
            return View(resultado.ToList());
        }
        [Authorize(Roles ="Colaboradores, Admin")]
        public async Task<IActionResult> CadastroColaboradores()
        {
            var usuarios = await _unitOfwork.UserServices.ObterUsuariosComEmailConfirmado();
            //ViewBag.Usuario = new SelectList(usuarios.Select(x => new
            //{
            //    x.Id,
            //    x.NomeCompleto,
            //}), "Id", "NomeCompleto");

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CadastroColaboradores(ColaboradoresViewModel colaboradoresViewModel)
        {
            try
            {
                var model = new EntidadeColaboradores
                {
                    UserId = colaboradoresViewModel.UserId,
                    Foto = colaboradoresViewModel.Foto,
                  
                    Ativo = true
                };
                await _unitOfwork.ColaboradoresServices.Cadastro(model);
                TempData["Msg"] = "Colaborador cadastrado com sucesso!";
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IActionResult> AlterarColaboradores(int Id)
        {
            var colaboradoresComUsuarios = await _unitOfwork.ColaboradoresServices.ObterColaboradoresUsuariosPorId(Id);



            var colaboradoresView = new ColaboradoresEdicaoViewModel
            {
                Id = colaboradoresComUsuarios.Id,
                NomeCompleto = colaboradoresComUsuarios.User.PrimeiroNome,
                Foto = colaboradoresComUsuarios.Foto,
               

            };

            if (colaboradoresComUsuarios != null)
            {
                return View(colaboradoresView);
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AlterarColaboradores(ColaboradoresEdicaoViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var colaboradores = await _unitOfwork.ColaboradoresServices.ObterPorId(model.Id);
                    if (colaboradores != null)
                    {
                        var usuario = await _unitOfwork.UserServices.ObterPorUserId(colaboradores.UserId);

                        if (usuario != null)
                        {

                           
                            usuario.PrimeiroNome = model.NomeCompleto;
                            colaboradores.Foto = model.Foto;
                            
                            await _unitOfwork.ColaboradoresServices.Atualizar(colaboradores);
                            await _unitOfwork.UserServices.Atualizar(usuario);
                        }
                    }
                    else
                    {
                        ViewBag.Msg = "Não há dados.";
                    }
                }

                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<JsonResult> ExcluirColaborador(int id)
        {
            try
            {
                var colaborador = await _unitOfwork.ColaboradoresServices.ObterPorId(id);
                if (colaborador != null)
                {
                    await _unitOfwork.ColaboradoresServices.Deletar(id);
                    return Json(new { sucesso = true, mensagem = "Colaborador excluído com sucesso" });
                }
                else
                {
                    return Json(new { sucesso = false, mensagem = "Colaborador não existe" });
                }
            }
            catch (Exception ex)
            {
                return Json(new { sucesso = false, mensagem = "Ocorreu um erro ao excluir o Colaborador: " + ex.Message });
            }
        }
    }
}
