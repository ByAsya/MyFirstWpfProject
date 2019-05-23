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
        
        private void Input_Click(object sender, RoutedEventArgs e)
        {
            In.Opacity = 1;
            Up.Opacity = 0.7;
            InUp.Children.Clear();

            SignIn sign = new SignIn();
            InUp.Children.Add(sign);
            
        } 

        private void Reg_Click(object sender, RoutedEventArgs e)
        {
            Up.Opacity = 1;
            In.Opacity = 0.7;
            InUp.Children.Clear();

            SignUp sign = new SignUp();
            InUp.Children.Add(sign);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            In.Opacity = 1;
            Up.Opacity = 0.7;

            SignIn sign = new SignIn();
            InUp.Children.Add(sign);
        }
    }
}
