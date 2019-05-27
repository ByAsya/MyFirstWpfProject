using MaterialDesignThemes.Wpf;
using MyProject.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
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
using static MyProject.Database.Data;

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
            string Mail = ProfileId.mail;
            string[] chekS = Mail.Split(new char[] { '@'});

            mail.Text = chekS[0];

            UserRepository userR = new UserRepository();
            var user=userR.Get(Mail);
            name.Text = user.nameU;
            int point = (int)(user.pointsOne + user.pointsThree + user.pointsTwo + user.pointsFour);
            DataObjects.taskCount = point;
            topics.Text+=DataObjects.taskCount.ToString();
            picture.ImageSource = new BitmapImage(new Uri(ProfileId.picture,UriKind.Relative));
            user.pictureProfile = picture.ImageSource.ToString();
            userR.Save();

            one.Text = "Ваши баллы: " + user.pointsOne;
            two.Text = "Ваши баллы: " + user.pointsTwo;
            three.Text = "Ваши баллы: " + user.pointsThree;
            four.Text = "Ваши баллы: " + user.pointsFour;
        }


        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Вы точно хотите удалить аккаунт?", 
                "Удаление",MessageBoxButton.YesNo, MessageBoxImage.None,MessageBoxResult.No);
           
            if (result==MessageBoxResult.Yes)
            {                
                UserRepository userR = new UserRepository();
                var user= userR.Get(ProfileId.mail);
                userR.Delete(user);

                Sign sign = new Sign();
                sign.Show();

                MainWindow window = (MainWindow)Application.Current.MainWindow;
                window.Start.Children.Clear();
            }
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            StartLearn n = new StartLearn();

            if (n.Icon.Kind == PackIconKind.Bell)
            {
                try
                {
                    MailAddress from = new MailAddress("sakun_nastya@mail.ru", "StudProg");
                    MailAddress to = new MailAddress(ProfileId.mail);
                    MailMessage m = new MailMessage(from, to);
                    m.Subject = "StudProg";
                    m.Body = $"Ваша успеваемость: {ProfileId.count}";
                    SmtpClient smtp = new SmtpClient("smpt.mail.ru", 587);
                    smtp.Credentials = new NetworkCredential("sakun_nastya@mail.ru", "itizam41");
                    smtp.EnableSsl = true;
                    smtp.Send(m);
                }

                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                
            }
            
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
