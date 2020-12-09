
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SysVendas.Domain.Dto;
using SysVendas.DomainService.Interfaces;
using SysVendas.DomainService.Services;

namespace SysVendas.API.Controllers
{
    [Route("api/[controller]")]
    public class FornecedorController : ApiControllerExtended
    {
        private readonly IFornecedorService _fornecedorService;
        private readonly ILogger _logger;
        private readonly LoggingEvents _LoggingEvents;

        /*   
        public FornecedorController(IFornecedorService fornecedorService, ILoggerFactory logger)
        {
            _fornecedorService = fornecedorService;
            _logger = logger.CreateLogger("FornecedorController");
        }
        */

        public FornecedorController(IFornecedorService fornecedorService, ILogger<FornecedorController> logger)
        {
            _fornecedorService = fornecedorService;
            _logger = logger;
        }

        [HttpPost]
        public async Task<IActionResult> CadastroFornecedor([FromBody] DtoFornecedorRequest dto)
        {
            var response = new DtoFornecedorResponse();
            
              _logger.LogInformation(LoggingEvents.GetItem, "Getting item {ID}", dto);


            if (dto == null)
            {
                response.AdicionarErro("Dto inválido.");
                return SendResponse(response);
            }
            response = _fornecedorService.InserirFornecedor(dto);

            return SendResponse(response);
        }


        [HttpGet("{codigo}")]
        public async Task<IActionResult> ConsultaFornecedor(int codigo)
        {
            {
                var response = new DtoConsultaFornecedorResponse();

                #region Validações                

                if (codigo < 1)
                    response.AdicionarErro("Parâmetros inválidos para consulta.");

                if (response.ExisteErros())
                    return SendResponse(response);

                #endregion

                response = _fornecedorService.ConsultarFornecedor(codigo);

                return Ok(response);
            }
        }

        [HttpDelete("{codigo}")]
        public async Task<IActionResult> DeletarFornecedor(int codigo)
        {
            {
                var response = new DtoExcluirFornecedorResponse();

                #region Validações                

                if (codigo < 1)
                    response.AdicionarErro("Parâmetros inválidos para consulta.");

                if (response.ExisteErros())
                    return SendResponse(response);

                #endregion

                response = _fornecedorService.ExcluirFornecedor(codigo);

                return Ok(response);
            }
        }
        [HttpPut("{codigo}")] // passar o DTO aqui 
        public async Task<IActionResult> AlterarFornecedor(int codigo,[FromBody]DtoAlterarFornecedorRequest dto) // passar o DTO
        {
            var response = new DtoAlterarFornecedorResponse();

            if (codigo == null)
            {
                response.AdicionarErro("Dto inválido.");
                return SendResponse(response);
            }
            response = _fornecedorService.AlterarFornecedor(codigo, dto);

            return SendResponse(response);
        }


    }
}