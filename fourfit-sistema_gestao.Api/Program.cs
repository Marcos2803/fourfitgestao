using fourfit.sistema_gestao.Context;
using fourfit.sistema_gestao.Domain.Entities.Account;
using fourfit.sistema_gestao.Domain.Interfaces;
using fourfit.sistema_gestao.Repositories.JwtRepository;
using fourfit.sistema_gestao.Repositories.Repository;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
string strConnection = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<DataContext>(option =>
{
    option.UseSqlServer(strConnection,
    option => option.EnableRetryOnFailure());


});

builder.Services.AddIdentity<User, IdentityRole>(option =>
{
  option.SignIn.RequireConfirmedAccount = true;
  option.Lockout.MaxFailedAccessAttempts = 3;
  option.Password.RequiredLength = 6;
  option.Password.RequireUppercase = false;

})
  .AddEntityFrameworkStores<DataContext>()
  .AddDefaultTokenProviders();

builder.Services.Configure<DataProtectionTokenProviderOptions>(options =>
   options.TokenLifespan = TimeSpan.FromHours(3));

builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<IAuthenticationJwtServices, GerarTokenRepositoy>();


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
