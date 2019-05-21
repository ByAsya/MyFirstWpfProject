using MyProject.database;
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

namespace MyProject
{
    /// <summary>
    /// Логика взаимодействия для Profile.xaml
    /// </summary>
    public partial class Profile : UserControl
    {
        public Profile()
        {
            InitializeComponent();
        }

        private void Load_Click(object sender, RoutedEventArgs e)
        {
            mail.Text = ProfileId.mail;

            UserRepository userR = new UserRepository();
            var user=userR.Get(mail.Text);

            name.Text = user.name;
            topics.Text += user.t_count;
        }


        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Вы точно хотите удалить аккаунт?", 
                "Удаление",MessageBoxButton.YesNo, MessageBoxImage.None,MessageBoxResult.No);
           
            if (result==MessageBoxResult.Yes)
            {
                UserRepository userR = new UserRepository();
                userR.Delete(userR.Get(mail.Text));
                name.Text = "пусто";
                mail.Text = "пусто";

                Вход_Регистрация sign = new Вход_Регистрация();
                sign.Show();

                MainWindow window = (MainWindow)Application.Current.MainWindow;
                window.Start.Children.Clear();
            }
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            name.Text = "пусто";
            mail.Text = "пусто";

            Вход_Регистрация sign = new Вход_Регистрация();
            sign.Show();

            MainWindow window = (MainWindow)Application.Current.MainWindow;
            window.Start.Children.Clear();
        }

        private void Redact_Click(object sender, RoutedEventArgs e)
        {
            ProfileRedact redact = new ProfileRedact();
            redact.Show();
        }
    }
}
