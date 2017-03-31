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

namespace CalendarPlug
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Calendar_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            string[] splitedDate = new string[1];
            splitedDate = calPlug.SelectedDate.ToString().Split(new char[] { '-', ' '});

            Events es = new Events(int.Parse(splitedDate[0]), calPlug.DisplayDate.Month, calPlug.DisplayDate.Year);
            es.Show();
        }
    }
}
