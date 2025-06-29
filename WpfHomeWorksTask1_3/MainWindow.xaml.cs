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

namespace WpfHomeWorksTask1_3
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

        
        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            Random rnd = new Random();
            int x = rnd.Next(0, (int)MainGrid.ActualWidth - (int)Button.Width);
            int y = rnd.Next(0, (int)MainGrid.ActualHeight - (int)Button.Height);
            Button.Margin = new Thickness(x, y, 0, 0);
        }
    }
}