global using static Quizzard.QuizBrainExtensions;

namespace Quizzard;

public class QuizBrain
{
    public List<Question> _questions;
    public int _count = 0;
    public int _score = 0;

    public QuizBrain(List<Question> quizQuestions)
    {
        _questions = quizQuestions;
    }

    public void NextQuestion()
    {
        var response = Input($"Q.{_count + 1}: {_questions[_count].text} (True/False) ");
        if (string.IsNullOrEmpty(response) || string.IsNullOrWhiteSpace(response))
        {
            Print("Response was blank. try again...");
            return;
        }
        response = char.ToUpper(response[0]) + response[1..].ToLower();

        if(response == _questions[_count].answer)
        {
            Print("You got it right!");
            _score++;
        }
        else
        {
            Print("Sorry, that wasn't it...");
        }
        Print($"The correct answer was: {_questions[_count].answer}");
        _count++;
        Print($"Current Score: {_score}/{_count}{Environment.NewLine}");
    }

    // INTERNAL and STATIC
    public static readonly List<string> Categories = new() 
    { 
        "computers", 
        "math", 
        "video games", 
        "mythology", 
        "history", 
        "music", 
        "cars", 
        "general" 
    };

    public static readonly List<string> difficulty = new()
    {
        "easy",
        "medium",
        "hard"
    };

}


public static class QuizBrainExtensions
{
    public static string Input(object prompt)
    {
        if(prompt != null)
        {
            Console.WriteLine(prompt.ToString());
        }
        var output = Console.ReadLine();

        if (output != null)
            return output;
        return "";
    }
    /// <summary>
    /// Encapsualted Console.WriteLine()
    /// </summary>
    /// <param name="message"></param>
    public static void Print(object? message)
    {
        Console.WriteLine(message);
    }
    public static char GetKey(object? prompt)
    {
        if (prompt != null)
        {
            Print(prompt);
        }

        return Console.ReadKey(intercept: true).KeyChar;
    }

    public static void SetQuestions(this List<Question> list, List<Dictionary<string, string>> source)
    {
        foreach (var question in source)
        {
            list.Add(new Question(question["text"], question["answer"]));
        }
    }
}