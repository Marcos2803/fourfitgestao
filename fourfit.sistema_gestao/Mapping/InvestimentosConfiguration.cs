using fourfit.sistema_gestao.Domain.Entities.Financas;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace fourfit.sistema_gestao.Mapping
{
    public class InvestimentosConfiguration : IEntityTypeConfiguration<Investimentos>
    {
        public void Configure(EntityTypeBuilder<Investimentos> builder)
        {
            builder.ToTable("Investimentos");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Descricao)
            .HasColumnType("varchar(10)")
             .IsRequired();

            builder.Property(x => x.Observacao)
                .HasColumnType("varchar(10)")
                .IsRequired();
        }
    }
}
