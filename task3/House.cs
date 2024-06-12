namespace task3;
/*
 * Створіть клас House з двома полями та властивостями.
 * Створіть два методи Clone() та DeepClone(), які виконують поверхневе та глибоке
 * копіювання відповідно. Реалізуйте найпростіший спосіб перевірки.
 */
public class Street
{
    public string street { get; set; }

    public Street(string stree)
    {
        street = stree;
    }
}

public class House:ICloneable
{
    public Street _street;
    private int _nomber;

    public House(Street street, int nomber )
    {
        _street = street;
        _nomber = nomber;
    } 
    public object Clone() 
    {
     return this.MemberwiseClone(); 
    }
    public House DeepClone()
    {
        return new House(new Street(_street.street), _nomber);
    }

    public override string ToString()
    {
        return $"{_street.street} {_nomber}";
    }
}