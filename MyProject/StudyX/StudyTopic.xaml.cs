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
            if (TextName.Text == "Стеки и очереди")
            {
                DataObjects.nameTopic = TextName.Text;
                TopicRepository topicQ = new TopicRepository();
                var topic = topicQ.Get(DataObjects.nameTopic);                
                
                Text.Text = topic.topicText;
            }

            else if (TextName.Text == "Деревья и графы")
            {
                DataObjects.nameTopic = TextName.Text;
                TopicRepository topicQ = new TopicRepository();
                var topic = topicQ.Get(DataObjects.nameTopic);

                Text.Text = topic.topicText;
            }

            else if (TextName.Text == "Деки и списки")
            {
                DataObjects.nameTopic = TextName.Text;
                TopicRepository topicQ = new TopicRepository();
                var topic = topicQ.Get(DataObjects.nameTopic);

                Text.Text = topic.topicText;
            }

            else
            {
                DataObjects.nameTopic = TextName.Text;
                TopicRepository topicQ = new TopicRepository();
                var topic = topicQ.Get(DataObjects.nameTopic);

                Text.Text = topic.topicText;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            example.Opacity =1;
            topic.Opacity = 0.7;
            task.Opacity = 0.7;

            if (TextName.Text == "Стеки и очереди")
            {
                DataObjects.nameTopic = TextName.Text;
                TopicRepository topicQ = new TopicRepository();
                var topic = topicQ.Get(DataObjects.nameTopic);

                topic.exampleText = "Очереди:"+Environment.NewLine+"Queue<int> numbers = new Queue<int>();"+Environment.NewLine+"numbers.Enqueue(3); // очередь 3"+
                    Environment.NewLine+"numbers.Enqueue(5); // очередь 3, 5"+Environment.NewLine+"numbers.Enqueue(8); // очередь 3, 5, 8"+
                    Environment.NewLine+ "// получаем первый элемент очереди"+Environment.NewLine+ "int queueElement = numbers.Dequeue(); //теперь очередь 5, 8"+
                    Environment.NewLine+ "// получаем первый элемент без его извлечения" + Environment.NewLine+ "Person pp = persons.Peek();"+
                    Environment.NewLine+"Список:"+Environment.NewLine+ "List<int> numbers = new List<int>() { 1, 2, 3, 45 };"+Environment.NewLine+
                    "numbers.Add(6); // добавление элемента"+Environment.NewLine+ "numbers.RemoveAt(1); //  удаляем второй элемент";                

                Text.Text = topic.exampleText;
            }

            else if (TextName.Text == "Деревья и графы")
            {
                DataObjects.nameTopic = TextName.Text;
                TopicRepository topicQ = new TopicRepository();
                var topic = topicQ.Get(DataObjects.nameTopic);

                Text.Text = topic.exampleText;
            }

            else if (TextName.Text == "Деки и списки")
            {
                DataObjects.nameTopic = TextName.Text;
                TopicRepository topicQ = new TopicRepository();
                var topic = topicQ.Get(DataObjects.nameTopic);

                topic.exampleText = "Список:" + Environment.NewLine + "List<int> numbers = new List<int>() { 1, 2, 3, 45 };" + Environment.NewLine +
                    "numbers.Add(6); // добавление элемента" + Environment.NewLine + "numbers.RemoveAt(1); //  удаляем второй элемент";

                Text.Text = topic.exampleText;
            }

            else
            {
                DataObjects.nameTopic = TextName.Text;
                TopicRepository topicQ = new TopicRepository();
                var topic = topicQ.Get(DataObjects.nameTopic);

                Text.Text = topic.exampleText;
            }
        }

        private void Task_Click(object sender, RoutedEventArgs e)
        {
            example.Opacity = 0.7;
            topic.Opacity = 0.7;
            task.Opacity = 1;

            Text.Text = null;

            if (TextName.Text == "Стеки и очереди")
            {
                DataObjects.nameTopic = TextName.Text;
                TaskRepository taskR=new TaskRepository();
                var task = taskR.GetAll();

                Answer answer = new Answer();

                UserRepository userR = new UserRepository();
                var user_ = userR.Get(ProfileId.mail);

                var users = from u in task
                            orderby u.nameTask
                            select u;

                foreach(var t in users)
                {
                    if (t.topic == "Стеки и очереди")
                    {
                        Text.Text += t.textTask + Environment.NewLine + Environment.NewLine;
                    }

                    else
                        Text.Text = null;
                }

                if (Text.Text != String.Empty && user_.pointsOne < 5)
                {
                    answer.Show();
                }

                else
                    MessageBox.Show("Вы уже заработыли максимальный балл по этой теме!");
            }

            else if (TextName.Text == "Деревья и графы")
            {
                DataObjects.nameTopic = TextName.Text;
                TaskRepository taskR = new TaskRepository();
                var task = taskR.GetAll();
                Answer answer = new Answer();

                UserRepository userR = new UserRepository();
                var user_ = userR.Get(ProfileId.mail);
                var users = from u in task
                            orderby u.nameTask
                            select u;

                foreach (var t in users)
                {
                    if (t.topic == "Деревья и графы")
                    {
                        Text.Text += t.textTask + Environment.NewLine + Environment.NewLine;
                    }

                    else
                        Text.Text= null;
                }

                if (Text.Text != String.Empty && user_.pointsTwo < 5)
                {
                    answer.Show();
                }

                else
                    MessageBox.Show("Вы уже заработыли максимальный балл по этой теме!");
            }

            else if (TextName.Text == "Деки и списки")
            {
                DataObjects.nameTopic = TextName.Text;
                TaskRepository taskR = new TaskRepository();
                var task = taskR.GetAll();
                Answer answer = new Answer();

                UserRepository userR = new UserRepository();
                var user_ = userR.Get(ProfileId.mail);
                var users = from u in task
                            orderby u.nameTask
                            select u;

                foreach (var t in users)
                {
                    if (t.topic == "Деки и списки")
                    {
                        Text.Text += t.textTask + Environment.NewLine+Environment.NewLine;
                    }
                    else
                        Text.Text=null;
                }

                if (Text.Text != String.Empty && user_.pointsThree < 5)
                {
                    answer.Show();
                }

                else
                    MessageBox.Show("Вы уже заработыли максимальный балл по этой теме!");
            }

            else
            {
                DataObjects.nameTopic = TextName.Text;
                TopicRepository topicQ = new TopicRepository();
                var topic = topicQ.Get(DataObjects.nameTopic);

                TaskRepository taskR = new TaskRepository();
                var task = taskR.GetAll();
                Answer answer = new Answer();

                UserRepository userR = new UserRepository();
                var user_ = userR.Get(ProfileId.mail);
                var users = from u in task
                            orderby u.nameTask
                            select u;

                foreach (var t in users)
                {
                    if (t.topic == "Сортировки")
                    {
                        Text.Text += t.textTask + Environment.NewLine + Environment.NewLine;
                    }

                    else
                        Text.Text= null;
                }

                if (Text.Text != String.Empty && user_.pointsFour < 5)
                {
                    answer.Show();
                }

                else
                    MessageBox.Show("Вы уже заработыли максимальный балл по этой теме!");
            }           
            
        }
    }
}
