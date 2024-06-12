namespace task2;
/*
 * Створіть клас Block із 4 полями сторін, перевизначте в ньому методи:
 * Equals - здатний порівнювати блоки між собою,
 * ToString - повертає інформацію про поля блоку.
 */
class Program
{
    static void Main(string[] args)
    {
        Block block1 = new Block(10, 20, 10, 30);
        Block block2 = new Block(10, 20, 10, 30);
        Block block3 = new Block(20, 40, 50, 100);
        Console.WriteLine(block1.Equals(block2));

        Console.WriteLine(block1.Equals(block3));

        Console.WriteLine(block2.ToString());
        
    }
}