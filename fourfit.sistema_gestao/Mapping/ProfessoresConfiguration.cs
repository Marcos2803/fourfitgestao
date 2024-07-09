using fourfit.sistema_gestao.Domain.Entities.Account;
using fourfit.sistema_gestao.Domain.Entities.Profission;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace fourfit.sistema_gestao.Mapping
{
    public class ProfessoresConfiguration : IEntityTypeConfiguration<EntidadeProfessores>
    {
        public void Configure(EntityTypeBuilder<EntidadeProfessores> builder)
        {
            builder.ToTable("Professores");
            builder.HasKey("Id");

            builder.HasOne(x => x.User)
                .WithMany(a => a.Professores)
                .HasForeignKey(a => a.UserId);

            //builder.Property(x => x.User.PrimeiroNome)
            //   .HasColumnType("varchar(50)")
            //   .IsRequired();

            builder.Property(x => x.Cpf)
              .HasColumnType("varchar(14)")
              .IsRequired();

            builder.Property(x => x.Cref)
              .HasColumnType("varchar(15)")
              .IsRequired();

            builder.Property(x => x.Especialidade)
              .HasColumnType("varchar(50)")
              .IsRequired();

        }
    }
}
