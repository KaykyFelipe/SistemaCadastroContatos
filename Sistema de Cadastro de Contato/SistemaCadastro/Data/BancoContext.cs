using Microsoft.EntityFrameworkCore;
using SistemaCadastro.Models;

namespace SistemaCadastro.Data
{
    public class BancoContext : DbContext     
    {

          public DbSet<ContatoModel> Contatos { get; set; } 

        private static readonly ILoggerFactory _logger = LoggerFactory.Create(p=>p.AddConsole()); //log das querys

       public BancoContext(DbContextOptions<BancoContext> options)
        : base(options)
    {
    }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(BancoContext).Assembly);

        }
    }
}