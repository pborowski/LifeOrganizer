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
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Add_Task_Window : Window
    {
        public Add_Task_Window()
        {
            InitializeComponent();
            Textbox_Add_Title.Focus();
        }
        public string NewTitle
        {
            get;
            set;
        }
        public string NewDescription
        {
            get;
            set;
        }
        public DateTime NewDate
        {
            get;
            set;
        }
        private void Button_Add_Task_Confirm_Click(object sender, RoutedEventArgs e)
        {
            if(Textbox_Add_Title.Text.Length>0 && Textbox_Add_Description.Text.Length>0 )
            {
                NewTitle = Textbox_Add_Title.Text;
                NewDescription = Textbox_Add_Description.Text;
                NewDate = DatePicker_Add_Date.DisplayDate;
                DialogResult = true;
                Close();
            }
            else
            {
                //MessageBox.Show();
            }
            
        }
    }
}
