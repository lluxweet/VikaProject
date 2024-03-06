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
using System.Windows.Shapes;

namespace VikaDiplom.Windows
{
    /// <summary>
    /// Логика взаимодействия для ApplicationAddEditWindow.xaml
    /// </summary>
    public partial class ApplicationAddEditWindow : Window
    {
        private Заявления текущееЗаявление = new Заявления(); 
        public ApplicationAddEditWindow(Заявления выборЗаявления)
        {
            InitializeComponent();
            if (выборЗаявления != null)
                текущееЗаявление = выборЗаявления;

            cmbOpecun.ItemsSource = TaranovaDiplomEntities.GetContext().Опекуны.ToList();
            cmbChild.ItemsSource = TaranovaDiplomEntities.GetContext().Дети.ToList();
            cmbReshenieOpeki.ItemsSource = TaranovaDiplomEntities.GetContext().РешениеОпеки.ToList();
            cmbTypeZayavka.ItemsSource = TaranovaDiplomEntities.GetContext().ТипЗаявления.ToList();

            
            DataContext = текущееЗаявление;         

        }

        private void bntSave_Click(object sender, RoutedEventArgs e)
        {
            if (текущееЗаявление.Код == 0)
                TaranovaDiplomEntities.GetContext().Заявления.Add(текущееЗаявление);
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

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            dateReshenia.SelectedDate = null;
        }
    }
}
