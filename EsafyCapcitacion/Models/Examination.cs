using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EsafyCapcitacion.Models
{
    public class Examination
    {
        public int ExaminationId { get; set; }
        public int CourseId { get; set; }
        public int CourseTestId { get; set; }
        public int StudentId { get; set; }
        public IList<Answer> AnswerList { get; set; }
    }
}
