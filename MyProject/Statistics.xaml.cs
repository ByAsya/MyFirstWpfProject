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
using static MyProject.Database.Data;

namespace MyProject
{
    /// <summary>
    /// Логика взаимодействия для Statistics.xaml
    /// </summary>
    public partial class Statistics : UserControl
    {
        public Statistics()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            UserRepository userR = new UserRepository();
            var users = from u in userR.GetAll()
                        orderby (u.pointsFour+u.pointsOne+u.pointsTwo+u.pointsThree) descending
                        select  u;

            
            try
            {
                int points = (int)(users.First().pointsFour + users.First().pointsOne + users.First().pointsTwo + users.First().pointsThree);
                oneP.ImageSource = null;
                Top1.Text = "Имя пользователя: "+users.First().nameU+ Environment.NewLine + "Почта: " + users.First().mail + Environment.NewLine + "Баллы: " + points;
                oneP.ImageSource = new BitmapImage(new Uri(users.First().pictureProfile, UriKind.Relative));
            }

            catch
            {
                Top1.Text = null;
                oneP.ImageSource = new BitmapImage(new Uri("D:\\ООП\\MyProject\\MyProject\\pictures\\default_user_icon.jpg", UriKind.Relative));
            }

            try
            {
                int points = (int)(users.ElementAt(1).pointsFour + users.ElementAt(1).pointsOne + users.ElementAt(1).pointsTwo + users.ElementAt(1).pointsThree);
                Top2.Text = "Имя пользователя: " + users.ElementAt(1).nameU + Environment.NewLine + "Почта: " + users.ElementAt(1).mail +Environment.NewLine+"Баллы: "+ points;
                twoP.ImageSource = new BitmapImage(new Uri(users.ElementAt(1).pictureProfile, UriKind.Relative));
            }

            catch
            {
                Top2.Text = null;
                twoP.ImageSource = new BitmapImage(new Uri("D:\\ООП\\MyProject\\MyProject\\pictures\\default_user_icon.jpg", UriKind.Relative));
            }

            try
            {
                int points = (int)(users.ElementAt(2).pointsFour + users.ElementAt(2).pointsOne + users.ElementAt(2).pointsTwo + users.ElementAt(2).pointsThree);
                Top3.Text = "Имя пользователя: " + users.ElementAt(2).nameU + Environment.NewLine + "Почта: " + users.ElementAt(2).mail + Environment.NewLine + "Баллы: " + points;
                threeP.ImageSource = new BitmapImage(new Uri(users.ElementAt(2).pictureProfile, UriKind.Relative));
            }

            catch
            {
                Top3.Text = null;
                threeP.ImageSource = new BitmapImage(new Uri("D:\\ООП\\MyProject\\MyProject\\pictures\\default_user_icon.jpg", UriKind.Relative));
            }

            try
            {
                int points = (int)(users.ElementAt(3).pointsFour + users.ElementAt(3).pointsOne + users.ElementAt(3).pointsTwo + users.ElementAt(3).pointsThree);
                Top4.Text = "Имя пользователя: " + users.ElementAt(3).nameU + Environment.NewLine + "Почта: " + users.ElementAt(3).mail + Environment.NewLine+"Баллы: " + points;
                fourP.ImageSource = new BitmapImage(new Uri(users.ElementAt(3).pictureProfile, UriKind.Relative));
            }

            catch
            {
                Top4.Text = null;
                fourP.ImageSource = new BitmapImage(new Uri("D:\\ООП\\MyProject\\MyProject\\pictures\\default_user_icon.jpg", UriKind.Relative));
            }
        }
    }
}
