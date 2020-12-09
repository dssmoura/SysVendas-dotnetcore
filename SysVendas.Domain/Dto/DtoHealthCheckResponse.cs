using System;
using SysVendas.Domain.Contract;

namespace SysVendas.Domain.Dto
{
    public class DtoHealthCheckResponse : ResponseBase
    {
         public bool HealthCheckMySql {get; set;}
    }
}