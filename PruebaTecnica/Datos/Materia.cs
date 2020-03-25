using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Materia: TrackDate
    {
        public int Id { get; set; }
        public string NombreMateria { get; set; }
        public int ProfesorId { get; set; }

        public Profesor Profesor { get; set; }
    }
}
