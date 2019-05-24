﻿using System;
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
    /// Логика взаимодействия для Admin.xaml
    /// </summary>
    public partial class Admin : UserControl
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Sign sign = new Sign();
            sign.Show();

            MainWindow window = (MainWindow)Application.Current.MainWindow;
            window.Start.Children.Clear();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow w = (MainWindow)Application.Current.MainWindow;
            StartLearn n = new StartLearn();
            n.Block.Children.Clear();
            Admin admin = new Admin();
            Study study = new Study();
            StudyAdminStart studyA = new StudyAdminStart();

            n.AdminPage.Children.Clear();
            study.topics.Children.Clear();
            study.topics.Children.Add(studyA);
            n.AnotherPages.Children.Add(study);
            n.Admin.Children.Add(admin);
            w.Start.Children.Add(n);
        }
    }
}
