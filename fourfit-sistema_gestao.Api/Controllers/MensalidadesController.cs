using fourfit.sistema_gestao.Domain.Entities.Alunos;
using fourfit.sistema_gestao.Domain.Interfaces;
using fourfit_sistema_gestao.Api.Models.Mensalidade;
using fourfit_sistema_gestao.Api.Validation;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace fourfit_sistema_gestao.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MensalidadesController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public MensalidadesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpPost]
        [Route("Register")]
        //[Authorize]
        [SwaggerResponse(statusCode: 200, description: "Mensalidades cadastrado com sucesso", Type = typeof(MensalidadesViewModels))]
        [SwaggerResponse(statusCode: 400, description: "Campos obrigatórios", Type = typeof(ValidarCampos))]
        [SwaggerResponse(statusCode: 500, description: "Erro internet", Type = typeof(ErrosGenericos))]
        [SwaggerResponse(statusCode: 401, description: "Não autorizado", Type = typeof(ValidarCampos))]
        [SwaggerResponse(statusCode: 404, description: "Usuário nao autenticado", Type = typeof(MensalidadesViewModels))]
        public async Task<IActionResult> Register(MensalidadesViewModels model)
        {
            try
            {
                var mensalidades = new Mensalidades
                {
                    Id = model.Id,
                    AlunosId = model.AlunosId,
                    PlanoId = model.PlanoId,
                    FormaPagamentoId = model.FormaPagamentoId,
                    ContasBancariasId = model.ContasBancariasId,
                    ValorMensalidade = model.ValorMensalidade,
                    ValorMatricula = model.ValorMatricula,
                    MesReferente = model.MesReferente,
                    DataInicialPlano = model.DataInicialPlano,
                    DataPagamento = model.DataPagamento,
                    StatusPagamentos = model.StatusPagamentos

                };

                await _unitOfWork.MensalidadesServices.Cadastro(mensalidades);
                await _unitOfWork.MensalidadesServices.Salvar();
                return Ok($"Mensalidade cadastrados com sucesso");
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }

        //[HttpGet]
        //[Route("Update/{id}")]
        //[SwaggerResponse(200, "Informações do mensalidade obtidas com sucesso", typeof(MensalidadesIndexViewModels))]
        //[SwaggerResponse(404, "Mensalidade não encontrado")]
        //public async Task<IActionResult> Update(int id)
        //{
        //    var mensalidades = await _unitOfWork.MensalidadesServices.ObterMensalidadesExistentes(id);

        //    if (mensalidades == null)
        //    {
        //        return NotFound("Mensalidade não encontrado");
        //    }

        //    var modalidadesView = new MensalidadesIndexViewModels
        //    {
        //        Id = mensalidades.Id,
        //        AlunosId = mensalidades.AlunosId,
        //        PlanoId = mensalidades.PlanoId,
        //        ContasBancariasId = mensalidades.ContaBancariaId,
        //        PagamentosId = mensalidades.PagamentosId,


        //    };

        //    return Ok(modalidadesView);
        //}
        [HttpDelete]
        [Route("Delete/{id}")]
        [SwaggerResponse(200, "Mensalidade excluído com sucesso")]
        [SwaggerResponse(404, "Mensalidade não encontrado")]
        [SwaggerResponse(500, "Erro interno")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var mensalidade = await _unitOfWork.MensalidadesServices.ObterPorId(id);
                if (mensalidade == null)
                {
                    return NotFound("Mensalidade não encontrado");
                }

                await _unitOfWork.MensalidadesServices.Deletar(id);
                await _unitOfWork.MensalidadesServices.Salvar();

                return Ok("Mensalidade excluído com sucesso");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Erro interno: " + ex.Message);
            }
        }
    }
}
