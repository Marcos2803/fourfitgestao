using fourfit.sistema_gestao.Domain.Entities.Checkin;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

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
