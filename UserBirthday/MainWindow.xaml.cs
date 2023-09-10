using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
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

namespace UserBirthday
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Count(object sender, RoutedEventArgs e)
        {
            DateTime date = DP.DisplayDate;
            DateTime today = DateTime.Now;
            TimeSpan difference = today - date;
            Years.Text = Convert.ToString((int)(difference.Days / 365.25));
            Months.Text = Convert.ToString((int)((difference.Days % 365.25) / 30.44));
            Days.Text = Convert.ToString(difference.Days % 30);
        }

        private void RadioButtonTime_Click(object sender, RoutedEventArgs e)
        {
            Time.Visibility = Visibility.Visible;
            Time_Button.Visibility = Visibility.Visible;
            DaysOfWeek.Visibility = Visibility.Collapsed;
            Week_Button.Visibility = Visibility.Collapsed;
            VisokosYears.Visibility = Visibility.Collapsed;
            Visokos_Button.Visibility = Visibility.Collapsed;
        }

        private void DayOfWeekRepeat(object sender, RoutedEventArgs e)
        {
            DateTime date = DP.DisplayDate;
            DateTime today = DateTime.Now;
            DateTime dayofweek;
            int Birthdays = 0;
            for (int year = date.Year; year <= today.Year; year++)
            {
                for (int month = 1; month <= 12; month++)
                {
                    dayofweek = new DateTime(year, month, date.Day);
                    if (date.DayOfWeek == dayofweek.DayOfWeek && date.Month == dayofweek.Month)
                    {
                        Birthdays++;
                    }
                }
            }
            DayOfWeek.Text = Convert.ToString(date.DayOfWeek);
            CountDayOfWeek.Text = Convert.ToString(Birthdays);
        }

        private void RadioButtonDayOfWeek_Click(object sender, RoutedEventArgs e)
        {
            DaysOfWeek.Visibility = Visibility.Visible;
            Week_Button.Visibility = Visibility.Visible;
            Time.Visibility = Visibility.Collapsed;
            Time_Button.Visibility = Visibility.Collapsed;
            VisokosYears.Visibility = Visibility.Collapsed;
            Visokos_Button.Visibility = Visibility.Collapsed;

        }
        private void VisokosYearRepeat(object sender, RoutedEventArgs e)
        {
            DateTime date = DP.DisplayDate;
            DateTime today = DateTime.Now;
            int LeapYear = 0;
            for (int year = date.Year; year <= today.Year; year++)
            {
                if (DateTime.IsLeapYear(year))
                {
                    LeapYear++;
                }
            }
            VisokosYear.Text = Convert.ToString(LeapYear);
            }
        private void RadioButtonVisokosYear_Click(object sender, RoutedEventArgs e)
        {
            VisokosYears.Visibility = Visibility.Visible;
            Visokos_Button.Visibility = Visibility.Visible;
            DaysOfWeek.Visibility = Visibility.Collapsed;
            Week_Button.Visibility = Visibility.Collapsed;
            Time.Visibility = Visibility.Collapsed;
            Time_Button.Visibility = Visibility.Collapsed;

        }

        private void ConkretVisokosYear(object sender, RoutedEventArgs e)
        {
            DateTime date = DP.DisplayDate;
            DateTime today = DateTime.Now;
            int LeapYear = 0;
            for (int year = date.Year; year <= today.Year; year++)
            {
                if (DateTime.IsLeapYear(year))
                {
                    MessageBox.Show("Високосный год " + year);
                }
            }
        }
    }
}
