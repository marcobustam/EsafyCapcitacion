using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EsafyCapcitacion.Models
{
    public class Examination
    {
        [Display(Name = "Id")]
        public int ExaminationId { get; set; }
        [Display(Name = "Curso")]
        public int CourseId { get; set; }
        [Display(Name = "Test")]
        public int CourseTestId { get; set; }
        [Display(Name = "Estudiante")]
        public int StudentId { get; set; }
        [Display(Name = "Respuestas")]
        public IList<Answer> AnswerList { get; set; }
        [Display(Name = "Creado")]
        public DateTime Created { get; set; }
        [Display(Name = "Modificado")]
        public DateTime Modified { get; set; }
        [Display(Name = "Estado")]
        public ExamState ExamState { get; set; }
    }
    public enum ExamState { Creado, Disponible, Pendiente, Realizado, Cancelado }
}
