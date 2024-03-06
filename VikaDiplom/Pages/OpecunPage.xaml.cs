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
    /// Логика взаимодействия для OpecunPage.xaml
    /// </summary>
    public partial class OpecunPage : Page
    {
        public OpecunPage()
        {
            InitializeComponent();
            GridOpecun.ItemsSource = TaranovaDiplomEntities.GetContext().Опекуны.ToList();
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                TaranovaDiplomEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                GridOpecun.ItemsSource = TaranovaDiplomEntities.GetContext().Опекуны.ToList();
            }
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            OpecunAddEditWindow window = new OpecunAddEditWindow(null);
            window.IsVisibleChanged += Page_IsVisibleChanged;
            window.ShowDialog();
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            OpecunAddEditWindow window = new OpecunAddEditWindow((sender as Button).DataContext as Опекуны);
            window.IsVisibleChanged += Page_IsVisibleChanged;
            window.ShowDialog();
        }

        private void BtnDelet_Click(object sender, RoutedEventArgs e)
        {
            var OpecunForDelet = GridOpecun.SelectedItems.Cast<Опекуны>().ToList();
            if (MessageBox.Show($"Вы точно хотите удалить следующую запись?",
                    "Внимение!", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    TaranovaDiplomEntities.GetContext().Опекуны.RemoveRange(OpecunForDelet);
                    TaranovaDiplomEntities.GetContext().SaveChanges();
                    MessageBox.Show("Данные успешно удалены");

                    GridOpecun.ItemsSource = TaranovaDiplomEntities.GetContext().Опекуны.ToList();
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
                GridOpecun.ItemsSource = TaranovaDiplomEntities.GetContext().Опекуны.Where(x =>
                x.Фамилия.ToLower().Contains(txbSerch.Text.ToLower())).ToList();
            }
            else
            {
                GridOpecun.ItemsSource = TaranovaDiplomEntities.GetContext().Опекуны.ToList();
            }
        }
    }
}
