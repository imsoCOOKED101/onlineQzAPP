using static System.Net.Mime.MediaTypeNames;

class MultipleChoice : Program
{
    private string[] options; // Options for the multiple-choice question
    private char[] optionLabels = { 'A', 'B', 'C' }; // Labels for options

    // Constructor to initialize the question, answer, and options
    public MultipleChoice(string text, string answer, string[] options) : base(text, answer)
    {
        this.options = options;
    }

    // Implementation of AskQuestion method
    public override void AskQuestion()
    {
        Console.WriteLine($"{text}\n"); // Display question text
        for (int i = 0; i < options.Length; i++)
        {
            Console.WriteLine($"{optionLabels[i]}. {options[i]}");
        }
    }
}