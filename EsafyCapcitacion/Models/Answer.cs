using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EsafyCapcitacion.Models
{
    public class Answer
    {
        public int AnswerId { get; set; }
        public int CourseId { get; set; }
        public int CourseTestId { get; set; }
        public int TestQuestionId { get; set; }
        public int QuestionOptionId { get; set; }
        public int StudentId { get; set; }
    }
}
