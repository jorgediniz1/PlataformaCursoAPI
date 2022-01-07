using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PlataformaCursos.Domain.Entities;

namespace PlataformaCursos.Infrastructure.Maps
{
    public class CursoMap : IEntityTypeConfiguration<Curso>
    {
        public void Configure(EntityTypeBuilder<Curso> builder)
        {
            builder.ToTable("tb_cursos");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome).HasColumnType("varchar(60)").HasMaxLength(60);
            builder.Property(x => x.Descricao).HasColumnType("varchar(250)").HasMaxLength(250);
            builder.Property(x => x.CargaHoraria).HasColumnType("");
            builder.Property(x => x);
            builder.Property(x => x);
            builder.Property(x => x);

        }
    }
}