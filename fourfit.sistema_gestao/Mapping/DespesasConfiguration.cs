using fourfit.sistema_gestao.Domain.Entities.Financas;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fourfit.sistema_gestao.Mapping
{
    public class DespesasConfiguration : IEntityTypeConfiguration<Despesas>
    {
        public void Configure(EntityTypeBuilder<Despesas> builder)
        {
            builder.ToTable("Despesas");
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
