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
        public static Educational_practice_RybakovEntities3 dbPractik = new Educational_practice_RybakovEntities3();
        public static Authorization authUser;

        public Examination()
        {
            InitializeComponent();
        }

        private void Check_Click(object sender, RoutedEventArgs e)
        {
            Applicationsss rer = new Applicationsss();

            foreach (var user in Authoriztion.dbPractik.Authorization)
            {
                if (user.Login == Login.Text.Trim())
                {
                    if (user.Pass == Password.Text.Trim() && user.IdAuth != 1)
                    {
                        MessageBox.Show($"Здравствуйте, пользователь: {user.Login}");
                        Teacher.Text = rer.Teacher_FullName;
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
