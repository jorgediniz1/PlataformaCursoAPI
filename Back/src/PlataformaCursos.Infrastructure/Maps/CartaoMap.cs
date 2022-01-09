using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PlataformaCursos.Domain.Entities;

namespace PlataformaCursos.Infrastructure.Maps
{
    public class CartaoMap : IEntityTypeConfiguration<Cartao>
    {
        public void Configure(EntityTypeBuilder<Cartao> builder)
        {
            builder.ToTable("tb_cartoes");
            
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("Id").ValueGeneratedOnAdd();
            builder.Property(x => x.Numero).HasColumnType("numeric").HasMaxLength(16);
            builder.Property(x => x.Codigo).HasColumnType("numeric").HasMaxLength(3);
            builder.Property(x => x.NomeTitular).HasColumnType("varchar(60)").HasMaxLength(60);
            builder.Property(x => x.DataVencimento).HasColumnType("datetime");
         
        
          //1:N - Conta:Cartão => CONTA  
        }
    }
}