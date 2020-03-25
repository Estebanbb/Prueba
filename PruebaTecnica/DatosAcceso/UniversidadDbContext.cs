using Datos;

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosAcceso
{
    class UniversidadDbContext : DbContext
    {
        public UniversidadDbContext() : base("Conn1")
        {

        }

        public DbSet<Profesor> Profesores { get; set; }
        public DbSet<Alumno> Alumnos { get; set; }
        public DbSet<AlumnoSalon> AlumnoSalones { get; set; }
        public DbSet<Materia> Materias { get; set; }
        public DbSet<AlumnoMateria> AlumnoMaterias { get; set; }
        public DbSet<Nota> Notas { get; set; }
        public DbSet<Salon> Salones { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
