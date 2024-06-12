namespace task6;

public struct Point
{
    private int _x, _y, _z;

    public Point(int x, int y, int z)
    {
        _x = x;
        _y = y;
        _z = z;
    }

    public static Point operator +(Point point1, Point point2)
    {
        return new Point(point1._x+point2._x,point1._y+point2._y,point1._z+point2._z);
    }

    public override string ToString()
    {
        return $"{_x}:{_y}:{_z}";
    }
}