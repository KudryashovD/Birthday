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
            DateTime date = (DateTime)DP.SelectedDate;
            DateTime today = DateTime.Now;
            bool flag = true;
            while (flag)
            {
            if (date > today)
            {
                    MessageBox.Show("Дата рождения не может быть больше сегодняшней даты, повторите ввод");
                    flag = false;
            }
                else
                { 
            TimeSpan difference = today - date;
            Years.Text = Convert.ToString((int)(difference.Days / 365.25));
            Months.Text = Convert.ToString(Math.Round((int)((difference.Days % 365.25) / 30.44) - 0.6));
            Days.Text = Convert.ToString(difference.Days % 30);
                    flag = false;
                }
        }
    }

        private void RadioButtonTime_Click(object sender, RoutedEventArgs e)
        {
            Time.Visibility = Visibility.Visible;
            Time_Button.Visibility = Visibility.Visible;
            DaysOfWeek.Visibility = Visibility.Collapsed;
            Week_Button.Visibility = Visibility.Collapsed;
            VisokosYears.Visibility = Visibility.Collapsed;
            Visokos_Button.Visibility = Visibility.Collapsed;
            Goroscope.Visibility = Visibility.Collapsed;
        }

        private void DayOfWeekRepeat(object sender, RoutedEventArgs e)
        {
            DateTime date = (DateTime)DP.SelectedDate;
            DateTime today = DateTime.Now;
            bool flag = true;
            while (flag)
            {
                if (date > today)
                {
                    MessageBox.Show("Дата рождения не может быть больше сегодняшней даты, повторите ввод");
                    flag = false;
                }
                else
                {
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
                    flag = false;
                }
            }
        }

        private void RadioButtonDayOfWeek_Click(object sender, RoutedEventArgs e)
        {
            DaysOfWeek.Visibility = Visibility.Visible;
            Week_Button.Visibility = Visibility.Visible;
            Time.Visibility = Visibility.Collapsed;
            Time_Button.Visibility = Visibility.Collapsed;
            VisokosYears.Visibility = Visibility.Collapsed;
            Visokos_Button.Visibility = Visibility.Collapsed;
            Goroscope.Visibility = Visibility.Collapsed;

        }
        private void VisokosYearRepeat(object sender, RoutedEventArgs e)
        {
            DateTime date = (DateTime)DP.SelectedDate;
            DateTime today = DateTime.Now;
            bool flag = true;
            while (flag)
            {
                if (date > today)
                {
                    MessageBox.Show("Дата рождения не может быть больше сегодняшней даты, повторите ввод");
                    flag = false;
                }
                else
                {
                    int LeapYear = 0;
                    for (int year = date.Year; year <= today.Year; year++)
                    {
                        if (DateTime.IsLeapYear(year))
                        {
                            LeapYear++;
                        }
                    }
                    VisokosYear.Text = Convert.ToString(LeapYear);
                    flag = false;
                }
            }
            }
        private void RadioButtonVisokosYear_Click(object sender, RoutedEventArgs e)
        {
            VisokosYears.Visibility = Visibility.Visible;
            Visokos_Button.Visibility = Visibility.Visible;
            DaysOfWeek.Visibility = Visibility.Collapsed;
            Week_Button.Visibility = Visibility.Collapsed;
            Time.Visibility = Visibility.Collapsed;
            Time_Button.Visibility = Visibility.Collapsed;
            Goroscope.Visibility = Visibility.Collapsed;

        }

        private void ConkretVisokosYear(object sender, RoutedEventArgs e)
        {
            DateTime date = (DateTime)DP.SelectedDate;
            DateTime today = DateTime.Now;
            bool flag = true;
            while (flag)
            {
                if (date > today)
                {
                    MessageBox.Show("Дата рождения не может быть больше сегодняшней даты, повторите ввод");
                    flag = false;
                }
                else
                {
                    for (int year = date.Year; year <= today.Year; year++)
                    {
                        if (DateTime.IsLeapYear(year))
                        {
                            MessageBox.Show("Високосный год " + year);
                        }
                    }
                    flag = false;
                }
            }
        }

        private void RadioButtonGoroscope(object sender, RoutedEventArgs e)
        {
            Goroscope.Visibility = Visibility.Visible;
            VisokosYears.Visibility = Visibility.Collapsed;
            Visokos_Button.Visibility = Visibility.Collapsed;
            DaysOfWeek.Visibility = Visibility.Collapsed;
            Week_Button.Visibility = Visibility.Collapsed;
            Time.Visibility = Visibility.Collapsed;
            Time_Button.Visibility = Visibility.Collapsed;
        }

        private void ComboBoxGRSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
            
                    if (CBGoroscope.SelectedIndex == 1)
                    {
                        SlavianGR.Visibility = Visibility.Visible;
                        EastGR.Visibility = Visibility.Collapsed;
                DateTime date = (DateTime)DP.SelectedDate;
                    DateTime today = DateTime.Now;
                    bool flag = true;
                    while (flag)
                    {
                        if (date > today)
                        {
                            MessageBox.Show("Дата рождения не может быть больше сегодняшней даты, повторите ввод");
                            flag = false;
                        }
                        else
                        {
                            if(date.Day>=24 && date.Month==12 || date.Day<=30 && date.Month == 1)
                            {
                                Slavian.Text = "Мороз";
                            }
                            else if(date.Day>=31 && date.Month==1 || date.Day<=28 && date.Month == 2)
                            {
                                Slavian.Text = "Велес";
                            }
                            else if(date.Month == 3)
                            {
                                Slavian.Text = "Макошь";
                            }
                            else if (date.Month == 4)
                            {
                                Slavian.Text = "Жива";
                            }
                            else if (date.Day >= 1  && date.Month == 5 || date.Day <= 14 && date.Month == 5)
                            {
                                Slavian.Text = "Ярила";
                            }
                            else if (date.Day>=15 && date.Month == 5 || date.Day<=2 && date.Month == 6)
                            {
                                Slavian.Text = "Леля";
                            }
                            else if (date.Day>=2 && date.Month == 6 || date.Day<=12 && date.Month == 6)
                            {
                                Slavian.Text = "Кострома";
                            }
                            else if (date.Day>=13 && date.Day!=24 && date.Month==6 || date.Day<=6 && date.Month == 7)
                            {
                                Slavian.Text = "Додола";
                            }
                            else if (date.Day==24 && date.Month == 6)
                            {
                                Slavian.Text = "Иван Купала";
                            }
                            else if (date.Day>=6 && date.Month==7 || date.Day<=31 && date.Month == 7)
                            {
                                Slavian.Text = "Лада";
                            }
                            else if (date.Day>=1 && date.Month==8 || date.Day<=28 && date.Month == 8)
                            {
                                Slavian.Text = "Перун";
                            }
                            else if (date.Day>=29 && date.Month==8 || date.Day<=13 && date.Month == 9)
                            {
                                Slavian.Text = "Сева";
                            }
                            else if (date.Day>=14 && date.Month==9 || date.Day<=27 && date.Month == 9)
                            {
                                Slavian.Text = "Рожаница";
                            }
                            else if (date.Day>=28 && date.Month==9 || date.Day<=15 && date.Month == 10)
                            {
                                Slavian.Text = "Сварожичи";
                            }
                            else if (date.Day>=16 && date.Month==10 || date.Day<=8 && date.Month == 11)
                            {
                                Slavian.Text = "Морена";
                            }
                            else if(date.Day>=9 && date.Month==11 || date.Day<=28 && date.Month == 11)
                            {
                                Slavian.Text = "Зима";
                            }
                            else if (date.Day>=29 && date.Month==11 || date.Day<=23 && date.Month == 12)
                            {
                                Slavian.Text = "Карачун";
                            }
                            flag= false;
                        }
                    }
                        }
                    else if (CBGoroscope.SelectedIndex == 2)
                    {
                        EastGR.Visibility = Visibility.Visible;
                        SlavianGR.Visibility = Visibility.Collapsed;
                DateTime date = (DateTime)DP.SelectedDate;
                    DateTime today = DateTime.Now;
                    bool flag = true;
                    while (flag)
                    {
                        if (date > today)
                        {
                            MessageBox.Show("Дата рождения не может быть больше сегодняшней даты, повторите ввод");
                            flag = false;
                        }
                        else
                        {
                            int year = date.Year;
                            string[] Animals = new string[]{ "ОБЕЗЬЯНА", "ПЕТУХ", "СОБАКА", "СВИНЬЯ", "КРЫСА", "БЫК", "ТИГР", "КРОЛИК", "ДРАКОН", "ЗМЕЯ", "ЛОШАДЬ", "ОВЦА" };
                            string animal = Animals[year % 12];
                            East.Text = animal;
                            flag = false;
                        }
                    }
                        }

            }
            catch
            {
                MessageBox.Show("Введите дату");
            }
        }
    }
}
