using System.Linq;
using SysVendas.Data.Context;
using SysVendas.Domain.Dto;
using SysVendas.Domain.Entities;
using SysVendas.Domain.Interfaces;

namespace SysVendas.Data.Repositories
{
    public class FornecedorRepository : IFornecedorRepository
    {
        private readonly MyDbContext _context;

        public FornecedorRepository(MyDbContext context)
        {
            _context = context;
        }
        // commit
        public DtoFornecedorResponse InserirFornecedor(DtoFornecedorRequest Fornecedor)
        {
            var response = new DtoFornecedorResponse();

            var forne = new Fornecedor()
            {
                Nome = Fornecedor.Nome,
                Rua = Fornecedor.Rua,
                Numero = Fornecedor.Numero,
                Bairro = Fornecedor.Bairro,
                Cidade = Fornecedor.Cidade,
                Estado = Fornecedor.Estado,
                Email = Fornecedor.Email
            };
            _context.Fornecedor.Add(forne);
            _context.SaveChanges();
            response.MensagemRetorno = "Fornecedor " + Fornecedor.Nome + " foi incluido com sucesso !";

            return response;
        }

        public DtoConsultaFornecedorResponse ConsultarFornecedor(int codigo)
        {
            var response = new DtoConsultaFornecedorResponse();

            var retorno = _context.Fornecedor.Where(x => x.Codigo == codigo).FirstOrDefault();

            if (retorno == null)
            {
                response.AdicionarErro("Fornecedor não encontrado na base de dados.");
                return response;
            }
            response.Nome = retorno.Nome;
            response.Rua = retorno.Rua;
            response.Numero = retorno.Numero;
            response.Bairro = retorno.Bairro;
            response.Cidade = retorno.Cidade;
            response.Estado = retorno.Estado;
            response.Email = retorno.Email;

            return response;
        }

        public DtoExcluirFornecedorResponse ExcluirFornecedor(int codigo)
        {

            var response = new DtoExcluirFornecedorResponse();

            var retorno = _context.Fornecedor.Where(x => x.Codigo == codigo).FirstOrDefault();

            if (retorno == null)
            {
                response.AdicionarErro("Fornecedor não encontrado na base de dados.");
                return response;
            }
            
            response.Nome = retorno.Nome;
            _context.Fornecedor.Remove(retorno);
            _context.SaveChanges();              
            response.MensagemRetorno = "Fornecedor " + response.Nome + " foi excluido com sucesso !";            
            return response;
        }

        public DtoAlterarFornecedorResponse AlterarFornecedor(int codigo , DtoAlterarFornecedorRequest dto)
        {
            var response = new DtoAlterarFornecedorResponse();

            var retorno = _context.Fornecedor.Where(x => x.Codigo == codigo).FirstOrDefault();

            if (!string.IsNullOrEmpty(dto.Nome))
            {
                retorno.Nome = dto.Nome;
            }
            if (!string.IsNullOrEmpty(dto.Rua))
            {
                retorno.Rua = dto.Rua;
            }
            if (dto.Numero < 0)
            {
                retorno.Numero = dto.Numero;
            }
            if (!string.IsNullOrEmpty(dto.Bairro))
            {
                retorno.Bairro = dto.Bairro;
            }
            if (!string.IsNullOrEmpty(dto.Cidade))
            {
                retorno.Cidade = dto.Cidade;
            }
            if (!string.IsNullOrEmpty(dto.Estado))
            {
                retorno.Estado = dto.Estado;
            }
            if (!string.IsNullOrEmpty(dto.Email))
            {
                retorno.Email = dto.Email;
            }
            if (!string.IsNullOrEmpty(dto.Email))
            {
                retorno.Email = dto.Email;
            }

            _context.Fornecedor.Update(retorno);
            _context.SaveChanges();
            response.MensagemRetorno = "Fornecedor foi alterado com sucesso !";

            return response;
           
        }
    }
}