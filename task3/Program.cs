namespace task3;
/*
 * Створіть клас House з двома полями та властивостями.
 * Створіть два методи Clone() та DeepClone(), які виконують поверхневе та глибоке
 * копіювання відповідно. Реалізуйте найпростіший спосіб перевірки.
 */
class Program
{
    static void Main(string[] args)
    {
        House originalHouse = new House(new Street("Street"), 1);
        House shallowCopy = (House)originalHouse.Clone();
        House deepCopy = originalHouse.DeepClone();
        
        Console.WriteLine("Оригінал House: " + originalHouse.ToString());
        Console.WriteLine("Поверхневе  : " + shallowCopy.ToString());
        Console.WriteLine("Глибока: " + deepCopy.ToString());
        
        originalHouse._street.street = "Вулиця";
        
        Console.WriteLine();
        Console.WriteLine("Оригінал House: " + originalHouse.ToString());
        Console.WriteLine("Поверхнева Copy: " + shallowCopy.ToString());
        Console.WriteLine("Глибока Copy: " + deepCopy.ToString());

    }
}