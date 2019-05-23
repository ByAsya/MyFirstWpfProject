using MyProject.database;
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
    /// Логика взаимодействия для SignUp.xaml
    /// </summary>
    public partial class SignUp : UserControl
    {
        public SignUp()
        {
            InitializeComponent();
        }

        UserRepository userR = new UserRepository();
        private void Reg_Click(object sender, RoutedEventArgs e)
        {

            MainWindow w = (MainWindow)Application.Current.MainWindow;
            StartLearn n = new StartLearn();
            n.Block.Children.Clear();
            Profile p = new Profile();

            if (mail2.Text == String.Empty || name2.Text == String.Empty || pass2.Password == String.Empty||Code.Text==String.Empty)
            {
                MessageBox.Show("Заполните все поля!");
            }

            else
            {
                try
                {
                    string mail_ = mail2.Text;
                    string[] chekS = mail_.Split(new char[] { '@' });
                    string check = chekS.Last();

                    if (check == "gmail.com" || check == "mail.ru")
                    {
                        if (Code.Text == code.ToString())
                        {
                            User user = new User { Id = mail2.Text, name = name2.Text, password = pass2.Password.GetHashCode().ToString() };
                            userR.Create(user);

                            ProfileId.mail = user.Id;
                            ProfileId.name = user.name;
                            ProfileId.count = user.t_count;
                            ProfileId.password = user.password;

                            MessageBox.Show("Регистрация выполнена успешно!");
                            MainWindow window = (MainWindow)Application.Current.MainWindow;
                            window.sign.Close();

                            n.AnotherPages.Children.Add(p);
                            w.Start.Children.Add(n);
                        }

                        else
                            MessageBox.Show("Неверный код подтверждения!");
                    }

                    else
                        MessageBox.Show("Неправильный формат почты!" + Environment.NewLine + "Пример:kkk@mail.ru, kkk@gmai.com");

                }

                catch (Exception)
                {
                    MessageBox.Show("Данная почта уже использована!");
                }
            }
        }

        public static Random rnd = new Random();
        public int code = rnd.Next(0, 10);
        private void Button_Click(object sender, RoutedEventArgs e)
        {           

            try
            {
                MailAddress from = new MailAddress("sakun_nastya@mail.ru", "StudProg");
                MailAddress to = new MailAddress(mail2.Text);
                MailMessage m = new MailMessage(from, to);
                m.Subject = "StudProg";
                m.Body = $"Код для подтверждения пароля:{code} ";
                SmtpClient smtp = new SmtpClient("smpt.mail.ru", 587);
                smtp.Credentials = new NetworkCredential("sakun_nastya@mail.ru", "itizam41");
                smtp.EnableSsl = true;
                smtp.Send(m);
                MessageBox.Show("Код выслан!");
            }

            catch (Exception)
            {
                MessageBox.Show("Отсутствует подключение к интернету!");
            }

        }
    }
}
