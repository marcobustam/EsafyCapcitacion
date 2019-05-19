using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EsafyCapcitacion.Models
{
    public class CourseTest
    {
        public int CourseTestId { get; set; }
        public string CourseTestName { get; set; }
        public int CourseId { get; set; }
        public IList<TestQuestion> QuestionList { get; set; }
    }
    public class TestQuestion
    {
        public int TestQuestionId { get; set; }
        public int CourseTestId { get; set; }
        public string QuestionTitle { get; set; }
        public string HeadingText { get; set; }
        public string SubHeadingText { get; set; }
        public IList<QuestionOption> OptionList { get; set; }

        public TestQuestion()
        {
            OptionList = new List<QuestionOption>();
        }

    }
    public class QuestionOption
    {
        public int QuestionOptionId { get; set; }
        public int TestQuestionId { get; set; }
        public string QuestionText { get; set; }
        public bool IsCorrectAns { get; set; }

    }
}
