﻿
using fourfit.sistema_gestao.Domain.Entities;
using fourfit.sistema_gestao.Domain.Entities.Account;
using fourfit.sistema_gestao.Domain.Entities.Alunos;
using fourfit.sistema_gestao.Domain.Entities.Equipaments;
using fourfit.sistema_gestao.Mapping;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace fourfit.sistema_gestao.Context
{
    public class DataContext:IdentityDbContext<User>
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)  
        {
           
        }
        // Dataset

       
        #region Tabelas
        public DbSet<User> Usuarios { get; set; }
        public DbSet<Equipamentos> Equipamentos { get; set; }
        public DbSet<EntidadeAlunos> Alunos { get; set; }
        public DbSet<Genero> Genero { get; set; }
        public DbSet<TipoPagamento> TipoPagamento { get; set; }
        public DbSet<TipoPagamentoPc> TipoPagamentoPc { get; set; }
        public DbSet<TipoPlano> TipoPlano { get; set; }
        public DbSet<AlunosPesquisa> AlunosPesquisa { get; set; }
        #endregion
        protected override void OnModelCreating(ModelBuilder builder)
        {
            //builder.Entity<User>(new UserConfiguration().Configure);
            //builder.Entity<EntidadeAlunos>(new AlunosConfiguration().Configure);
            builder.Entity<EntidadeAlunos>()
            .HasOne(e => e.User)
            .WithMany()
            .HasForeignKey(e => e.UserId);

            builder.Entity<EntidadeAlunos>()
                .HasOne(e => e.TipoPlano)
                .WithMany()
                .HasForeignKey(e => e.TipoPlanoId);

            builder.Entity<EntidadeAlunos>()
                .HasOne(e => e.TipoPagamento)
                .WithMany()
                .HasForeignKey(e => e.TipoPagamentoId);

            base.OnModelCreating(builder);
        }
    }
}
