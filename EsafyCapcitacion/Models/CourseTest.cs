using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EsafyCapcitacion.Models
{
    public class CourseTest
    {
        [Display(Name = "Id")]
        public int CourseTestId { get; set; }
        [Display(Name = "Nombre")]
        public string CourseTestName { get; set; }
        [Display(Name = "Curso")]
        public int CourseId { get; set; }
        [Display(Name = "Preguntas")]
        public IList<TestQuestion> QuestionList { get; set; }
        [Display(Name = "Creado")]
        public DateTime Created { get; set; }
        [Display(Name = "Modificado")]
        public DateTime Modified { get; set; }
        [Display(Name = "Habilitado")]
        public bool IsAvailable { get; set; }
    }
    public class TestQuestion
    {
        [Display(Name = "Id")]
        public int TestQuestionId { get; set; }
        [Display(Name = "Test")]
        public int CourseTestId { get; set; }
        [Display(Name = "Título")]
        public string QuestionTitle { get; set; }
        [Display(Name = "Enunciado")]
        public string HeadingText { get; set; }
        [Display(Name = "Habilitado")]
        public string SubHeadingText { get; set; }
        [Display(Name = "Opciones")]
        public IList<QuestionOption> OptionList { get; set; }
        [Display(Name = "Creado")]
        public DateTime Created { get; set; }
        [Display(Name = "Modificado")]
        public DateTime Modified { get; set; }
        public TestQuestion()
        {
            OptionList = new List<QuestionOption>();
        }

    }
    public class QuestionOption
    {
        [Display(Name = "Id")]
        public int QuestionOptionId { get; set; }
        [Display(Name = "Pregunta")]
        public int TestQuestionId { get; set; }
        [Display(Name = "Respuesta")]
        public string QuestionText { get; set; }
        [Display(Name = "Es correcta?")]
        public bool IsCorrectAns { get; set; }
        [Display(Name = "Creado")]
        public DateTime Created { get; set; }
        [Display(Name = "Modificado")]
        public DateTime Modified { get; set; }
    }
}
