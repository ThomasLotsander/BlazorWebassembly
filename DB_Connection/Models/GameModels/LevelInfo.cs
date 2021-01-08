using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DB_Connection.Models.GameModels
{
    public class LevelInfo
    {
        [Key]
        public int LevelID { get; set; }

        public string LevelName { get; set; }

        public virtual IEnumerable<Player> Players { get; set; }
    }
}
