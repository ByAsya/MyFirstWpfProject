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

namespace MyProject
{
    /// <summary>
    /// Логика взаимодействия для StackDack.xaml
    /// </summary>
    public partial class StackDack : UserControl
    {
        public StackDack()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Example.Opacity = 0.7;
            Topic.Opacity = 1;
            Task.Opacity = 0.7;

            Text.Text = null;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Example.Opacity = 1;
            Topic.Opacity = 0.7;
            Task.Opacity = 0.7;

            Text.Text = null;
            Text.Text += "Примеры:";
        }

        private void Task_Click(object sender, RoutedEventArgs e)
        {
            Example.Opacity = 0.7;
            Topic.Opacity = 0.7;
            Task.Opacity = 1;

            Text.Text = null;
            Text.Text += "Задания:";
        }
    }
}
