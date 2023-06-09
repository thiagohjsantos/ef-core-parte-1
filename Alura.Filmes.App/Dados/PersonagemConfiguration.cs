using Alura.Filmes.App.Negocio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Alura.Filmes.App.Dados
{
    public class PersonagemConfiguration : IEntityTypeConfiguration<Personagem>
    {
        public void Configure(EntityTypeBuilder<Personagem> builder)
        {
            builder
                .ToTable("lotr_characters");

            builder
                .Property(x => x.Id)
                .HasColumnName("character_id");

            builder
                .Property(x => x.Nome)
                .HasColumnName("character_name")
                .HasColumnType("varchar(60)")
                .IsRequired();
        }
    }
}
