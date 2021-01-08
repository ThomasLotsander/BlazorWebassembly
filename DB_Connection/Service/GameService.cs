using DB_Connection.Connection;
using DB_Connection.Models.GameModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using System.Web.Http.Results;

namespace DB_Connection.Service
{
    public class GameService
    {
        GameContext gameContext;
        public GameService(GameContext context)
        {
            gameContext = context;
        }
        public void AddPlayerScore(Player player)
        {
            gameContext.Players.Add(player);
        }

        public List<Player> GetHighScore()
        {
            return gameContext.Players.ToList();
        }
    }
}
