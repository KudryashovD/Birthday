# День рождения

Наше приложение было создано для того, чтобы пользователь мог узнать интересующую его информацию о дате своего рождения!👀

**Наше приложение:**

![Начальный экран](blob:https://web.telegram.org/05c988aa-2bd9-41a4-8d65-1bd1ac175351)

## Описание нашего проекта
**В нашем `приложении` вы сможете:**
*<br/>:white_check_mark: Узнать кто вы по `восточному` и `славянскому` календарям;
<br/>:white_check_mark: Узнать сколько раз вы праздновали ваш день рождения именно в тот `день недели`, в который вы родились;
<br/>:white_check_mark: Узнать сколько `лет, месяцев и дней` прошло с момента вашего рождения;
<br/>:white_check_mark: Узнать в какой `день недели` вы родились;
<br/>:white_check_mark: Узнать сколько `високосных годов` прошло с момента вашего рождения и что это были за года.*
## Демо проекта

#### Если вы хотите узнать сколько времени прошло с момента вашего рождения вам нужно выполнить следующие шаги:
1. Ввести `дату вашего рождения`:
![Ввод даты рождения](image-1.png)
2. Выбрать пункт `"Сколько времени прошло"`:
![Выбор пункта](image-2.png)
3. Нажать на кнопку `"Рассчитать"`:
![Нажатие на кнопку "Рассчитать"](image-3.png)

#### Если вы хотите узнать в какой день недели вы родились и сколько раз вы праздновали ваш день рождения в этот день вам нужно выполнить следующие шаги:
1. Ввести `дату вашего рождения`:
![Ввод даты рождения](image-1.png)
2. Выбрать пункт `"День недели"`:
![Выбор пункта](image-4.png)
3. Нажать на кнопку `"Рассчитать"`
![Нажатие на кнопку "Рассчитать"](image-5.png)

#### Если вы хотите узнать сколько високосных годов прошло с момента вашего рождения и что это были за года вам нужно выполнить следующие шаги:
1. Ввести `дату вашего рождения`:
![Ввод даты рождения](image-1.png)
2. Выбрать пункт `"Високосные года"`:
![Выбор пункта](image-6.png)
3. Нажать на кнопку `"Рассчитать"`, если хотите узнать количество високосных годов:
![Нажатие на кнопку "Рассчитать"](image-7.png)
4. Нажать на кнопку `"Какие года были високосными"`, если хотите узнать какие именно года были високосными:
![Нажатие на кнопку "Какие года были високосными"](image-8.png)

#### Если вы хотите узнать кто вы по восточному гороскопу вам нужно выполнить следующие шаги:
1. Ввести `дату вашего рождения`:
![Ввод даты рождения](image-1.png)
2. Выбрать пункт `"Гороскоп"` и выбрать в выпадающем списке `"Восточный гороскоп"`:
![Выбор гороскопа](image-9.png)
![Результат гороскопа](image-10.png)

#### Если вы хотите узнать кто вы по славянскому гороскопу вам нужно выполнить следующие шаги:
1. Ввести `дату вашего рождения`:
![Ввод даты рождения](image-1.png)
2. Выбрать пункт `"Гороскоп"` и выбрать в выпадающем списке `"Славянский гороскоп"`:
![Выбор гороскопа](image-11.png)
![Результат гороскопа](image-12.png)
## Технологии, использованные в проекте

+ В нашем проекте была использована среда разработки `Visual Studio`.
![Среда разработки](image-13.png)
+ В качестве основного языка программирования был использован `C#`.
## Код проекта

### Разметка

```
    <Window x:Class="UserBirthday.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
        xmlns:local="clr-namespace:UserBirthday"
        mc:Ignorable="d"
        Title="Данные дня рождения" Height="450" Width="800">
    <Grid>
        <Grid.RowDefinitions>
            <RowDefinition Height="40"></RowDefinition>
            <RowDefinition Height="80"></RowDefinition>
            <RowDefinition></RowDefinition>
            <RowDefinition Height="40"></RowDefinition>
        </Grid.RowDefinitions>
        <StackPanel>
            <TextBlock Style="{StaticResource TextBoxStyle}">Введите дату своего рождения и выберите желаемое действие</TextBlock>
        </StackPanel>
        <StackPanel Grid.Row="1">
            <DatePicker Name="DP" Style="{StaticResource DatePickStyle}"></DatePicker>
            <WrapPanel>
            <RadioButton Style="{StaticResource RadioButtonStyle}" Click="RadioButtonTime_Click">Сколько времени прошло</RadioButton>
                <RadioButton Style="{StaticResource RadioButtonStyle}" Click="RadioButtonDayOfWeek_Click">День недели</RadioButton>
                <RadioButton Style="{StaticResource RadioButtonStyle}" Click="RadioButtonVisokosYear_Click">Високосные года</RadioButton>
                <RadioButton Style="{StaticResource RadioButtonStyle}" Click="RadioButtonGoroscope">Гороскоп</RadioButton>
            </WrapPanel>
        </StackPanel>
        <StackPanel Grid.Row="2" Visibility="Collapsed" Name="Time">
            <TextBlock Style="{StaticResource TextBoxStyle}">С момента вашего рождения прошло</TextBlock>
            <TextBlock Style="{StaticResource DataStyle}">Лет</TextBlock>
            <TextBlock Name="Years" Style="{StaticResource DataStyle}"></TextBlock>
            <TextBlock Style="{StaticResource DataStyle}">Месяцев</TextBlock>
            <TextBlock Name="Months" Style="{StaticResource DataStyle}"></TextBlock>
            <TextBlock Style="{StaticResource DataStyle}">Дней</TextBlock>
            <TextBlock Name="Days" Style="{StaticResource DataStyle}"></TextBlock>
        </StackPanel>
        <StackPanel Grid.Row="3" Visibility="Collapsed" Name="Time_Button">
            <Button Style="{StaticResource ButtonStyle}" Click="Count">Рассчитать</Button>
        </StackPanel>
        <StackPanel Grid.Row="2" Name="DaysOfWeek" Visibility="Collapsed">
            <TextBlock Style="{StaticResource TextBoxStyle}">Дни недели</TextBlock>
            <TextBlock Style="{StaticResource DataStyle}">День недели</TextBlock>
            <TextBlock Name="DayOfWeek" Style="{StaticResource DataStyle}"></TextBlock>
            <TextBlock Style="{StaticResource DataStyle}">Количество повторений</TextBlock>
            <TextBlock Name="CountDayOfWeek" Style="{StaticResource DataStyle}"></TextBlock>
        </StackPanel>
        <StackPanel Grid.Row="3" Name="Week_Button" Visibility="Collapsed">
            <Button Style="{StaticResource ButtonStyle}" Click="DayOfWeekRepeat">Рассчитать</Button>
        </StackPanel>
        <StackPanel Grid.Row="2" Name="VisokosYears" Visibility="Collapsed">
            <TextBlock Style="{StaticResource TextBoxStyle}">Високосные года</TextBlock>
            <TextBlock Style="{StaticResource DataStyle}">Количество високосных годов</TextBlock>
            <TextBlock Name="VisokosYear" Style="{StaticResource DataStyle}"></TextBlock>
        </StackPanel>
        <WrapPanel Grid.Row="3" Name="Visokos_Button" Visibility="Collapsed">
            <Button Style="{StaticResource VisokosButtonStyle}" Click="ConkretVisokosYear">Какие года были високосными?</Button>
            <Button Style="{StaticResource VisokosButtonStyle}" Click="VisokosYearRepeat">Рассчитать</Button>
        </WrapPanel>
        <StackPanel Grid.Row="2" Name="Goroscope" Visibility="Collapsed">
            <ComboBox FontSize="20" SelectionChanged="ComboBoxGRSelectionChanged" Name="CBGoroscope">
                <ComboBoxItem IsSelected="True" IsEnabled="False">Выберите нужный гороскоп</ComboBoxItem>
                <ComboBoxItem>Славянский гороскоп</ComboBoxItem>
                <ComboBoxItem>Восточный гороскоп</ComboBoxItem>
            </ComboBox>
        <StackPanel Grid.Row="2" Name="SlavianGR" Visibility="Collapsed">
            <TextBlock Style="{StaticResource TextBoxStyle}">Славянский гороскоп</TextBlock>
            <TextBlock Name="Slavian" Style="{StaticResource DataStyle}"></TextBlock>
        </StackPanel>
            <StackPanel Grid.Row="2" Name="EastGR" Visibility="Collapsed">
                <TextBlock Style="{StaticResource TextBoxStyle}">Восточный гороскоп</TextBlock>
                <TextBlock Name="East" Style="{StaticResource DataStyle}"></TextBlock>
            </StackPanel>
        </StackPanel>
    </Grid>
    </Window>

```

## Функционал

+ Рассчёт прошедшего времени с момента рождения
```
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
```

+ Рассчёт в какой день недели родился пользователь и сколько раз он праздновал день рождения в данный день недели
```
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
```

+ Рассчёт сколько високосных годов прошло с момента рождения пользователя и что это были за года
```
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
```

+ Рассчёт гороскопов пользователя

```
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
```

## Установка приложения

1. Вам необходимо установить Visual Studio (не переживайте, данное приложение вам пригодится для запуска других наших проектов 👋).
2. Перейти на страницу с нашим приложением и скопировать ссылку на наше хранилище:
[День рождения](https://github.com/KudryashovD/Birthday)
3. Пользоваться приложением и наслаждаться.

## Авторы
* **Дмитрий Кудряшов** - *Base programmer* - [KudryashovD](https://github.com/KudryashovD)
