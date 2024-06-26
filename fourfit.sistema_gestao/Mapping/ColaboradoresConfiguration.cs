﻿using fourfit.sistema_gestao.Domain.Entities.Alunos;
using fourfit.sistema_gestao.Domain.Entities.Profission;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fourfit.sistema_gestao.Mapping
{
    public class ColaboradoresConfiguration : IEntityTypeConfiguration<EntidadeColaboradores>
    {
        public void Configure(EntityTypeBuilder<EntidadeColaboradores> builder)
        {

            builder.ToTable("Colaboradores");
            builder.HasKey("Id");

            builder.HasOne(x => x.User)
                .WithMany(a => a.Colaboradores)
                .HasForeignKey(a => a.UserId);

            builder.Property(x => x.NomeCompleto)
                   .HasColumnType("varchar(50)")
                   .IsRequired();
        }

    }
}
