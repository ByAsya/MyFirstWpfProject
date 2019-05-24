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

        private void Load_Click(object sender, RoutedEventArgs e)
        {
            Name.Text = ProfileId.name;
            Mail.Text = ProfileId.mail;
        }

            private void Redact_Click(object sender, RoutedEventArgs e)
        {
            Profile profile = new Profile();
            UserRepository userR = new UserRepository();
            var user_ = userR.Get(ProfileId.mail);

            userR.Delete(user_);

            User user = new User { mail = Mail.Text, nameU = Name.Text, passwordU = Pass.Password.GetHashCode().ToString()};
            userR.Create(user);

            ProfileId.mail = Mail.Text;
            ProfileId.name = Name.Text;

            MainWindow w = (MainWindow)Application.Current.MainWindow;
            StartLearn n = new StartLearn();
            n.Block.Children.Clear();
            Profile p = new Profile();
            n.AnotherPages.Children.Add(p);
            w.Start.Children.Add(n);

            MessageBox.Show("Данные изменены!");
            this.Close();
        }
    }
}
