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
    /// Логика взаимодействия для Examination.xaml
    /// </summary>
    public partial class Examination : Page
    {
        Educational_practice_RybakovEntities dbPractik = new Educational_practice_RybakovEntities();

        public Examination()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Authoriztion());
        }

        private void Check_Click(object sender, RoutedEventArgs e)
        {

            foreach (var user in Authoriztion.dbPractik.Authorization)
            {
                if (user.Login == Login.Text.Trim())
                {
                    if (user.Pass == Password.Text.Trim() && user.IdAuth != 1)
                    {
                        MessageBox.Show($"Здравствуйте, пользователь: {user.Login}");

                        var query = (from ap in dbPractik.Applicationsss
                                     join us in dbPractik.Authorization
                                     on ap.IdAuth equals us.IdAuth
                                     where ap.IdAuth == user.IdAuth
                                     select ap.Teacher_FullName).First();

                        Teacher.Text = query;

                        var query3 = (from ap in dbPractik.Applicationsss
                                     join us in dbPractik.Authorization
                                     on ap.IdAuth equals us.IdAuth
                                     where ap.IdAuth == user.IdAuth
                                     select ap.Speciality).First();

                        Spec.Text = query3;

                        var query2 = (from ap in dbPractik.Applicationsss
                                     join us in dbPractik.Authorization
                                     on ap.IdAuth equals us.IdAuth
                                     where ap.IdAuth == user.IdAuth
                                     select ap.Enrolled).First();
                        if (query2 == true)
                        {
                            Check.Text = "Одобрена";
                        }
                        else if (query2 == false)
                        {
                            Check.Text = "Отклонена";
                        }
                    }
                    if (user.Pass == Password.Text.Trim() && user.IdAuth == 1)
                    {
                        MessageBox.Show($"Администратор не подает заявки {user.Login}");
                        break;
                    }
                }
            }
        }
    }
}
