namespace RayTracer;

public class Point3
{
    public double X { get; set; }
    public double Y { get; set; }
    public double Z { get; set; }

    public Point3()
    {
        X = 0;
        Y = 0;
        Z = 0;
    }

    public Point3(double x, double y, double z)
    {
        X = x;
        Y = y;
        Z = z;
    }

    public static Point3 operator +(Point3 origin, Vector3 direction)
    {
        return new Point3(origin.X + direction.X, origin.Y + direction.Y, origin.Z + direction.Z);
    }

    public static Point3 operator -(Point3 origin, Vector3 direction)
    {
        return new Point3(origin.X - direction.X, origin.Y - direction.Y, origin.Z - direction.Z);
    }

    public static Point3 operator -(Point3 p1, Point3 p2)
    {
        return new Point3(p1.X + p2.X, p1.Y + p2.Y, p1.Z + p2.Z);
    }

    public override string ToString()
    {
        return $"{X}, {Y}, {Z}";
    }
}
