using Dominio.Context.Entidades.Clientes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructura.Context.Mapping
{
    public class MascotaMap : EntityMap<Mascota>
    {
        public override void Configure(EntityTypeBuilder<Mascota> builder)
        {
            builder.ToTable("Mascota");
            builder.HasKey(m => m.MascotaId);
            builder.Property(m => m.Nombre).IsRequired().HasMaxLength(100);
            builder.Property(m => m.Raza).HasMaxLength(100);
            builder.Property(m => m.FechaNacimiento).IsRequired();

            base.Configure(builder);
        }
    }
}
