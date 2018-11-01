using HitWicket.Models;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HitWicket.UserControls
{
    /// <summary>
    /// Interaction logic for Player.xaml
    /// </summary>
    public partial class UPlayer : UserControl
    {
        public UPlayer()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        public static readonly DependencyProperty PlayerProperty = DependencyProperty.Register(
            "Player", typeof(Player), typeof(UPlayer), new PropertyMetadata(new HitWicket.Models.Player()));

        public HitWicket.Models.Player Player
        {
            get { return (HitWicket.Models.Player)GetValue(PlayerProperty); }
            set { SetValue(PlayerProperty, value); }
        }

    }
}
