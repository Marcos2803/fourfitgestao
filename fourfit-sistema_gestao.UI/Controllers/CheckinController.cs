using fourfit.sistema_gestao.Domain.Entities.Checkin;
using fourfit.sistema_gestao.Domain.Interfaces;
using fourfit_sistema_gestao.UI.Models.Checkins;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace fourfit_sistema_gestao.UI.Controllers
{
    public class CheckinController : Controller
    {
        private readonly IUnitOfWork _unitOfwork;


        public CheckinController(IUnitOfWork unitOfwork)
        {

            _unitOfwork = unitOfwork;
        }
        public async Task<IActionResult> Index()
        {
            var resultado = await _unitOfwork.CheckinServices.ObterCheckinExistentes();
            return View(resultado.ToList());
        }

        public async Task<IActionResult> CadastroCheckin()
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
        public  async Task<IActionResult> CadastroCheckin(CheckinViewModel checkinViewModel)
        {
            try
            {
                var model = new Checkin
                {
                    UserId = checkinViewModel.UserId,
                    //Data = DateTime.Now,
                    Horarios = checkinViewModel.Horarios,
                };
                await _unitOfwork.CheckinServices.Cadastro(model);
                TempData["Msg"] = "Checkin cadastrado com sucesso!";
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
