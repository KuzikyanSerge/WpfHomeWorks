using System.Collections.ObjectModel;
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

namespace WpfHomeWorksTask8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Products> products = new ObservableCollection<Products>();
        public MainWindow()
        {
            InitializeComponent();
            products.Add(new Products()
            {
                imya = "Мороженое",
                tsena = 80,
                izobradzenie = @"C:\Users\Invasion Core i7\Desktop\Для курсов по C#\WpfHomeWorks\WpfHomeWorksTask8\img\Morodzenoe.png",
                tipTovara = TipTovara.Еда
            }); 
            products.Add(new Products()
            {
                imya = "Ноутбук",
                tsena = 100000,
                izobradzenie = @"C:\Users\Invasion Core i7\Desktop\Для курсов по C#\WpfHomeWorks\WpfHomeWorksTask8\img\Notebook.png",
                tipTovara = TipTovara.Бытовая_техника
            }); 
            products.Add(new Products()
            {
                imya = "Помидоры 1кг",
                tsena = 150,
                izobradzenie = @"C:\Users\Invasion Core i7\Desktop\Для курсов по C#\WpfHomeWorks\WpfHomeWorksTask8\img\Pomidor.png",
                tipTovara = TipTovara.Еда
            });
            lstBox.ItemsSource = products;
        }
    }
}