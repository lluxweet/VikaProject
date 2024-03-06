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
using VikaDiplom.Windows;

namespace VikaDiplom.Pages
{
    /// <summary>
    /// Логика взаимодействия для ApplicationPage.xaml
    /// </summary>
    public partial class ApplicationPage : Page
    {
        public ApplicationPage()
        {
            InitializeComponent();
            GridApp.ItemsSource = TaranovaDiplomEntities.GetContext().Заявления.ToList();
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                TaranovaDiplomEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                GridApp.ItemsSource = TaranovaDiplomEntities.GetContext().Заявления.ToList();
            }
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            ApplicationAddEditWindow window = new ApplicationAddEditWindow(null);
            window.IsVisibleChanged += Page_IsVisibleChanged;
            window.ShowDialog();
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            ApplicationAddEditWindow window = new ApplicationAddEditWindow((sender as Button).DataContext as Заявления);
            window.IsVisibleChanged += Page_IsVisibleChanged;
            window.ShowDialog();
        }

        private void BtnDelet_Click(object sender, RoutedEventArgs e)
        {
            var AppForDelet = GridApp.SelectedItems.Cast<Заявления>().ToList();
            if (MessageBox.Show($"Вы точно хотите удалить следующую запись?",
                    "Внимение!", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    TaranovaDiplomEntities.GetContext().Заявления.RemoveRange(AppForDelet);
                    TaranovaDiplomEntities.GetContext().SaveChanges();
                    MessageBox.Show("Данные успешно удалены");

                    GridApp.ItemsSource = TaranovaDiplomEntities.GetContext().Заявления.ToList();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message.ToString());
                }
            }
        }

        private void txbSerch_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txbSerch.Text != "")
            {
                GridApp.ItemsSource = TaranovaDiplomEntities.GetContext().Заявления.Where(x =>
                x.Опекуны.Фамилия.ToLower().Contains(txbSerch.Text.ToLower())).ToList();
            }
            else
            {
                GridApp.ItemsSource = TaranovaDiplomEntities.GetContext().Заявления.ToList();
            }
        }
    }
}
