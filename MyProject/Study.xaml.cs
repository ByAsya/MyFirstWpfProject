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

        private void QL_Click(object sender, RoutedEventArgs e)
        {
            QueueList ql = new QueueList();
            Text.Children.Clear();
            Topics.Children.Add(ql);
        }
        
        private void TG_Click(object sender, RoutedEventArgs e)
        {
            TreeGraph tg = new TreeGraph();
            Text.Children.Clear();
            Topics.Children.Add(tg);
        }

        private void DS_Click(object sender, RoutedEventArgs e)
        {
            StackDack ds = new StackDack();
            Text.Children.Clear();
            Topics.Children.Add(ds);
        }

        private void Sort_Click(object sender, RoutedEventArgs e)
        {
            Sort sort = new Sort();
            Text.Children.Clear();
            Topics.Children.Add(sort);
        }
    }
}
