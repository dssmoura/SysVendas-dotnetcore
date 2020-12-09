
using SysVendas.Domain.Dto;

namespace SysVendas.DomainService.Interfaces
{
    public interface IFornecedorService
    {
        DtoFornecedorResponse InserirFornecedor(DtoFornecedorRequest dto);

        DtoConsultaFornecedorResponse ConsultarFornecedor(int codigo);

        DtoExcluirFornecedorResponse ExcluirFornecedor(int codigo);

        DtoAlterarFornecedorResponse AlterarFornecedor(int codigo, DtoAlterarFornecedorRequest dto);       
    }
}