using Microsoft.EntityFrameworkCore;
using SistemaCadastro.Models;

namespace SistemaCadastro.Data
{
    public class BancoContext : DbContext     
    {

          public DbSet<ContatoModel> Clientes { get; set; } 

        private static readonly ILoggerFactory _logger = LoggerFactory.Create(p=>p.AddConsole()); //log das querys

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            
            optionsBuilder
            .UseLoggerFactory(_logger)
            .EnableSensitiveDataLogging()
            .UseSqlServer("Server=CONDOMINIO\\SQLSERVER2022;Database=SistemaContatos;Trusted_Connection=True;TrustServerCertificate=True;");// Qual Banco estamos usando e qual string de conexao
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(BancoContext).Assembly);

        }
    }
}