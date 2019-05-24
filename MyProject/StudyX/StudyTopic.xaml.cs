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
    /// Логика взаимодействия для QueueList.xaml
    /// </summary>
    public partial class StudyTopic : UserControl
    {
        public StudyTopic()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            example.Opacity = 0.7;
            topic.Opacity = 1;
            task.Opacity = 0.7;
            Text.Text = TopicObject.text;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            example.Opacity =1;
            topic.Opacity = 0.7;
            task.Opacity = 0.7;
            
            Text.Text= TopicObject.example;
        }

        private void Task_Click(object sender, RoutedEventArgs e)
        {
            example.Opacity = 0.7;
            topic.Opacity = 0.7;
            task.Opacity = 1;
            
            Text.Text= TopicObject.task;
        }
    }
}
