using System;
using System.Collections.Generic;

namespace Studio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string question1 = "What is your favorite color?";
            List<string> answer1 = new List<string> { "blue", "Green", "Brown" };
            string answer = "blue";
            MultipleChoice multipleChoice = new MultipleChoice(answer1, answer, question1);

            string question2 = "True/False Is the sky purple?";
            bool answer2 = false;
            TrueFalse trueFalse = new TrueFalse(answer2, question2);

            string question3 = "Which are numbers?";
            List<string> answer3 = new List<string> { "1", "2", "Benny G", "23" };
            List<int> checkBoxAnswer = new List<int> { 1, 2, 4 };
            CheckBox checkBox = new CheckBox(answer3, checkBoxAnswer, question3);

            Quiz quiz = new Quiz(new List<Questions>());
            quiz.AddQuestion(trueFalse);
            quiz.AddQuestion(multipleChoice);
            quiz.AddQuestion(checkBox);


            quiz.RunTest();
            quiz.GradeQuiz();

        }
    }
}