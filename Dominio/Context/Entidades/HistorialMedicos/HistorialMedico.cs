using Dominio.Context.Entidades.Clientes;
using Dominio.Context.Entidades.Veterinarios;
using Dominio.Core;

namespace Dominio.Context.Entidades.HistorialMedicos
{
    public class HistorialMedico : Entity
    {
        public int HistorialMedicoId { get; set; }
        public int MascotaId { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha { get; set; }
        public int VeterinarioId { get; set; }

        public Mascota Mascota { get; set; }
        public Veterinario Veterinario { get; set; }
    }
}
