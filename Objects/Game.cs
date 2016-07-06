using System.Collections.Generic;
using System;

namespace Game.Objects
{
  public class GameMechanic
  {
    public int PlayerOne;
    public int PlayerTwo;
    public Dictionary<string, int> rps = new Dictionary<string, int>()
    {
      {"ROCK", 1},
      {"PAPER", 2},
      {"SCISSOR", 3}
    };

    public string RockPaperScissors(string P1Input, string P2Input)
     {
       var P1 = P1Input.ToUpper();
       var P2 = P2Input.ToUpper();
       if (rps.ContainsKey(P1))
       {
         PlayerOne = rps[P1];
       }
       else
       {
         PlayerOne = 0;
       }
       if (rps.ContainsKey(P2))
       {
         PlayerTwo = rps[P2];
       }
       else
       {
         PlayerTwo = 0;
       }

       if (PlayerOne == 0 || PlayerTwo == 0)
       {
         return "Invalid choice";
       } else if (PlayerOne == PlayerTwo)
         {
          return "Draw!";
         }
          else if (PlayerOne > PlayerTwo && (PlayerOne - PlayerTwo) == 2) //p1=scissor, p2=rock
          {
            return "Player Two Wins!";
          } else if  (PlayerTwo > PlayerOne && (PlayerTwo - PlayerOne) == 2)  //p1=rock, p2=scissor
          {
            return "Player One Wins!";
          } else if (PlayerOne < PlayerTwo) //p1=paper, p2=scissor
          {
            return "Player Two Wins!";
          } else if (PlayerTwo < PlayerOne) //p2=papper, p1=scissor
          {
            return "Player One Wins!";
          }
          else
          {
            return "Try Again";
        }
    }
  }
}
