
using fourfit.sistema_gestao.Domain.Entities.Store.Venda;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace fourfit.sistema_gestao.Mapping
{
    public class PagamentosConfiguration : IEntityTypeConfiguration<Pagamentos>
    {
        public void Configure(EntityTypeBuilder<Pagamentos> builder)
        {
            builder.ToTable("Pagamentos");
            builder.HasKey("Id");

            builder.HasOne(x => x.TipoPagamentoPc)
               .WithMany(a => a.Pagamentos)
               .HasForeignKey(a => a.TipoPagamentoPcId);

            builder.HasOne(x => x.ContasBancarias)
               .WithMany(a => a.Pagamentos)
               .HasForeignKey(a => a.ContasBancariasId);

            builder.Property(x => x.DataPagamento)
              .HasColumnType("date")
              .IsRequired();

            builder.Property(x => x.ValorVenda)
              .HasColumnType(" decimal(18, 2)")
              .IsRequired();

            builder.Property(x => x.Desconto)
              .HasColumnType(" decimal(18, 2)")
              .IsRequired();

            builder.Property(x => x.ValorComDesconto)
              .HasColumnType(" decimal(18, 2)")
              .IsRequired();

            builder.Property(x => x.ValorPago)
              .HasColumnType(" decimal(18, 2)")
              .IsRequired();

            builder.Property(x => x.Troco)
              .HasColumnType(" decimal(18, 2)")
              .IsRequired();

            builder.Property(x => x.StatusPagamentos)
              .HasColumnType("varchar(10)")
              .IsRequired();
        }
    }
}
