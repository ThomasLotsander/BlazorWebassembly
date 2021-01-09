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
        public HttpResponseMessage AddPlayerScore(Player player)
        {
            HttpRequestMessage message = new HttpRequestMessage();
            
            try
            {
                var players = gameContext.Players.ToList();
                var existingPlayer = players.FirstOrDefault<Player>(c => c.PlayerName == player.PlayerName);
                if (existingPlayer != null)
                {
                    // Player already exists;
                    var newTime = TimeSpan.Parse(player.Time);
                    var oldTime = TimeSpan.Parse(existingPlayer.Time);
                    if (newTime.Ticks < oldTime.Ticks)
                    {
                        existingPlayer.Time = player.Time;
                        gameContext.SaveChanges();
                    }
                    return message.CreateResponse(System.Net.HttpStatusCode.Forbidden);

                }
                else
                {
                    gameContext.Players.Add(player);
                    gameContext.SaveChanges();
                    return message.CreateResponse(System.Net.HttpStatusCode.OK);
                }

            }
            catch (Exception)
            {
                return message.CreateResponse(System.Net.HttpStatusCode.BadRequest);

                throw;
            }
        }

        public List<Player> GetHighScore()
        {
            return gameContext.Players.ToList();
        }
    }
}
