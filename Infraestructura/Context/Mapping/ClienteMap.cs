using Dominio.Context.Entidades.Clientes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructura.Context.Mapping
{
    public class ClienteMap : EntityMap<Cliente>
    {
        public override void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("Cliente");

            builder.HasKey(c => c.ClienteId);

            builder.Property(c => c.Nombre)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(c => c.Apellido)
                .IsRequired()
                .HasMaxLength(100);


            builder.Property(c => c.Telefono)
                .HasMaxLength(20);

            builder.Property(c => c.Email)
                .HasMaxLength(100);
            base.Configure(builder);
        }
    }
}
