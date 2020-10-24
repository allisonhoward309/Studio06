using System;
using System.Collections.Generic;
using System.Text;

namespace Studio_6
{
        public class MultipleChoice : Questions
        {
            List<string> PossibleAnswers { get; set; }
            string Answer { get; set; }

        public MultipleChoice(List<string> possibleAnswers, string answer, string question) : base(question)
            {
                Answer = answer;
                PossibleAnswers = possibleAnswers;
                AvailablePoints = 1;
    }
            public override void PrintPossibleAnswers()
            {
                Dictionary<int, string> choices = new Dictionary<int, string> { };
                for (int i = 0; i < this.PossibleAnswers.Count; i++)
                {
                    choices.Add(i + 1, this.PossibleAnswers[i]);
                }
                foreach (KeyValuePair<int, string> q in choices)
                {
                    Console.WriteLine(q.Key + ": " + q.Value);
                }
            }

            public override int MatchAnswer()
            {
                Console.WriteLine("Select the choice that best answers the question.");
                string input = Console.ReadLine();
                    if (input == Answer)
                    {
                        Points += 1;
                    }
            return Points;
        }
        }
    }