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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MyProject
{
    /// <summary>
    /// Логика взаимодействия для StudyAdmin.xaml
    /// </summary>
    public partial class StudyAdmin : UserControl
    {
        public StudyAdmin()
        {
            InitializeComponent();
        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TextR.Document.Blocks.Clear();
            example.Opacity = 0.7;
            topic.Opacity = 1;
            task.Opacity = 0.7;
            TextR.AppendText(DataObjects.textTopic);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            TextR.Document.Blocks.Clear();
            example.Opacity = 1;
            topic.Opacity = 0.7;
            task.Opacity = 0.7;
            TextR.AppendText(DataObjects.textExample);
        }

        private void Task_Click(object sender, RoutedEventArgs e)
        {
            TextR.Document.Blocks.Clear();
            example.Opacity = 0.7;
            topic.Opacity = 0.7;
            task.Opacity = 1;
            TextR.AppendText(DataObjects.textTask);
        }

        private void Redact_Click(object sender, RoutedEventArgs e)
        {
            string text;

            if (topic.Opacity == 1)
            {
                text = new TextRange(TextR.Document.ContentStart, TextR.Document.ContentEnd).Text;
                DataObjects.textTopic = text;
            }

            else if (example.Opacity == 1)
            {
                text = new TextRange(TextR.Document.ContentStart, TextR.Document.ContentEnd).Text;
                DataObjects.textExample = text;
            }

            else if(task.Opacity==1)
            {
                text = new TextRange(TextR.Document.ContentStart, TextR.Document.ContentEnd).Text;
                DataObjects.textTask = text;
            }               

            MessageBox.Show("Изменения сохранены!");
        }
    }
}
