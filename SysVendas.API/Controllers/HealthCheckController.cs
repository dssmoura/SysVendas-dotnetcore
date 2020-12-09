using System;
using System.ComponentModel;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SysVendas.Domain.Dto;
using SysVendas.Domain.Interfaces;

namespace SysVendas.API.Controllers
{

    [Route("api/[controller]")]
    public class HealthCheckController : ApiControllerExtended
    {
        private readonly IHealtCheckRepository _healtCheckRepository;

        public HealthCheckController(IHealtCheckRepository healtCheckRepository)
        {
            _healtCheckRepository = healtCheckRepository;
        }

        [HttpGet]
        [Route("/api/healthcheck")]
        public async Task<IActionResult> HealthCheck()
        {
            var response = _healtCheckRepository.HealtCheck();
            return SendResponse(response);
        }

        public enum TipoErro
        {
            [Description("Erro inesperado na comunicação com banco de dados MySql.")]
            ErroInesperadoMySql = 1,
        }
    }
}