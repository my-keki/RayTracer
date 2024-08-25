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
}
