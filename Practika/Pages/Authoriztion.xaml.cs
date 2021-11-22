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
    /// Логика взаимодействия для Authoriztion.xaml
    /// </summary>
    public partial class Authoriztion : Page
    {
        public static Educational_practice_RybakovEntities dbPractik = new Educational_practice_RybakovEntities();
        public static Authorization authUser;

        public Authoriztion()
        {
            InitializeComponent();
        }

        private void SignUp_Click(object sender, RoutedEventArgs e)
        {
            if (Login.Text == "" || Password.Text == "")
            {
                MessageBox.Show("Введите ваши данные");
            }
            else
            {
                Authorization user = new Authorization
                {
                    Login = Login.Text,
                    Pass = Password.Text
                };
                MainWindow.db.Authorization.Add(user);
                MainWindow.db.SaveChanges();
                MessageBox.Show("Успешно!");

            }
        }

        //private void SignIn_Click(object sender, RoutedEventArgs e)
        //{
        //    foreach (var user in Authoriztion.dbPractik.Authorization)
        //    {
        //        if (user.Login == Login.Text.Trim())
        //        {
        //            if (user.Pass == Password.Text.Trim() && user.Id_Role == 2)
        //            {
        //                MessageBox.Show($"Привет, Пользователь: {user.Login}");
        //                MainWindow.authUser = user;
        //            }
        //            if (user.Pass == Password.Text.Trim() && user.Id_Role == 1)
        //            {
        //                MessageBox.Show($"Привет, админ: {user.Login}");
        //                MainWindow.authUser = user;
        //            }
        //            //IstanbulDB istanbulDB = new IstanbulDB();
        //            //this.Close();
        //            //istanbulDB.Show();
        //        }
        //    }
        //}
    }
}
