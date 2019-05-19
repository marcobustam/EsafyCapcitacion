using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EsafyCapcitacion.Models
{
    public class Person
    {
        public int PersonId { get; set; }
        [Display(Name="Alias")]
        public string ShortName { get; set; }
        [Display(Name = "Creado")]
        public DateTime Created { get; set; }
        [Display(Name = "Modificado")]
        public DateTime Modified { get; set; }

    }
}
