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
    /// Логика взаимодействия для StudyAdminStart.xaml
    /// </summary>
    public partial class StudyAdminStart : UserControl
    {
        public StudyAdminStart()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            text.AppendText("ssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssss" +
                "sssssssssssssssssssssssssssssssssssssssssssssss" +
                Environment.NewLine+ Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine +
                Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine +
                Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine +
                Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine +
                Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine +
                "shdjwehjkdhddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddd");
        }
    }
}
