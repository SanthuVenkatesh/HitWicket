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
    /// Interaction logic for UTextBox.xaml
    /// </summary>
    public partial class UTextBox : UserControl
    {
        private static string _watermark;
        private bool _isSet = false;
        public UTextBox()
        {
            InitializeComponent();
            this.DataContext = this;
            _watermark = this.Watermark;
            this.txtBox.Foreground = Brushes.Gray;
        }

        // watermark dependency property
        public static readonly DependencyProperty WatermarkProperty =
            DependencyProperty.Register("Watermark", typeof(string), typeof(UTextBox), new PropertyMetadata(""));

        //public static readonly DependencyProperty styleProperty =
        //    DependencyProperty.Register("Style", typeof(Style), typeof(UTextBox), new PropertyMetadata(""));

        public string Watermark
        {
            get { return (string)GetValue(WatermarkProperty); }
            set { SetValue(WatermarkProperty, value); }
        }

        //public Style style
        //{
        //    get { return (Style)GetValue(styleProperty); }
        //    set { SetValue(styleProperty, value); }
        //}

        private void txtBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (!_isSet)
            {
                _watermark = Watermark;
                _isSet = true;
            }
            if (txtBox.Text == _watermark)
            {
                txtBox.Text = "";
                txtBox.Foreground = Brushes.Black;
            }
        }

        private void txtBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBox.Text))
            {
                txtBox.Text = _watermark;
                txtBox.Foreground = Brushes.Gray;
            }
        }




        public static readonly RoutedEvent TextBoxStyleChangedEvent = EventManager.RegisterRoutedEvent("TextBoxStyleChanged", RoutingStrategy.Bubble, typeof(RoutedPropertyChangedEventHandler<Style>), typeof(UTextBox));

        public static readonly DependencyProperty TextBoxStyleProperty = DependencyProperty.Register(
            "TextBoxStyle",
            typeof(Style),
            typeof(UTextBox),
            new FrameworkPropertyMetadata(null,
                FrameworkPropertyMetadataOptions.AffectsRender,
                new PropertyChangedCallback(OnTextBoxStyleChanged))
                );

        public Style TextBoxStyle
        {
            get { return (Style)GetValue(TextBoxStyleProperty); }
            set { SetValue(TextBoxStyleProperty, value); }
        }

        private static void OnTextBoxStyleChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            UTextBox UTxtBox = (UTextBox)d;
            Style newValue = (Style)e.NewValue;
            Style oldValue = (Style)e.OldValue;

            UTxtBox.txtBox.Style = newValue;

            RoutedPropertyChangedEventArgs<Style> routedArgs =
                    new RoutedPropertyChangedEventArgs<Style>(oldValue, newValue, TextBoxStyleChangedEvent);

            //UTxtBox.OnTextBoxStyleChanged(routedArgs);
        }
    }
}
