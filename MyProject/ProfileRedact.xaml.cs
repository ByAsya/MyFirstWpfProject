using MyProject.database;
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
using System.Windows.Shapes;

namespace MyProject
{
    /// <summary>
    /// Логика взаимодействия для ProfileRedact.xaml
    /// </summary>
    public partial class ProfileRedact : Window
    {
        public ProfileRedact()
        {
            InitializeComponent();
        }
        
        private void Redact_Click(object sender, RoutedEventArgs e)
        {
            User user = new User();
            UserRepository userR = new UserRepository();
            Вход_Регистрация input = new Вход_Регистрация();
            Profile profile = new Profile();
            var redactUser = userR.Get(input.mail1.Text);

            if (input.mail1==null)
            {
                redactUser = userR.Get(input.mail2.Text);
            }
            
            redactUser.Id = mail.Text;
            redactUser.name = name.Text;
            redactUser.password = pass.Password;

            profile.mail.Text = redactUser.Id;
            profile.name.Text = redactUser.name;

            MessageBox.Show("Данные изменены!");
            this.Close();
        }
    }
}
