using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PlataformaCursos.Domain.Entities;

namespace PlataformaCursos.Infrastructure.Maps
{
    public class EstudanteMap : IEntityTypeConfiguration<Estudante>
    {
        public void Configure(EntityTypeBuilder<Estudante> builder)
        {
            builder.ToTable("tb_estudantes");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome).HasColumnType("varchar(60)").IsRequired();
            builder.Property(x => x.Email).HasColumnType("varchar(100)").IsRequired();
            builder.Property(x => x.Senha).HasColumnType("varchar(50)").IsRequired();

           
            builder.HasMany(x => x.Cursos).WithMany(x => x.Estudantes);
            builder.HasOne(x => x.Conta).WithOne(x => x.Estudante);
        }
    }
}