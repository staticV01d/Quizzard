namespace Quizzard;

internal class Data
{
#pragma warning disable IDE0090 // Use 'new(...)'

  // COMPUTERS //
  public static List<Dictionary<string, string>> computerEasy = new List<Dictionary<string, string>>()
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
  public static List<Dictionary<string, string>> computerMedium = new List<Dictionary<string, string>>()
  {
        new Dictionary<string, string>()
        {
            { "text", "The first computer bug was formed by faulty wires." },
            { "answer", "False" }
        },
        new Dictionary<string, string> ()
        {
            { "text","FLAC stands for 'Free Lossless Audio Condenser'" },
            { "answer","False" }

        },
        new Dictionary<string, string> ()
        {
            { "text","All program codes have to be compiled into an executable file in order to be run. This file can then be executed on any machine." },
            { "answer","False" },
        },
        new Dictionary<string, string> ()
        {
            { "text","To bypass US Munitions Export Laws, the creator of the PGP published all the source code in book form." },
            { "answer","True" },
        },
        new Dictionary<string, string> ()
        {
            { "text","The open source program Redis is a relational database server." },
            { "answer","False" },
        },
        new Dictionary<string, string> ()
        {
            { "text","The first dual-core CPU was the Intel Pentium D." },
            { "answer","False" },
        },
        new Dictionary<string, string> ()
        {
            { "text","The last Windows operating system to be based on the Windows 9x kernel was Windows 98." },
            { "answer","False" }
        },
        new Dictionary<string, string> ()
        {
            { "text","It's not possible to format a write-protected DVD-R Hard Disk." },
            { "answer","True" }
        },
        new Dictionary<string, string> ()
        {
            { "text","Linus Sebastian is the creator of the Linux kernel, which went on to be used in Linux, Android, and Chrome OS." },
            { "answer","False" },
        },
        new Dictionary<string, string> ()
        {
            {"text","A Boolean value of '0' represents which of these words?"},{"answer","False"}
        }
  };
  //public static List<Dictionary<string, string>> computerHard = new List<Dictionary<string, string>>()
  //{
  //  new Dictionary<string, string>()
  //  {

  //  },
  //  new Dictionary<string, string>()
  //  {

  //  },
  //  new Dictionary<string, string>()
  //  {

  //  },
  //  new Dictionary<string, string>()
  //  {

  //  },
  //  new Dictionary<string, string>()
  //  {

  //  },
  //  new Dictionary<string, string>()
  //  {

  //  },
  //  new Dictionary<string, string>()
  //  {

  //  },
  //  new Dictionary<string, string>()
  //  {

  //  },
  //  new Dictionary<string, string>()
  //  {

  //  },
  //  new Dictionary<string, string>()
  //  {

  //  }
  //};
  #region
  // MATH //
  //public static List<Dictionary<string, string>> mathEasy = new List<Dictionary<string, string>>()
  //{
  //  new Dictionary<string, string>()
  //  {

  //  },
  //  new Dictionary<string, string>()
  //  {

  //  },
  //  new Dictionary<string, string>()
  //  {

  //  },
  //  new Dictionary<string, string>()
  //  {

  //  },
  //  new Dictionary<string, string>()
  //  {

  //  },
  //  new Dictionary<string, string>()
  //  {

  //  },
  //  new Dictionary<string, string>()
  //  {

  //  },
  //  new Dictionary<string, string>()
  //  {

  //  },
  //  new Dictionary<string, string>()
  //  {

  //  },
  //  new Dictionary<string, string>()
  //  {

  //  }
  //};
  //public static List<Dictionary<string, string>> mathMedium = new List<Dictionary<string, string>>()
  //{
  //  new Dictionary<string, string>()
  //  {

  //  },
  //  new Dictionary<string, string>()
  //  {

  //  },
  //  new Dictionary<string, string>()
  //  {

  //  },
  //  new Dictionary<string, string>()
  //  {

