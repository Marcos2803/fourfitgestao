
using fourfit.sistema_gestao.Domain.Entities.Store.Venda;
using fourfit.sistema_gestao.Domain.Interfaces;
using fourfit_sistema_gestao.Api.Models.Venda;
using fourfit_sistema_gestao.Api.Validation;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.Transactions;

namespace fourfit_sistema_gestao.Api.Controllers.Store
{
    [Route("api/[controller]")]
    [ApiController]
    public class VendasController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public VendasController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpPost]
        [Route("Register")]
        //[Authorize]
        [SwaggerResponse(statusCode: 200, description: "Venda cadastrado com sucesso", Type = typeof(VendasViewModels))]
        [SwaggerResponse(statusCode: 400, description: "Campos obrigatórios", Type = typeof(ValidarCampos))]
        [SwaggerResponse(statusCode: 500, description: "Erro internet", Type = typeof(ErrosGenericos))]
        [SwaggerResponse(statusCode: 401, description: "Não autorizado", Type = typeof(ValidarCampos))]
        [SwaggerResponse(statusCode: 404, description: "Usuário nao autenticado", Type = typeof(VendasViewModels))]
        public async Task<IActionResult> Register(VendasViewModels model)
        {
            //using (var transactionScope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))


                try
                {
                    var user = await _unitOfWork.UserServices.ObterPorUserId(model.UserId);
                    if (user == null)
                    {
                        return NotFound("Usuário não encontrado");
                    }

                    var vendaItens = new List<VendaItens>();
                    foreach (var item in model.VendaItens)
                    {
                        var produto = await _unitOfWork.ProdutosServices.ObterProdutosPorId(item.ProdutosId);
                        if (produto == null)
                        {
                            return NotFound("Produto não encontrado");
                        }

                        if (produto.QuantidadeEstoque < item.Quantidade)
                        {
                        return NotFound("Estoque insuficiente ");
                        }
                        produto.QuantidadeEstoque -= item.Quantidade;

                        vendaItens.Add(new VendaItens
                        {

                            ProdutosId = item.ProdutosId,
                            Quantidade = item.Quantidade,
                            Produtos = produto 
                        });
                     await _unitOfWork.ProdutosServices.Atualizar(produto);
                    }
                    var vendas = new Vendas
                    {
                        UserId = model.UserId,
                        DataVenda = DateTime.Now,
                        VendaItens = vendaItens,
                        StatusPagamentos = model.StatusPagamentos,

                    };

                    await _unitOfWork.VendasServices.Cadastro(vendas);
                    await _unitOfWork.VendasServices.Salvar();

                //// Confirmar a transação se tudo ocorrer bem
                //transactionScope.Complete();
                
                return Ok($"Venda cadastrado com sucesso");
                }
                catch (Exception ex)
                {

                    throw new Exception(ex.Message);
                }



        }

        [HttpDelete]
        [Route("Delete/{id}")]
        [SwaggerResponse(200, "Venda excluído com sucesso")]
        [SwaggerResponse(404, "Venda não encontrado")]
        [SwaggerResponse(500, "Erro interno")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var venda = await _unitOfWork.VendasServices.ObterPorId(id);
                if (venda == null)
                {
                    return NotFound("Venda não encontrado");
                }

                await _unitOfWork.VendasServices.Deletar(id);
                await _unitOfWork.VendasServices.Salvar();

                return Ok("Venda excluído com sucesso");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Erro interno: " + ex.Message);
            }
        }
    }
}
