using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace TP
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DateTime alarme; 
        DispatcherTimer _timer;
        TimeSpan _time;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Load(object sender, RoutedEventArgs e)
        {
            
           
            string str_Date = "11:6:00";
            alarme = Convert.ToDateTime(str_Date);
            DateTime now = DateTime.Now;
            hs.Content = now.ToString("HH:mm:ss");
            ha.Content = alarme.ToString("HH:mm:ss");

            _time = TimeSpan.FromSeconds((alarme - now).TotalSeconds);

            _timer = new DispatcherTimer(new TimeSpan(0, 0, 1), DispatcherPriority.Normal, delegate
            {
                timerLabel.Content = _time.ToString("c");
                if (_time <= TimeSpan.Zero)
                {
                    timerLabel.Content = "";
                    _timer.Stop();
                }
                 _time = _time.Add(TimeSpan.FromSeconds(-1));
            }, Application.Current.Dispatcher);

            _timer.Start();

        }

   

        private void bt_click(object sender, RoutedEventArgs e)
        {
            ex_label.Content = "Hello World";
        }

    }
}
