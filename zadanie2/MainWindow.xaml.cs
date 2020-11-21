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

            if (String.IsNullOrEmpty(Name))
            {
                Console.WriteLine("Входная строка пуста");
                return String.Empty;
            }

            Console.WriteLine("Изначальная длинна строки = " + Name.Length);


            Name = Name.Trim().Replace(".", String.Empty);
            Console.WriteLine("Длинна строки после удаления пробелов и точек = " + Name.Length);



            if (String.IsNullOrEmpty(Name))
            {
                Console.WriteLine("Входная строка пуста");
                return String.Empty;
            }


            int index = Name.IndexOf(' ');


            if (index < 0)
            {
                Console.WriteLine("Строка имеет только Фамилию - " + Name.Substring(0, 1).ToUpper() + Name.Substring(1).ToLower());
                return Name.Substring(0, 1).ToUpper() + Name.Substring(1).ToLower();
            }


            string lastName = Name.Substring(0, index).Trim();
            lastName = lastName.Substring(0, 1).ToUpper() + lastName.Substring(1).ToLower();

            Console.WriteLine("Фамилия - " + lastName);


            Name = Name.Substring(index).Trim();


            index = Name.IndexOf(' ');


            if (index < 0)
            {
                Console.WriteLine("Строка имеет только Фамилию и первый инициал - " + lastName + " " + Name.Substring(0, 1).ToUpper() + ".");
                return lastName + " " + Name.Substring(0, 1).ToUpper() + ".";
            }


            string firstName = Name.Substring(0, index).Trim();
            firstName = firstName.Substring(0, 1).ToUpper() + firstName.Substring(1).ToLower();

            Console.WriteLine("Имя - " + firstName);


            string fatherName = Name.Substring(index).Trim().Substring(0, 1).ToUpper() + Name.Substring(index).Trim().Substring(1).ToLower();

            Console.WriteLine("Отчество - " + fatherName);

            return lastName + " " + firstName.Substring(0, 1) + ". " + fatherName.Substring(0, 1) + ".";

        }
    }
}
