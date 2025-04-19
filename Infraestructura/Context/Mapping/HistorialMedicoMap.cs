using Dominio.Context.Entidades.HistorialMedicos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura.Context.Mapping
{
    public class HistorialMedicoMap : EntityMap<HistorialMedico>
    {
        public override void Configure(EntityTypeBuilder<HistorialMedico> builder)
        {
            builder.ToTable("HistorialMedico");

            builder.HasKey(h => h.HistorialMedicoId);
            builder.Property(h => h.Descripcion).IsRequired();
            builder.Property(h => h.Fecha).IsRequired();

            base.Configure(builder);
        }
    }
}
