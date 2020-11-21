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

namespace zadanie2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void calculate_Click(object sender, RoutedEventArgs e)
        {
            String s = slovo1.Text;

            slovo2.Text += ("Результат - " + ExctraxtIni(s.ToString()));
        }
        private static string ExctraxtIni(string Name)
        {
            //удаляем начальные и конечные пробелы в строке, а также все точки
            Name = Name.Trim().Replace(".", String.Empty);

           //Возварщаем пустую строку если строка состояла из пробелов и точек
            if (String.IsNullOrEmpty(Name))
            {               
                return String.Empty;
            }

            //Получаем индекс первого пробела
            int index = Name.IndexOf(' ');

            //Если Пробел не найден Возвращаем только Фамилию
            if (index < 0)
            {
                return Name.Substring(0, 1).ToUpper() + Name.Substring(1).ToLower();
            }

            // получаем фамилию
            string lastName = Name.Substring(0, index).Trim();
            lastName = lastName.Substring(0, 1).ToUpper() + lastName.Substring(1).ToLower();

            //Удаляем фамилию из нашей строки
            Name = Name.Substring(index).Trim();

            //Получаем индекс первого пробела для имени
            index = Name.IndexOf(' ');

            //Если Пробел не найден Возвращаем  Фамилию и первый инициал
            if (index < 0)
            {            
                return lastName + " " + Name.Substring(0, 1).ToUpper() + ".";
            }

            // получаем фамилию
            string firstName = Name.Substring(0, index).Trim();
            firstName = firstName.Substring(0, 1).ToUpper() + firstName.Substring(1).ToLower();

            //Получаем оставшееся отчество
            string fatherName = Name.Substring(index).Trim().Substring(0, 1).ToUpper() + Name.Substring(index).Trim().Substring(1).ToLower();
            return lastName + " " + firstName.Substring(0, 1) + ". " + fatherName.Substring(0, 1) + ".";

        }
    }
}
