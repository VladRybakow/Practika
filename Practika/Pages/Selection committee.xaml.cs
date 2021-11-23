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
using Practika.Pages;
using Practika.BD;

namespace Practika.Pages
{
    /// <summary>
    /// Логика взаимодействия для Selection_committee.xaml
    /// </summary>
    public partial class Selection_committee : Page
    {
        Educational_practice_RybakovEntities3 qwe = new Educational_practice_RybakovEntities3();

        public Selection_committee()
        {
            InitializeComponent();

            qwe = new Educational_practice_RybakovEntities3();

            CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(Appli.ItemsSource);
        }

        private void ButtonAdd(object sender, RoutedEventArgs e)
        {
            var asd = Appli.SelectedItem as Applicationsss;

            if (asd == null)
            {
                MessageBox.Show("Эта строка пуста.");
                return;
            }

            MessageBoxResult result = MessageBox.Show("Вы действительно хотите сохранить?", "Сохранить?", MessageBoxButton.YesNoCancel);

            if (result == MessageBoxResult.Yes)
            {
                try
                {
                    qwe.Applicationsss.Add(asd);
                    qwe.SaveChanges();
                    Appli.ItemsSource = qwe.Applicationsss.ToList();
                }
                catch
                {
                    MessageBox.Show("Удалите соединения связанные с этим данным");
                }
            }
        }

        private void ButtonDel(object sender, RoutedEventArgs e)
        {
            var asd = Appli.SelectedItem as Applicationsss;

            if (asd == null)
            {
                MessageBox.Show("Пустая строка");
                return;
            }

            MessageBoxResult result = MessageBox.Show("Вы действительно хотите удалить строку?", "Удалить?", MessageBoxButton.YesNoCancel);

            if (result == MessageBoxResult.Yes)
            {
                try
                {
                    qwe.Applicationsss.Remove(asd);
                    qwe.SaveChanges();
                    Appli.ItemsSource = qwe.Applicationsss.ToList();
                }

                catch
                {
                    MessageBox.Show("Удалите соединения связанные с этим данным");
                }
            }
        }
    }
}
