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

namespace ecz
{
    /// <summary>
    /// Логика взаимодействия для Login.xaml
    /// </summary>
    public partial class Login : Page
    {
        public Login()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            
            // Проверка, есть ли текст в текстовых полях
            if (!string.IsNullOrWhiteSpace(LoginBox.Text) && !string.IsNullOrWhiteSpace(PasswordBox.Text))
            {
                // Переход на следующую страницу
                NavigationService.Navigate(new Solution());
            }
            else
            {
                // Вывод сообщения об ошибке
                MessageBox.Show("Пожалуйста, заполните все текстовые поля.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }
    }
}
