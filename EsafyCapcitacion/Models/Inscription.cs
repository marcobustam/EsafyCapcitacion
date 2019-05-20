using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EsafyCapcitacion.Models
{
    public class Inscription
    {
        [Display(Name = "Id")]
        public int CourseId { get; set; }
        [Display(Name = "Estudiante")]
        public int StudentId { get; set; }
        [Display(Name = "Creado")]
        public DateTime Created { get; set; }
        [Display(Name = "Modificado")]
        public DateTime Modified { get; set; }
    }
}
