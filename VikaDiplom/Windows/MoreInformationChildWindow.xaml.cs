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
    /// Логика взаимодействия для MoreInformationChildWindow.xaml
    /// </summary>
    public partial class MoreInformationChildWindow : Window
    {
        private Дети дети = new Дети();
        public MoreInformationChildWindow(Дети дети1)
        {
            InitializeComponent();
            if (дети != null)
                дети = дети1;
            DataContext = дети;
        }
    }
}
