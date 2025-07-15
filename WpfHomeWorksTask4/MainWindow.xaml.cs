using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfHomeWorksTask4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }        
    }
    public class CounterButton : Button
    {
        public static readonly DependencyProperty OnOffProperty =
            DependencyProperty.Register(
                nameof(ClickOnOff),
                typeof(int),
                typeof(CounterButton),
                new FrameworkPropertyMetadata(
                    1,
                    FrameworkPropertyMetadataOptions.None,
                    OnOffChanged));
        public int ClickOnOff
        {
            get { return (int)GetValue(OnOffProperty); }
            set { SetValue(OnOffProperty, value); }
        }
        private static void OnOffChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            Color colorRed = Color.FromRgb(255, 0, 0);
            Color colorGreen = Color.FromRgb(0, 255, 0);
            var button = (CounterButton)d;
            int newValue = (int)e.NewValue;
            button.Content = (newValue% 2 == 0)
                ? "OFF"
                : "ON";
            if (newValue % 2 == 0)
            {
                button.Background = new SolidColorBrush(colorRed);
            }
            else button.Background = new SolidColorBrush(colorGreen);
        }
        public CounterButton()
        {
            ClickOnOff = 2;
            Click += (sender, e) => ClickOnOff++;
        }
    }
}