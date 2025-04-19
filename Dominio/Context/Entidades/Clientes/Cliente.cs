using Dominio.Core;

namespace Dominio.Context.Entidades.Clientes
{
    public class Cliente : Entity
    {
        public int ClienteId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public ICollection<Mascota> Mascotas { get; set; }
    }
}
