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
using static MyProject.Database.Data;

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

        private void QL_Click(object sender, RoutedEventArgs e)
        {
            topics.Children.Clear();

            DataObjects.nameTopic = "Стеки и очереди";
            TopicRepository topicQ = new TopicRepository();
            var topic = topicQ.Get(DataObjects.nameTopic);

            topics.Children.Clear();
            st.TextName.Text = topic.nameTopic;
            st.Text.Text = topic.topicText;            

            topics.Children.Add(st);
        }
        
        private void TG_Click(object sender, RoutedEventArgs e)
        {
            topics.Children.Clear();

            DataObjects.nameTopic = "Деревья и графы";
            TopicRepository topicQ = new TopicRepository();
            var topic = topicQ.Get(DataObjects.nameTopic);

            topics.Children.Clear();
            st.TextName.Text = topic.nameTopic;
            st.Text.Text = topic.topicText;

            topics.Children.Add(st);
        }

        private void DS_Click(object sender, RoutedEventArgs e)
        {
            topics.Children.Clear();

            DataObjects.nameTopic = "Деки и списки";
            TopicRepository topicQ = new TopicRepository();
            var topic = topicQ.Get(DataObjects.nameTopic);

            topics.Children.Clear();
            st.TextName.Text = topic.nameTopic;
            st.Text.Text = topic.topicText;

            topics.Children.Add(st);
        }

        private void Sort_Click(object sender, RoutedEventArgs e)
        {
            topics.Children.Clear();

            DataObjects.nameTopic = "Сортировки";
            TopicRepository topicQ = new TopicRepository();
            var topic = topicQ.Get(DataObjects.nameTopic);

            topics.Children.Clear();
            st.TextName.Text = topic.nameTopic;
            st.Text.Text = topic.topicText;

            topics.Children.Add(st);
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            TopicRepository topicR = new TopicRepository();
            var topic=topicR.Get("Введение");

            startTopic.Text = topic.topicText;
        }
    }
}
