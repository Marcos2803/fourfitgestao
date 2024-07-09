using fourfit.sistema_gestao.Domain.Entities.Financas;
using fourfit.sistema_gestao.Domain.Interfaces;
using fourfit_sistema_gestao.UI.Models.Financas;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace fourfit_sistema_gestao.UI.Controllers
{
    public class InvestimentosController : Controller
    {
        private readonly IUnitOfWork _unitOfwork;

        public InvestimentosController(IUnitOfWork unitOfwork)
        {

            _unitOfwork = unitOfwork;
        }
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> CadastroInvestimentos()
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
        public async Task<IActionResult> CadastroInvestimentos(InvestimentosViewModel investimentosViewModel)
        {
            try
            {
                var model = new Investimentos
                {
                    Valor = investimentosViewModel.Valor,
                    Tipo = investimentosViewModel.Tipo,
                    Vencimento = DateTime.Now,
                    Pagamento = DateTime.Now,
                    Ativo = true
                };
                await _unitOfwork.InvestimentosServices.Cadastro(model);
                TempData["Msg"] = "Investimento cadastrado com sucesso!";
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
