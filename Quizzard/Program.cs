// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
global using Quizzard;

Print($"Welcome to Quizzard, the True/False quiz game!{Environment.NewLine}");
List<Question> questions = new List<Question>();

//foreach(var question in Data.questionData)
//{
//    questions.Add(new Question(question["text"], question["answer"]));
//}

bool verifyInput = false;

while (!verifyInput)
{
  var categories = "";

  foreach (var c in QuizBrain.Categories)
  {
    categories += c + ", ";
  }

  categories = categories.TrimEnd(',',' ');

  var category = Input($"What category quiz would you like to take? \n({categories})").ToLower();

  var difficultyList = QuizBrain.GetDifficulties(category);
  var difficulties = "";

  foreach (var d in difficultyList)
  {
    difficulties += d + ", ";
  }
  // TODO: Get This working (Put the right stuff in the right place)
  difficulties = difficulties.TrimEnd(',',' ');

  var difficulty = Input($"What difficulty? ({difficulties})");
  if (category == "computers")
  {
    if (difficulty == "easy")
    {
      questions.SetQuestions(Data.computerEasy);
      verifyInput = true;
    }
    else if (difficulty == "medium")
    {
      questions.SetQuestions(Data.computerMedium);
      verifyInput = true;
    }
  }
  //else if (category == "math")
  //{
  //  if (difficulty == "easy")
  //    Print("");
  //  else if (difficulty == "medium")
  //    Print("");
  //  else if (difficulty == "hard")
  //    Print("");
  //}
  else if (category == "video games")
  {
    if (difficulty == "easy")
    {
      questions.SetQuestions(Data.videoGamesEasy);
      verifyInput = true;
    }
    else if (difficulty == "medium")
    {
      questions.SetQuestions(Data.videoGamesMedium);
      verifyInput = true;
    }
    else if (difficulty == "hard")
    {
      questions.SetQuestions(Data.videoGamesHard);
      verifyInput = true;
    }
  }
  //else if (category == "mythology")
  //{
  //  if (difficulty == "easy")
  //    Print("");
  //  else if (difficulty == "medium")
  //    Print("");
  //  else if (difficulty == "hard")
  //    Print("");
  //}
  else if (category == "history")
  {
    if (difficulty == "easy")
    {
      questions.SetQuestions(Data.historyEasy);
      verifyInput = true;
    }
    else if (difficulty == "medium")
    {
      questions.SetQuestions(Data.historyMedium);
      verifyInput = true;
    }
    else
      Print("Difficulty setting not available");
  }
  else if (category == "music")
  {
    if (difficulty == "easy")
    {
      questions.SetQuestions(Data.musicEasy);
      verifyInput = true;
    }
    else if (difficulty == "medium")
    {
      questions.SetQuestions(Data.musicMedium);
      verifyInput = true;
    }
    else
      Print("Difficulty setting not available");
  }
  //else if (category == "cars")
  //{
  //  if (difficulty == "easy")
  //    Print("");
  //  else if (difficulty == "medium")
  //    Print("");
  //  else if (difficulty == "hard")
  //    Print("");
  //}
  else if (category == "general")
  {
    if (difficulty == "easy")
    {
      questions.SetQuestions(Data.genEasy);
      verifyInput = true;
    }
    else if (difficulty == "medium")
    {
      questions.SetQuestions(Data.genMedium);
      verifyInput = true;
    }
    else
      Print("Difficulty setting not available");
  }
  else
    Print("Category not available");
}

Console.Clear();
Console.WriteLine("Let's begin!");
Console.WriteLine(Environment.NewLine);
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
