using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LifeOrganizer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {        
        public MainWindow()
        {
            InitializeComponent();
            ToDoFile_Read();
            DoingFile_Read();
            DoneFile_Read();
            MessageBox.Show("Test commit 1");
        }
        //"C:\\Users\\Pawel\\ToDo.txt"
        private void ToDoFile_Write()
        {
            
            try
            {
                FileStream fs = new FileStream("C:\\Users\\Pawel\\ToDo2.txt", FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                foreach (Expander ex in StackPanel_To_Do.Children)
                {
                    sw.WriteLine(ex.Header.ToString());
                    sw.WriteLine((ex.Content as TextBlock).Text.ToString());
                }
                sw.Close();
                fs.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
        private void DoingFile_Write()
        {
            
            try
            {
                FileStream fs = new FileStream("C:\\Users\\Pawel\\Doing.txt", FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                foreach (Expander ex in StackPanel_Doing.Children)
                {
                    sw.WriteLine(ex.Header.ToString());
                    sw.WriteLine((ex.Content as TextBlock).Text.ToString());
                }
                sw.Close();
                fs.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
        private void DoneFile_Write()
        {
            
            try
            {
                FileStream fs = new FileStream("C:\\Users\\Pawel\\Done.txt", FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                foreach (Expander ex in StackPanel_Done.Children)
                {
                    sw.WriteLine(ex.Header.ToString());
                    sw.WriteLine((ex.Content as TextBlock).Text.ToString());
                }
                sw.Close();
                fs.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        private void ToDoFile_Read()
        {
            try
            {
                FileStream fs = new FileStream("C:\\Users\\Pawel\\ToDo2.txt",
                FileMode.Open, FileAccess.Read);

                try
                {
                    StreamReader sr = new StreamReader(fs);
                    while (!sr.EndOfStream)
                    {
                        string head = sr.ReadLine();
                        string date = sr.ReadLine();
                        string cont = sr.ReadLine();
                        Expander ex = TaskCreate(head + "\n" + date, cont);
                        StackPanel_To_Do.Children.Add(ex);
                    }
                    sr.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
            catch
            {
                
            }
        }
        private void DoingFile_Read()
        {
            try
            {
                FileStream fs = new FileStream("C:\\Users\\Pawel\\Doing.txt",
                FileMode.Open, FileAccess.Read);

                try
                {
                    StreamReader sr = new StreamReader(fs);
                    while (!sr.EndOfStream)
                    {
                        string head = sr.ReadLine();
                        string date = sr.ReadLine();
                        string cont = sr.ReadLine();
                        Expander ex = TaskCreate(head + "\n" + date, cont);
                        ex.Background = new SolidColorBrush(Colors.Orange);
                        StackPanel_Doing.Children.Add(ex);
                    }
                    sr.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
            catch
            {

            }
        }
        private void DoneFile_Read()
        {
            try
            {
                FileStream fs = new FileStream("C:\\Users\\Pawel\\Done.txt",
                FileMode.Open, FileAccess.Read);

                try
                {
                    StreamReader sr = new StreamReader(fs);
                    while (!sr.EndOfStream)
                    {
                        string head = sr.ReadLine();
                        string date = sr.ReadLine();
                        string cont = sr.ReadLine();
                        Expander ex = TaskCreate(head + "\n" + date, cont);
                        ex.Background = new SolidColorBrush(Colors.Green);
                        StackPanel_Done.Children.Add(ex);
                    }
                    sr.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
            catch
            {

            }
        }

        private Expander TaskCreate(string head, string cont)
        {
            Expander NewTask = new Expander();
            TextBlock NewDescription = new TextBlock();
            NewDescription.Text = cont;
            NewDescription.TextWrapping = System.Windows.TextWrapping.Wrap;
            NewDescription.FontSize = 11;
            NewDescription.FontWeight = FontWeights.Normal;
            NewDescription.Foreground = new SolidColorBrush(Colors.White);
            NewTask.Header = head;
            NewTask.FontSize = 12;
            NewTask.FontWeight = FontWeights.Bold;
            NewTask.Content = NewDescription;
            NewTask.Background = new SolidColorBrush(Colors.Crimson);
            NewTask.Foreground = new SolidColorBrush(Colors.Yellow);
            NewTask.Margin = new Thickness(5);
            NewTask.MouseRightButtonUp += NewTask_MouseRightButtonUp;
            return NewTask;
        }

        private void Button_Add_Click(object sender, RoutedEventArgs e)
        {
            Add_Task_Window okno = new Add_Task_Window();
            if (okno.ShowDialog() == true)
            {
                StackPanel_To_Do.Children.Add(TaskCreate(okno.NewTitle + "\n" + okno.NewDate.ToShortDateString(), okno.NewDescription));
            }
        }

        void NewTask_MouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {
            Task_Menu_Window menu = new Task_Menu_Window();
            Point p = Mouse.GetPosition(this);
            menu.Left = p.X;
            menu.Top = p.Y;
            if (menu.ShowDialog() == true)
            {
                switch (menu.Choice)
                {
                    case "Push":
                        bool ifFound = false;
                        foreach (Expander ex in StackPanel_To_Do.Children)
                        {
                            if (ex == (sender as Expander))
                            {
                                StackPanel_To_Do.Children.Remove(sender as Expander);
                                StackPanel_Doing.Children.Add(sender as Expander);
                                (sender as Expander).Background = new SolidColorBrush(Colors.Orange);
                                ifFound = true;
                            }
                            if (ifFound)
                            {
                                Data_Save();
                                break;
                            }
                        }
                        if (ifFound == false)
                        {
                            foreach (Expander ex in StackPanel_Doing.Children)
                            {
                                if (ex == (sender as Expander))
                                {
                                    StackPanel_Doing.Children.Remove(sender as Expander);
                                    StackPanel_Done.Children.Add(sender as Expander);
                                    (sender as Expander).Background = new SolidColorBrush(Colors.Green);
                                    ifFound = true;
                                }
                                if (ifFound)
                                {
                                    Data_Save();
                                    break;
                                }
                            }
                        }
                        break;

                    case "Edit":
                        Expander exp = (sender as Expander);
                        Edit_Task_Window okno = new Edit_Task_Window();//((exp.Header as string).Substring(0, (exp.Header as string).Length-10),     exp.Content.ToString(),    (exp.Header as string).Substring((exp.Header as string).Length-10, (exp.Header as string).Length-1));
                        if (okno.ShowDialog() == true)
                        {
                            exp.Header = okno.NewTitle + "\n" + okno.NewDate.ToShortDateString();
                            exp.Content = okno.NewDescription;
                        }
                        Data_Save();
                        break;

                    case "Delete":
                        foreach (Expander ex in StackPanel_To_Do.Children)
                        {
                            if (ex == (sender as Expander))
                            {
                                StackPanel_To_Do.Children.Remove(sender as Expander);
                                Data_Save();
                                MessageBox.Show(sender.GetType().ToString());
                                break;
                            }
                        }
                        foreach (Expander ex in StackPanel_Doing.Children)
                        {
                            if (ex == (sender as Expander))
                            {
                                StackPanel_Doing.Children.Remove(sender as Expander);
                                Data_Save();
                                break;
                            }
                        }
                        foreach (Expander ex in StackPanel_Done.Children)
                        {
                            if (ex == (sender as Expander))
                            {
                                StackPanel_Done.Children.Remove(sender as Expander);
                                Data_Save();
                                break;
                            }
                        }
                        break;
                    default:
                        break;
                }
            }
        }

        private void Data_Save()
        {
            ToDoFile_Write();
            DoingFile_Write();
            DoneFile_Write();
        }
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Data_Save();
        }

        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            ScrollViever_ToDo.Height = e.NewSize.Height-100;
            ScrollViever_Doing.Height = e.NewSize.Height-100;
            ScrollViever_Done.Height = e.NewSize.Height-100;
        }
    }
}
