using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EsafyCapcitacion.Models
{
    public class Vertical
    {
        [Display(Name = "Id")]
        public int VerticalId { get; set; }
        [Display(Name = "Nombre")]
        public string VerticalName { get; set; }
        [Display(Name = "Creado")]
        public DateTime Created { get; set; }
        [Display(Name = "Modificado")]
        public DateTime Modified { get; set; }
    }
}
