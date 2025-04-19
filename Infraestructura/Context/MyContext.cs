using Dominio.Context.Entidades.Clientes;
using Dominio.Context.Entidades.HistorialMedicos;
using Dominio.Context.Entidades.Seguridad;
using Dominio.Context.Entidades.Veterinarios;
using Dominio.Core;
using Infraestructura.Context.Mapping;
using Infraestructura.Context.Mapping.Seguridad;
using Infraestructura.Core;
using Microsoft.EntityFrameworkCore;

namespace Infraestructura.Context
{
    public class MyContext : BCUnitOfWork, IDataContext
    {
        public MyContext(DbContextOptions<MyContext> context)
            : base(context)
        {
            Database.SetCommandTimeout((int)TimeSpan.FromSeconds(1).TotalSeconds);
        }

        public virtual DbSet<Usuario> Usuarios { get; set; }
        public virtual DbSet<Rol> Rol {  get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Mascota> Mascotas { get; set; }
        public DbSet<HistorialMedico> HistorialMedicos { get; set; }
        public DbSet<Veterinario> Veterinarios { get; set; }
        public virtual DbSet<Pantalla> Pantalla { get; set; }
        public virtual DbSet<Permisos> Permisos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioMap());
            modelBuilder.ApplyConfiguration(new RolMap());
            modelBuilder.ApplyConfiguration(new VeterinarioMap());
            modelBuilder.ApplyConfiguration(new HistorialMedicoMap());
            modelBuilder.ApplyConfiguration(new MascotaMap());
            modelBuilder.ApplyConfiguration(new ClienteMap());
            modelBuilder.ApplyConfiguration(new PantallaMap());
            modelBuilder.ApplyConfiguration(new PermisosMap());
            base.OnModelCreating(modelBuilder);
        }


        public override void Commit(TransactionInfo transactionInfo)
        {
            base.Commit(transactionInfo);
        }
    }
}
