namespace task6;
/*
 Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
 Створіть структуру, яка описує точку у тривимірній системі координат. 
 Організуйте можливість складання двох точок через використання навантаження оператора +.
 */
class Program
{
    static void Main(string[] args)
    {
        Point point1 = new Point(10, 20, 30);
        Point point2 = new Point(23, 50, 90);
        Console.WriteLine(point1+point2+point2);
    }
}