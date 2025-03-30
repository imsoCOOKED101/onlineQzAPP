class TrueOrFalse : Program
{
    public TrueOrFalse(string text, string answer) : base(text, answer) { }

    // Implementation of AskQuestion method
    public override void AskQuestion()
    {
        Console.WriteLine($"{text} (True/False)"); // Display question text
    }
}
