using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EsafyCapcitacion.Models
{
    public class Course
    {
        [Display(Name = "Id")]
        public int CourseId { get; set; }
        [Display(Name = "Nombre")]
        public string CourseName { get; set; }
        [Display(Name = "Alias")]
        public string CourseShortName { get; set; }
        [Display(Name = "Código Sence")]
        public string SenceCode { get; set; }
        [Display(Name = "Nombre Sence")]
        public string SenceTitle { get; set; }
        [Display(Name = "Vertical")]
        public int VerticalId { get; set; }
        [Display(Name="Creado")]
        public DateTime Created { get; set; }
        [Display(Name = "Modificado")]
        public DateTime Modified { get; set; }
        [Display(Name = "Habilitado")]
        public bool IsAvailable { get; set; }
    }
}
