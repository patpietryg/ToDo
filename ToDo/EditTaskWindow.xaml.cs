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

namespace ToDo
{
    public partial class EditTaskWindow : Window
    {
        public EditTaskWindow()
        {
            InitializeComponent();
        }
        private void Save_Button_Click(object sender, RoutedEventArgs e)
        {
            if (NameBox.Text == "" || DatePicker.Text == "")
            {
                MessageBox.Show(
                    "You have to fill all fields marked with stars",
                    "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                Task newTask = new Task(NameBox.Text, DescriptionBox.Text, DatePicker.SelectedDate.Value, CheckBox.IsChecked.Value);
                Tasks.ListOfTasks.Add(newTask);
                this.DialogResult = true;
                Close();
            }
        }
        private void Cancel_Button_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            Close();
        }
    }
}
