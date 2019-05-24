using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
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
    /// Логика взаимодействия для Начало_обучения.xaml
    /// </summary>
    public partial class StartLearn : UserControl
    {
        public StartLearn()
        {
            InitializeComponent();
        }

        
        private void ExitProfile_Click(object sender, RoutedEventArgs e)
        {
            if (Icon.Kind == PackIconKind.Bell)
            {
                try
                {
                    MailAddress from = new MailAddress("sakun_nastya@mail.ru", "StudProg");
                    MailAddress to = new MailAddress(ProfileId.mail);
                    MailMessage m = new MailMessage(from, to);
                    m.Subject = "StudProg";
                    m.Body = $"Ваша успеваемость: {ProfileId.count}";
                    SmtpClient smtp = new SmtpClient("smpt.mail.ru", 587);
                    smtp.Credentials = new NetworkCredential("sakun_nastya@mail.ru", "itizam41");
                    smtp.EnableSsl = true;
                    smtp.Send(m);
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }

            Sign sign = new Sign();
            sign.Show();

            MainWindow window = (MainWindow)Application.Current.MainWindow;
            window.Start.Children.Clear();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
       
        private void Profile_Click(object sender, RoutedEventArgs e)
        {
            AnotherPages.Children.Clear();
            Block.Children.Clear();
            Profile profile = new Profile();

            AnotherPages.Children.Add(profile);
        }

        
        private void Home_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = (MainWindow)Application.Current.MainWindow;
            window.Start.Children.Clear();
            StartLearn nach = new StartLearn();
            window.Start.Children.Add(nach);
        }
        
        private void Stat_Click(object sender, RoutedEventArgs e)
        {
            AnotherPages.Children.Clear();
            Block.Children.Clear();
            Statistics stat = new Statistics();
            AnotherPages.Children.Add(stat);
        }

        private void Study_Click(object sender, RoutedEventArgs e)
        {
            Study study = new Study();
            Block.Children.Clear();
            AnotherPages.Children.Clear();
            AnotherPages.Children.Add(study);
        }

        private void AllCourses_Click(object sender, RoutedEventArgs e)
        {
            Study st = new Study();
            Block.Children.Clear();
            AnotherPages.Children.Clear();
            AnotherPages.Children.Add(st);
        }

        private void QS_Click(object sender, RoutedEventArgs e)
        {
            Study st = new Study();
            Block.Children.Clear();
            AnotherPages.Children.Clear();
            st.topics.Children.Clear();
            AnotherPages.Children.Add(st);

            StudyTopic ql = new StudyTopic();
            st.topics.Children.Clear();

            TopicObject.name = "Один";
            TopicObject.text = "ТекстОдин";
            TopicObject.example = "Пример1";
            TopicObject.task = "Задание1";

            ql.TextName.Text = TopicObject.name;
            ql.Text.Text = TopicObject.text;

            st.topics.Children.Add(ql);
        }

        private void TG_Click(object sender, RoutedEventArgs e)
        {
            Study st = new Study();
            Block.Children.Clear();
            AnotherPages.Children.Clear();
            st.topics.Children.Clear();
            AnotherPages.Children.Add(st);

            StudyTopic ql = new StudyTopic();
            st.topics.Children.Clear();

            TopicObject.name = "Два";
            TopicObject.text = "ТекстДва";
            TopicObject.example = "Пример2";
            TopicObject.task = "Задание2";

            ql.TextName.Text = TopicObject.name;
            ql.Text.Text = TopicObject.text;

            st.topics.Children.Add(ql);
        }

        private void MailStat_Click(object sender, RoutedEventArgs e)
        {        
            if(Icon.Kind==PackIconKind.Bell)
            {
                Icon.Kind = PackIconKind.BellOff;
                Bell.ToolTip = "Отправка статистики на почту выкл.";
            }

            else
            {
                Icon.Kind = PackIconKind.Bell;
                Bell.ToolTip = "Отправка статистики на почту вкл.";
            }
            
        }
    }
}
