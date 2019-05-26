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
    /// Логика взаимодействия для Study.xaml
    /// </summary>
    public partial class Study : UserControl
    {
        public Study()
        {
            InitializeComponent();
        }

        StudyTopic st = new StudyTopic();
        StudyAdmin adminS = new StudyAdmin();

        private void QL_Click(object sender, RoutedEventArgs e)
        {
            topics.Children.Clear();

            DataObjects.nameTopic = "Стеки и очереди";
            st.TextName.Text = DataObjects.nameTopic;
            adminS.TextName.Text = DataObjects.nameTopic;
            st.Text.Text = DataObjects.textTopic;            

            if(TopicObject.adminName=="sakunnastya28@gmail.com")
            {
                adminS.TextR.Document.Blocks.Clear();
                adminS.TextR.AppendText(DataObjects.textTopic);
                topics.Children.Add(adminS);
            }
            else
            {
                topics.Children.Add(st);
            }
        }
        
        private void TG_Click(object sender, RoutedEventArgs e)
        {
            topics.Children.Clear();

            DataObjects.nameTopic = "Деревья и графы";
            st.TextName.Text = DataObjects.nameTopic;
            adminS.TextName.Text = DataObjects.nameTopic;
            st.Text.Text = DataObjects.textTopic;

            if (TopicObject.adminName == "sakunnastya28@gmail.com")
            {
                adminS.TextR.Document.Blocks.Clear();
                adminS.TextR.AppendText(DataObjects.textTopic);
                topics.Children.Add(adminS);
            }
            else
            {
                topics.Children.Add(st);
            }
        }

        private void DS_Click(object sender, RoutedEventArgs e)
        {
            topics.Children.Clear();

            DataObjects.nameTopic = "Деки и списки";
            st.TextName.Text = DataObjects.nameTopic;
            adminS.TextName.Text = DataObjects.nameTopic;
            st.Text.Text = DataObjects.textTopic;

            if (TopicObject.adminName == "sakunnastya28@gmail.com")
            {
                adminS.TextR.Document.Blocks.Clear();
                adminS.TextR.AppendText(DataObjects.textTopic);
                topics.Children.Add(adminS);
            }
            else
            {
                topics.Children.Add(st);
            }
        }

        private void Sort_Click(object sender, RoutedEventArgs e)
        {
            topics.Children.Clear();

            DataObjects.nameTopic = "Сортировки";
            st.TextName.Text = DataObjects.nameTopic;
            adminS.TextName.Text = DataObjects.nameTopic;
            st.Text.Text = DataObjects.textTopic;

            if (TopicObject.adminName == "sakunnastya28@gmail.com")
            {
                adminS.TextR.Document.Blocks.Clear();
                adminS.TextR.AppendText(DataObjects.textTopic);
                topics.Children.Add(adminS);
            }
            else
            {
                topics.Children.Add(st);
            }
        }
    }
}
