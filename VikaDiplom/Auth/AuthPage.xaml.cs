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
using VikaDiplom.Pages;

namespace VikaDiplom.Auth
{
    /// <summary>
    /// Логика взаимодействия для AuthPage.xaml
    /// </summary>
    public partial class AuthPage : Page
    {
        public AuthPage()
        {
            InitializeComponent();
        }

        private void btnvxod_Click(object sender, RoutedEventArgs e)
        {
            if (txblogin.Text.Length == 0)
            {
                MessageBox.Show("Введите логин");
                return;
            }

            if (txbpassword.Password.Length == 0)
            {
                MessageBox.Show("Введите пароль");
                return;
            }

            var authUser = TaranovaDiplomEntities.GetContext().Пользователи.Where(item => item.Логин.ToLower() == txblogin.Text.ToLower() && item.Пароль == txbpassword.Password).FirstOrDefault();

            if (authUser != null)
            {
                NavigationService.Navigate(new HomePage());
                MessageBox.Show("Авторизация успешна");
            }
            else
            {
                MessageBox.Show("Данные введены неверно");
            }
        }
    }
}
