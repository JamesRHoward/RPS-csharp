using System;
using System.Collections.Generic;
using Nancy;
using Game.Objects;

namespace Game
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };
      Post["/result"] = _ => {
        GameMechanic game = new GameMechanic();
        var winner = game.RockPaperScissors(Request.Form["player-one"], Request.Form["player-two"]);
        return View["result.cshtml", winner];
      };
    }
  }
}
