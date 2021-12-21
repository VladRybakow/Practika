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
    public partial class Authoriztion : Page
    {
        public static Educational_practice_RybakovEntities1 dbPractik = new Educational_practice_RybakovEntities1();
        public static Authorization authUser;
        public static int aut { get; set; }

        public Authoriztion()
        {
            InitializeComponent();
        }

        private void SignUp_Click(object sender, RoutedEventArgs e)
        {
            Authorization user = new Authorization();

            if ((Login.Text == "" || Password.Text == "") && (user.Login != Login.Text || user.Pass != Password.Text))
            {
                MessageBox.Show("Ошибка с вводом данных");
            }
            else
            {
                user.Login = Login.Text;
                user.Pass = Password.Text;
                user.IdAuth = 2;
                MainWindow.dbPractik.Authorization.Add(user);

                try
                {
                    MainWindow.dbPractik.SaveChanges();
                }
                catch
                {
                    MessageBox.Show("Такой логин уже существует");
                }
                finally
                {
                    MessageBox.Show("Успешно!");
                }
            }
        }

        private void SignIn_Click(object sender, RoutedEventArgs e)
        {
            foreach (var user in Authoriztion.dbPractik.Authorization)
            {
                if (user.Login == Login.Text.Trim())
                {
                    if (user.Pass == Password.Text.Trim() && user.IdAuth != 1)
                    {
                        MessageBox.Show($"Здравствуйте, пользователь: {user.Login}");
                        Authoriztion.authUser = user;
                        NavigationService.Navigate(new Invitation());
                    }
                    if (user.Pass == Password.Text.Trim() && user.IdAuth == 1)
                    {
                        MessageBox.Show($"Вход с правами администратора: {user.Login}");
                        Authoriztion.authUser = user;
                        NavigationService.Navigate(new Selection_committee());
                    }
                    aut = user.IdAuth; 
                }
            }
        }

        private void SignIn_Click1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Examination());
        }

        private void Schedule_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Schedule());
        }
    }
}
