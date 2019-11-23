﻿using System;
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

namespace WPF_lab1_Navigation_Application
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            System.IO.StreamWriter sw = new System.IO.StreamWriter("C:\\username.txt");
            sw.WriteLine(textBox1.Text);
            sw.Close();
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            System.IO.StreamReader sr = new System.IO.StreamReader("C:\\username.txt");
            label1.Content = "Hello " + sr.ReadToEnd();
            sr.Close();
        }
    }
}
