using Dominio.Context.Entidades.HistorialMedicos;
using Dominio.Core;

namespace Dominio.Context.Entidades.Clientes
{
    public class Mascota : Entity
    {
        public int MascotaId { get; set; }
        public int ClienteId { get; set; }
        public string Nombre { get; set; }
        public string Raza { get; set; }
        public int FechaNacimiento { get; set; }
        public Cliente Cliente { get; set; }
        public ICollection<HistorialMedico> HistorialMedico { get; set; }
    }
}
