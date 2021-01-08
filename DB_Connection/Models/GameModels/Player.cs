using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DB_Connection.Models.GameModels
{
    public class Player
    {
        [Key]
        public int PlayerID { get; set; }

        public string PlayerName { get; set; }




    }
}
