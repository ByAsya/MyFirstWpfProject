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
    /// Логика взаимодействия для Study.xaml
    /// </summary>
    public partial class Study : UserControl
    {
        public Study()
        {
            InitializeComponent();
        }

        StudyTopic ql = new StudyTopic();

        private void QL_Click(object sender, RoutedEventArgs e)
        {
            topics.Children.Clear();
            Topic.name = "Один";
            Topic.text = "ТекстОдин";
            Topic.example = "Пример1";
            Topic.task = "Задание1";

            ql.TextName.Text = Topic.name;
            ql.Text.Text = Topic.text;
            
            topics.Children.Add(ql);
        }
        
        private void TG_Click(object sender, RoutedEventArgs e)
        {
            topics.Children.Clear();
            Topic.name = "Два";
            Topic.text = "ТекстДва";
            Topic.example = "Пример2";
            Topic.task = "Задание2";

            ql.TextName.Text = Topic.name;
            ql.Text.Text = Topic.text;

            topics.Children.Add(ql);
        }

        private void DS_Click(object sender, RoutedEventArgs e)
        {
            topics.Children.Clear();
            Topic.name = "Три";
            Topic.text = "ТекстТри";
            Topic.example = "Пример3";
            Topic.task = "Задание3";

            ql.TextName.Text = Topic.name;
            ql.Text.Text = Topic.text;

            topics.Children.Add(ql);
        }

        private void Sort_Click(object sender, RoutedEventArgs e)
        {
            topics.Children.Clear();
            Topic.name = "Четыре";
            Topic.text = "Текст4";
            Topic.example = "Пример4";
            Topic.task = "Задание4";

            ql.TextName.Text = Topic.name;
            ql.Text.Text = Topic.text;

            topics.Children.Add(ql);
        }
    }
}
