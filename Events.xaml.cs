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

namespace CalendarPlug
{
    /// <summary>
    /// Logika interakcji dla klasy Events.xaml
    /// </summary>
    public partial class Events : Window
    {
        public Events(int day, int month, int year)
        {
            InitializeComponent();
            this.year.Content += year.ToString();
            this.month.Content += month.ToString();
            this.day.Content += day.ToString();
        }
    }
}
