using System;

namespace QuizProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //IQuestion q1 = new TrueOrFalse();
            //IQuestion q2 = new ShortAnswer();

            IQuestion q1 = QuestionFactory.NewQuestion(QuestionFactory.QuestionType.TrueOrFalse);
            IQuestion q2 = QuestionFactory.NewQuestion(QuestionFactory.QuestionType.ShortAnswer);
        }
    }
}
