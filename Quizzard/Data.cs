namespace Quizzard;

internal class Data
{
#pragma warning disable IDE0090 // Use 'new(...)'
    public static List<Dictionary<string, string>> computerMedium = new List<Dictionary<string, string>>()
#pragma warning restore IDE0090 // Use 'new(...)'
    {
        new Dictionary<string, string>()
        {
            { "text", "Linus Torvalds created Linux and Git." },
            { "answer", "True" }
        },
        new Dictionary<string, string> ()
        {
            { "text", "The programming language \"Python\" is based off a modified version of \"JavaScript\"." },
            { "answer", "False" }

        },
        new Dictionary<string, string> ()
        {
            { "text", "The logo for Snapchat is a Bell." },
            { "answer", "False" }
        },
        new Dictionary<string, string> ()
        {
            { "text", "Pointers were not used in the original C programming language; they were added later on in C++." },
            { "answer", "False" }
        },
        new Dictionary<string, string> ()
        {
            { "text", "RAM stands for Random Access Memory." },
            { "answer", "True" }
        },
        new Dictionary<string, string> ()
        {
            { "text", "Ada Lovelace is often considered the first computer programmer." },
            { "answer", "True" }
        },
        new Dictionary<string, string> ()
        {
            { "text", "Time on Computers is measured via the EPOX System." },
            { "answer", "False" }
        },
        new Dictionary<string, string> ()
        {
            { "text", "The Windows 7 operating system has six main editions." },
            { "answer", "True" }
        },
        new Dictionary<string, string> ()
        {
            { "text", "The Windows ME operating system was released in the year 2000." },
            { "answer", "True" }
        },
        new Dictionary<string, string> ()
        {
            { "text", "The NVidia GTX 1080 gets its name because it can only render at a 1920x1080 screen resolution." },
            { "answer", "False" }
        }
    };
}

