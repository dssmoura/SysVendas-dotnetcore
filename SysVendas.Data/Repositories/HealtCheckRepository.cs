using System;
using System.Linq;
using SysVendas.Data.Context;
using SysVendas.Domain.Contract;
using SysVendas.Domain.Dto;
using SysVendas.Domain.Interfaces;

namespace SysVendas.Data.Repositories
{
    public class HealtCheckRepository : IHealtCheckRepository    
    {
        private readonly MyDbContext _context;

        public HealtCheckRepository(MyDbContext context)
        {
            _context = context;
        }


        public DtoHealthCheckResponse HealtCheck()
        {
            var response = new DtoHealthCheckResponse();

            try
            {
                _context.Fornecedor.ToList().FirstOrDefault();
                response.HealthCheckMySql = true;
            }
            catch(Exception ex)
            {
                response.HealthCheckMySql = false;                
                response.AdicionarErro("Erro inesperado na comunicação com banco de dados MySql.");                
            }

            return response;                        
        }
    }
}