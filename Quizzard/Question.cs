using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizzard
{
  public class Question
  {
    public string text, answer;

    public Question(string text, string answer)
    {
      this.text = text;
      this.answer = answer;
    }
  }
}
