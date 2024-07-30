using fourfit.sistema_gestao.Domain.Entities.Store.Venda;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace fourfit.sistema_gestao.Mapping
{
    public class VendasConfiguration : IEntityTypeConfiguration<Vendas>
    {
        public void Configure(EntityTypeBuilder<Vendas> builder)
        {
            builder.ToTable("Vendas");
            builder.HasKey("Id");

            builder.HasOne(x => x.User)
                .WithMany(a => a.Vendas)
                .HasForeignKey(a => a.UserId);

            builder.HasOne(x => x.Produtos)
                .WithMany(a => a.Vendas)
                .HasForeignKey(a => a.ProdutosId);

            builder.HasOne(x => x.Pagamentos)
                .WithMany(a => a.Vendas)
                .HasForeignKey(a => a.PagamentosId);

            builder.Property(x => x.DataVenda)
              .HasColumnType("date")
              .IsRequired();

            builder.Property(x => x.StatusPagamentos)
              .HasColumnType("varchar(10)")
              .IsRequired();
        }
    }
}
