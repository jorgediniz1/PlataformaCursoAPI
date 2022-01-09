using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PlataformaCursos.Domain.Entities;

namespace PlataformaCursos.Infrastructure.Maps
{
    public class ContaMap : IEntityTypeConfiguration<Conta>
    {
        public void Configure(EntityTypeBuilder<Conta> builder)
        {
            builder.ToTable("tb_contas");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Status).HasColumnType("boolean");

            builder.HasMany(x => x.Cartoes).WithOne(x => x.Conta).HasForeignKey(x => x.ContaId);
        }
    }
}
