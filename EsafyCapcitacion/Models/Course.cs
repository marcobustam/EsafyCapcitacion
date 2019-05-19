using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EsafyCapcitacion.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string CourseShortName { get; set; }

        public string SenceCode { get; set; }
        public string SenceTitle { get; set; }
        public int VerticalId { get; set; }

        [Display(Name="Creado")]
        public DateTime Created { get; set; }
        [Display(Name = "Modificado")]
        public DateTime Modified { get; set; }

    }
}
