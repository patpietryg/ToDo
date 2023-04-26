using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
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

namespace ToDo
{
    public partial class MainWindow : Window
    {
        static string workingDirectory = Environment.CurrentDirectory;
        static string path = Directory.GetParent(workingDirectory).Parent.Parent.FullName + "\\tasks.txt";
        public MainWindow()
        {
            Tasks.Read(path);
            InitializeComponent();
            lvTasks.ItemsSource = Tasks.ListOfTasks;
        }

        private void Add_Button_Click(object sender, RoutedEventArgs e)
        {
            AddTaskWindow window = new AddTaskWindow();
            window.ShowDialog();
            lvTasks.Items.Refresh();
        }
        private void Delete_Button_Click(object sender, RoutedEventArgs e)
        {
            if (lvTasks.SelectedItems.Count != 0)
            {
                var confirmation = MessageBox.Show(
                    "Are you sure you want to delete selected tasks??",
                    "Warning", MessageBoxButton.YesNo, MessageBoxImage.Question);

                if (confirmation == MessageBoxResult.Yes)
                {
                    foreach (Task itemSelected in lvTasks.SelectedItems)
                    {
                        Tasks.ListOfTasks.Remove(itemSelected);
                    }
                    lvTasks.Items.Refresh();
                }
            }
            else
            {
                MessageBox.Show("No item is selected!", "Error",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void Edit_Button_Click(object sender, RoutedEventArgs e)
        {
            if(lvTasks.SelectedItems.Count == 1)
            {
                foreach (Task task in lvTasks.SelectedItems)
                {
                    EditTaskWindow window = new EditTaskWindow();
                    window.DataContext = this;
                    foreach (Window item in Application.Current.Windows)
                    {
                        if (item.Title == "EditTaskWindow")
                        {
                            ((EditTaskWindow)item).NameBox.Text = task.Name;
                            ((EditTaskWindow)item).DescriptionBox.Text = task.Description;
                            ((EditTaskWindow)item).DatePicker.SelectedDate = DateTime.Parse(Convert.ToString(task.Deadline));
                            ((EditTaskWindow)item).CheckBox.IsChecked = task.IsDone;
                        }
                    }
                    if(window.ShowDialog()==true)
                    {
                        Tasks.ListOfTasks.Remove(task);
                    }
                }
            }
            else
            {
                MessageBox.Show("No item is selected!", "Error",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
            lvTasks.Items.Refresh();
        }
        private void Save_Button_Click(object sender, RoutedEventArgs e)
        {
            if(Tasks.Write(path))
            {
                MessageBox.Show("Your changes have been successfully saved!", "Information",
                   MessageBoxButton.OK, MessageBoxImage.None);
            }
            else
            {
                MessageBox.Show("Your changes have NOT been successfully saved!", "Warning",
                   MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        void PrintDescription(object sender, SelectionChangedEventArgs args)
        {
            if(lvTasks.SelectedItems.Count == 1)
            {
                foreach(Task task in lvTasks.SelectedItems)
                {
                    Description.Text = task.Description;
                }
            }
        }
    }
}
