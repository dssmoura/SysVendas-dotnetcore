using System;
using System.Collections.Generic;
using System.Net;

namespace SysVendas.Domain.Contract
{
    public class ResponseBase
    {
        public ResponseBase()
        {
            StatusCode = HttpStatusCode.OK;
            Sucesso = true;
            Mensagens = new List<string>();
        }

        public HttpStatusCode StatusCode { get; set; }
        public List<string> Mensagens { get; set; }
        public Boolean Sucesso { get; set; }

        public void AdicionarErro(string erro)
        {
            Mensagens.Add(erro);
            StatusCode = HttpStatusCode.BadRequest;
            Sucesso = false;
        }
        public bool ExisteErros()
        {
            if(Mensagens.Count > 0)
                return true;

            return false;
        }
    }
}