//using HitWicket.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace HitWicket
{
    /// <summary>
    /// Interaction logic for SquadWindow.xaml
    /// </summary>
    public partial class SquadWindow : Window
    {
        public SquadWindow()
        {
            InitializeComponent();
            //List<Models.Player> _players = DataService.GetTeamPlayers(1);
            this.player1.Player = new Models.Player
            {
                Firstname = "Sandeep",
                Lastname = "Eti",
                Age = 25,
                Fielding = new Models.Skill(90),
                Wicketkeeping = new Models.Skill(80),
                Batting = new Models.Skill(95),
                Bowling = new Models.Skill(95),
                Style = "LHB, LF"
            };

            this.player2.Player = new Models.Player
            {
                Firstname = "Venkatesh",
                Lastname = "Santhu",
                Age = 24,
                Fielding = new Models.Skill(10),
                Wicketkeeping = new Models.Skill(20),
                Batting = new Models.Skill(30),
                Bowling = new Models.Skill(90),
                Style = "RHB, RF"
            };

            this.player3.Player = new Models.Player
            {
                Firstname = "Srinivas",
                Lastname = "Maddala",
                Age = 33,
                Fielding = new Models.Skill(40),
                Wicketkeeping = new Models.Skill(80),
                Batting = new Models.Skill(50),
                Bowling = new Models.Skill(10),
                Style = "RHB, WK"
            };

            this.player4.Player = new Models.Player
            {
                Firstname = "Santhosh",
                Lastname = "Goleccha",
                Age = 43,
                Fielding = new Models.Skill(50),
                Wicketkeeping = new Models.Skill(20),
                Batting = new Models.Skill(80),
                Bowling = new Models.Skill(30),
                Style = "RHB, SLM"
            };

            this.player5.Player = new Models.Player
            {
                Firstname = "Trimurthulu",
                Lastname = "Raavi",
                Age = 26,
                Fielding = new Models.Skill(30),
                Wicketkeeping = new Models.Skill(20),
                Batting = new Models.Skill(40),
                Bowling = new Models.Skill(40),
                Style = "RHB, RM"
            };

            this.player6.Player = new Models.Player
            {
                Firstname = "Mohit",
                Lastname = "Ande",
                Age = 22,
                Fielding = new Models.Skill(70),
                Wicketkeeping = new Models.Skill(20),
                Batting = new Models.Skill(70),
                Bowling = new Models.Skill(30),
                Style = "RHB, RF"
            };

            this.player7.Player = new Models.Player
            {
                Firstname = "Rafiq",
                Lastname = "Mohammed",
                Age = 24,
                Fielding = new Models.Skill(10),
                Wicketkeeping = new Models.Skill(20),
                Batting = new Models.Skill(70),
                Bowling = new Models.Skill(40),
                Style = "LHB, RF"
            };

            this.player8.Player = new Models.Player
            {
                Firstname = "Suresh",
                Lastname = "Jeediguntla",
                Age = 42,
                Fielding = new Models.Skill(10),
                Wicketkeeping = new Models.Skill(20),
                Batting = new Models.Skill(10),
                Bowling = new Models.Skill(80),
                Style = "RHB, SLC"
            };

            this.player9.Player = new Models.Player
            {
                Firstname = "Teja",
                Lastname = "Gorkha",
                Age = 29,
                Fielding = new Models.Skill(10),
                Wicketkeeping = new Models.Skill(10),
                Batting = new Models.Skill(20),
                Bowling = new Models.Skill(40),
                Style = "RHB, SLC"
            };

            this.player10.Player = new Models.Player
            {
                Firstname = "Bhaskar",
                Lastname = "Gottapu",
                Age = 31,
                Fielding = new Models.Skill(10),
                Wicketkeeping = new Models.Skill(20),
                Batting = new Models.Skill(50),
                Bowling = new Models.Skill(50),
                Style = "RHB, LM"
            };

            this.player11.Player = new Models.Player
            {
                Firstname = "Karun",
                Lastname = "Kumar",
                Age = 32,
                Fielding = new Models.Skill(10),
                Wicketkeeping = new Models.Skill(80),
                Batting = new Models.Skill(60),
                Bowling = new Models.Skill(10),
                Style = "RHB, WK"
            };
        }
    }
}
