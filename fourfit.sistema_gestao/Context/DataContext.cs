
using fourfit.sistema_gestao.Domain.Entities;
using fourfit.sistema_gestao.Domain.Entities.Account;
using fourfit.sistema_gestao.Domain.Entities.Alunos;
using fourfit.sistema_gestao.Domain.Entities.Checkin;
using fourfit.sistema_gestao.Domain.Entities.EmailConfig;
using fourfit.sistema_gestao.Domain.Entities.Financas;
using fourfit.sistema_gestao.Domain.Entities.Profission;
using fourfit.sistema_gestao.Mapping;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace fourfit.sistema_gestao.Context
{
    public class DataContext : IdentityDbContext<User>
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {


        }
        // Dataset


        #region Tabelas
         public DbSet<User> Usuarios { get; set; }
        //public DbSet<entidadeEmailConfiguracoes>? EmailConfiguracoes { get; set; }
        //public DbSet<entidadeEmailAddress>? EmailAddress { get; set; }
        //public DbSet<entidadeEmailPasswordAccount>? EmailPasswordAccount { get; set; }
        public DbSet<EntidadeAlunos> Alunos { get; set; }
        //public DbSet<TipoPagamento> TipoPagamento { get; set; }
        //public DbSet<TipoPagamentoPc> TipoPagamentoPc { get; set; }
        //public DbSet<TipoPlano> TipoPlano { get; set; }
        //public DbSet<Parq> Parq { get; set; }
        //public DbSet<AlunosPesquisa> AlunosPesquisa { get; set; }

        public DbSet<EntidadeProfessores> Professores { get; set; }
        public DbSet<EntidadeColaboradores> Colaboradores { get; set; }
        //public DbSet<Checkin> Checkin { get; set; }
        //public DbSet<Despesas> Despesas { get; set; }
        //public DbSet<Investimentos> Investimentos { get; set; }
        //public DbSet<AvaliacaoFisica> AvaliacaoFisica { get; set; }
        #endregion
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<User>(new UserConfiguration().Configure);
            builder.Entity<EntidadeAlunos>(new AlunosConfiguration().Configure);
            builder.Entity<EntidadeProfessores>(new ProfessoresConfiguration().Configure);
            builder.Entity<EntidadeColaboradores>(new ColaboradoresConfiguration().Configure);
            base.OnModelCreating(builder);
        }
    }
}