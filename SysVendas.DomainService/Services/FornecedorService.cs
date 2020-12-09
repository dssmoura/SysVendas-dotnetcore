using System;
using SysVendas.Domain.Dto;
using SysVendas.Domain.Interfaces;
using SysVendas.DomainService.Interfaces;

namespace SysVendas.DomainService.Services
{
    public class FornecedorService : IFornecedorService
    {
        private readonly IFornecedorRepository _fornecedorContext;

        public FornecedorService(IFornecedorRepository fornecedorContext)
        {
            _fornecedorContext = fornecedorContext;
        }

        public DtoFornecedorResponse InserirFornecedor(DtoFornecedorRequest dto)
        {
            var response = new DtoFornecedorResponse();

            if (dto == null)
            {
                response.AdicionarErro("Dto inválido.");
                return response;
            }
            if (dto.Nome == null)
            {
                response.AdicionarErro("Informe o nome do fornecedor");
            }
            if (dto.Rua == null)
            {
                response.AdicionarErro("Informe a rua do fornecedor");
            }
            if (dto.Numero < 0 || dto.Numero == 0)
            {
                response.AdicionarErro("Informe a numero do fornecedor");
            }
            if (dto.Bairro == null)
            {
                response.AdicionarErro("Informe o bairro do fornecedor");
            }
            if (dto.Cidade == null)
            {
                response.AdicionarErro("Informe a cidade do fornecedor");
            }
            if (dto.Estado == null)
            {
                response.AdicionarErro("Informe o estado do fornecedor");
            }
            if (dto.Email == null)
            {
                response.AdicionarErro("Informe o Email do fornecedor");
            }
            if (response.ExisteErros())
            {
                return response;
            }
            try
            {
                response = _fornecedorContext.InserirFornecedor(dto);
            }
            catch (Exception ex)
            {
                response.AdicionarErro("Erro inesperado na inserção do Fornecedor.");
            }
            return response;
        }


        public DtoConsultaFornecedorResponse ConsultarFornecedor(int codigo)
        {
            var response = new DtoConsultaFornecedorResponse();

            if (codigo == null)
            {
                response.AdicionarErro("Dto inválido.");
                return response;
            }
            if (codigo < 1)
            {
                response.AdicionarErro("Parâmetros inválidos para consulta.");
                return response;
            }
            try
            {
                response = _fornecedorContext.ConsultarFornecedor(codigo);
            }
            catch (Exception ex)
            {
                response.AdicionarErro("Erro inesperado na consulta do Fornecedor.");
            }
            return response;
        }

        public DtoExcluirFornecedorResponse ExcluirFornecedor(int codigo)
        {
            var response = new DtoExcluirFornecedorResponse();
            if (codigo == null)
            {
                response.AdicionarErro("Dto inválido.");
                return response;
            }
            if (codigo < 1)
            {
                response.AdicionarErro("Parâmetros inválidos para consulta.");
                return response;
            }
            try
            {
                response = _fornecedorContext.ExcluirFornecedor(codigo);
            }
            catch (Exception ex)
            {
                response.AdicionarErro("Erro inesperado na consulta do Fornecedor.");
            }
            return response;
        }

        public DtoAlterarFornecedorResponse AlterarFornecedor(int codigo, DtoAlterarFornecedorRequest dto)
        {
            var response = new DtoAlterarFornecedorResponse();

            try
            {
                 response = _fornecedorContext.AlterarFornecedor(codigo, dto);
            }
            catch (Exception ex)
            {
                response.AdicionarErro("Erro inesperado na alteração do Fornecedor.");
            }
            return response;
        }
    }
}