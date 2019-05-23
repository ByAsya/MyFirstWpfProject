﻿using MaterialDesignThemes.Wpf;
using MyProject.database;
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

namespace MyProject
{
    /// <summary>
    /// Логика взаимодействия для SignIn.xaml
    /// </summary>
    public partial class SignIn : UserControl
    {
        public SignIn()
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

                    if (pass1.Password.GetHashCode().ToString() != user.password)
                    {
                        pass1.BorderBrush = Brushes.Red;
                        MessageBox.Show("Неверный пароль!");
                        pass1.BorderBrush = Brushes.Red;
                    }

                    else
                    {
                        ProfileId.mail = user.Id;
                        ProfileId.name = user.name;
                        ProfileId.count = user.t_count;

                        string mailAdmin = "sakunnastya28@gmail.com";

                        if (user.Id == mailAdmin)
                        {
                            Admin admin = new Admin();
                            Study study = new Study();
                            n.AdminPage.Children.Clear();
                            n.AnotherPages.Children.Add(study);
                            n.Admin.Children.Add(admin);
                            w.Start.Children.Add(n);
                        }

                        else
                        {
                            n.AnotherPages.Children.Add(p);
                            w.Start.Children.Add(n);
                        }

                        MainWindow window = (MainWindow)Application.Current.MainWindow;
                        window.sign.Close();
                    }
                }

                catch (Exception)
                {
                    mail1.BorderBrush = Brushes.Red;
                    pass1.BorderBrush = Brushes.Red;
                    MessageBox.Show("Неверный логин или пароль!");
                    mail1.BorderBrush = Brushes.Gray;
                    pass1.BorderBrush = Brushes.Gray;
                }

            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            RememberPass rpass = new RememberPass();
            rpassword.Children.Clear();
            rpassword.Children.Add(rpass);
        }
    }
}
