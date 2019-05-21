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
using System.Windows.Shapes;

namespace MyProject
{
    /// <summary>
    /// Логика взаимодействия для Вход_Регистрация.xaml
    /// </summary>
    public partial class Вход_Регистрация : Window
    {
        public Вход_Регистрация()
        {
            InitializeComponent();
            
        }

        UserRepository userR = new UserRepository();

        private void Input_Click(object sender, RoutedEventArgs e)
        {
            MainWindow w = (MainWindow)Application.Current.MainWindow;
            Начало_обучения n = new Начало_обучения();
            n.Block.Children.Clear();
            Profile p = new Profile();
            n.AnotherPages.Children.Add(p);
            w.Start.Children.Add(n);

            ProfileId.mail = mail1.Text;
            this.Close();
        }

        private void Reg_Click(object sender, RoutedEventArgs e)
        {            
            User user = new User { Id = mail2.Text, name = name2.Text, password = pass2.Password };
            userR.Create(user);
            MessageBox.Show("Регистрация выполнена успешно!");            

            MainWindow w = (MainWindow)Application.Current.MainWindow;
            Начало_обучения n = new Начало_обучения();
            n.Block.Children.Clear();
            Profile p = new Profile();
            n.AnotherPages.Children.Add(p);
            w.Start.Children.Add(n);

            ProfileId.mail = mail2.Text;

            this.Close();
        }
    }
}
