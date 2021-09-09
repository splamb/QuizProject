using System;
using System.Collections.Generic;
using System.Text;

namespace QuizProject
{
    class Quiz
    {
        private static Quiz _instance = null;

        public static Quiz Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Quiz();
                }

                return _instance;
            }
        }

        public void Start()
        {
            Console.WriteLine("Start Quiz");
        }

    }
}
