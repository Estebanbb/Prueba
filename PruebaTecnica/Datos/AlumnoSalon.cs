using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class AlumnoSalon: TrackDate
    {
        public int Id { get; set; }

        public int AlumnoId { get; set; }
        public int SalonId { get; set; }

        public Alumno Alumno { get; set; }
        public Salon Salon { get; set; }
    }
}
