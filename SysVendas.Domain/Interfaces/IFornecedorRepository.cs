using SysVendas.Domain.Dto;

namespace SysVendas.Domain.Interfaces
{
    public interface IFornecedorRepository
    {
        DtoFornecedorResponse InserirFornecedor(DtoFornecedorRequest dto);

        DtoConsultaFornecedorResponse ConsultarFornecedor(int codigo);

        DtoExcluirFornecedorResponse ExcluirFornecedor(int codigo);

        DtoAlterarFornecedorResponse AlterarFornecedor(int codigo, DtoAlterarFornecedorRequest dto);

    }
}