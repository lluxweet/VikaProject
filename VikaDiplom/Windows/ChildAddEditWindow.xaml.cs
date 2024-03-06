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
    /// Логика взаимодействия для ChildAddEditWindow.xaml
    /// </summary>
    public partial class ChildAddEditWindow : Window
    {
        private Дети _currentChildren = new Дети();
        public ChildAddEditWindow(Дети selectedChildren)
        {
            InitializeComponent();            
            if (selectedChildren != null)
                _currentChildren = selectedChildren;

            cmbCategAge.ItemsSource = TaranovaDiplomEntities.GetContext().КатегорияВозраста.ToList();
            cmbAge.ItemsSource = TaranovaDiplomEntities.GetContext().Возраст.ToList();
            cmbCategZdor.ItemsSource = TaranovaDiplomEntities.GetContext().КатегорияЗдоровья.ToList();
            cmbCity.ItemsSource = TaranovaDiplomEntities.GetContext().Город.ToList();
            cmbColorVolos.ItemsSource = TaranovaDiplomEntities.GetContext().ЦветВолос.ToList();
            cmbGlaza.ItemsSource = TaranovaDiplomEntities.GetContext().ЦветГлаз.ToList();
            cmbLichnost.ItemsSource = TaranovaDiplomEntities.GetContext().ТипЛичности.ToList();
            cmbRegion.ItemsSource = TaranovaDiplomEntities.GetContext().Регион.ToList();
            cmbSex.ItemsSource = TaranovaDiplomEntities.GetContext().Пол.ToList();
            cmbStreet.ItemsSource = TaranovaDiplomEntities.GetContext().Улица.ToList();
           

            DataContext = _currentChildren;
        }
        private void bntSave_Click(object sender, RoutedEventArgs e)
        {
            if (_currentChildren.Код == 0)
                TaranovaDiplomEntities.GetContext().Дети.Add(_currentChildren);
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
            dateSnyatie.SelectedDate = null;
        }
    }
}
