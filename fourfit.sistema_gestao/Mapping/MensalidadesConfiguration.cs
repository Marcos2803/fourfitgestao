using fourfit.sistema_gestao.Domain.Entities.Alunos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fourfit.sistema_gestao.Mapping
{
    public class MensalidadesConfiguration : IEntityTypeConfiguration<Mensalidades>
    {
        public void Configure(EntityTypeBuilder<Mensalidades> builder)
        {
            
        builder.ToTable("Mensalidades");
            builder.HasKey("Id");

            builder.HasOne(x => x.Alunos)
                .WithMany(a => a.Mensalidades)
                .HasForeignKey(a => a.AlunosId);

            builder.HasOne(x => x.Planos)
                .WithMany(a => a.Mensalidades)
                .HasForeignKey(a => a.PlanoId);

            builder.HasOne(x => x.ContasBancarias)
                .WithMany(a => a.Mensalidades)
                .HasForeignKey(a => a.ContasBancariasId);

            builder.HasOne(x => x.Pagamentos)
               .WithMany(a => a.Mensalidades)
               .HasForeignKey(a => a.PagamentosId);
           
                 builder.Property(x => x.ValorMensalidade)
              .HasColumnType(" decimal(18, 2)")
              .IsRequired();

            builder.Property(x => x.ValorMatricula)
              .HasColumnType(" decimal(18, 2)")
              .IsRequired();

            builder.Property(x => x.ValorMensalidade)
              .HasColumnType(" varchar(12)")
              .IsRequired();

            builder.Property(x => x.ValorMensalidade)
             .HasColumnType(" varchar(12)")
             .IsRequired();

            builder.Property(x => x.DataInicialPlano)
          .HasColumnType("date")
          .IsRequired();

            builder.Property(x => x.DataPagamento)
          .HasColumnType("date")
          .IsRequired();

            builder.Property(m => m.StatusPagamento)
                .HasConversion<string>() // Armazena o enum como string no banco de dados
                .IsRequired();

        }
    }
}
