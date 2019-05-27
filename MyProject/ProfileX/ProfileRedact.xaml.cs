using MyProject.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using static MyProject.Database.Data;

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
            user_.nameU = Name.Text;
            user_.passwordU = Pass.Password.GetHashCode().ToString();
            user_.mail = Mail.Text;

            userR.Save();

            ProfileId.mail = Mail.Text;
            ProfileId.name = Name.Text;

            MainWindow w = (MainWindow)System.Windows.Application.Current.MainWindow;
            StartLearn n = new StartLearn();
            n.Block.Children.Clear();
            Profile p = new Profile();
            n.AnotherPages.Children.Add(p);
            w.Start.Children.Add(n);

            System.Windows.MessageBox.Show("Данные изменены!");
            this.Close();
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
                DragMove();
        }

        private void Picture_Click(object sender, RoutedEventArgs e)
        {
            string image = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All files(*.*)|*.*";

                if(dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    image = dialog.FileName;
                    ProfileId.picture = image;

                    UserRepository userR = new UserRepository();
                    var user = userR.Get(ProfileId.mail);
                    user.pictureProfile = ProfileId.picture;
                    userR.Save();
                    
                }
            }

            catch(Exception ex)
            {
                System.Windows.MessageBox.Show(ex.ToString());
            }
        }
    }
}
