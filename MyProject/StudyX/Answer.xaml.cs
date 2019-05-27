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
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using static MyProject.Database.Data;

namespace MyProject
{
    /// <summary>
    /// Логика взаимодействия для Answer.xaml
    /// </summary>
    public partial class Answer : Window
    {
        public Answer()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            UserRepository user = new UserRepository();
            var User = user.Get(ProfileId.mail);
            int point;

            if(DataObjects.nameTopic=="Стеки и очереди")
            {
                point = (int)User.pointsOne;
                TaskRepository taskR = new TaskRepository();
                var task = taskR.GetAll();

                UserRepository userR = new UserRepository();
                var users = from u in task
                            where u.topic=="Стеки и очереди"
                            select u;
                
                if(one.Text==users.ElementAt(0).answers)
                {
                    point++;
                    if (two.Text == users.ElementAt(1).answers)
                    {
                        point++;
                        if (three.Text == users.ElementAt(2).answers)
                        {
                            point++;

                            if (four.Text == users.ElementAt(3).answers)
                            {
                                point++;

                                if (five.Text == users.ElementAt(4).answers)
                                {
                                    point++;
                                }
                            }
                        }
                    }

                }
                var user_ = userR.Get(ProfileId.mail);
                user_.pointsOne = point;
                userR.Save();
                MessageBox.Show("Ваши баллы: "+point.ToString());
            }

            else if (DataObjects.nameTopic == "Сортировки")
            {
                point = (int)User.pointsFour;
                TaskRepository taskR = new TaskRepository();
                var task = taskR.GetAll();

                UserRepository userR = new UserRepository();
                var users = from u in task
                            where u.topic == "Сортировки"
                            select u;

                if (one.Text == users.ElementAt(0).answers)
                {
                    point++;
                    if (two.Text == users.ElementAt(1).answers)
                    {
                        point++;
                        if (three.Text == users.ElementAt(2).answers)
                        {
                            point++;

                            if (four.Text == users.ElementAt(3).answers)
                            {
                                point++;

                                if (five.Text == users.ElementAt(4).answers)
                                {
                                    point++;
                                }
                            }
                        }
                    }

                }
                var user_ = userR.Get(ProfileId.mail);
                user_.pointsFour = point;
                userR.Save();
                MessageBox.Show("Ваши баллы: " + point.ToString());
            }

            else if (DataObjects.nameTopic == "Деревья и графы")
            {
                point = (int)User.pointsOne;
                TaskRepository taskR = new TaskRepository();
                var task = taskR.GetAll();

                UserRepository userR = new UserRepository();
                var users = from u in task
                            where u.topic == "Деревья и графы"
                            select u;

                if (one.Text == users.ElementAt(0).answers)
                {
                    point++;
                    if (two.Text == users.ElementAt(1).answers)
                    {
                        point++;
                        if (three.Text == users.ElementAt(2).answers)
                        {
                            point++;

                            if (four.Text == users.ElementAt(3).answers)
                            {
                                point++;

                                if (five.Text == users.ElementAt(4).answers)
                                {
                                    point++;
                                }
                            }
                        }
                    }

                }
                var user_ = userR.Get(ProfileId.mail);
                user_.pointsOne = point;
                userR.Save();
                MessageBox.Show("Ваши баллы: " + point.ToString());
            }
            this.Close();
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
                DragMove();
        }
    }
}
