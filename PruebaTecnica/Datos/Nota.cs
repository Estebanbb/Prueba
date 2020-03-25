using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Nota: TrackDate
    {
        public int Id { get; set; }

        public string Calificacion { get; set; }
        public int AlumnoId { get; set; }

        public Alumno Alumno { get; set; }
    }
}
