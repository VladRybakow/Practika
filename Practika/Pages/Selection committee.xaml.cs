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

    public partial class Selection_committee : Page
    {
        Educational_practice_RybakovEntities qwe = new Educational_practice_RybakovEntities();

        public Selection_committee()
        {
            InitializeComponent();

            var query = (from ap in qwe.Applicationsss
                         where ap.Enrolled == null
                         select ap);
            Appli.ItemsSource = query.ToList();
        }

        private void ButtonAdd(object sender, RoutedEventArgs e)
        {
            var asd = Appli.SelectedItem as Applicationsss;

            if (asd == null)
            {
                MessageBox.Show("Эта строка пуста.");
                return;
            }

            MessageBoxResult result = MessageBox.Show("Вы действительно хотите одобрить эту заявку?", "Одобрить?", MessageBoxButton.YesNoCancel);

            if (result == MessageBoxResult.Yes)
            {
                try
                {
                    asd.Enrolled = true;
                    qwe.SaveChanges();                
                }
                catch
                {
                    MessageBox.Show("Удалите соединения связанные с этим данным");
                }
            }
        }

        private void Close1(object sender, RoutedEventArgs e)
        {
            var asd = Appli.SelectedItem as Applicationsss;

            if (asd == null)
            {
                MessageBox.Show("Эта строка пуста.");
                return;
            }

            MessageBoxResult result = MessageBox.Show("Вы действительно хотите отклонить эту заявку?", "отклонить?", MessageBoxButton.YesNoCancel);

            if (result == MessageBoxResult.Yes)
            {
                try
                {
                    asd.Enrolled = false;
                    qwe.SaveChanges();
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
                }

                catch
                {
                    MessageBox.Show("Удалите соединения связанные с этим данным");
                }
            }
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Authoriztion());
        }
    }
}
