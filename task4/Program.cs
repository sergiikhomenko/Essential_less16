namespace task4;
/*
 Створіть клас, який містить інформацію про дату (день, місяць, рік).
 За допомогою механізму перевантаження операторів визначте операцію 
 різниці двох дат (результат у вигляді кількості днів між датами), 
 а також операцію збільшення дати на певне кількість днів. 
*/
class Program
{
    static void Main(string[] args)
    {
        DateOpera dateOpera1 = new DateOpera(25, 12, 1991);
        DateOpera dateOpera2 = new DateOpera(25, 12, 2024);
        Console.WriteLine($"Днів {dateOpera1-dateOpera2}");
        dateOpera1 = dateOpera1 + 40;
        Console.WriteLine(dateOpera1);
    }
}