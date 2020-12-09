using SysVendas.Domain.Contract;

namespace SysVendas.Domain.Dto
{
    public class DtoExcluirFornecedorRequest 
    {      
        public int Codigo {get; set;}

    }

    public class DtoExcluirFornecedorResponse : ResponseBase
    {
        public string Nome {get; set;}
        public string MensagemRetorno {get; set;}
      
    }
}