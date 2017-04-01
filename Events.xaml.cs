using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Win32;
using System.Media;
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
using WMPLib;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace CalendarPlug
{
    /// <summary>
    /// Logika interakcji dla klasy Events.xaml
    /// </summary>
    public partial class Events : Window
    {
        int minutes = 60;
        int hours = 24;

        public Events(int day, int month, int year)
        {
            InitializeComponent();
            this.year.Content += year.ToString();
            this.month.Content += month.ToString();
            this.day.Content += day.ToString();
            for(int i = 0; i < minutes; i++)
                minute.Items.Add(new ComboBoxItem().Content = i);
            for (int i = 0; i < hours; i++)
                hour.Items.Add(new ComboBoxItem().Content = i);
            minute.SelectedIndex = 0;
            hour.SelectedIndex = 0;
        }

        private void addEventB_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
