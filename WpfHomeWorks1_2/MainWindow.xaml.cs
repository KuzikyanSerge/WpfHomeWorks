using System.Drawing;
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
using Color = System.Windows.Media.Color;

namespace WpfHomeWorksTask1_2
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
        private int _id = 0;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _id += 1;
            if (_id > 3)
                _id = 1;
                        
            Color colorGrey = Color.FromRgb(128, 128, 128);
            Color colorRed = Color.FromRgb(255, 0, 0);
            Color colorYellow = Color.FromRgb(255, 255, 0);
            Color colorGreen = Color.FromRgb(0, 255, 0);

            switch (_id)
            {
                case 1:
                    Red.Fill = new SolidColorBrush(colorRed);
                    Yellow.Fill = new SolidColorBrush(colorGrey);
                    Green.Fill = new SolidColorBrush(colorGrey);
                    break;
                case 2:
                    Red.Fill = new SolidColorBrush(colorGrey);
                    Yellow.Fill = new SolidColorBrush(colorYellow);
                    Green.Fill = new SolidColorBrush(colorGrey);
                    break;
                case 3:
                    Red.Fill = new SolidColorBrush(colorGrey);
                    Yellow.Fill = new SolidColorBrush(colorGrey);
                    Green.Fill = new SolidColorBrush(colorGreen);
                    break;
            }
        }
    }
}