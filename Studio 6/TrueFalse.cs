using System;
using System.Collections.Generic;
using System.Text;

namespace Studio_6
{
    class TrueFalse : Questions
    {
        public bool Answer { get; set; }
        

        public TrueFalse(bool answer, string question) : base(question)
        {
            Answer = answer;
            AvailablePoints = 1;
        }

        public override void PrintPossibleAnswers()
        {
            Console.WriteLine("True \nFalse");
        }

        public override int MatchAnswer()
        {
            Console.WriteLine("Enter True or False.");
            string input = Console.ReadLine();
            bool responce = bool.Parse(input);
            if (responce == Answer)
            {
                Points += 1;
            }

            return Points;
        }


    }
}
