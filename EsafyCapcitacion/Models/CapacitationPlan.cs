using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EsafyCapcitacion.Models
{
    public class CapacitationPlan
    {
        [Display(Name = "Id")]
        public int CapacitationPlanId { get; set; }
        [Display(Name = "Empresa")]
        public int CompanyId { get; set; }
        [Display(Name = "Nombre")]
        public string PlanName { get; set; }
        [Display(Name = "Activo?")]
        public bool IsActive { get; set; }
        [Display(Name = "Creado")]
        public DateTime Created { get; set; }
        [Display(Name = "Modificado")]
        public DateTime Modified { get; set; }
        [Display(Name = "Cursos")]
        public IList<Course> CourseList { get; set; }
    }
}
