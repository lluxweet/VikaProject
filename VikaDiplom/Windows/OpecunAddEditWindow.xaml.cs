using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace VikaDiplom.Windows
{
    /// <summary>
    /// Логика взаимодействия для OpecunAddEditWindow.xaml
    /// </summary>
    public partial class OpecunAddEditWindow : Window
    {
        private Опекуны текущийОпекун = new Опекуны();
        public OpecunAddEditWindow(Опекуны выборОпекуна)
        {
            InitializeComponent();
           
            if (выборОпекуна != null)
                текущийОпекун = выборОпекуна;           

            txbPhone.PreviewTextInput += txbPhone_PreviewTextInput;
            cmbCelObrash.ItemsSource = TaranovaDiplomEntities.GetContext().ЦельОбращения.ToList();

            DataContext = текущийОпекун;
        }

        private void txbPhone_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9+]+"); // Регулярное выражение для разрешения только цифр и знака "+"
            e.Handled = regex.IsMatch(e.Text);
        }

        private void bntSave_Click(object sender, RoutedEventArgs e)
        {
            if (текущийОпекун.Код == 0)
                TaranovaDiplomEntities.GetContext().Опекуны.Add(текущийОпекун);
            try
            {
                TaranovaDiplomEntities.GetContext().SaveChanges();
                MessageBox.Show("Данные успешно сохранены на главную страницу!");
                Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }
    }
}
