using System;

class Question // the mian program
{
    static void Main()
    {
        Console.WriteLine("Enter your name: ");
        string userName = Console.ReadLine();

        // to create a new quiz
        Quiz quiz = new Quiz(userName);

        quiz.AddQuestion(new MultipleChoice("1. How old is the Earth?", "B. Billion of years old", new string[] { "Hundred years old", "Billion of years old", "Thousand years old \n" }));
        quiz.AddQuestion(new MultipleChoice("2. What is the tallest mountain in the Philippines?", "A. Mount Apo", new string[] { "Mount Apo", "Mount Palug", "Mount Dulang-dulang \n" }));


        quiz.AddQuestion(new TrueOrFalse("1. Is Russia the biggest country in the world?", "True"));
        quiz.AddQuestion(new TrueOrFalse("2. The sun is a star?", "True"));
        quiz.AddQuestion(new TrueOrFalse("3. All dogs are relatives of cats?", "False"));

        quiz.Start();
    }
}
