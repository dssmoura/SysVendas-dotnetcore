# SysVendas

# Projeto crud simulando um sistema de vendas baseado em .NETCore

## Banco de dados ##

 - Schema = 
 - user = 
 - senha = 
 - Variavel Ambiente = SYS_VENDAS_MYSQL 
 - Valor = server=
     var connectionStringsMySql = 


  Criação das pastas padrão do sistema 
   
  - SysVendas.DomainService
   - SysVendas.Ioc

## COMANDOS UTEIS 
 - Atualizar campos criados no banco de dados 
   - Criação do Script após criação das entidades e map
          PS D:\sysvendas\SysVendas.Data> dotnet ef --startup-project ../SysVendas.Api migrations add NomeScript   

   - Execução do Script após criação        
     PS D:\sysvendas\SysVendas.Data> dotnet ef --startup-project ../SysVendas.Api database update
 
 - Remover referencias 
     dotnet remove .\SysVendas.Domain.csproj reference ..\SysVendas.Data\SysVendas.Data.csproj    

   
## Passos para criação do projeto 

  - Criação das Entidades 
     - SysVendas.Domain\Entities\Fornecedor
     - Executar instalação dos pacotes do EF
          - dotnet add package Microsoft.EntityFrameworkCore.Design --version 2.0.3
          - dotnet add package MySql.Data.EntityFrameworkCore --version 8.0.11
          - dotnet add package MySql.Data.EntityFrameworkCore.Design --version 8.0.11    
    - Adcionar referencias do projeto 
          - dotnet add .\SysVendas.Data.csproj reference ..\SysVendas.Domain\SysVendas.Domain.csproj

    - Criação dos maps do projeto:
          - Context\Map\Fornecedor
    - Criação do contexto: 
          - MyDbContext.cs (Adcionar as referencias das tabelas a seram criadas (public virtual DbSet<Fornecedor> Fornecedor { get; set; })) 
          - EntityTypeConfiguration.cs - Arquivo padrão do EF

    - Criação IOC (criar como class lib.)      
           - Navegue até a raiz do projeto de Ioc, neste caso ".\src\CancelamentoPedidoAba.Ioc", adicionar a refencias abaixo:
           - dotnet add package Microsoft.Extensions.DependencyInjection.Abstractions --version 2.1.1
           - dotnet add package Microsoft.Extensions.Configuration --version 2.1.1
         - NativeInjectorConfig
              - connectionStringsMySql podendo ser passada localmente ou via variavel de ambiente 
               - injeção de dependencias com as interfaces do projeto 
    
    - Startup do projeto fazer a referencia com o RegisterServices (IOC)
    
    - Adcionar referencias do projeto 
          - D:\sysvendas\SysVendas.API> dotnet add .\SysVendas.API.csproj reference ..\SysVendas.Data\SysVendas.Data.csproj
          - D:\sysvendas\SysVendas.Ioc> dotnet add .\SysVendas.Ioc.csproj reference ..\SysVendas.Data\SysVendas.Data.csproj
          - D:\sysvendas\SysVendas.API> dotnet add .\SysVendas.API.csproj reference ..\SysVendas.Ioc\SysVendas.Ioc.csproj
          - D:\sysvendas\SysVendas.API> dotnet add .\SysVendas.API.csproj reference ..\SysVendas.Ioc\SysVendas.Ioc.csproj
    
    Adicionar o Migration ao projeto
          - D:\sysvendas\SysVendas.Data> dotnet ef --startup-project ..\SysVendas.API migrations add Init

    Executtar o comando para criação das tabelas 
          - D:\sysvendas\SysVendas.Data> dotnet ef --startup-project ..\SysVendas.API  database update           

## Modelo contratos Json's 

- Inserir Fornecedor :
      {
            "nome": "Fornecedor Especial",
            "rua": "Rua do comercio",
            "numero": 362,
            "bairro": "Bairro",
            "cidade": "Franca",
            "estado": "SP",
            "email": "fornecedor@fornecedor.com.br"
      }


## Pull request - https://bitbucket.org/danilo_moura/sysvendas/pull-requests/1/bd-001/diff


      
   
