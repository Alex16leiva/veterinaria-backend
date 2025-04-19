using Dominio.Context.Entidades.Veterinarios;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura.Context.Mapping
{
    public class VeterinarioMap : EntityMap<Veterinario>
    {
        public override void Configure(EntityTypeBuilder<Veterinario> builder)
        {
            builder.ToTable("Veterinario");

            builder.HasKey(v => v.VeterinarioId);

            builder.Property(v => v.Nombre).IsRequired().HasMaxLength(100);

            builder.Property(v => v.Especialidad).HasMaxLength(100);

            builder.Property(v => v.Telefono).HasMaxLength(20);

            builder.Property(v => v.Email).HasMaxLength(100);
            base.Configure(builder);
        }
    }
}
