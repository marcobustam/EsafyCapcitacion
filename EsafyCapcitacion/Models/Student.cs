using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EsafyCapcitacion.Models
{
    public class Student : Person
    {
        [Display(Name = "Empresa")]
        public int CompanyId { get; set; } 
    }
}
