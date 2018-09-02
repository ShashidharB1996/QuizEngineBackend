using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizServer.Models
{
    public class Question
    {
        public int Quesid { get; set; }
        public string QuestionText { get; set; }
        public List<Option> Options { get; set; }
    }

    public class Option
    {
        public int Opid { get; set; }
        public string OptionText { get; set; }
    }
}
