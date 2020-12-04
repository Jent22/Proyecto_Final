using App.Core.Entidades;
using App.Core.Entidades.EntidadesBaseDatos;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace App.Infrastructure.Datos
{
    public partial class DatosContexto : IdentityDbContext<Usuario>
    {
        public virtual DbSet<Asignatura> asignatura { get; set; }
        public virtual DbSet<Docente> docente { get; set; }
        public virtual DbSet<Estudiante> estudiante { get; set; }

        /*private const string conexion = "";*/
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                /*
                 * To protect potentially sensitive information in your connection string, you should move it out of source code. 
                 * See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                 */

                optionsBuilder.UseMySql("server=localhost;port=3306;database=bdapp;user=root;password=");
            }
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}