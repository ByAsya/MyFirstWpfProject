using MyProject.Database;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
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

namespace MyProject.Admin
{
    /// <summary>
    /// Логика взаимодействия для TopicU.xaml
    /// </summary>
    public partial class TopicU : UserControl
    {
        Data db = new Data();
        ObservableCollection<Topic> Topic = new ObservableCollection<Topic>();

        public TopicU()
        {
            InitializeComponent();

        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            db.Dispose();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = (MainWindow)Application.Current.MainWindow;
            window.Start.Children.Clear();
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            db.Topics.Load();
            Topic = db.Topics.Local;
            tableTopics.ItemsSource = Topic;
        }

        private void Del_Click(object sender, RoutedEventArgs e)
        {
            if (tableTopics.SelectedItems.Count > 0)
            {
                for (int i = 0; i < tableTopics.SelectedItems.Count; i++)
                {
                    Topic topic = tableTopics.SelectedItems[i] as Topic;
                    if (topic != null)
                    {
                        db.Topics.Remove(topic);
                    }
                }
            }
            db.SaveChanges();
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            db.SaveChanges();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            db.SaveChanges();
        }

        private void Topic_Click(object sender, RoutedEventArgs e)
        {
            MainWindow w = (MainWindow)Application.Current.MainWindow;
            StartLearn n = new StartLearn();
            n.Block.Children.Clear();
            TopicU admin = new TopicU();
            w.Start.Children.Add(admin);
        }

        private void Task_Click(object sender, RoutedEventArgs e)
        {
            MainWindow w = (MainWindow)Application.Current.MainWindow;
            StartLearn n = new StartLearn();
            n.Block.Children.Clear();
            TaskU admin = new TaskU();
            w.Start.Children.Add(admin);
        }
    }
}
