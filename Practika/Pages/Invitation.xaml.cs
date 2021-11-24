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
    public partial class Invitation : Page
    {
        public Invitation()
        {
            InitializeComponent();
        }

        private void Save_Application(object sender, RoutedEventArgs e)
        {
            Applicationsss application = new Applicationsss();

            if (Applic.Text != null || Spec.Text != null || Prep.Text != null)
            {
                application.Description = Applic.Text;
                application.Speciality = Spec.Text;
                application.Teacher_FullName = Prep.Text;
                application.IdAuth = Authoriztion.aut;

                MainWindow.dbPractik.Applicationsss.Add(application);

                MainWindow.dbPractik.SaveChanges();

                MessageBox.Show("Ваша заявка отправлена на рассмотрение");
            }
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Authoriztion());
        }
    }
}
