abstract class Program // Abstract base class representing a generic question
{
    protected string text { get; set; } // Question text
    private string answer { get; set; } // Correct answer

    // Constructor to initialize question text and answer
    public Program(string text, string answer)
    {
        this.text = text;
        this.answer = answer;
    }

    public string GetText()
    {
        return text;
    }

    public string GetAnswer()
    {
        return answer;
    }

    // Abstract method to be implemented by derived classes
    public abstract void AskQuestion();
}
