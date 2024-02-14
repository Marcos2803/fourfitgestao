using fourfit.sistema_gestao.Domain.Entities.Alunos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace fourfit.sistema_gestao.Mapping
{
    public class AlunosConfiguration : IEntityTypeConfiguration<EntidadeAlunos>
    {
        public void Configure(EntityTypeBuilder<EntidadeAlunos> builder)
        {
            builder.ToTable("Alunos");
            builder.HasKey("Id");

            builder.HasOne(x => x.User)
                .WithMany(a => a.Alunos)
                .HasForeignKey(a => a.UserId);
        }
    }
}
