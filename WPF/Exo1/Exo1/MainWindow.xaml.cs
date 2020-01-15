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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Exo1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
       

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Wrap windowWrap = new Wrap();
            windowWrap.ShowDialog();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            DockPanelWin dock = new DockPanelWin();
            dock.ShowDialog();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Spliter spliter = new Spliter();
            spliter.ShowDialog();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            explander explander = new explander();
            explander.ShowDialog();
        }
    }
}
