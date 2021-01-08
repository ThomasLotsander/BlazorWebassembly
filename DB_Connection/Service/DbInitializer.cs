using DB_Connection.Connection;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using DB_Connection.Models.GameModels;

namespace DB_Connection.Service
{
    public static class DbInitializer
    {
        public static void Initialize(GameContext context)
        {
            try
            {
                context.Database.EnsureCreated();

                if (context.Players.Any())
                {
                    return;
                }

                var players = new Player[]
                {
                    new Player()
                    {
                       PlayerName = "Thomas",
                       Time = "00:45:12"
                    },
                     new Player()
                    {
                       PlayerName = "Mia",
                       Time = "00:30:45"
                    }
                };

                foreach (var player in players)
                {
                    context.Players.Add(player);
                }

                context.SaveChanges();
            }
            catch (Exception e)
            {
                // TODO: Add logging 
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
