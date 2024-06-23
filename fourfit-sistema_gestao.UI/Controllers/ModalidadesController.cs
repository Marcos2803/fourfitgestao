using fourfit.sistema_gestao.Domain.Entities.Modalidades;
using fourfit.sistema_gestao.Domain.Interfaces;
using fourfit_sistema_gestao.UI.Models.Modalidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace fourfit_sistema_gestao.UI.Controllers
{
    public class ModalidadesController : Controller
    {
        private readonly IUnitOfWork _unitOfwork;

        public ModalidadesController(IUnitOfWork unitOfwork)
        {

            _unitOfwork = unitOfwork;
        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> CadastroModalidades()
        {
            var usuarios = await _unitOfwork.UserServices.ObterUsuariosComEmailConfirmado();
            ViewBag.Usuario = new SelectList(usuarios.Select(x => new
            {
                x.Id,
                x.NomeCompleto,
            }), "Id", "NomeCompleto");

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CadastroModalidades(ModalidadesViewModel modalidadesViewModel)
        {
            try
            {
                var model = new Modalidades
                {
                    UserId = modalidadesViewModel.UserId,
                    Ativo = true
                };
                await _unitOfwork.ModalidadesServices.Cadastro(model);
                TempData["Msg"] = "Modalidades cadastrado com sucesso!";
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
