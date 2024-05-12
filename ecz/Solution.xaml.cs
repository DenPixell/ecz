using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using Ansver;

namespace ecz
{
    /// <summary>
    /// Логика взаимодействия для Solution.xaml
    /// </summary>
    public partial class Solution : Page
    {
        public Solution()
        {
            InitializeComponent();
        }

        private void ResultButton_Click(object sender, RoutedEventArgs e)
        {
            // Получаем значение из текстового поля NumBox
            if (int.TryParse(NumBox.Text, out int side))
            {
                // Создаем экземпляр класса Class1 и передаем в него значение стороны квадрата
                Ansver.Class1 obj = new Ansver.Class1(side);

                // Выводим результаты на экран
                MessageBox.Show($"Периметр квадрата: {obj.perimeter}\nПлощадь квадрата: {obj.ploshad}", "Результат");
            }
            else
            {
                // Если введено некорректное значение, выводим сообщение об ошибке
                MessageBox.Show("Введите корректное число в поле!", "Ошибка");
            }
        }

    }
}
