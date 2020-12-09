using SysVendas.Domain.Contract;

namespace SysVendas.Domain.Dto
{
    public class DtoConsultaFornecedorRequest 
    {      
        public int Codigo {get; set;}

    }

    public class DtoConsultaFornecedorResponse : ResponseBase
    {
        public string Nome {get; set;}
        public string Rua {get; set;}
        public int Numero {get; set;}
        public string Bairro {get; set;}
        public string Cidade {get; set;}
        public string Estado {get; set;}
        public string Email {get; set;}
    }
}