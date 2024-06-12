namespace task4;
/*
 Створіть клас, який містить інформацію про дату (день, місяць, рік).
 За допомогою механізму перевантаження операторів визначте операцію
 різниці двох дат (результат у вигляді кількості днів між датами),
 а також операцію збільшення дати на певне кількість днів.
*/
public class DateOpera
{
 
 private int _day,_month,_year;

 public DateOpera(int dey,int month,int year)
 {
   _day = dey;
   _month = month;
   _year = year;
 }

 public static int operator -(DateOpera data1, DateOpera data2)
 {
     DateTime dateTime1 = new DateTime(data1._year, data1._month, data1._day);
     DateTime dateTime2 = new DateTime(data2._year, data2._month, data2._day);
     TimeSpan timeSpan = dateTime2 - dateTime1;
     return (int)timeSpan.TotalDays;
 }

 public static DateOpera operator +(DateOpera date, int days)
 {
     DateTime dateTime = new DateTime(date._year, date._month, date._day);
     dateTime = dateTime.AddDays(days);
     return new DateOpera(dateTime.Day, dateTime.Month, dateTime.Year);
 }

 public override string ToString()
 {
     return $"{_day}/{_month}/{_year}";
 }
}