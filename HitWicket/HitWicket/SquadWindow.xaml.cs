using HitWicket.Services;
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
                Fielding = 90,
                Wicketkeeping = 80,
                Batting = 95,
                Bowling = 95,
                Style = "LHB, LF"
            };

            this.player2.Player = new Models.Player
            {
                Firstname = "Venkatesh",
                Lastname = "Santhu",
                Age = 24,
                Fielding = 10,
                Wicketkeeping = 20,
                Batting = 30,
                Bowling = 90,
                Style = "RHB, RF"
            };

            this.player3.Player = new Models.Player
            {
                Firstname = "Srinivas",
                Lastname = "Maddala",
                Age = 33,
                Fielding = 40,
                Wicketkeeping = 80,
                Batting = 50,
                Bowling = 10,
                Style = "RHB, WK"
            };

            this.player4.Player = new Models.Player
            {
                Firstname = "Santhosh",
                Lastname = "Goleccha",
                Age = 43,
                Fielding = 50,
                Wicketkeeping = 20,
                Batting = 80,
                Bowling = 30,
                Style = "RHB, SLM"
            };

            this.player5.Player = new Models.Player
            {
                Firstname = "Trimurthulu",
                Lastname = "Raavi",
                Age = 26,
                Fielding = 30,
                Wicketkeeping = 20,
                Batting = 40,
                Bowling = 40,
                Style = "RHB, RM"
            };

            this.player6.Player = new Models.Player
            {
                Firstname = "Mohit",
                Lastname = "Ande",
                Age = 22,
                Fielding = 70,
                Wicketkeeping = 20,
                Batting = 70,
                Bowling = 30,
                Style = "RHB, RF"
            };

            this.player7.Player = new Models.Player
            {
                Firstname = "Rafiq",
                Lastname = "Mohammed",
                Age = 24,
                Fielding = 10,
                Wicketkeeping = 20,
                Batting = 70,
                Bowling = 40,
                Style = "LHB, RF"
            };

            this.player8.Player = new Models.Player
            {
                Firstname = "Suresh",
                Lastname = "Jeediguntla",
                Age = 42,
                Fielding = 10,
                Wicketkeeping = 20,
                Batting = 10,
                Bowling = 80,
                Style = "RHB, SLC"
            };

            this.player9.Player = new Models.Player
            {
                Firstname = "Teja",
                Lastname = "Gorkha",
                Age = 29,
                Fielding = 10,
                Wicketkeeping = 10,
                Batting = 20,
                Bowling = 40,
                Style = "RHB, SLC"
            };

            this.player10.Player = new Models.Player
            {
                Firstname = "Bhaskar",
                Lastname = "Gottapu",
                Age = 31,
                Fielding = 10,
                Wicketkeeping = 20,
                Batting = 50,
                Bowling = 50,
                Style = "RHB, LM"
            };

            this.player11.Player = new Models.Player
            {
                Firstname = "Karun",
                Lastname = "Kumar",
                Age = 32,
                Fielding = 10,
                Wicketkeeping = 80,
                Batting = 60,
                Bowling = 10,
                Style = "RHB, WK"
            };
        }
    }
}
