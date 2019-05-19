using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EsafyCapcitacion.Models.Cursos
{
    public class CursoCapacitacion
    {
        public int CursoCapacitacionId { get; set; }
        public string NombreCurso { get; set; }
        public bool EsObligatorio { get; set; }

        public int HorasDuracion { get; set; } 

    }
}
