using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EsafyCapcitacion.Models
{
    public class Answer
    {
        [Display(Name = "Id")]
        public int AnswerId { get; set; }
        [Display(Name = "Curso")]
        public int CourseId { get; set; }
        [Display(Name = "Test")]
        public int CourseTestId { get; set; }
        [Display(Name = "Pregunta")]
        public int TestQuestionId { get; set; }
        [Display(Name = "Opción")]
        public int QuestionOptionId { get; set; }
        [Display(Name = "Estudiante")]
        public int StudentId { get; set; }
        [Display(Name = "Creado")]
        public DateTime Created { get; set; }
        [Display(Name = "Modificado")]
        public DateTime Modified { get; set; }
    }
}
