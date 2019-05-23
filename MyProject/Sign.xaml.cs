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
    public partial class Sign : Window
    {
        public Sign()
        {
            InitializeComponent();

        }

        UserRepository userR = new UserRepository();

        private void Input_Click(object sender, RoutedEventArgs e)
        {
            
            if (mail1.Text == String.Empty || pass1.Password == String.Empty)
            {
                MessageBox.Show("Заполните все поля!");
            }            

            else
            {
                MainWindow w = (MainWindow)Application.Current.MainWindow;
                StartLearn n = new StartLearn();
                n.Block.Children.Clear();
                Profile p = new Profile();

                try
                {
                    string mail = mail1.Text;

                    UserRepository userR = new UserRepository();
                    var user = userR.Get(mail);

                    if(pass1.Password.GetHashCode().ToString()!=user.password)
                    {
                        pass1.BorderBrush = Brushes.Red;
                        MessageBox.Show("Неверный пароль!");
                    }
                    
                    else
                    {
                        ProfileId.mail = user.Id;
                        ProfileId.name = user.name;
                        ProfileId.count = user.t_count;

                        this.Close();

                        n.AnotherPages.Children.Add(p);
                        w.Start.Children.Add(n);
                    }                    
                }

                catch(Exception)
                {
                    mail1.BorderBrush = Brushes.Red;
                    pass1.BorderBrush = Brushes.Red;
                    MessageBox.Show("Неверный логин или пароль!");
                }               
                
            }
        } 

        private void Reg_Click(object sender, RoutedEventArgs e)
        {
           
            MainWindow w = (MainWindow)Application.Current.MainWindow;
            StartLearn n = new StartLearn();
            n.Block.Children.Clear();
            Profile p = new Profile();

            if (mail2.Text == String.Empty || name2.Text==String.Empty||pass2.Password==String.Empty)
            {
                MessageBox.Show("Заполните все поля!");
            }

            else
            {
                try
                {
                    string mail_ = mail2.Text;
                    string[] chekS = mail_.Split(new char[] { '@' });
                    string check = chekS.Last();

                    if (check == "gmail.com" || check == "mail.ru")
                    {
                        User user = new User { Id = mail2.Text, name = name2.Text, password = pass2.Password.GetHashCode().ToString() };
                        userR.Create(user);

                        ProfileId.mail = user.Id;
                        ProfileId.name = user.name;
                        ProfileId.count = user.t_count;
                        ProfileId.password = user.password;

                        MessageBox.Show("Регистрация выполнена успешно!");
                        this.Close();

                        n.AnotherPages.Children.Add(p);
                        w.Start.Children.Add(n);
                    }

                    else
                        MessageBox.Show("Неправильный формат почты!" + Environment.NewLine + "Пример:kkk@mail.ru, kkk@gmai.com");

                }

                catch (Exception)
                {
                    MessageBox.Show("Данная почта уже использована!");
                }
            }            
        }
    }
}
