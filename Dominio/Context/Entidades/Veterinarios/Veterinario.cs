using Dominio.Context.Entidades.HistorialMedicos;
using Dominio.Core;

namespace Dominio.Context.Entidades.Veterinarios
{
    public class Veterinario : Entity
    {
        public int VeterinarioId { get; set; }
        public string Nombre { get; set; }
        public string Especialidad { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public ICollection<HistorialMedico> HistorialMedico { get; set; }
    }
}
