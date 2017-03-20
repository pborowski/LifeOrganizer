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

namespace LifeOrganizer
{
    /// <summary>
    /// Interaction logic for Task_Menu_Window.xaml
    /// </summary>
    /// 


    public partial class Task_Menu_Window : Window
    {
        public string Choice
        {
            get;
            set;
        }

        public Task_Menu_Window()
        {
            InitializeComponent();
        }

        private void Push_Click(object sender, RoutedEventArgs e)
        {
            Choice = "Push";
            DialogResult = true;
            Close();
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            Choice = "Edit";
            DialogResult = true;
            Close();
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            Choice = "Delete";
            DialogResult = true;
            Close();
        }

    }
}
