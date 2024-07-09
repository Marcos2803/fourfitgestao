using fourfit.sistema_gestao.Domain.Entities.Alunos;
using fourfit.sistema_gestao.Domain.Entities.EmailConfig;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fourfit.sistema_gestao.Mapping
{
    public class AvaliacaoFisicaConfiguration : IEntityTypeConfiguration<AvaliacaoFisica>
    {
        public void Configure(EntityTypeBuilder<AvaliacaoFisica> builder)
        {
            builder.ToTable("AvaliacaoFisica");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Data)
            .HasColumnType("varchar(10)")
             .IsRequired();

            builder.Property(x => x.Altura)
            .HasColumnType("varchar(10)")
            .IsRequired();
        }
    }

}   