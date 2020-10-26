using System;
using System.Collections.Generic;
using System.Text;

namespace Studio_6
{
    class Quiz
    {
            List<Questions> Classes { get; set; }
            int Score { get; set; }
            public int Total { get; set; }

            public Quiz(List<Questions> classes)
            {
                Classes = classes;
                Score = 0;
                Total = 0;
                
                for (int i=0; i<classes.Count; i++)
                {
                    Total += classes[i].AvailablePoints;
            }
            }
            public List<Questions> AddQuestion(Questions input)
            {
                Classes.Add(input);
                Total += input.AvailablePoints;
                
                return Classes;
            }

            public void RunTest()
            {
                for (int i = 0; i < Classes.Count; i++)
                {
                    Classes[i].PrintQuestion();
                    Classes[i].PrintPossibleAnswers();
                    int points = Classes[i].MatchAnswer();
                PointsGained(points);
                }
            }
            private void PointsGained(int pointsFromTest)
            {
                Score += pointsFromTest;
            }
        public void GradeQuiz()
        {
            Console.WriteLine("Your score is: " + Score + " / " + Total);

        }
    }
}
