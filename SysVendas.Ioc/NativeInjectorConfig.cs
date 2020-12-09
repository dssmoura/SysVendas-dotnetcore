using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SysVendas.Data.Context;
using SysVendas.Data.Repositories;
using SysVendas.Domain.Interfaces;
using SysVendas.DomainService.Interfaces;
using SysVendas.DomainService.Services;

namespace SysVendas.Ioc
{
    public static class NativeInjectorConfig
    {
        public static void RegisterServices(this IServiceCollection services, IConfiguration configuration)
        {
            // Conexão por variavel de ambiente
            // var connectionStringsMySql = Environment.GetEnvironmentVariable("SYS_VENDAS_MYSQL");            
            
            // Conexão Local
            //var connectionStringsMySql = "server=localhost;userid=sys_venda;password=#$8.D353nV.8$#;database=sysvendas;SslMode=none";

            // Conexão Web    
            var connectionStringsMySql = "server=sysvendas.mysql.dbaas.com.br;userid=sysvendas;password=Dsm@2018@;database=sysvendas;SslMode=none";

            if (!string.IsNullOrEmpty(connectionStringsMySql))
                services.AddDbContext<MyDbContext>(options => options.UseMySQL(connectionStringsMySql), ServiceLifetime.Singleton);

            services.AddSingleton<IConfiguration>(configuration)
                    .AddTransient<IHealtCheckRepository, HealtCheckRepository>()
                    .AddTransient<IFornecedorService, FornecedorService>()
                    .AddTransient<IFornecedorRepository, FornecedorRepository>();
        }
    }
}