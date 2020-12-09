using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SysVendas.Domain.Entities;

namespace SysVendas.Data.Context.Map
{
    public class FornecedorMap : EntityTypeConfiguration<Fornecedor>
    {
        public override void Map(EntityTypeBuilder<Fornecedor> builder)
        {
            // Primary Key
            builder.HasKey(e => e.Codigo);

            // Table & Column Mappings
            builder.ToTable("FORNECEDOR");
            builder.Property(e => e.Codigo).HasColumnName("Codigo");
            builder.Property(e => e.Nome).HasColumnName("Nome");
            builder.Property(e => e.Rua).HasColumnName("Rua");
            builder.Property(e => e.Numero).HasColumnName("Numero");
            builder.Property(e => e.Bairro).HasColumnName("Bairro");
            builder.Property(e => e.Cidade).HasColumnName("Cidade");
            builder.Property(e => e.Estado).HasColumnName("Estado");
            builder.Property(e => e.Email).HasColumnName("Email");
        }
    }
}