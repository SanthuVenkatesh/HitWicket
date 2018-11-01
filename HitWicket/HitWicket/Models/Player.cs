using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HitWicket.Models
{
    public class Player
    {
        public long ManagerId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Age { get; set; }
        public int Fielding { get; set; }
        public int Wicketkeeping { get; set; }
        public int Batting { get; set; }
        public int Bowling { get; set; }
        public string Style { get; set; }
    }
}
