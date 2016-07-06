using System;
using System.Collections.Generic;
using Xunit;
using Game.Objects;

namespace Game
{
  public class GameTest
  {
    // [Fact]
    // public void GameTestForP1ROCK_P2SCISSOR()
    // {
    //   string p1wins = "Player One Wins!";
    //   GameMechanic game = new GameMechanic();
    //   string testWin = game.RockPaperScissors("rock", "scissor");
    //   Assert.Equal(p1wins, testWin);
    // }
    [Fact]
    public void GameTestForP1PAPER_P2SCISSOR()
    {
      string p2wins = "Player Two Wins!";
      GameMechanic game = new GameMechanic();
      string testWin =game.RockPaperScissors("paper", "scissor");
      Assert.Equal(p2wins, testWin);
    }
    // [Fact]
    // public void GameTestForP1PAPER_P2PAPER()
    // {
    //   string draw = "Draw!";
    //   GameMechanic game = new GameMechanic();
    //   string testWin =game.RockPaperScissors("paper", "paper");
    //   Assert.Equal(draw, testWin);
    // }
  }
}
