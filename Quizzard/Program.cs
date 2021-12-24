// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
global using Quizzard;

Print($"Welcome to Quizzard, the True/False quiz game!{Environment.NewLine}");
List<Question> questions = new List<Question>();

//foreach(var question in Data.questionData)
//{
//    questions.Add(new Question(question["text"], question["answer"]));
//}
var category = Input($"What category quiz would you like to take? {}")
questions.SetQuestions(Data.computerMedium); 

var quizmaster = new QuizBrain(questions);

while (quizmaster._count < quizmaster._questions.Count)
{
    quizmaster.NextQuestion();
}

Print("The quiz has ended.");
var percentCorrect = (float)quizmaster._score / (float)quizmaster._count;
percentCorrect *= 100;
Print($"You got {percentCorrect}% correct!");
GetKey("Press any key to exit...");