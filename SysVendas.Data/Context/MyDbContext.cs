using Microsoft.EntityFrameworkCore;
using SysVendas.Data.Context.Map;
using SysVendas.Domain.Entities;

namespace SysVendas.Data.Context
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options)
            : base(options)
        { }

        #region Propriedades

        public virtual DbSet<Fornecedor> Fornecedor { get; set; }
        public virtual DbSet<Cliente> Cliente { get; set; }

        #endregion Propriedades

        #region Métodos sobrecarregados

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.AddConfiguration(new FornecedorMap());
            modelBuilder.AddConfiguration(new ClienteMap());
        }

        #endregion
    }
}