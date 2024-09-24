using fourfit.sistema_gestao.Domain.Entities.Alunos;
using fourfit.sistema_gestao.Domain.Interfaces;
using fourfit_sistema_gestao.UI.Models.Account;
using fourfit_sistema_gestao.UI.Models.Alunos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace fourfit_sistema_gestao.UI.Controllers
{
    //[Authorize]
    public class AlunosController : Controller
    {

        private readonly IUnitOfWork _unitOfwork;

        public AlunosController(IUnitOfWork unitOfwork)
        {

            _unitOfwork = unitOfwork;
        }
        
        public async Task<IActionResult> Index(string searchString)
        
        
        {
            ViewBag.CurrentFilter = searchString;

            var resultado = await _unitOfwork.AlunosServices.ObterAlunosExistentes();

            //if (!string.IsNullOrEmpty(searchString))
            //{
            //    resultado = resultado.Where(x => x.User.NomeCompleto.Contains(searchString));
            //}

            return View(resultado.ToList());

        }
        
        public async Task<IActionResult> CadastroAlunos()
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
        public async Task<IActionResult> CadastroAlunos(AlunosViewModel alunosViewModel)
        {
            try
            {
                var CpfRemoverMascara = alunosViewModel.Cpf.ToString().Replace(".", "").Replace("-", "");
                var model = new EntidadeAlunos
                {
                    UserId = alunosViewModel.UserId,
                    Cpf = Convert.ToInt64(CpfRemoverMascara),
                    Foto = alunosViewModel.Foto,
                    Cep = alunosViewModel.Cep,
                    Endereco = alunosViewModel.Endereco,
                    Numero = alunosViewModel.Numero,
                    Bairro = alunosViewModel.Bairro,
                    Cidade = alunosViewModel.Cidade,
                    Estado = alunosViewModel.Estado,
                    DataNacimento = alunosViewModel.DataNacimento,
                    DataCadastro = DateTime.Now,
                    
                };
                await _unitOfwork.AlunosServices.Cadastro(model);
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
            var alunosComUsuarios = await _unitOfwork.AlunosServices.ObterAlunosUsuariosPorId(Id);
            
            var alunosView = new AlunosEdicaoViewModel
            {
                Id = alunosComUsuarios.Id,
                PrimeiroNome = alunosComUsuarios.User.PrimeiroNome,
                Cpf = alunosComUsuarios.Bairro,
                Celular = alunosComUsuarios.Celular,
                Cep = alunosComUsuarios.Cep,
                Endereco = alunosComUsuarios.Endereco,
                Numero = alunosComUsuarios.Numero,
                Bairro = alunosComUsuarios.Bairro,
                Cidade = alunosComUsuarios.Cidade,
                Estado = alunosComUsuarios.Estado,
                DataNacimento = alunosComUsuarios.DataNacimento,
               
               

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
                    var alunos = await _unitOfwork.AlunosServices.ObterPorId(model.Id);
                    if (alunos != null)
                    {
                        var usuario = await _unitOfwork.UserServices.ObterPorUserId(alunos.UserId);

                        if (usuario != null)
                        {
                            //alunos.Cpf = model.Bairro;
                            alunos.Celular = model.Celular;
                            alunos.Cep = model.Cep;
                            alunos.Endereco = model.Endereco;
                            alunos.Bairro = model.Bairro;
                            alunos.Numero = model.Numero;
                            alunos.Cidade = model.Cidade;
                            alunos.Estado = model.Estado;
                            alunos.DataNacimento = model.DataNacimento;
                            usuario.PrimeiroNome = model.PrimeiroNome;
                            await _unitOfwork.AlunosServices.Atualizar(alunos);
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
        public async Task<JsonResult> ExcluirAluno(int id)
        {
            try
            {
                var aluno = await _unitOfwork.AlunosServices.ObterPorId(id);
                if (aluno != null)
                {
                    await _unitOfwork.AlunosServices.Deletar(id);
                    return Json(new { sucesso = true, mensagem = "Aluno excluído com sucesso" });
                }
                else
                {
                    return Json(new { sucesso = false, mensagem = "Aluno não existe" });
                }
            }
            catch (Exception ex)
            {
                return Json(new { sucesso = false, mensagem = "Ocorreu um erro ao excluir o aluno: " + ex.Message });
            }
        }

    }
}
