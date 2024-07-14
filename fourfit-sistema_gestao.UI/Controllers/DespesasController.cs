using fourfit.sistema_gestao.Domain.Entities.Alunos;
using fourfit.sistema_gestao.Domain.Entities.Financas;
using fourfit.sistema_gestao.Domain.Interfaces;
using fourfit_sistema_gestao.UI.Models.Alunos;
using fourfit_sistema_gestao.UI.Models.Financas;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace fourfit_sistema_gestao.UI.Controllers
{
    public class DespesasController : Controller
    {
        private readonly IUnitOfWork _unitOfwork;

        public DespesasController(IUnitOfWork unitOfwork)
        {

            _unitOfwork = unitOfwork;
        }
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> CadastroDespesas()
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
        public async Task<IActionResult> CadastroDespesas(DespesasViewModel despesasViewModel)
        {
            try
            {
                var model = new Despesas
                {
                   //Valor = despesasViewModel.Valor,
                   // Tipo = despesasViewModel.Tipo,
                   // Vencimento = DateTime.Now,
                   // Pagamento = DateTime.Now,
                    
                };
                await _unitOfwork.DespesasServices.Cadastro(model);
                TempData["Msg"] = "Despesa cadastrado com sucesso!";
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
