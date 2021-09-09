using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuizProject;
using System;

namespace QuizUnitTest
{
    [TestClass]
    public class QuestionFactoryTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            IQuestion q1 = QuestionFactory.NewQuestion(QuestionFactory.QuestionType.TrueOrFalse);

            if (q1.GetType() != typeof(TrueOrFalse))
            {
                throw new Exception();
            }
        }
    }
}