  //  },
  //  new Dictionary<string, string>()
  //  {

  //  },
  //  new Dictionary<string, string>()
  //  {

  //  },
  //  new Dictionary<string, string>()
  //  {

  //  },
  //  new Dictionary<string, string>()
  //  {

  //  },
  //  new Dictionary<string, string>()
  //  {

  //  },
  //  new Dictionary<string, string>()
  //  {

  //  }
  //};
  //public static List<Dictionary<string, string>> mathHard = new List<Dictionary<string, string>>()
  //{
  //  new Dictionary<string, string>()
  //  {

  //  },
  //  new Dictionary<string, string>()
  //  {

  //  },
  //  new Dictionary<string, string>()
  //  {

  //  },
  //  new Dictionary<string, string>()
  //  {

  //  },
  //  new Dictionary<string, string>()
  //  {

  //  },
  //  new Dictionary<string, string>()
  //  {

  //  },
  //  new Dictionary<string, string>()
  //  {

  //  },
  //  new Dictionary<string, string>()
  //  {

  //  },
  //  new Dictionary<string, string>()
  //  {

  //  },
  //  new Dictionary<string, string>()
  //  {

  //  }
  //};
  //
  #endregion
  // Video Games //
  public static List<Dictionary<string, string>> videoGamesEasy = new List<Dictionary<string, string>>()
  {
    new Dictionary<string, string>()
    {
      { "text","The main character in the 'Half-Life' franchise is named Morgan Freeman." },
      { "answer","False" }
    },
    new Dictionary<string, string>()
    {
      { "text","Big the Cat is a playable character in 'Sonic Generations'." },
      { "answer","False" }
    },
    new Dictionary<string, string>()
    {
      { "text","Niko Bellic is the protagonist of Grand Theft Auto IV." },
      { "answer","True" }
    },
    new Dictionary<string, string>()
    {
      { "text","In Team Fortress 2, being disguised as a scout or medic results in a speed boost." },
      { "answer","False" }
    },
    new Dictionary<string, string>()
    {
      { "text","In Sonic the Hedgehog universe, Tails' real name is Miles Prower." },
      { "answer","True" }
    },
    new Dictionary<string, string>()
    {
      { "text","In Pokémon, Arbok evolves into Seviper." },
      { "answer","False" }
    },
    new Dictionary<string, string>()
    {
      { "text","Valve's 'Portal' and 'Half-Life' franchises exist within the same in-game universe." },
      { "answer","True" }
    },
    new Dictionary<string, string>()
    {
      { "text","The game 'Pocket Morty' has a Morty called 'Pocket Mortys Morty'?" },
      { "answer","True" }
    },
    new Dictionary<string, string>()
    {
      { "text","'Sonic the Hedgehog 2' originally was going to have a time travel system." },
      { "answer","True" }
    },
    new Dictionary<string, string>()
    {
      { "text","The shotgun appears in every numbered Resident Evil game." },
      { "answer","True" }
    }
  };
  public static List<Dictionary<string, string>> videoGamesMedium = new List<Dictionary<string, string>>()
  {
    new Dictionary<string, string>()
    {
      { "text","In World of Warcraft lore, Thrall is the original wielder of 'Doomhammer'." },
      { "answer","False" }
    },
    new Dictionary<string, string>()
    {
      { "text","In 'Overwatch,' an allied McCree will say 'Step right up' upon using his ultimate ability Deadeye." },
      { "answer","True" }
    },
    new Dictionary<string, string>()
    {
      { "text","The Sniper's SMG in Team Fortress 2, was originally intended to be the Scout's primary weapon." },
      { "answer","True" }
    },
    new Dictionary<string, string>()
    {
      { "text","Pistons were added to Minecraft in Beta 1.5." },
      { "answer","False" }
    },
    new Dictionary<string, string>()
    {
      { "text","In Monster Hunter Generations, guild style is a type of hunting style." },
      { "answer","True" }
    },
    new Dictionary<string, string>()
    {
      { "text","In Riot Games 'League of Legends' the name of Halloween event is called 'The Reckoning'." },
      { "answer","False" }
    },
    new Dictionary<string, string>()
    {
      { "text","In the video game 'Transistor', 'Red' is the name of the main character." },
      { "answer","True" }
    },
    new Dictionary<string, string>()
    {
      { "text","In 'Call Of Duty, Zombies', you can upgrade the 'Apothicon Servant' in the 'Shadows Of Evil' map." },
      { "answer","False" }
    },
    new Dictionary<string, string>()
    {
      { "text","'Return to Castle Wolfenstein' was the only game of the Wolfenstein series where you don't play as William 'B.J.' Blazkowicz." },
      { "answer","False" }
    },
    new Dictionary<string, string>()
    {
      { "text","In the Season One Championship of 'League of Legends', the highest achievable rank was Diamond." },
      { "answer","False" }
    }
  };
  public static List<Dictionary<string, string>> videoGamesHard = new List<Dictionary<string, string>>()
  {
    new Dictionary<string, string>()
    {
      { "text","The retail disc of Tony Hawk's Pro Skater 5 only comes with the tutorial." },
      { "answer","True" }
    },
    new Dictionary<string, string>()
    {
      { "text","In 'The Sims' series, the most members in a household you can have is 8." },
      { "answer","True" }
    },
    new Dictionary<string, string>()
    {
      { "text","The first 'Metal Gear' game was released for the PlayStation 1." },
      { "answer","False" }
    },
    new Dictionary<string, string>()
    {
      { "text","In 'Portal 2', Cave Johnson started out Aperture Science as a shower curtain company." },
      { "answer","True" }
    },
    new Dictionary<string, string>()
    {
      { "text","In Undertale, having a 'Fun Value' set to 56-57 will play the 'Wrong Number Song Call'." },
      { "answer","False" }
    },
    new Dictionary<string, string>()
    {
      { "text","TF2, Sentry rocket damage falloff is calculated based on the distance between the sentry and the enemy, not the engineer and the enemy" },
      { "answer","False" }
    },
    new Dictionary<string, string>()
    {
      { "text","The names of Roxas's Keyblades in Kingdom Hearts are 'Oathkeeper' and 'Oblivion'." },
      { "answer","True" }
    },
    new Dictionary<string, string>()
    {
      { "text","All of these maps were in 'Tom Clancy's Rainbow Six Siege' on its initial release, House, Clubhouse, Border, Consulate." },
      { "answer","False" }
    },
    new Dictionary<string, string>()
    {
      { "text","The video game 'Fuel' has an open world that is 5,560 square miles?" },
      { "answer","True" }
    },
    new Dictionary<string, string>()
    {
      { "text","In 'Minecraft', gold tools are faster than diamond tools." },
      { "answer","True" }
    }
  };
  #region
  // MYTHOLOGY //
  public static List<Dictionary<string, string>> mythEasy = new List<Dictionary<string, string>>()
  {
    new Dictionary<string, string>()
    {

    },
    new Dictionary<string, string>()
    {

    },
    new Dictionary<string, string>()
    {

    },
    new Dictionary<string, string>()
    {

    },
    new Dictionary<string, string>()
    {

    },
    new Dictionary<string, string>()
    {

    },
    new Dictionary<string, string>()
    {

    },
    new Dictionary<string, string>()
    {

    },
    new Dictionary<string, string>()
    {

    },
    new Dictionary<string, string>()
    {

    }
  };
  public static List<Dictionary<string, string>> mythMedium = new List<Dictionary<string, string>>()
  {
    new Dictionary<string, string>()
    {

    },
    new Dictionary<string, string>()
    {

    },
    new Dictionary<string, string>()
    {

    },
    new Dictionary<string, string>()
    {

    },
    new Dictionary<string, string>()
    {

    },
    new Dictionary<string, string>()
    {

    },
    new Dictionary<string, string>()
    {

    },
    new Dictionary<string, string>()
    {

    },
    new Dictionary<string, string>()
    {

    },
    new Dictionary<string, string>()
    {

    }
  };
  public static List<Dictionary<string, string>> mythHard = new List<Dictionary<string, string>>()
  {
    new Dictionary<string, string>()
    {

    },
    new Dictionary<string, string>()
    {

    },
    new Dictionary<string, string>()
    {

    },
    new Dictionary<string, string>()
    {

    },
    new Dictionary<string, string>()
    {

    },
    new Dictionary<string, string>()
    {

    },
    new Dictionary<string, string>()
    {

    },
    new Dictionary<string, string>()
    {

    },
    new Dictionary<string, string>()
    {

    },
    new Dictionary<string, string>()
    {

    }
  };
  #endregion
  // HISTORY //
  public static List<Dictionary<string, string>> historyEasy = new List<Dictionary<string, string>>()
  {
    new Dictionary<string, string>()
    {
      { "text","The Cold War ended with Joseph Stalin's death." },
      { "answer","False" }
    },
    new Dictionary<string, string>()
    {
      { "text","The United States was a member of the League of Nations." },
      { "answer","False" }
    },
    new Dictionary<string, string>()
    {
      { "text","United States President John F. Kennedy was assassinated during his presidential motorcade in Atlanta, Georgia on November 22nd, 1963." },
      { "answer","False" }
    },
    new Dictionary<string, string>()
    {
      { "text","Former United States Presidents John Adams and Thomas Jefferson died within hours of each other." },
      { "answer","True" }
    },
    new Dictionary<string, string>()
    {
      { "text","Adolf Hitler was a german soldier in World War I." },
      { "answer","True" }
    },
    new Dictionary<string, string>()
    {
      { "text","The United States of America declared their independence from the British Empire on July 4th, 1776." },
      { "answer","True" }
    },
    new Dictionary<string, string>()
    {
      { "text","Adolf Hitler was tried at the Nuremberg trials." },
      { "answer","False" }
    },
    new Dictionary<string, string>()
    {
      { "text","Kublai Khan is the grandchild of Genghis Khan?" },
      { "answer","True" }
    },
    new Dictionary<string, string>()
    {
      { "text","The United States of America was the first country to launch a man into space." },
      { "answer","False" }
    },
    new Dictionary<string, string>()
    {
      { "text","Thomas Crapper was a plumber who invented the flushing toilet." },
      { "answer","False" }
    }
  };
  public static List<Dictionary<string, string>> historyMedium = new List<Dictionary<string, string>>()
  {
    new Dictionary<string, string>()
    {
      { "text","The M41 Walker Bulldog remains in service in some countries to this day." },
      { "answer","True" }
    },
    new Dictionary<string, string>()
    {
      { "text","Assyrian king Sennacherib&#039;s destruction of Babylon in 689 BCE was viewed as a triumph by other Assyrian citizens." },
      { "answer","False" }
    },
    new Dictionary<string, string>()
    {
      { "text","Brezhnev was the 5th leader of the USSR." },
      { "answer","True" }
    },
    new Dictionary<string, string>()
    {
      { "text","If you grab the bladed end of a longsword in a specific way, you will not cut yourself." },
      { "answer","True" }
    },
    new Dictionary<string, string>()
    {
      { "text","Abraham Lincoln was the first U.S. President to be born outside the borders of the thirteen original states. " },
      { "answer","True" }
    },
    new Dictionary<string, string>()
    {
      { "text","Martin Luther King Jr. and Anne Frank were born the same year. " },
      { "answer","True" }
    },
    new Dictionary<string, string>()
    {
      { "text","Oxford University is older than the Aztec Empire. " },
      { "answer","True" }
    },
    new Dictionary<string, string>()
    {
      { "text","The Korean War ended in 1953 without any ceasefire." },
      { "answer","False" }
    },
    new Dictionary<string, string>()
    {
      { "text","Sir Issac Newton served as a Member of Parliament, but the only recorded time he spoke was to complain about a draft in the chambers." },
      { "answer","True" }
    },
    new Dictionary<string, string>()
    {
      { "text","Franz Joseph I was the last emperor of Austria." },
      { "answer","False" }
    }
  };
  #region
  //public static List<Dictionary<string, string>> historyHard = new List<Dictionary<string, string>>()
  //{
  //  new Dictionary<string, string>()
  //  {

