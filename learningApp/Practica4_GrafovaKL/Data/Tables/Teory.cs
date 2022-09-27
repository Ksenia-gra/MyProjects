using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica4_GrafovaKL
{
    public class Teory
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Path { get; set; }        

        public List<Question> Questions { get; set; } = new List<Question>();
    }

    public class Question
    {
        public int Id { get; set; }

        public string QuestionText { get; set; }

        public int QuestionType { get; set; }

        public int IdTeory { get; set; }

        public List<Answer> Answers { get; set; } = new List<Answer>();
    }

    public class Answer
    {
        public int Id { get; set; }

        public string AnswerText { get; set; }

        public bool isRight { get; set; }

        public int IdQuestion { get; set; }

    }
}
