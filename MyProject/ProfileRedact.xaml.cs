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
    /// Логика взаимодействия для ProfileRedact.xaml
    /// </summary>
    public partial class ProfileRedact : Window
    {
        public ProfileRedact()
        {
            InitializeComponent();
        }
        
        private void Redact_Click(object sender, RoutedEventArgs e)
        {
            Profile profile = new Profile();
            UserRepository userR = new UserRepository();
            var user_ = userR.Get(ProfileId.mail);

            userR.Delete(user_);

            User user = new User { Id = Mail.Text, name = Name.Text, password = Pass.Password };
            userR.Create(user);

            ProfileId.mail = Mail.Text;
            ProfileId.name = Name.Text;

            MainWindow w = (MainWindow)Application.Current.MainWindow;
            Начало_обучения n = new Начало_обучения();
            n.Block.Children.Clear();
            Profile p = new Profile();
            n.AnotherPages.Children.Add(p);
            w.Start.Children.Add(n);

            MessageBox.Show("Данные изменены!");
            this.Close();
        }
    }
}
