﻿using fourfit.sistema_gestao.Domain.Entities.Account;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fourfit.sistema_gestao.Mapping
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable(nameof(User));

            builder.HasKey(x => x.Id);

            builder.Property(x => x.NomeCompleto)
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder.Property(x => x.Celular)
                .HasColumnType("varchar(16)")
                .IsRequired();

            builder.Property(x => x.Endereco)
               .HasColumnType("varchar(100)")
               .IsRequired();

            builder.Property(x => x.Cpf)
              .HasColumnType("varchar(14)")
              .IsRequired();

            builder.Property(x => x.Bairro)
               .HasColumnType("varchar(50)")
               .IsRequired();

            builder.Property(x => x.Cidade)
               .HasColumnType("varchar(50)")
               .IsRequired();

            builder.Property(x => x.Estado)
               .HasColumnType("varchar(2)")
               .IsRequired();

            builder.Property(x => x.UserName)
              .HasColumnType("varchar(50)")
              .IsRequired();

            builder.Property(x => x.Email)
              .HasColumnType("varchar(50)")
              .IsRequired();

             

                
        } 
    }
}
