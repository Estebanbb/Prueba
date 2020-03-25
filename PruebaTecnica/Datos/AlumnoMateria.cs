using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class AlumnoMateria: TrackDate
    {
        public int Id { get; set; }
        public int AlumnoId { get; set; }
        public int MateriaId { get; set; }
        public Alumno Alumno { get; set; }
        public Materia Materia { get; set; }
    }
}