  //  },
  //  new Dictionary<string, string>()
  //  {

  //  },
  //  new Dictionary<string, string>()
  //  {

  //  },
  //  new Dictionary<string, string>()
  //  {

  //  },
  //  new Dictionary<string, string>()
  //  {

  //  },
  //  new Dictionary<string, string>()
  //  {

  //  },
  //  new Dictionary<string, string>()
  //  {

  //  },
  //  new Dictionary<string, string>()
  //  {

  //  },
  //  new Dictionary<string, string>()
  //  {

  //  },
  //  new Dictionary<string, string>()
  //  {

  //  }
  //};
  #endregion
  // MUSIC //
  public static List<Dictionary<string, string>> musicEasy = new List<Dictionary<string, string>>()
  {
    new Dictionary<string, string>()
    {
      { "text","The music video to The Buggle's 'Video Killed the Radio Star' was the first music video to broadcast on MTV." },
      { "answer","True" }
    },
    new Dictionary<string, string>()
    {
      { "text","Eurobeat is primarily an Italian genre of music." },
      { "answer","True" }
    },
    new Dictionary<string, string>()
    {
      { "text","American rapper Dr. Dre actually has a Ph.D. doctorate." },
      { "answer","False" }
    },
    new Dictionary<string, string>()
    {
      { "text","The alternative rock band, They Might Be Giants, released their album 'Flood' in 1990. " },
      { "answer","True" }
    },
    new Dictionary<string, string>()
    {
      { "text","Daft Punk originated in France." },
      { "answer","True" }
    },
    new Dictionary<string, string>()
    {
      { "text","Scatman John's real name was John Paul Larkin." },
      { "answer","True" }
    },
    new Dictionary<string, string>()
    {
      { "text","Michael Jackson wrote The Simpsons song 'Do the Bartman'." },
      { "answer","False" }
    },
    new Dictionary<string, string>()
    {
      { "text","In 1993, Prince changed his name to an unpronounceable symbol because he was unhappy with his contract with Warner Bros." },
      { "answer","True" }
    },
    new Dictionary<string, string>()
    {
      { "text","The 2011 movie 'The Adventures of Tintin' was directed by Steven Spielberg." },
      { "answer","True" }
    },
    new Dictionary<string, string>()
    {
      { "text","Lead Singer Rivers Cuomo of American rock band Weezer attended Harvard." },
      { "answer","True" }
    }
  };
  public static List<Dictionary<string, string>> musicMedium = new List<Dictionary<string, string>>()
  {
    new Dictionary<string, string>()
    {
      { "text","Rapper Snoop Dogg's real name is 'Cordozar Calvin Broadus, Jr.'." },
      { "answer","True" }
    },
    new Dictionary<string, string>()
    {
      { "text","Soulja Boy's 'Crank That' won a Grammy for Best Rap Song in 2007." },
      { "answer","False" }
    },
    new Dictionary<string, string>()
    {
      { "text","Norwegian producer Kygo released a remix of the song 'Sexual Healing' by Marvin Gaye." },
      { "answer","True" }
    },
    new Dictionary<string, string>()
    {
      { "text","The country song  'A Boy Named Sue' was written by Shel Silverstein." },
      { "answer","True" }
    },
    new Dictionary<string, string>()
    {
      { "text","'The Division Bell' is the final album of the progressive rock band Pink Floyd." },
      { "answer","False" }
    },
    new Dictionary<string, string>()
    {
      { "text","'Twenty One Pilots' made the song 'The Motion' featuring Sampha." },
      { "answer","False" }
    },
    new Dictionary<string, string>()
    {
      { "text","EDM label Monstercat signs tracks instead of artists." },
      { "answer","True" }
    },
    new Dictionary<string, string>()
    {
      { "text","3 members of 2 Live Crew were arrested for playing songs from their album, As Nasty As They Wanna Be, live." },
      { "answer","True" }
    },
    new Dictionary<string, string>()
    {
      { "text","Dave Grohl recorded the Foo Fighters' debut, 'Foo Fighters,' by himself." },
      { "answer","True" }
    },
    new Dictionary<string, string>()
    {
      { "text","'Neutral Milk Hotel' is a real band." },
      { "answer","True" }
    }
  };
  #region
  //public static List<Dictionary<string, string>> musicHard = new List<Dictionary<string, string>>()
  //{
  //  new Dictionary<string, string>()
  //  {

