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

namespace WpfHomeWorksTask3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int n = 1;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void KursComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Самостоятельно не получилось сделать, спросил у нейросети, были разные непонятные варианты,
            //выбил более простой который более менее понятен для меня, зато получилось то что хотел сделать
            switch (((ComboBoxItem)KursComboBox.SelectedItem).Content.ToString())
            {
                //это сам "натыкал", но то что выше нет
                case "Программирование":
                    ProgListBox.Visibility = Visibility.Visible;
                    DesListBox.Visibility = Visibility.Hidden;
                    ManListBox.Visibility = Visibility.Hidden;
                    DesListBox.SelectedItem = null;
                    ManListBox.SelectedItem = null;
                    break;
                case "Дизайн":
                    ProgListBox.Visibility = Visibility.Hidden;
                    DesListBox.Visibility = Visibility.Visible;
                    ManListBox.Visibility = Visibility.Hidden;
                    ProgListBox.SelectedItem = null;
                    ManListBox.SelectedItem = null;
                    break;
                case "Менеджмент":
                    ProgListBox.Visibility = Visibility.Hidden;
                    DesListBox.Visibility = Visibility.Hidden;
                    ManListBox.Visibility = Visibility.Visible;
                    ProgListBox.SelectedItem = null;
                    DesListBox.SelectedItem = null;
                    break;
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!CheckBox.IsChecked ?? false)
            {
                MessageBox.Show("Ошибка: необходимо согласиться на обработку данных!", "Ошибка",
                              MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            var selectedKurs1 = ProgListBox.SelectedItems
            .Cast<ListBoxItem>()
            .Select(item => item.Content?.ToString())
            .ToList();

            var selectedKurs2 = DesListBox.SelectedItems
            .Cast<ListBoxItem>()
            .Select(item => item.Content?.ToString())
            .ToList();

            var selectedKurs3 = ManListBox.SelectedItems
            .Cast<ListBoxItem>()
            .Select(item => item.Content?.ToString())
            .ToList();
            string selectedKurs = string.Join(",\n", selectedKurs1) + string.Join(",\n", selectedKurs2) + string.Join(",\n", selectedKurs3);

            string formaObucheniya = "Очная";
            if (Zaochno.IsChecked == true)
                formaObucheniya = "Заочная";

            string message = $"Профиль успешно сохранен!\n\n" +
                             $"Имя студента: {NameStudent.Text}\n\n" +
                             $"Факультет: {KursComboBox.Text}\n\n" +
                             $"Выбранные курсы:\n{string.Join(", ", selectedKurs)}\n\n" +
                             $"Количество часов: {(int)Chasy.Value}\n\n" +
                             $"Форма обучения: {formaObucheniya}\n\n" +
                             $"Согласие на обработку данных: {(CheckBox.IsChecked == true ? "Да" : "Нет")}";

            MessageBox.Show(message, "Успешно", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            KolChasov.Content = $"Количество часов: {(int)Chasy.Value}";
        }
    }
}