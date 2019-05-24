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
        StudyAdmin adminS = new StudyAdmin();

        private void QL_Click(object sender, RoutedEventArgs e)
        {
            topics.Children.Clear();

            ql.TextName.Text = TopicObject.name;
            ql.Text.Text = TopicObject.text;            

            if(TopicObject.adminName=="sakunnastya28@gmail.com")
            {
                adminS.TextR.Document.Blocks.Clear();
                adminS.TextNameR.Document.Blocks.Clear();
                adminS.TextR.AppendText(TopicObject.text);
                adminS.TextNameR.AppendText(TopicObject.name);
                topics.Children.Add(adminS);
            }
            else
                topics.Children.Add(ql);
        }
        
        private void TG_Click(object sender, RoutedEventArgs e)
        {
            topics.Children.Clear();

            ql.TextName.Text = TopicObject.name;
            ql.Text.Text = TopicObject.text;

            if (TopicObject.adminName == "sakunnastya28@gmail.com")
            {
                adminS.TextR.Document.Blocks.Clear();
                adminS.TextNameR.Document.Blocks.Clear();
                adminS.TextR.AppendText(TopicObject.text);
                adminS.TextNameR.AppendText(TopicObject.name);
                topics.Children.Add(adminS);
            }
            else
                topics.Children.Add(ql);
        }

        private void DS_Click(object sender, RoutedEventArgs e)
        {
            topics.Children.Clear();

            ql.TextName.Text = TopicObject.name;
            ql.Text.Text = TopicObject.text;

            if (TopicObject.adminName == "sakunnastya28@gmail.com")
            {
                adminS.TextR.Document.Blocks.Clear();
                adminS.TextNameR.Document.Blocks.Clear();
                adminS.TextR.AppendText(TopicObject.text);
                adminS.TextNameR.AppendText(TopicObject.name);
                topics.Children.Add(adminS);
            }
            else
                topics.Children.Add(ql);
        }

        private void Sort_Click(object sender, RoutedEventArgs e)
        {
            topics.Children.Clear();

            ql.TextName.Text = TopicObject.name;
            ql.Text.Text = TopicObject.text;

            if (TopicObject.adminName == "sakunnastya28@gmail.com")
            {
                adminS.TextR.Document.Blocks.Clear();
                adminS.TextNameR.Document.Blocks.Clear();
                adminS.TextR.AppendText(TopicObject.text);
                adminS.TextNameR.AppendText(TopicObject.name);
                topics.Children.Add(adminS);
            }
            else
                topics.Children.Add(ql);
        }
    }
}
