using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace HitWicket.UserControls
{
    public class WTextBox : TextBox
    {
        static WTextBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(WTextBox),
                new FrameworkPropertyMetadata(typeof(WTextBox)));
        }

        public object Watermark
        {
            get { return (object)GetValue(WatermarkProperty); }
            set { SetValue(WatermarkProperty, value); }
        }

        public static readonly DependencyProperty WatermarkProperty =
            DependencyProperty.Register(
                "Watermark",
                typeof(object), typeof(WTextBox),
                new UIPropertyMetadata(null));
    }
}
