using System;
using System.Collections.Generic;
using System.Text;

namespace Studio_6
{
        public abstract class Questions
        {
             public string Question { get; set; }
             public int Points { get; set; }
             public int AvailablePoints { get; set; }

        public Questions(string question)
            {
                Question = question;
            }

            public abstract int MatchAnswer();
            public abstract void PrintPossibleAnswers();
            public void PrintQuestion()
            {
                Console.WriteLine(Question);
            }

        }
    }