  //  },
  //  new Dictionary<string, string>()
  //  {

  //  },
  //  new Dictionary<string, string>()
  //  {

  //  },
  //  new Dictionary<string, string>()
  //  {

  //  },
  //  new Dictionary<string, string>()
  //  {

  //  },
  //  new Dictionary<string, string>()
  //  {

  //  },
  //  new Dictionary<string, string>()
  //  {

  //  },
  //  new Dictionary<string, string>()
  //  {

  //  },
  //  new Dictionary<string, string>()
  //  {

  //  },
  //  new Dictionary<string, string>()
  //  {

  //  }
  //};
  #endregion

  #region
  // CARS //
  public static List<Dictionary<string, string>> carsEasy = new List<Dictionary<string, string>>()
  {
    new Dictionary<string, string>()
    {

    },
    new Dictionary<string, string>()
    {

    },
    new Dictionary<string, string>()
    {

    },
    new Dictionary<string, string>()
    {

    },
    new Dictionary<string, string>()
    {

    },
    new Dictionary<string, string>()
    {

    },
    new Dictionary<string, string>()
    {

    },
    new Dictionary<string, string>()
    {

    },
    new Dictionary<string, string>()
    {

    },
    new Dictionary<string, string>()
    {

    }
  };
  public static List<Dictionary<string, string>> carsMedium = new List<Dictionary<string, string>>()
  {
    new Dictionary<string, string>()
    {

    },
    new Dictionary<string, string>()
    {

    },
    new Dictionary<string, string>()
    {

    },
    new Dictionary<string, string>()
    {

    },
    new Dictionary<string, string>()
    {

    },
    new Dictionary<string, string>()
    {

    },
    new Dictionary<string, string>()
    {

    },
    new Dictionary<string, string>()
    {

    },
    new Dictionary<string, string>()
    {

    },
    new Dictionary<string, string>()
    {

    }
  };
  public static List<Dictionary<string, string>> carsHard = new List<Dictionary<string, string>>()
  {
    new Dictionary<string, string>()
    {

    },
    new Dictionary<string, string>()
    {

    },
    new Dictionary<string, string>()
    {

    },
    new Dictionary<string, string>()
    {

    },
    new Dictionary<string, string>()
    {

    },
    new Dictionary<string, string>()
    {

    },
    new Dictionary<string, string>()
    {

    },
    new Dictionary<string, string>()
    {

    },
    new Dictionary<string, string>()
    {

    },
    new Dictionary<string, string>()
    {

    }
  };
  #endregion

