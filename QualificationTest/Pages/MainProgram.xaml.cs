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

namespace QualificationTest
{
    /// <summary>
    /// Логика взаимодействия для MainProgram.xaml
    /// </summary>
    public partial class MainProgram : Page
    {
        ApplicationContext db;
        public MainProgram()
        {
            InitializeComponent();
            db = new ApplicationContext();
            LoadQuestion();
        }

        private void SubmitAnswer_Click(object sender, RoutedEventArgs e)
        {
        }
        public void LoadQuestion()
        {
            
        }
    }
}
