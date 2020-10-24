using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Studio_6
{
        public class CheckBox : Questions
        {
            List<string> PossibleAnswers { get; set; }
            List<int> Answer { get; set; }
            private Dictionary<int, string> choices = new Dictionary<int, string> { };

        public CheckBox(List<string> possibleAnswers, List<int> answer, string question) : base(question)
            {
                Answer = answer;
                PossibleAnswers = possibleAnswers;
                AvailablePoints = answer.Count;
            }
            public override void PrintPossibleAnswers()
            {
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
                Console.WriteLine("Select the number of the choices that best answers the" +
                    " question and seperate your responce with commas. NOTE: There is more than " +
                    "one right answer.");
                string input = Console.ReadLine();
                int[] nums = Array.ConvertAll(input.Split(','), int.Parse);
                for (int i = 0; i < nums.Count(); i++)
                    {
                        foreach (int nbr in  choices.Keys)
                        {
                            if (nums[i] == nbr)
                            {
                                Points += 1;
                            }
                        }
                }
            return Points;
        }
        }
    }
