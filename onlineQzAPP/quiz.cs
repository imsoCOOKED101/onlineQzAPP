class Quiz
{
    private List<Program> questions = new List<Program>(); // List to store questions
    private List<string> userAnswers = new List<string>(); // List to store user answers
    private string userName; // Store user's name
    private int score = 0; // Score counter

    // Constructor to initialize the quiz with the user's name
    public Quiz(string userName)
    {
        this.userName = userName;
    }

    public void AddQuestion(Program q)
    {
        questions.Add(q);
    }

    public void Start()
    {
        Console.WriteLine($"\nWelcome, {userName}! Let's start the quiz...\n");

        foreach (var question in questions)
        {
            question.AskQuestion();
            string? userAnswer;

            while (true)
            {
                Console.Write("Your Answer: ");
                userAnswer = Console.ReadLine()?.Trim();

                if (question is MultipleChoice)
                {
                    if (userAnswer.Length == 1 && "ABC".Contains(userAnswer.ToUpper()))
                        break;
                }
                else if (question is TrueOrFalse)
                {
                    if (userAnswer.Equals("True", StringComparison.OrdinalIgnoreCase) ||
                        userAnswer.Equals("False", StringComparison.OrdinalIgnoreCase))
                        break;
                }
                Console.WriteLine("Invalid input! Please enter a valid choice.");
            }

            userAnswers.Add(userAnswer);

            // this will check if the answer is correct
            if (userAnswer.Equals(question.GetAnswer(), StringComparison.OrdinalIgnoreCase))
            {
                score++; // increment the score
            }
        }
        //display the resul of the quiz
        Console.WriteLine($"\nQuiz Completed! Here are your results, {userName}:\n");
        for (int i = 0; i < questions.Count; i++)
        {
            string correctness = userAnswers[i].Equals(questions[i].GetAnswer(), StringComparison.OrdinalIgnoreCase) ? "✓ Correct" : "x Incorrect";
            Console.WriteLine($"{i + 1}. {questions[i].GetText()}");
            Console.WriteLine($"   Your Answer: {userAnswers[i]} | Correct Answer: {questions[i].GetAnswer()} -> {correctness}\n");
        }
        Console.WriteLine($"Final Score: {score} / {questions.Count}"); //this display the overall score
    }
}