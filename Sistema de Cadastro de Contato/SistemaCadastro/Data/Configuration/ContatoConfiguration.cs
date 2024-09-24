
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using SistemaCadastro.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configuration
{



    public class ClienteConfiguration : IEntityTypeConfiguration<ContatoModel>
    {
        public void Configure(EntityTypeBuilder<ContatoModel> builder)
        {
            builder.ToTable("Contato");
            builder.HasKey(p => p.Id);//Cria a Chave Primaria Id
            builder.Property(p => p.Nome).HasColumnType("VARCHAR(80)").IsRequired();//Cria a Coluna Nome
            builder.Property(p => p.Email).HasColumnType("VARCHAR(80)").IsRequired();
            builder.Property(p => p.Numero).HasColumnType("CHAR(11)");//Cria a Coluna Telefone


        }

    }
}