  // GENERAL //
  public static List<Dictionary<string, string>> genEasy = new List<Dictionary<string, string>>()
  {
    new Dictionary<string, string>()
    {
      { "text","The Great Wall of China is visible from the moon." },
      { "answer","False" }
    },
    new Dictionary<string, string>()
    {
      { "text","French is an official language in Canada." },
      { "answer","True" }
    },
    new Dictionary<string, string>()
    {
      { "text","It is automatically considered entrapment in the United States if the police sell you illegal substances without revealing themselves." },
      { "answer","False" }
    },
    new Dictionary<string, string>()
    {
      { "text","Bulls are attracted to the color red." },
      { "answer","False" }
    },
    new Dictionary<string, string>()
    {
      { "text","You can legally drink alcohol while driving in Mississippi." },
      { "answer","True" }
    },
    new Dictionary<string, string>()
    {
      { "text","In 2010, Twitter and the United States Library of Congress partnered together to archive every tweet by American citizens." },
      { "answer","True" }
    },
    new Dictionary<string, string>()
    {
      { "text","One of Donald Trump's 2016 Presidential Campaign promises was to build a border wall between the United States and Mexico." },
      { "answer","True" }
    },
    new Dictionary<string, string>()
    {
      { "text","Scotland voted to become an independent country during the referendum from September 2014." },
      { "answer","False" }
    },
    new Dictionary<string, string>()
    {
      { "text","Vietnam's national flag is a red star in front of a yellow background." },
      { "answer","False" }
    },
    new Dictionary<string, string>()
    {
      { "text","Slovakia is a member of European Union" },
      { "answer","True" }
    }
  };
  public static List<Dictionary<string, string>> genMedium = new List<Dictionary<string, string>>()
  {
    new Dictionary<string, string>()
    {
      { "text","Coca-Cola's original colour was green." },
      { "answer","False" }
    },
    new Dictionary<string, string>()
    {
      { "text","The vapor produced by e-cigarettes is actually water." },
      { "answer","False" }
    },
    new Dictionary<string, string>()
    {
      { "text","The bikini is named after the 'Bikini Atoll', an island where the United States conducted tests on atomic bombs." },
      { "answer","True" }
    },
    new Dictionary<string, string>()
    {
      { "text","Cucumbers are usually more than 90% water." },
      { "answer","True" }
    },
    new Dictionary<string, string>()
    {
      { "text","Kissing someone for one minute burns about 2 calories." },
      { "answer","True" }
    },
    new Dictionary<string, string>()
    {
      { "text","Sitting for more than three hours a day can cut two years off a person's life expectancy." },
      { "answer","True" }
    },
    new Dictionary<string, string>()
    {
      { "text","The French word for 'glass' is 'glace'." },
      { "answer","False" }
    },
    new Dictionary<string, string>()
    {
      { "text","Popcorn was invented in 1871 by Frederick W. Rueckheim in the USA where he sold the snack on the streets of Chicago." },
      { "answer","False" }
    },
    new Dictionary<string, string>()
    {
      { "text","The pickled gherkin was first added to hamburgers because a US health law required all fast-food to include a source of Vitamin C." },
      { "answer","False" }
    },
    new Dictionary<string, string>()
    {
      { "text","'Buffalo buffalo Buffalo buffalo buffalo buffalo Buffalo buffalo.' is a grammatically correct sentence." },
      { "answer","True" }
    }
  };
  #region
  //public static List<Dictionary<string, string>> genHard = new List<Dictionary<string, string>>()
  //{
  //  new Dictionary<string, string>()
  //  {

  //  },
  //  new Dictionary<string, string>()
  //  {

  //  },
  //  new Dictionary<string, string>()
  //  {

  //  },
  //  new Dictionary<string, string>()
  //  {

  //  },
  //  new Dictionary<string, string>()
  //  {

  //  },
  //  new Dictionary<string, string>()
  //  {

  //  },
  //  new Dictionary<string, string>()
  //  {

  //  },
  //  new Dictionary<string, string>()
  //  {

  //  },
  //  new Dictionary<string, string>()
  //  {

  //  },
  //  new Dictionary<string, string>()
  //  {

  //  }
  //};
  #endregion

#pragma warning restore IDE0090 // Use 'new(...)'
}

