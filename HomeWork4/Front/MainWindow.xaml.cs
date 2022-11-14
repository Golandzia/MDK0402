using HomeWork4.Core;
using HomeWork4.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace HomeWork4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            FileReader fileReader = new FileReader();
            fileReader.Teacher();
            LessonComboBox.ItemsSource = fileReader.Teacher();
            TeacherComboBox.DisplayMemberPath = "TeacherName";
            fileReader.Lesson();
            LessonComboBox.ItemsSource = fileReader.Lesson();
            LessonComboBox.DisplayMemberPath = "Name";
            times = new ObservableCollection<Time>();
        }

        Time time;
        public ObservableCollection<Time> times;
        private void createButton_Click(object sender, RoutedEventArgs e)
        {
            if (TeacherComboBox.Text == null || LessonComboBox.Text == null)
            {
                MessageBox.Show("Выберите учителя и предмет!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                time = new Time(TeacherComboBox.Text, LessonComboBox.Text);
                times.Add(time);
                Output.ItemsSource = times;
                Output.DisplayMemberPath = "TimeShow";
            }
        }
    }
}
