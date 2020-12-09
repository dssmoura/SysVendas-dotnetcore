using SysVendas.Domain.Contract;

namespace SysVendas.Domain.Dto
{
    public class DtoAlterarFornecedorRequest
    {

        public string Nome {get; set;}
        public string Rua {get; set;}
        public int Numero {get; set;}
        public string Bairro {get; set;}
        public string Cidade {get; set;}
        public string Estado {get; set;}
        public string Email {get; set;}
    }

        public class DtoAlterarFornecedorResponse : ResponseBase
    {
        //public int Codigo {get; set;}
         public string MensagemRetorno {get; set;}
    }  
}