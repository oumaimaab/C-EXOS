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

namespace WPFPREPAEXO2TP
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        FilOps f = new FilOps();
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = f.Filiere;

        }

        private void ajouter_Click(object sender, RoutedEventArgs e)
        {

        }
        

    }
}
