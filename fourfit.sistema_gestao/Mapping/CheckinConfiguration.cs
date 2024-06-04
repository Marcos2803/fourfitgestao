using fourfit.sistema_gestao.Domain.Entities.Checkin;
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
    public class CheckinConfiguration : IEntityTypeConfiguration<Checkin>
    {
        public void Configure(EntityTypeBuilder<Checkin> builder)
        {
            builder.ToTable("Checkin");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Data)
            .HasColumnType("varchar(10)")
             .IsRequired();

            builder.Property(x => x.Horarios)
            .HasColumnType("varchar(10)")
            .IsRequired();
        }
    }
}
