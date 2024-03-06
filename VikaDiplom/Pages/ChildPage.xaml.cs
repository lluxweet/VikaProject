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
    /// Логика взаимодействия для ChildPage.xaml
    /// </summary>
    public partial class ChildPage : Page
    {
        public ChildPage()
        {
            InitializeComponent();
            GridChild.ItemsSource = TaranovaDiplomEntities.GetContext().Дети.ToList();
        }
        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                TaranovaDiplomEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                GridChild.ItemsSource = TaranovaDiplomEntities.GetContext().Дети.ToList();
            }
        }
        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            ChildAddEditWindow window = new ChildAddEditWindow(null);
            window.IsVisibleChanged += Page_IsVisibleChanged;
            window.ShowDialog();
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            ChildAddEditWindow window = new ChildAddEditWindow((sender as Button).DataContext as Дети);
            window.IsVisibleChanged += Page_IsVisibleChanged;
            window.ShowDialog();
        }

        private void BtnDelet_Click(object sender, RoutedEventArgs e)
        {
            var ChildForDelet = GridChild.SelectedItems.Cast<Дети>().ToList();
            if (MessageBox.Show($"Вы точно хотите удалить следующую запись?",
                    "Внимение!", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    TaranovaDiplomEntities.GetContext().Дети.RemoveRange(ChildForDelet);
                    TaranovaDiplomEntities.GetContext().SaveChanges();
                    MessageBox.Show("Данные успешно удалены");

                    GridChild.ItemsSource = TaranovaDiplomEntities.GetContext().Дети.ToList();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message.ToString());
                }
            }
        }

        private void BtnMore_Click(object sender, RoutedEventArgs e)
        {
            MoreInformationChildWindow window = new MoreInformationChildWindow((sender as Button).DataContext as Дети);
            window.IsVisibleChanged += Page_IsVisibleChanged;
            window.ShowDialog();
        }       

        private void txbSerch_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txbSerch.Text != "")
            {
                GridChild.ItemsSource = TaranovaDiplomEntities.GetContext().Дети.Where(x =>
                x.Фамилия.ToLower().Contains(txbSerch.Text.ToLower())).ToList();
            }
            else
            {
                GridChild.ItemsSource = TaranovaDiplomEntities.GetContext().Дети.ToList();
            }
        }
    }
}
