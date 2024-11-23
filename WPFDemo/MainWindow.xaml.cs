using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
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
using WPFDemo.Data;

namespace WPFDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Person> people = new List<Person>
        {
            new Person{Name = "Peter", Age = 30},
            new Person{Name = "Maria", Age = 20},
            new Person{Name = "Jack", Age = 35},
            new Person{Name = "Marc", Age = 40},
            new Person{Name = "Scott", Age = 27},
        };
        public MainWindow()
        {
            InitializeComponent();

            ListBoxPeople.ItemsSource = people;
        }

        private void ShowSelectedButton_Click(object sender, RoutedEventArgs e)
        {
            var selectedPersons = ListBoxPeople.SelectedItems;
            foreach (var item in selectedPersons)
            {
                Person person = (Person)item;
                MessageBox.Show($"Name: {person.Name}, Age: {person.Age}");
            }
        }
    }

}
