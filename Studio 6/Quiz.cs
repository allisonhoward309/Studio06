using System;
using System.Collections.Generic;
using System.Text;

namespace Studio_6
{
    class Quiz
    {
        /**/
       /* Hello*/
            public List<Questions> Classes { get; set; }
            public int Score { get; set; }
            private int Total { get; set; }

            public Quiz(List<Questions> classes)
            {
                Classes = classes;
                Score = 0;
                for (int i=0; i<classes.Count; i++)
                {
                    Total += classes[i].AvailablePoints;
                    Console.WriteLine(Total);
            }
            }
            public List<Questions> AddQuestion(Questions input)
            {
                Classes.Add(input);
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
            int grade = Score / Total * 100;
            Console.WriteLine("You scored " + grade + "%");
                
            }
        }
    }
