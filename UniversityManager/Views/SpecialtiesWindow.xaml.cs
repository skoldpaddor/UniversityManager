﻿using Models;
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

namespace UniversityManager.Views
{
    /// <summary>
    /// Interaction logic for SpecialtiesWindow.xaml
    /// </summary>
    public partial class SpecialtiesWindow : Window
    {
        public SpecialtiesWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var context = new UniversityEntities();

            listSpecialties.ItemsSource = context.Specialties.ToList();
        }
    }
}
