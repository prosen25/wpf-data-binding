﻿using System;
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
        Person person = new Person
        {
            Name = "Jack",
            Age = 30
        };
        public MainWindow()
        {
            InitializeComponent();

            this.DataContext = person;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            MessageBox.Show($"{person.Name} is {person.Age} years old");
        }
    }

}
