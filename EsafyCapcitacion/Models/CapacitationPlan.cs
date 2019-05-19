using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EsafyCapcitacion.Models
{
    public class CapacitationPlan
    {
        public int CapacitationPlanId { get; set; }
        public int CompanyId { get; set; }
        public string PlanName { get; set; }
        public bool IsActive { get; set; }
        [Display(Name = "Creado")]
        public DateTime Created { get; set; }
        [Display(Name = "Modificado")]
        public DateTime Modified { get; set; }
        public IList<Course> CourseList { get; set; }
    }
}
