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
using VikaDiplom.Auth;
using Application = Microsoft.Office.Interop.Word.Application;

namespace VikaDiplom.Pages
{
    /// <summary>
    /// Логика взаимодействия для HomePage.xaml
    /// </summary>
    public partial class HomePage : Page
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void btnchild_Click(object sender, RoutedEventArgs e)
        {
            frame.Navigate(new ChildPage());
        }

        private void btnOpeca_Click(object sender, RoutedEventArgs e)
        {
            frame.Navigate(new OpecunPage());
        }

        private void btnApp_Click(object sender, RoutedEventArgs e)
        {
            frame.Navigate(new ApplicationPage());
        }        

        private void btxExit_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult message = MessageBox.Show("Вы точно хотите выйти из аккаунта?", "Внимание!", MessageBoxButton.YesNo);
            if (message == MessageBoxResult.Yes)
            {
                NavigationService.Navigate(new AuthPage());
            }            
        }

        private void btnPrint_Click(object sender, RoutedEventArgs e)
        {
            string filePath = @"C:\Users\мыших\Desktop\заявление.docx";

            try
            {
                Application wordApp = new Application();
                wordApp.Visible = true;

                wordApp.Documents.Open(filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при открытии документа: " + ex.Message);
            }
        }
    }
}
