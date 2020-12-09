using Microsoft.AspNetCore.Mvc;
using SysVendas.Domain.Contract;

namespace SysVendas.API.Controllers
{
    public class ApiControllerExtended : Controller
    {
        [NonAction]
        public IActionResult SendResponse<T>(T response) where T : ResponseBase
        {
            if (!response.ExisteErros())
            {
                return Ok(response);
            }
            else
            {
               return BadRequest(response);
            }
        }
    }
}
