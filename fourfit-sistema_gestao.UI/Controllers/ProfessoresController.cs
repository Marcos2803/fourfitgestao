using fourfit.sistema_gestao.Domain.Entities.Profission;
using fourfit.sistema_gestao.Domain.Interfaces;
using fourfit_sistema_gestao.UI.Models;
using fourfit_sistema_gestao.UI.Models.Alunos;
using fourfit_sistema_gestao.UI.Models.Professores;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace fourfit_sistema_gestao.UI.Controllers
{
    public class ProfessoresController : Controller
    {

        private readonly IUnitOfWork _unitOfwork;

        public ProfessoresController(IUnitOfWork unitOfwork)
        {

            _unitOfwork = unitOfwork;
        }
        public async Task<IActionResult> Index()
        {
            var resultado = await _unitOfwork.ProfessoresServices.ObterProfessoresExistentes();
            return View(resultado.ToList());
            
        }

        public async Task<IActionResult> CadastroProfessores()
        {
            var usuarios = await _unitOfwork.UserServices.ObterUsuariosComEmailConfirmado();
            ViewBag.Usuario = new SelectList(usuarios.Select(x => new
            {
                x.Id,
                x.PrimeiroNome,
            }), "Id", "PrimeiroNome");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CadastroProfessores(ProfessoresViewModel professoresViewModel)
        {
            try
            {
                var CpfRemoverMascara = professoresViewModel.Cpf.ToString().Replace(".", "").Replace("-", "");
                var model = new EntidadeProfessores
                {
                   UserId = professoresViewModel.UserId,
                   Cpf = Convert.ToInt64(CpfRemoverMascara),
                    Cref = professoresViewModel.Cref,
                   Especialidade = professoresViewModel.Especialidade,
                   Foto = professoresViewModel.Foto,
                    Celular = professoresViewModel.Celular,
                    Cep = professoresViewModel.Cep,
                    Endereco = professoresViewModel.Endereco,
                    Numero = professoresViewModel.Numero,
                    Bairro = professoresViewModel.Bairro,
                    Cidade = professoresViewModel.Cidade,
                    Estado = professoresViewModel.Estado,
                    DataNacimento = professoresViewModel.DataNacimento,
                    DataCadastro = DateTime.Now,
                    
                };
                await _unitOfwork.ProfessoresServices.Cadastro(model);
                TempData["Msg"] = "Professor cadastrado com sucesso!";
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IActionResult> AlterarProfessores(int Id)
        {
            var professoresComUsuarios = await _unitOfwork.ProfessoresServices.ObterProfessoresUsuariosPorId(Id);

            

            var professoresView = new ProfessoresEdicaoViewModel
            {
                Id = professoresComUsuarios.Id,
                NomeCompleto = professoresComUsuarios.User.PrimeiroNome,
               // Cpf = professoresComUsuarios.Cpf,
                Cref = professoresComUsuarios.Cref,
                Especialidade = professoresComUsuarios.Especialidade,
                Foto = professoresComUsuarios.Foto,
                

            };

            if (professoresComUsuarios != null)
            {
                return View(professoresView);
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AlterarProfessores(ProfessoresEdicaoViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var professores = await _unitOfwork.ProfessoresServices.ObterPorId(model.Id);
                    if (professores != null)
                    {
                        var usuario = await _unitOfwork.UserServices.ObterPorUserId(professores.UserId);

                        if (usuario != null)
                        {

                            //professores.Cpf = model.Cpf;
                            professores.Cref = model.Cref;
                            usuario.PrimeiroNome = model.NomeCompleto;
                            professores.Foto = model.Foto;
                            professores.Especialidade = model.Especialidade;
                            
                            await _unitOfwork.ProfessoresServices.Atualizar(professores);
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

        public async Task<JsonResult> ExcluirProfessor(int id)
        {
            try
            {
                var professor = await _unitOfwork.ProfessoresServices.ObterPorId(id);
                if (professor != null)
                {
                    await _unitOfwork.ProfessoresServices.Deletar(id);
                    return Json(new { sucesso = true, mensagem = "Professor excluído com sucesso" });
                }
                else
                {
                    return Json(new { sucesso = false, mensagem = "Professor não existe" });
                }
            }
            catch (Exception ex)
            {
                return Json(new { sucesso = false, mensagem = "Ocorreu um erro ao excluir o Professor: " + ex.Message });
            }
        }
    }

}
