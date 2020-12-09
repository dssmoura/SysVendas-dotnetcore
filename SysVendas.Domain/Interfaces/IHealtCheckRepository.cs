using SysVendas.Domain.Contract;
using SysVendas.Domain.Dto;

namespace SysVendas.Domain.Interfaces
{
    public interface IHealtCheckRepository
    {
        DtoHealthCheckResponse HealtCheck();
    }
}