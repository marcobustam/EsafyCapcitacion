using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EsafyCapcitacion.Models
{
    public class Company
    {
        [Display(Name = "Id")]
        public int CompanyId { get; set; }
        [Display(Name = "Nombre")]
        public string CompanyName { get; set; }
        [Display(Name = "Empleados")]
        public IList<Person> Employees { get; set; }
        [Display(Name = "Creado")]
        public DateTime Created { get; set; }
        [Display(Name = "Modificado")]
        public DateTime Modified { get; set; }
    }
}
