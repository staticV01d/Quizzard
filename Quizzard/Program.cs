// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
global using Quizzard;

Print($"Welcome to Quizzard, the True/False quiz game!{Environment.NewLine}");
List<Question> questions = new List<Question>();

//foreach(var question in Data.questionData)
//{
//    questions.Add(new Question(question["text"], question["answer"]));
//}
var categories = "";

foreach (var c in QuizBrain.Categories)
{
  categories += c + ", ";
}

categories = categories.Remove(categories.Length - 2);

var category = Input($"What category quiz would you like to take? \n({categories})").ToLower();

var difficultyList = QuizBrain.GetDifficulties(category);
var difficulties = "";

foreach (var d in difficultyList)
{
  difficulties += d + ", ";
}

difficulties = difficulties.Remove(difficulties.Length - 2);

var difficulty = Input($"What difficulty? ({difficulties})");

if (category == "computers")
{
  if (difficulty == "easy")
    questions.SetQuestions(Data.computerEasy);
  else if (difficulty == "medium")
    questions.SetQuestions(Data.computerMedium);
  else { /*Unavailable*/ }

}
else if (category == "math")
{
  if (difficulty == "easy")
    Print("");
  else if (difficulty == "medium")
    Print("");
  else if (difficulty == "hard")
    Print("");

}
else if (category == "video games")
{
  if (difficulty == "easy")
    Print("");
  else if (difficulty == "medium")
    Print("");
  else if (difficulty == "hard")
    Print("");
}
else if (category == "mythology")
{
  if (difficulty == "easy")
    Print("");
  else if (difficulty == "medium")
    Print("");
  else if (difficulty == "hard")
    Print("");
}
else if (category == "history")
{
  if (difficulty == "easy")
    Print("");
  else if (difficulty == "medium")
    Print("");
  else if (difficulty == "hard")
    Print("");
}
else if (category == "music")
{
  if (difficulty == "easy")
    Print("");
  else if (difficulty == "medium")
    Print("");
  else if (difficulty == "hard")
    Print("");
}
else if (category == "cars")
{
  if (difficulty == "easy")
    Print("");
  else if (difficulty == "medium")
    Print("");
  else if (difficulty == "hard")
    Print("");
}
else if (category == "general")
{
  if (difficulty == "easy")
    Print("");
  else if (difficulty == "medium")
    Print("");
  else if (difficulty == "hard")
    Print("");
}
else
{
  if (difficulty == "easy")
    Print("");
  else if (difficulty == "medium")
    Print("");
  else if (difficulty == "hard")
    Print("");
}

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
