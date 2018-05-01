using System;
using System.Collections.Generic;

namespace css566OnlineCourse.Models
{
    public class MultipleChoiceQuestion
    {
        //public MultipleChoiceQuestion()
        //{
        //}
        public String Question { get; set; }
        public List<String> Options { get; set; }
        public String Answer { get; set; }
    }

    public class Quiz
    {
        public Dictionary<String, MultipleChoiceQuestion> MultipleChoiceQuestions { get; set; }
    }
}
