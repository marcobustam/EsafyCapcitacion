using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EsafyCapcitacion.Models
{
    public class CapacitationClass
    {
        public int CapacitationClassId { get; set; }
        public int CourseId { get; set; }
        [Display(Name = "Creado")]
        public DateTime Created { get; set; }
        [Display(Name = "Modificado")]
        public DateTime Modified { get; set; }

    }
}
