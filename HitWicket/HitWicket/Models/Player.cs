using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HitWicket.Models
{
    public enum SkillLevel {
        NIL = 1,
        Hopeful,
        Useful,
        Moderate,
        Average,
        Reliable,
        Accomplished,
        Remarkable,
        Brilliant,
        Exemplary,
        Prodigious,
        Fantastic,
        Magnificent,
        Masterful,
        Supreme,
        Magical,
        Legendary,
        Wonderful,
        Demigod,
        Titan
    }
    public class Player
    {
        public long ManagerId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Age { get; set; }
        public Skill Fielding { get; set; }
        public Skill Wicketkeeping { get; set; }
        public Skill Batting { get; set; }
        public Skill Bowling { get; set; }
        public string Style { get; set; }
    }

    public class Skill
    {
        public Skill(int value)
        {
            SkillValue = value;
            SkillLevel = Enum.GetName(typeof(SkillLevel), SkillValue / 5).ToString();
        }
        public int SkillValue { get; set; }
        public string SkillLevel { get; set; }
    }
}
