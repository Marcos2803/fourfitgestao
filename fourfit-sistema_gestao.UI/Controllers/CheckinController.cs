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
            var alunos = await _unitOfwork.AlunosServices.ObterAlunosExistentes();
            ViewBag.Aluno = new SelectList(alunos.Select(x => new
            {
              x.Id,
              x.TipoPlano,
            }), "Id", "TipoPlano");

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CadastroCheckin(CheckinViewModel checkinViewModel)
        {
            try
            {
                var model = new Checkin
                {
                    Id = checkinViewModel.Id,
                    //Alunos = checkinViewModel.Alunos,
                    Horarios = checkinViewModel.Horarios,
                };
                //await IUnitOfWork.CheckinServices.Cadastro(model);
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
