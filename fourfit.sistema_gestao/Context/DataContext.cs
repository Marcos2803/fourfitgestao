
using fourfit.sistema_gestao.Domain.Entities;
using fourfit.sistema_gestao.Domain.Entities.Account;
using fourfit.sistema_gestao.Domain.Entities.Alunos;
using fourfit.sistema_gestao.Domain.Entities.Equipaments;
using fourfit.sistema_gestao.Mapping;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

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
        #endregion
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<User>(new UserConfiguration().Configure);
            builder.Entity<EntidadeAlunos>(new AlunosConfiguration().Configure);
            base.OnModelCreating(builder);
        }
    }
}
