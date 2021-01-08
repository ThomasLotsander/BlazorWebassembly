using DB_Connection.Models.GameModels;
using Microsoft.EntityFrameworkCore;

namespace DB_Connection.Connection
{
    public class GameContext : DbContext
    {

        public GameContext(DbContextOptions options) : base(options)
        {
        }

        

        public DbSet<LevelInfo> LevelInfo { get; set; }
        public DbSet<Player> Players { get; set; }

    }
}
